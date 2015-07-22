namespace WeatherApp.iOS.Services.LocationService
{
    using System.Threading.Tasks;
    using Model;
    using WeatherApp.Services.LocationService;
    using CoreLocation;

    /// <summary>
    /// Contract implementation for location service
    /// </summary>
    public class LocationService : ILocationService
    {
        private CLLocationManager locManager;

        /// <summary>
        /// Default constructor
        /// </summary>
        public LocationService()
        {
        }

        /// <summary>
        /// <see cref="WeatherApp.Services.LocationService.ILocationService"/>
        /// </summary>
        /// <returns><see cref="WeatherApp.Services.LocationService.ILocationService"/></returns>
        public Task<LocationModel> GetCurrentLocation()
        {
            TaskCompletionSource<LocationModel> tcs = new TaskCompletionSource<LocationModel>();
            this.locManager = new CLLocationManager();
            this.locManager.UpdatedLocation += (d, e) =>
            {
                if (e.NewLocation != null)
                {
                    tcs.SetResult(new LocationModel()
                    {
                        Longitude = e.NewLocation.Coordinate.Longitude,
                        Latitude = e.NewLocation.Coordinate.Latitude,
                        Altitude = e.NewLocation.Altitude,
                        Speed = e.NewLocation.Speed
                    });
                }
                this.locManager = null;
            };
            return tcs.Task;
        }
    }
}