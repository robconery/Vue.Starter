using Xunit;
using Contoso.Data;
using Contoso.Data.Models;
namespace Contoso.Tests;

public class ContentTests {
  ContentLibrary _lib;
  Document _doc;
  public ContentTests()
  {
    //let's use an in-memory version of SQLite
    //HACK: I hate this
    _lib = new ContentLibrary("../../../Tests/Content").Load();
    _doc = _lib.Documents.First();
  }

  [Fact]
  public void The_libray_loads_up_docs()
  {
    
    //there should be one doc in there
    Assert.Equal(_lib.Documents.Count, 1);
    
  }

  [Fact]
  public void The_test_doc_has_html()
  {
    Assert.NotNull(_doc.HTML);
  }
  [Fact]
  public void Doc_directory_is_Content()
  {
    Assert.Equal("Content",_doc.Directory);
  }
  [Fact]
  public void Doc_slug_is_test()
  {
    Assert.Equal("test",_doc.Slug);
  }
  [Fact]
  public void Doc_title_is_A_Test_Document()
  {
    Assert.Equal("A Test Document",_doc.Title);
  }
  [Fact]
  public void Doc_icon_is_book()
  {
    Assert.Equal("book",_doc.Icon);
  }
  [Fact]
  public void Doc_image_is_image_png()
  {
    Assert.Equal("image/image.png",_doc.Image);
  }
  [Fact]
  public void Doc_category_is_tests()
  {
    Assert.Equal("tests",_doc.Category);
  }
  [Fact]
  public void Doc_has_three_tags()
  {
    Assert.Equal(3,_doc.Tags.Count());
  }

}