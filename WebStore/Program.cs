using WebStore.Infrastructure.Middleware;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.UseStaticFiles();

//app.MapGet("/", () => app.Configuration["ServerGreetings"]);


// defaul controler map
app.MapDefaultControllerRoute();

app.UseMiddleware<TestMiddleware>();


app.MapControllerRoute(
    name: "defaul",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
