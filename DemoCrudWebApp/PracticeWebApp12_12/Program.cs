namespace PracticeWebApp12_12
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
            pattern: "/{controller=Employee}/{action=List}/{empId=0}"
            );

            app.Run();
        }
    }
}