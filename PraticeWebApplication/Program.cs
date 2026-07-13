namespace PraticeWebApplication
{
    public class Program
    {
        public static int Main(string[] args)
        {
            // Diagnostic: log first-chance exceptions to help surface startup issues in the console
            AppDomain.CurrentDomain.FirstChanceException += (sender, e) =>
            {
                try
                {
                    Console.Error.WriteLine($"FirstChanceException: {e.Exception.GetType()}: {e.Exception.Message}");
                }
                catch
                {
                    // ignore
                }
            };

            try
            {
                var builder = WebApplication.CreateBuilder(args);

                // Ensure console logging so startup exceptions appear in the console output.
                builder.Logging.ClearProviders();
                builder.Logging.AddConsole();

                // Add services to the container.
                builder.Services.AddControllersWithViews();

                var app = builder.Build();

                // Configure the HTTP request pipeline.
                if (!app.Environment.IsDevelopment())
                {
                    app.UseExceptionHandler("/Home/Error");
                    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                    app.UseHsts();
                }
                else
                {
                    // Developer friendly page during development
                    app.UseDeveloperExceptionPage();
                }

                app.UseHttpsRedirection();
                app.UseStaticFiles();

                app.UseRouting();

                app.UseAuthorization();

                app.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Guest}/{action=Home}/{id?}");

                app.Run();
                return 0;
            }
            catch (Exception ex)
            {
                // Print full details to console (including inner exceptions).
                Console.Error.WriteLine("Host terminated unexpectedly.");
                Console.Error.WriteLine(ex.ToString());
                return 1;
            }
        }
    }
}
