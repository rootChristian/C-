using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo1
{
    class Program
    {
        static void Main(string[] args)
        {
            Double radius = 0.0;
            Mathlib Circle = new Mathlib();

            try
            {
                // Circle
                radius = Circle.CheckParameter("Please enter the radius (>= 0)in cm? ", radius);
                Double circ_result = Circle.CircumferenceCircle(radius);
                Double area_result = Circle.AreaCircle(radius);
                string result = string.Format("Welcome,\n a circle of radius {0}cm has for circumference {1}cm and has for area {2}cm2.\n ", radius, circ_result, area_result);
                Console.WriteLine(result);
                Console.ReadLine();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                Console.ReadLine();
            }
        }
    }
}
