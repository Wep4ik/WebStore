var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

var app = builder.Build();

//app.MapGet("/", () => app.Configuration["ServerGreetings"]);

// defaul controler map
//app.MapDefaultControllerRoute();

app.MapControllerRoute(
    name: "defaul",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
