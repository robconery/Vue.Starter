using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("ContosoDev");
builder.Services.AddDbContext<Vue.Starter.Data.DB>(options => 
  options.UseSqlite(connectionString)
);
//this serves our Vue file
//app.UseDefaultFiles().UseStaticFiles();
var app = builder.Build();
app.UseStaticFiles();
app.MapFallbackToFile("index.html");

//routes
Vue.Starter.Api.Home.MapRoutes(app);
Vue.Starter.Api.Content.MapRoutes(app);

app.Run();

//this is for tests
public partial class Program { }