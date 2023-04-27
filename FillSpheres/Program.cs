using System;

namespace FillSpheres
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create new spheres
            Sphere sphere1 = new Sphere(new Color(255, 0, 0), 10);
            Sphere sphere2 = new Sphere(new Color(0, 255, 0), 20);
            Sphere sphere3 = new Sphere(new Color(0, 0, 255), 30);

            // Throw spheres and explode them
            sphere1.Throw();
            sphere1.Pop();
            sphere2.Throw();
            sphere2.Pop();
            sphere3.Throw();
            sphere3.Pop();

            // Print spheres color, radius and times thrown
            Console.WriteLine("Sphere 1 color: " + sphere1.Color.Red + ", " + sphere1.Color.Green + ", " + sphere1.Color.Blue);
            Console.WriteLine("Sphere 1 radius: " + sphere1.Radius);
            Console.WriteLine("Sphere 1 times thrown: " + sphere1.GetTimesThrown());
            Console.WriteLine("Sphere 2 color: " + sphere2.Color.Red + ", " + sphere2.Color.Green + ", " + sphere2.Color.Blue);
            Console.WriteLine("Sphere 2 radius: " + sphere2.Radius);
            Console.WriteLine("Sphere 2 times thrown: " + sphere2.GetTimesThrown());
            Console.WriteLine("Sphere 3 color: " + sphere3.Color.Red + ", " + sphere3.Color.Green + ", " + sphere3.Color.Blue);
            Console.WriteLine("Sphere 3 radius: " + sphere3.Radius);
            Console.WriteLine("Sphere 3 times thrown: " + sphere3.GetTimesThrown());
       }
    }
} 