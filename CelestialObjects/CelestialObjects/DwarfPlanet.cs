using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Celestials
{
    public class DwarfPlanet : Planet
    {
        public DwarfPlanet(String name, double objectRadius, long orbitalRadius, double orbitalPeriod, double rotationalPeriod, Color objectColor) : 
            base(name, objectRadius, orbitalRadius, orbitalPeriod, rotationalPeriod, objectColor) { }
        public override void Draw()
        {
            //Console.Write("Planet: ");
            base.Draw();
        }
    }
}
