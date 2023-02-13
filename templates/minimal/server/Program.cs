var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//this serves our Vue file
//app.UseDefaultFiles().UseStaticFiles();
app.UseStaticFiles();
app.MapFallbackToFile("index.html");

//routes
Vue.Starter.Routes.Home.MapRoutes(app);

app.Run();

//this is for tests
public partial class Program { }