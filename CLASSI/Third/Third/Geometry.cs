using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Third
{
    class Geometry
    {
        public const int cstRect = 2;
        public const int cstSide = 4;
        public const Double cstCircle = 3.14;
        private Double height;
        private Double width;
        private Double length;
        private Double radius;
        private Double side;

        // Method get and set 
        public Double Radius
        {
            get { return radius; }
            set { radius = value; }
        }
    }
}
