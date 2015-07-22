namespace WeatherApp
{
    using WeatherApp.Services.WeatherService;
    using WeatherApp.ViewModels;
    using WeatherApp.ViewModels.Base;
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
            MainPage = new ContentPage
            {
                Content = new StackLayout
                {
                    VerticalOptions = LayoutOptions.Center,
                    Children = {
                        new Label {
                            XAlign = TextAlignment.Center,
                            Text = "Welcome to Xamarin Forms!"
                        }
                    }
                },
            };
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
