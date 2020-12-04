using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Windows.Devices.Geolocation;
using Windows.Media.Capture;
using Windows.Media.MediaProperties;
using WindowsFormsNet50.Services;
using WindowsFormsNet50.Settings;

namespace WindowsFormsNet50
{
    public partial class frmMain : Form
    {
        private readonly ILogger<frmMain> logger;
        private readonly IFooService fooService;
        private readonly IServiceProvider serviceProvider;

        public frmMain(ILogger<frmMain> logger, IFooService fooService, IServiceProvider serviceProvider, IOptions<AppSettings> options)
        {
            InitializeComponent();

            this.logger = logger;
            logger.LogInformation("Creating MainForm...");

            this.fooService = fooService;
            this.serviceProvider = serviceProvider;

            var settings = options.Value;
            logger.LogDebug("Setting1: {Setting1}", settings.Setting1);
            logger.LogDebug("Setting2: {Setting2}", settings.Setting2);
        }

        private void OpenFormButton_Click(object sender, EventArgs e)
        {
            var frm = serviceProvider.GetService<frmSecondary>();
            frm.ShowDialog(this);
        }

        private async void GetLocationButton_Click(object sender, EventArgs e)
        {
            var locator = new Geolocator();
            var location = await locator.GetGeopositionAsync();
            var position = location.Coordinate.Point.Position;

            lblLatitude.Text = $"Latitude: {position.Latitude:N6}";
            lblLongitude.Text = $"Longitude: {position.Longitude:N6}";
        }

        private async void TakePictureButton_Click(object sender, EventArgs e)
        {
            var captureManager = new MediaCapture();
            await captureManager.InitializeAsync();

            var imageFormat = ImageEncodingProperties.CreateJpeg();
            using var stream = new MemoryStream();
            await captureManager.CapturePhotoToStreamAsync(imageFormat, stream.AsRandomAccessStream());

            picPhoto.Image = Image.FromStream(stream);
        }
    }
}
