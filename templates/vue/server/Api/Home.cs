namespace Vue.Starter.Api;

public static class Home{
  public static void MapRoutes(IEndpointRouteBuilder app)
  {
    //you can separate these into their own methods if you need to
    //the / route launches the SPA Proxy so you won't see it
    app.MapGet("api/about/", () => "About");
    app.MapGet("api/terms/", () => "Terms");
    app.MapGet("api/privacy/", () => "Privacy");

    
  }
  
}