namespace WeatherApp.Droid
{
    using Android.App;
    using Android.Content.PM;
    using Android.OS;
    using ViewModels.Base;
    using WeatherApp.Droid.Services.LocationService;
    using WeatherApp.Services.LocationService;

    [Activity(Label = "WeatherApp", Icon = "@drawable/icon", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsApplicationActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            App.Locator = new ViewModelLocator();
            App.Locator.RegisterService<ILocationService, LocationService>();
            App.Locator.BuildContainer();

            global::Xamarin.Forms.Forms.Init(this, bundle);
            LoadApplication(new App());
        }
    }
}

