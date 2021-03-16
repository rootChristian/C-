using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Third
{
    class MathLib : Geometry
    {
        Logger Log = new Logger();

        // Method square
        public Double PerimeterSquare(Double s)
        {
            Double result = (s*cstSide);
            return result;
        }

        public Double AreaSquare(Double s)
        {
            Double result = (s * s);
            return result;
        }

        // Method rectangle
        public Double PerimeterRectangle(Double l, Double w)
        {
            Double result = (l + w) * cstRect;
            return result;
        }

        public Double AreaRectangle(Double l, Double w)
        {
            Double result = l * w;
            return result;
        }

        // Method circle
        public Double AreaCircle(Double r)
        {
            Geometry geometry = new Geometry();
            geometry.Radius = r;
            Double result = geometry.Radius*geometry.Radius*cstCircle;
            return result;
        }

        // Function check input
        public Double CheckParameter(string sms, Double val)
        {
            Boolean success = true;
            do
            {

                try
                {
                    Console.Write(sms);
                    val = Convert.ToDouble(Console.ReadLine());
                    success = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    Log.LogToFile(ex.ToString(), Logger.LogType.alert);
                    Console.WriteLine("Please enter the correct value (Double)");
                    Console.ReadLine();
                    Console.Clear();
                    success = false;
                }
                
            } while (!success);

            return val;
        }

    }
}
