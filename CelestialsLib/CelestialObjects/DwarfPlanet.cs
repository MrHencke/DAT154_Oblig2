using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CelestialsLib
{
    public class DwarfPlanet : Planet
    {
        public DwarfPlanet(String name, CelestialObject orbits, int objectRadius, long orbitalRadius, double orbitalPeriod, double rotationalPeriod, Color objectColor) : 
            base(name, orbits, objectRadius, orbitalRadius, orbitalPeriod, rotationalPeriod, objectColor) { }
        public override void Draw()
        {
            base.Draw();
        }
    }
}
