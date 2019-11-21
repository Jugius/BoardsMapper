using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardsMapper.AppModels.Maps
{
    public class Location
    {
        public virtual double Latitude { get; set; }
        public virtual double Longitude { get; set; }
        public Location(double latitude, double longitude)
        {
            this.Latitude = latitude;
            this.Longitude = longitude;
        }
        public override string ToString()
        {
            return string.Format(CultureInfo.InvariantCulture, "{0:0.00000000},{1:0.00000000}", Latitude, Longitude);
        }
    }
}
