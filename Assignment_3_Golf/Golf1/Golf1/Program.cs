using System;

namespace Golf1
{
    class Program
    {
        // Simple Golf Console Application.

        static void Main(string[] args)
        {
            Console.WriteLine("Golf");

            // Angle in Radians.
            Console.Write("Angle Degrees in Radians: ");
            double angle = Convert.ToInt32(Console.ReadLine());
            // PI radians = 180°
            // Degree symbol Alt+0176
            double angleInRadians = (Math.PI / 180) * angle;
            Console.WriteLine($"{angle} Degrees is: {angleInRadians} Radians");
            Console.WriteLine($"{angle} Degrees is: {Math.Round(angleInRadians, 2)} Radians");

            // Distance. How far the object travels. Take into account gravity.

        }
    }
}
