internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        builder.Services.AddControllersWithViews();
        var app = builder.Build();

        //Routing
        app.MapControllerRoute(
            name: "default",
            pattern: "/{controller=Product}/{action=Index}"
            );
        app.MapControllerRoute(
           name: "default",
           pattern: "/{controller=Product}/{action=Index}/{id}/{name}"
           );

        //app.MapGet("/", () => "Hello World!");

        app.Run();
    }
}