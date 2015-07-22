namespace WeatherApp.Droid
{
    using Android.App;
    using Android.Content.PM;
    using Android.OS;
    using ViewModels.Base;

    [Activity(Label = "WeatherApp", Icon = "@drawable/icon", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsApplicationActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            App.Locator = new ViewModelLocator();
            App.Locator.BuildContainer();

            global::Xamarin.Forms.Forms.Init(this, bundle);
            LoadApplication(new App());
        }
    }
}

