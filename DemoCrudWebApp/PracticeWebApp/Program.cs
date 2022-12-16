namespace PracticeWebApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            app.MapControllerRoute(
            name: "default",
            pattern:
            "/{controller=OrderDetail}" +
            "/{action=Detail}" +
            "/{orderId=10248}"
            );


            app.Run();
        }
    }
}