namespace WeatherApp.WinPhone
{
    using Microsoft.Phone.Controls;
    using WeatherApp.ViewModels.Base;

    public partial class MainPage : global::Xamarin.Forms.Platform.WinPhone.FormsApplicationPage
    {
        public MainPage()
        {
            InitializeComponent();
            SupportedOrientations = SupportedPageOrientation.PortraitOrLandscape;

            WeatherApp.App.Locator = new ViewModelLocator();
            WeatherApp.App.Locator.BuildContainer();

            global::Xamarin.Forms.Forms.Init();
            LoadApplication(new WeatherApp.App());
        }
    }
}
