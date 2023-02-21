
using YamlDotNet.Serialization;

namespace Contoso.Data.Models
{

  public class Document
  {

    public Document()
    {
      
    }
    public string Directory { get; set; }
    public string Path { get; set; }
    public string Slug { get; set; }
    public DateTime CreatedAt { get; set; }
    public string HTML { get; set; }
    public string RawText { get; set; }

    [YamlMember(Alias = "title")]
    public string Title{ get; set; }
    
    [YamlMember(Alias = "index")]
    public int Index{ get; set; }
    
    [YamlMember(Alias = "icon")]
    public string Icon{ get; set; }

    [YamlMember(Alias = "image")]
    public string Image { get; set; }

    [YamlMember(Alias = "category")]
    public string Category { get; set; }

    [YamlMember(Alias = "tags")]
    public string[] Tags { get; set; }

    [YamlMember(Alias = "lede")]
    public string Lede { get; set; }

    
    [YamlMember(Alias = "cta")]
    public string CallToAction { get; set; }

    [YamlMember(Alias = "link")]
    public string Link { get; set; }

  }
}