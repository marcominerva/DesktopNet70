using System.Windows;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using WpfNet50.Settings;

namespace WpfNet50;

public partial class Window2 : Window
{
    public Window2(ILogger<Window2> logger, IOptions<AppSettings> options)
    {
        InitializeComponent();

        logger.LogInformation("Loading Window2...");
    }
}
