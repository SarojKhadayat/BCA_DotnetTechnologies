using DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBCA.Struct
{
    public struct CoordinatePoint
    {
        public CoordinatePoint(decimal lat, decimal lng)
        {
            Latitude = lat;
            Longitude = lng;
        }
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }
    }
}
