using System;
using System.Text;
using Celestials;


namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            List<CelestialObject> solarSystem = new List<CelestialObject>
             {
                 new Star("Sun"),
                 new Planet("Mercury"),
                 new Planet("Venus"),
                 new Planet("Terra"),
                 new Moon("The Moon")
             };
            foreach (CelestialObject obj in solarSystem)
            {
                obj.Draw();
            }

            Console.ReadLine();
        }
    }
}
