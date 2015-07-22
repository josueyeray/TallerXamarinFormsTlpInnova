namespace WeatherApp.Services.WeatherService
{
    using System.Globalization;
    using System.Net.Http;
    using System.Threading.Tasks;
    using WeatherApp.Model;


    /// <summary>
    /// Contract implementation for weather API service
    /// </summary>
    public class WeatherService : IWeatherService
    {
        private readonly string WeatherUri = "http://api.openweathermap.org/data/2.5/weather?lat={0}&lon={1}&units=metric";

        public WeatherService()
        {
        }


        /// <summary>
        /// <see cref="WeatherApp.Services.WeatherService.IWeatherService"/>
        /// </summary>
        /// <param name="currentLocation"><see cref="WeatherApp.Services.WeatherService.IWeatherService"/></param>
        /// <returns><see cref="WeatherApp.Services.WeatherService.IWeatherService"/></returns>
        public async Task<WeatherModel> GetCurrentLocationWeather(LocationModel currentLocation)
        {
            string uri = string.Format(this.WeatherUri, currentLocation.Latitude, currentLocation.Longitude);
            HttpClient client = new HttpClient();
            var result = await client.GetAsync(uri);
            if (result.IsSuccessStatusCode)
            {
                string resultJson = await result.Content.ReadAsStringAsync();
                return Newtonsoft.Json.JsonConvert.DeserializeObject<WeatherModel>(resultJson);
            }

            return new WeatherModel();
        }
    }
}
