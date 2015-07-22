namespace WeatherApp.ViewModels
{
    using System.Threading.Tasks;
    using WeatherApp.Model;
    using WeatherApp.Services.LocationService;
    using WeatherApp.Services.WeatherService;
    using WeatherApp.ViewModels.Base;

    /// <summary>
    /// MainView viewmodel
    /// </summary>
    public class MainViewModel : BaseViewModel
    {
        private readonly IWeatherService weatherService;
        private readonly ILocationService locService;
        private WeatherModel currentWeather;

        public MainViewModel(IWeatherService weatherService, ILocationService locService)
        {
            this.weatherService = weatherService;
            this.locService = locService;

            Task.Run(async () =>
            {
                var currentLocation = await this.locService.GetCurrentLocation();
                CurrentWeather = await this.weatherService.GetCurrentLocationWeather(currentLocation);
            });
        }

        public WeatherModel CurrentWeather
        {
            get { return this.currentWeather; }
            set
            {
                this.currentWeather = value;
                RaisePropertyChanged();
            }
        }
    }
}
