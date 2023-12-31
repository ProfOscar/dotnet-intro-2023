using ese01.Models.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<IUsersService, UsersService>();
// builder.Services.AddScoped<IUsersService, UsersService>();
// builder.Services.AddTransient<IUsersService, UsersService>();

builder.Services.AddControllersWithViews();

var app = builder.Build();

app.UseStaticFiles();

//app.MapGet("/", () => "Hello World!");

// app.MapControllerRoute(
//     name: "default",
//     pattern: "{controller=Home}/{action=Index}/{id?}");
app.MapDefaultControllerRoute();

app.Run();
