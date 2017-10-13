using System;

namespace ClassesAndObjectsTask2
{
    class Program
    {
        static void Main()
        {
            Triangle firstTriangle = new Triangle(10,6,15);
            Console.WriteLine(firstTriangle);
            Console.WriteLine(firstTriangle.CalcPerimeter());
            Console.WriteLine(firstTriangle.CalcArea());

            Console.ReadKey();
        }
    }
}
