using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Celestials
{
    public class AsteroidBelt : CelestialObject
    {
        public int innerOrbitalRadius;
        public AsteroidBelt(String name) : base(name) { }
        public override void Draw()
        {
            base.Draw();
        }
    }
}
