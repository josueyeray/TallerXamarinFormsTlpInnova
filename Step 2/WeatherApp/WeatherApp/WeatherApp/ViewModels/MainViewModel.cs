using WeatherApp.Services.WeatherService;
using WeatherApp.ViewModels.Base;

namespace WeatherApp.ViewModels
{

    /// <summary>
    /// MainView viewmodel
    /// </summary>
    public class MainViewModel : BaseViewModel
    {
        private readonly IWeatherService wService;
        public MainViewModel(IWeatherService wService)
        {
        }
    }
}
