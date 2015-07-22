namespace WeatherApp.Droid.Services.LocationService
{
    using System.Threading.Tasks;
    using Model;
    using WeatherApp.Services.LocationService;
    using Android.Locations;
    using Android.Content;

    /// <summary>
    /// Contract implementation for location service
    /// </summary>
    public class LocationService : ILocationService
    {
        private readonly LocationManager locationManager;

        public LocationService()
        {
            this.locationManager = Android.App.Application.Context.GetSystemService(Context.LocationService) as LocationManager;
        }

        /// <summary>
        /// <see cref="WeatherApp.Services.LocationService.ILocationService"/>
        /// </summary>
        /// <returns><see cref="WeatherApp.Services.LocationService.ILocationService"/></returns>
        public Task<LocationModel> GetCurrentLocation()
        {
            TaskCompletionSource<LocationModel> tcs = new TaskCompletionSource<LocationModel>();
            string provider = GetBestProvider();
            var location = this.locationManager.GetLastKnownLocation(provider);

            tcs.SetResult(new LocationModel()
            {
                Longitude = 32.345,
                Latitude = 5.433,
                Altitude = 100,
                Speed = 0
            });

            return tcs.Task;
        }

        private string GetBestProvider()
        {
            Criteria criteria = new Criteria();
            criteria.Accuracy = Accuracy.Coarse;
            criteria.PowerRequirement = Power.Low;
            string providerName = this.locationManager.GetBestProvider(criteria, true);
            return providerName;
        }
    }
}