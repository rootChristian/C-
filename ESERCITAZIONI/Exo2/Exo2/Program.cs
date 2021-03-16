using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo2
{
    class Program
    {
        static void Main(string[] args)
        {
            Double side_a = 0.0;
            Double side_b = 0.0;
            Double side_c = 0.0;
            Mathlib Triangolo = new Mathlib();

            try
            {
                side_a = Triangolo.CheckParameter("Please enter the side a (>= 0)in cm? ", side_a);
                side_b = Triangolo.CheckParameter("Please enter the side b (>= 0)in cm? ", side_b);
                side_c = Triangolo.CheckParameter("Please enter the side c (>= 0)in cm? ", side_c);

                Triangolo.NatureGeometry(side_a, side_b, side_c);
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
