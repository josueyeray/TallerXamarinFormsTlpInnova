namespace WeatherApp.Services.LocationService
{
    using System.Threading.Tasks;
    using Model;

    /// <summary>
    /// Contract definition for location service
    /// </summary>
    public interface ILocationService
    {
        /// <summary>
        /// Get current location coordinates
        /// </summary>
        /// <returns>Location in platform independent mode</returns>
        Task<LocationModel> GetCurrentLocation();
    }
}
