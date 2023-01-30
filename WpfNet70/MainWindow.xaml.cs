using System.IO;
using System.Windows;
using System.Windows.Media.Imaging;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Windows.Devices.Geolocation;
using Windows.Media.Capture;
using Windows.Media.MediaProperties;
using WpfNet50.Services;
using WpfNet50.Settings;

namespace WpfNet50;

public partial class MainWindow : Window
{
    private readonly ILogger logger;
    private readonly AppSettings appSettings;
    private readonly IServiceProvider serviceProvider;

    public MainWindow(ILogger<MainWindow> logger, IOptions<AppSettings> options,
        IFooService fooService, IServiceProvider serviceProvider, IMemoryCache cache)
    {
        InitializeComponent();

        this.logger = logger;
        appSettings = options.Value;
        this.serviceProvider = serviceProvider;

        logger.LogInformation("Loading MainWindow...");

        logger.LogDebug("Setting1: {Setting1}", appSettings.Setting1);
        logger.LogDebug("Setting2: {Setting2}", appSettings.Setting2);

        var value = fooService.GetFoo();
        logger.LogDebug("Service Value: {Value}", value);
    }

    private void OpenWindowButton_Click(object sender, RoutedEventArgs e)
    {
        var window = serviceProvider.GetService<Window2>();
        window.ShowDialog();
    }

    private async void GetLocationButton_Click(object sender, RoutedEventArgs e)
    {
        var locator = new Geolocator();
        var location = await locator.GetGeopositionAsync();
        var position = location.Coordinate.Point.Position;

        LatitudeTextBlock.Text = $"Latitude: {position.Latitude:N6}";
        LongitudeTextBlock.Text = $"Longitude: {position.Longitude:N6}";
    }

    private async void TakePhotoButton_Click(object sender, RoutedEventArgs e)
    {
        var captureManager = new MediaCapture();
        await captureManager.InitializeAsync();

        var imageFormat = ImageEncodingProperties.CreateJpeg();
        var stream = new MemoryStream();
        await captureManager.CapturePhotoToStreamAsync(imageFormat, stream.AsRandomAccessStream());
        stream.Position = 0;

        var imageSource = new BitmapImage();
        imageSource.BeginInit();
        imageSource.StreamSource = stream;
        imageSource.EndInit();
        Photo.Source = imageSource;
    }
}
