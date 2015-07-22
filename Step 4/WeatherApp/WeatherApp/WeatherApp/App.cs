namespace WeatherApp
{
    using WeatherApp.ViewModels;
    using WeatherApp.ViewModels.Base;
    using WeatherApp.Views;
    using Xamarin.Forms;

    public class App : Application
    {
        /// <summary>
        /// Application wide dependency container, resolver and locator.
        /// </summary>
        public static ViewModelLocator Locator { get; set; }

        /// <summary>
        /// Default Constructor
        /// </summary>
        public App()
        {
            // The root page of your application
            MainPage = new MainView();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
