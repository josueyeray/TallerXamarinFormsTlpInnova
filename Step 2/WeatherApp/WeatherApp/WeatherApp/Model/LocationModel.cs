using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp.Model
{
    /// <summary>
    /// Platform independent location class
    /// </summary>
    public class LocationModel
    {
        /// <summary>
        /// Location latitude
        /// </summary>
        public Double Latitude { get; set; }

        /// <summary>
        /// Location longitude
        /// </summary>
        public Double Longitude { get; set; }

        /// <summary>
        /// Location altitude
        /// </summary>
        public Double? Altitude { get; set; }

        /// <summary>
        /// Current speed
        /// </summary>
        public Double? Speed { get; set; }
    }
}
