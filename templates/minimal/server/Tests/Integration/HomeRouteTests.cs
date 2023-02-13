using Xunit;
using Vue.Starter.Routes;
using Microsoft.AspNetCore.Mvc.Testing;

public class HomeRouteTests {
  [Fact]
  public async Task The_about_route_returns_200()
  {
    await using var application = new WebApplicationFactory<Program>();
    using var client = application.CreateClient();
    var response = await client.GetStringAsync("/about");
    Assert.Equal("About",response);
  }
}