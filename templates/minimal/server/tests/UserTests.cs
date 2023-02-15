using Xunit;
using Microsoft.EntityFrameworkCore;
using Contoso.Data;
using Contoso.Data.Models;
namespace Contoso.Tests;

public class UserTests {
  DB _db;
  public UserTests()
  {
    //let's use an in-memory version of SQLite
    var opts = new DbContextOptionsBuilder<DB>().UseSqlite("Filename=:memory").Options;
    _db = new DB(opts);
    DbInitializer.Initialize(_db);
  }

  [Fact]
  public void The_Seed_Created_Users()
  {
    var users = _db.Users.ToList<User>();
    Assert.Equal(8, users.Count);
  }
}