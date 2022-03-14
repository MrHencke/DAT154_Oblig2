using System.Drawing;

namespace CelestialsLib
{
    public class Moon : Planet
    {
        public Moon(String name) : base(name) { }
        public Moon(String name, CelestialObject orbits, int objectRadius, int orbitalRadius, double orbitalPeriod, double rotationalPeriod, Color objectColor) :
        base(name, orbits, objectRadius, orbitalRadius, orbitalPeriod, rotationalPeriod, objectColor){ }
        public override void Draw()
        {
            base.Draw();
        }
    }
}
