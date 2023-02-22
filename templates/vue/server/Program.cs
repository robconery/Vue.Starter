using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("ContosoDev");
builder.Services.AddDbContext<Vue.Starter.Data.DB>(options => 
  options.UseSqlite(connectionString)
);
builder.Services.AddCors();
 
 
//this serves our Vue file
//app.UseDefaultFiles().UseStaticFiles();
var app = builder.Build();
app.UseStaticFiles();
app.MapFallbackToFile("index.html");

//lock this down as needed
app.UseCors(builder => builder
 .AllowAnyOrigin()
 .AllowAnyMethod()
 .AllowAnyHeader()
);
//routes
Vue.Starter.Api.Home.MapRoutes(app);
Vue.Starter.Api.Content.MapRoutes(app);

app.Run();

//this is for tests
public partial class Program { }