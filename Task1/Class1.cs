using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public static class Circle
    {
        public static double Circumference(double radius)
        {
            return radius*2*Math.PI;
        }
        public static double Area(double radius)
        {
            return radius * radius * Math.PI;
        }
        public static bool IsPointWithinCircle(double radius, double circleX0, double circleY0, double pointX, double pointY)
        {
            return Math.Sqrt(Math.Pow(pointX- circleX0,2)+ Math.Pow(pointY - circleY0, 2)) <= radius;
        }
        public static void CheckIfPointWithinCircle(double radius, double circleX0, double circleY0, double pointX, double pointY)
        {
            if (IsPointWithinCircle(radius, circleX0, circleY0, pointX, pointY))
                Console.WriteLine("Точка лежит в пределах круга");
            else
                Console.WriteLine("Точка лежит за пределами круга");
        }

        //public static bool IsPointWithinCircle(int radius, int circleX0, int circleY0, int pointX, int pointY)
        //{
        //    return Math.Sqrt(Math.Pow(pointX - circleX0, 2) + Math.Pow(pointY - circleY0, 2)) <= radius;
        //}
        //public static double Area(int radius)
        //{
        //    return radius * radius * Math.PI;
        //}   

        //public static double Circumference(int radius)
        //{
        //    return radius * 2 * Math.PI;
        //}
    }
}
