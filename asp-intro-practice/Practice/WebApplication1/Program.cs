var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();


var app = builder.Build();

//app.MapControllerRoute(
//    name: "default",
//    pattern: "{controller=Home}/{action=GetNum}/{id?}"
//    );
//app.MapControllerRoute(
//    name: "default",
//    pattern: "{controller=Home}/{action=Search}/{id?}"
//    );
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}"
    );

app.Run();
