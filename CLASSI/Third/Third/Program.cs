using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Third
{


    class Program
    {
        static void Main(string[] args)
        {
            Double length = 0.0;
            Double width = 0.0;
            Double side = 0.0;
            Double radius = 0.0;

            // Create new object
            MathLib Square = new MathLib();
            MathLib Rectangle = new MathLib();
            MathLib Circle = new MathLib();
            Logger Log = new Logger();

            try
            {
                // Square
                side = Square.CheckParameter("Please enter the side in cm? ", side);
                Double p_s_result = Square.PerimeterSquare(side);
                Double a_s_result = Square.AreaSquare(side);

                // Rectangle
                length = Rectangle.CheckParameter("Please enter the length in m? ", length);
                width = Rectangle.CheckParameter("Please enter the width in m? ", width);
                Double p_r_result = Rectangle.PerimeterRectangle(length, width);
                Double a_r_result = Rectangle.AreaRectangle(length, width);

                // Circle
                radius = Circle.CheckParameter("Please enter the radius in cm? ", radius);
                Double a_c_result = Square.AreaCircle(radius);
                if (a_c_result > 100)
                {
                    Log.LogToFile("Attention the value of the area of the circle must not exceed 100cm2!!! ", Logger.LogType.warning);
                }

                string result = string.Format("Welcome,\n a square of {0}cm side has for perimeter {1}cm and for area {2}cm2.\n " +
                "a rectangle {3}m long and {4}m wide has for perimeter {5}m and for area {6}m2.\n " +
                "a circle of radius {7}cm has for area {8}cm2. \n ...",
                side, p_s_result, a_s_result, length, width, p_r_result, a_r_result, radius, a_c_result);
                Console.WriteLine(result);
                Log.LogToFile(result, Logger.LogType.info);
                Console.ReadLine();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                Log.LogToFile(ex.ToString(), Logger.LogType.alert);
                Console.ReadLine();
            }  

        }
    }
}
