namespace Vue.Starter.Routes;

public static class Home{
  public static void MapRoutes(IEndpointRouteBuilder app)
  {
    //you can separate these into their own methods if you need to
    //the / route launches the SPA Proxy so you won't see it
    app.MapGet("/about/", () => "About");
    app.MapGet("/terms/", () => "Terms");
    app.MapGet("/privacy/", () => "Privacy");
  }
  
}