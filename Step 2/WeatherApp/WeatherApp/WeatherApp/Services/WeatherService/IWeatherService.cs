namespace WeatherApp.Services.WeatherService
{
    using System.Threading.Tasks;

    /// <summary>
    /// Contract definition for weather API service
    /// </summary>
    public interface IWeatherService
    {
        /// <summary>
        /// Get the current weather in the current location.
        /// </summary>
        /// <returns>Current weather</returns>
        Task<string> GetCurrentLocationWeather();
    }
}
