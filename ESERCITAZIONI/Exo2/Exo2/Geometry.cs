using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo2
{
    class Geometry
    {
        private Double side_a;
        private Double side_b;
        private Double side_c;

        // Method get and set 
        public Double Side_A
        {
            get { return side_a; }
            set { side_a = value; }
        }
        public Double Side_B
        {
            get { return side_b; }
            set { side_b = value; }
        }
        public Double Side_C
        {
            get { return side_c; }
            set { side_c = value; }
        }
    }
}
