using System.Windows;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using WpfNet50.Services;
using WpfNet50.Settings;

namespace WpfNet50;

public partial class App : Application
{
    private readonly IHost host;

    public App()
    {
        host = Host.CreateDefaultBuilder()
            .ConfigureServices(ConfigureServices)
            .Build();
    }

    private void ConfigureServices(HostBuilderContext context, IServiceCollection services)
    {
        services.AddMemoryCache();

        if (context.HostingEnvironment.IsDevelopment())
        {
            services.AddSingleton<IFooService, StubFooService>();
        }
        else
        {
            services.AddSingleton<IFooService, RealFooService>();
        }

        services.Configure<AppSettings>(context.Configuration.GetSection(nameof(AppSettings)));

        services.AddSingleton<MainWindow>();
        services.AddTransient<Window2>();
    }

    protected override void OnStartup(StartupEventArgs e)
    {
        var mainWindow = host.Services.GetService<MainWindow>();
        mainWindow.Show();

        base.OnStartup(e);
    }
}
