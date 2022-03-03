using System.Drawing;

namespace Celestials
{
    public class Star : CelestialObject
    {
        public Star(String name, double objectRadius, long orbitalRadius, double orbitalPeriod, double rotationalPeriod, Color objectColor) : 
            base(name, objectRadius, orbitalRadius, orbitalPeriod, rotationalPeriod, objectColor) { }
        public override void Draw()
        {
            //Console.Write("Star : ");
            base.Draw();
        }
    }
}
