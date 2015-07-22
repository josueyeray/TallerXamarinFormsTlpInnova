namespace WeatherApp.Services.WeatherService
{
    using System;
    using System.Net.Http;
    using System.Threading.Tasks;
    using WeatherApp.Services.LocationService;


    /// <summary>
    /// Contract implementation for weather API service
    /// </summary>
    public class WeatherService : IWeatherService
    {
        private readonly ILocationService locService;
        private readonly string WeatherUri = "api.openweathermap.org/data/2.5/weather?lat={0}&lon={1}";

        public WeatherService(ILocationService locationService)
        {
            this.locService = locationService;
        }


        /// <summary>
        /// <see cref="WeatherApp.Services.WeatherService.IWeatherService"/>
        /// </summary>
        /// <returns><see cref="WeatherApp.Services.WeatherService.IWeatherService"/></returns>
        public async Task<string> GetCurrentLocationWeather()
        {
            var currentLocation = await this.locService.GetCurrentLocation();
            if (currentLocation != null)
            {
                string uri = string.Format(this.WeatherUri, currentLocation.Latitude, currentLocation.Longitude);
                HttpClient client = new HttpClient();
                var result = await client.GetAsync(uri);
                if (result.IsSuccessStatusCode)
                {
                    string resultJson = await result.Content.ReadAsStringAsync();
                    return resultJson;
                }
            }

            return string.Empty;
        }
    }
}
