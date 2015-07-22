namespace WeatherApp.Services.WeatherService
{
    using System.Threading.Tasks;
    using WeatherApp.Model;


    /// <summary>
    /// Contract definition for weather API service
    /// </summary>
    public interface IWeatherService
    {
        /// <summary>
        /// Get the current weather in the current location.
        /// </summary>
        /// <param name="currentLocation">Current location coordinates</param>
        /// <returns>Current weather</returns>
        Task<WeatherModel> GetCurrentLocationWeather(LocationModel currentLocation);
    }
}
