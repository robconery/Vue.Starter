var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//this serves our Vue file
app.UseDefaultFiles();
app.UseStaticFiles();

app.Run();
