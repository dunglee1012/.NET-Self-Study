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
           pattern: "/{controller=Product}/{action=Index}/{id=0}/{name=ABC}"
           );

        //app.MapGet("/", () => "Hello World!");

        app.Run();
    }
}