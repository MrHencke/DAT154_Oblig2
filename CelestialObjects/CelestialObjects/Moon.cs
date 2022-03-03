using System.Drawing;

namespace Celestials
{
    public class Moon : Planet
    {
        public Moon(String name) : base(name) { }
        public Moon(String name, double objectRadius, long orbitalRadius, double orbitalPeriod, double rotationalPeriod, Color objectColor) :
        base(name, objectRadius, orbitalRadius, orbitalPeriod, rotationalPeriod, objectColor){ }
        public override void Draw()
        {
            base.Draw();
        }
    }
}
