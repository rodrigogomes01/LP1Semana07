using System;

namespace BetterFillSpheres
{

    class Program
    {
        static void Main(string[] args)
        {
            // Create new spheres
            Sphere sphere1 = new Sphere
            {
                Color = new Color
                {
                    Red = 255,
                    Green = 0,
                    Blue = 0,
                    Alpha = 50
                },
                Radius = 10
            };
            Sphere sphere2 = new Sphere
            {
                Color = new Color
                {
                    Red = 0,
                    Green = 255,
                    Blue = 0,
                    Alpha = 50
                },
                Radius = 20
            };
            Sphere sphere3 = new Sphere
            {
                Color = new Color
                {
                    Red = 0,
                    Green = 0,
                    Blue = 255,
                    Alpha = 50
                },
                Radius = 30
            };

            // Throw spheres and explode them
            sphere1.Throw();
            sphere1.Pop();
            sphere2.Throw();
            sphere2.Pop();
            sphere3.Throw();
            sphere3.Pop();

            // Print the spheres state
            Console.WriteLine("Sphere 1 color: " + sphere1.Color.Red + ", " +
                              sphere1.Color.Green + ", " + sphere1.Color.Blue +
                              ", " + sphere1.Color.Alpha + " | Sphere 1 radius: " +
                              sphere1.Radius + " | Sphere 1 times thrown: " +
                              sphere1.GetTimesThrown);
            Console.WriteLine("Sphere 2 color: " + sphere2.Color.Red + ", " +
                                sphere2.Color.Green + ", " + sphere2.Color.Blue +
                                ", " + sphere2.Color.Alpha + " | Sphere 2 radius: " +
                                sphere2.Radius + " | Sphere 2 times thrown: " +
                                sphere2.GetTimesThrown);
            Console.WriteLine("Sphere 3 color: " + sphere3.Color.Red + ", " +
                                sphere3.Color.Green + ", " + sphere3.Color.Blue +
                                ", " + sphere3.Color.Alpha + " | Sphere 3 radius: " +
                                sphere3.Radius + " | Sphere 3 times thrown: " +
                                sphere3.GetTimesThrown);

                                // Print the name of the color of each sphere
            Console.WriteLine("Sphere 1 color name: " + sphere1.Color.GetName);
            Console.WriteLine("Sphere 2 color name: " + sphere2.Color.GetName);
            Console.WriteLine("Sphere 3 color name: " + sphere3.Color.GetName);
        }
    }
} 