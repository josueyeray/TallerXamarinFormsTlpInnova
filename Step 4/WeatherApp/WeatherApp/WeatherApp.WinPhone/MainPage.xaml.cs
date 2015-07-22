namespace WeatherApp.WinPhone
{
    using Microsoft.Phone.Controls;
    using WeatherApp.Services.LocationService;
    using WeatherApp.ViewModels.Base;
    using WeatherApp.WinPhone.Services.LocationService;

    public partial class MainPage : global::Xamarin.Forms.Platform.WinPhone.FormsApplicationPage
    {
        public MainPage()
        {
            InitializeComponent();
            SupportedOrientations = SupportedPageOrientation.PortraitOrLandscape;

            WeatherApp.App.Locator = new ViewModelLocator();
            WeatherApp.App.Locator.RegisterService<ILocationService, LocationService>();
            WeatherApp.App.Locator.BuildContainer();

            global::Xamarin.Forms.Forms.Init();
            LoadApplication(new WeatherApp.App());
        }
    }
}
