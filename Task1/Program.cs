using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Circle.Circumference(1));
            Console.WriteLine(Circle.Area(1/Math.Sqrt(Math.PI)));
            Circle.CheckIfPointWithinCircle(2,1,1,2,2);
            Circle.CheckIfPointWithinCircle(1, 0, 0, 2, 2);
            Console.ReadKey();
        }
    }
}
