using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
builder.Services.AddDbContext<Contoso.Data.DB>(options => 
  options.UseSqlite(builder.Configuration.GetConnectionString("ContosoDev"))
);
//this serves our Vue file
//app.UseDefaultFiles().UseStaticFiles();
app.UseStaticFiles();
app.MapFallbackToFile("index.html");

//routes
Vue.Starter.Routes.Home.MapRoutes(app);

app.Run();

//this is for tests
public partial class Program { }