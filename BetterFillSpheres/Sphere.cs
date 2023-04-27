using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;

namespace BetterFillSpheres
{
    public class Sphere
    {
        // Color, radius and throw count
        public int ThrowCount;

        // Getters and setters
        public Color Color { get ; set ;}
        public float Radius { get ; set ;}


        // Pop() method that puts radius at 0
        public void Pop()
        {
            Radius = 0;
        }

        // Method Throw() that increments throw count only if radius is greater than 0
        public void Throw()
        {
            if (Radius > 0)
            {
                ThrowCount++;
            }
        }
        public int GetTimesThrown { get => throwCount; }
    }
}