
using System.Drawing;

namespace Celestials
{

    
    public class CelestialObject
    {
        public String name { get; protected set; }
        protected double objectRadius { get; set; }
        protected long orbitalRadius{ get; set; }
        protected double orbitalPeriod { get; set; }
        protected double rotationalPeriod { get; set; }
        protected Color objectColor { get; set; }

        public CelestialObject(String name)
        {
            this.name = name;
        }
        public CelestialObject(String name, double objectRadius, long orbitalRadius, double orbitalPeriod, double rotationalPeriod, Color objectColor)
        {
            this.name = name;
            this.objectRadius = objectRadius;
            this.orbitalRadius = orbitalRadius;
            this.orbitalPeriod = orbitalPeriod;
            this.rotationalPeriod = rotationalPeriod;
            this.objectColor = objectColor;
        }

        public virtual Tuple<long, long> calculatePosition(int time)
        {
            long x = (long)(orbitalRadius * Math.Cos(time * orbitalPeriod * Math.PI / 180));
            long y = (long)(orbitalRadius * Math.Sin(time * orbitalPeriod * Math.PI / 180));
            return new Tuple<long,long>(x, y);
        }

        public virtual void Draw()
        {
            Console.WriteLine();
            Console.WriteLine("{0}: {1}", this.GetType().Name, this.name);
        }

        public virtual void Draw(int time)
        {
            Draw();
            writePosition(time);
        }

        public virtual void writePosition(int time)
        {
            var positions = calculatePosition(time);
            Console.WriteLine("Current position:");
            Console.WriteLine("X: {0} ",positions.Item1);
            Console.WriteLine("Y: {0} ",positions.Item2);
        }
    }
}
