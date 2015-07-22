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

            var location = this.locationManager.GetLastKnownLocation(GetBestProvider());

            tcs.SetResult(new LocationModel()
            {
                Longitude = location.Longitude,
                Latitude = location.Latitude,
                Altitude = location.Altitude,
                Speed = location.Speed
            });

            return tcs.Task;
        }

        private string GetBestProvider()
        {
            Criteria criteria = new Criteria();
            criteria.PowerRequirement = Power.High;
            criteria.Accuracy = Accuracy.Fine;
            criteria.CostAllowed = true;
            criteria.HorizontalAccuracy = Accuracy.High;
            criteria.AltitudeRequired = true;
            criteria.BearingAccuracy = Accuracy.High;
            criteria.BearingRequired = true;
            criteria.SpeedAccuracy = Accuracy.High;
            criteria.SpeedRequired = true;
            criteria.VerticalAccuracy = Accuracy.High;

            string providerName = this.locationManager.GetBestProvider(criteria, true);
            return providerName;
        }
    }
}