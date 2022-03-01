
using System.Drawing;

namespace Celestials
{
    public class CelestialObject
    {
        protected String name;
        protected int objectRadius { get; set; }
        protected int orbitalRadius{ get; set; }
        protected int orbitalPeriod { get; set; }
        protected int rotationalPeriod { get; set; }
        public Color objectColor { get; set; }

        public CelestialObject(String name)
        {
            this.name = name;
        }

        public virtual ValueTuple<int, int> calculatePosition(int time)
        {
            int x = (int)(orbitalRadius * Math.Cos(time * orbitalPeriod * Math.PI / 180));
            int y = (int)(orbitalRadius * Math.Sin(time * orbitalPeriod * Math.PI / 180));
            (int x, int y) pos = (x,y);
            return pos;
        }

        public virtual void Draw()
        {
        Console.Write("{0}: ", this.GetType().Name);
        Console.WriteLine(name);
        }
    }
}
