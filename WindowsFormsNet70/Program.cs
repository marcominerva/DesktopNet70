using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using WindowsFormsNet50.Services;
using WindowsFormsNet50.Settings;

namespace WindowsFormsNet50;

internal static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    private static void Main()
    {
        Application.SetHighDpiMode(HighDpiMode.SystemAware);
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);

        var host = Host.CreateDefaultBuilder()
            .ConfigureServices(ConfigureServices)
            .Build();

        var services = host.Services;
        var mainForm = services.GetService<frmMain>();
        Application.Run(mainForm);
    }

    private static void ConfigureServices(HostBuilderContext hostingContext, IServiceCollection services)
    {
        var environment = hostingContext.HostingEnvironment.EnvironmentName;

        services.Configure<AppSettings>(hostingContext.Configuration.GetSection(nameof(AppSettings)));

        services.AddSingleton<IFooService, FooService>();

        services.AddSingleton<frmMain>();
        services.AddTransient<frmSecondary>();
    }
}
