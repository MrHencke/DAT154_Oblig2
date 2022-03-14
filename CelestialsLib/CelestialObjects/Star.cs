using System.Drawing;

namespace CelestialsLib
{
    public class Star : CelestialObject
    {
        public Star(String name, CelestialObject orbits, int objectRadius, int orbitalRadius, double orbitalPeriod, double rotationalPeriod, Color objectColor) : 
            base(name, orbits, objectRadius, orbitalRadius, orbitalPeriod, rotationalPeriod, objectColor) { }
        public override void Draw()
        {
            base.Draw();
        }
    }
}
