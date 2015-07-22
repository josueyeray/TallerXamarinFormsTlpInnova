namespace WeatherApp.WinPhone.Services.LocationService
{
    using System;
    using System.Threading.Tasks;
    using Model;
    using WeatherApp.Services.LocationService;
    using Windows.Devices.Geolocation;


    /// <summary>
    /// Contract implementation for location service
    /// </summary>
    public class LocationService : ILocationService
    {
        private Geolocator geoLocator;

        /// <summary>
        /// Default constructor
        /// </summary>
        public LocationService()
        {
            this.geoLocator = new Geolocator();
        }

        /// <summary>
        /// <see cref="WeatherApp.Services.LocationService.ILocationService"/>
        /// </summary>
        /// <returns><see cref="WeatherApp.Services.LocationService.ILocationService"/></returns>
        public async Task<LocationModel> GetCurrentLocation()
        {
            var currentLocation = await this.geoLocator.GetGeopositionAsync();
            if (currentLocation != null)
            {
                return new LocationModel()
                {
                    Latitude = currentLocation.Coordinate.Latitude,
                    Longitude = currentLocation.Coordinate.Longitude,
                    Altitude = currentLocation.Coordinate.Altitude,
                    Speed = currentLocation.Coordinate.Speed
                };
            }

            return new LocationModel();
        }
    }
}
