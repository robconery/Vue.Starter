using Markdig;
using Markdig.Parsers;
using Markdig.Renderers;
using Contoso.Data.Models;
using YamlDotNet.Serialization;
using YamlDotNet.Core;
using YamlDotNet.Core.Events;


namespace Contoso.Data;
// ...

public class ContentLibrary
{
    public IList<Document> Documents { get; set; } = new List<Document>();
    public ContentLibrary()
    {

    }
    public ContentLibrary Load(){
      var result = new List<Document>();
      //HACK: figure out how to make this less hard-codey crap
      foreach (string file in Directory.EnumerateFiles("../../../Content/", "*.md", SearchOption.AllDirectories))
      {
          //
        var text = File.ReadAllText(file);
        //var newDoc = new Document(text);
        Document doc;
        var yamler = new DeserializerBuilder().IgnoreUnmatchedProperties().Build();

        using (var input = new StringReader(text))
        {
            var parser = new Parser(input);
            parser.Consume<StreamStart>();
            parser.Consume<DocumentStart>();
            doc = yamler.Deserialize<Document>(parser);
            parser.Consume<DocumentEnd>();
        }


        var pipe = new MarkdownPipelineBuilder()
            .UseYamlFrontMatter()
            .UseCustomContainers()
            .UseEmphasisExtras()
            .UseGridTables()
            .UseMediaLinks()
            .UsePipeTables()
            .UseGenericAttributes() // Must be last as it is one parser that is modifying other parsers
            .Build();
        
        //TODO: Refactor and separate
        var writer = new StringWriter();
        var renderer = new HtmlRenderer(writer);
        pipe.Setup(renderer);
        
        var parsed  = MarkdownParser.Parse(text,pipe);
        var rendered = renderer.Render(parsed);
        writer.Flush();

        doc.HTML = writer.ToString();
        doc.CreatedAt = DateTime.Now;
      }
      return this;
    }

}