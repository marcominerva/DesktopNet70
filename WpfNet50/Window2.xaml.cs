using Microsoft.Extensions.Logging;
using System.Windows;

namespace WpfNet50
{
    public partial class Window2 : Window
    {
        public Window2(ILogger<Window2> logger)
        {
            InitializeComponent();

            logger.LogInformation("Loading Window2...");
        }
    }
}
