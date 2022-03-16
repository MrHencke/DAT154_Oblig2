using System.Drawing;

namespace CelestialsLib
{
    public class Moon : CelestialObject
    {
        public Moon(String name) : base(name) { }
        public Moon(String name, CelestialObject orbits, int objectRadius, int orbitalRadius, double orbitalPeriod, double rotationalPeriod, Color objectColor) :
        base(name, orbits, objectRadius, orbitalRadius, orbitalPeriod, rotationalPeriod, objectColor){
            //Slightly different scaling for moons as opposed to other objects.
            this.OrbitalRadius = (int)(Math.Sqrt(200 * Math.Sqrt(orbitalRadius) / Math.Log(orbitalRadius))) % 20;
        }
    }
}
