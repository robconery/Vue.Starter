using Xunit;
using Contoso.Data;
using Contoso.Data.Models;
namespace Contoso.Tests;

public class ContentTests {
  public ContentTests()
  {
    //let's use an in-memory version of SQLite

  }

  [Fact]
  public void A_Query_Returns_Documents()
  {
    var lib = new ContentLibrary().Load();

  }
}