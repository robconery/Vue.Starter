using Xunit;
using Vue.Kit.Models;

public class MembershipTests
{
  User _user = User.Register("test@test.com","Test Person","password");
  public MembershipTests()
  {

  }
  [Fact]
  public void New_user_has_a_hashed_password(){
    Assert.NotNull(_user.HashedPassword);
  }
}