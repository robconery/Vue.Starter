namespace Vue.Starter.Api;
using Vue.Starter.Data;

public static class Content{
  public static void MapRoutes(IEndpointRouteBuilder app)
  {
    var lib = new ContentLibrary().Load();
    //you can separate these into their own methods if you need to
    //the / route launches the SPA Proxy so you won't see it
    app.MapGet("api/content/{dir}", (string dir) => {
      var docs = lib.Documents.Where(d => d.Directory.ToLower() == dir.ToLower());
      return docs;
    });
    
  }
  
}