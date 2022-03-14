using System.Drawing;

namespace CelestialsLib
{

    public class CelestialObject
    {
        public String name { get; protected set; }
        protected CelestialObject orbits { get; set; }
        protected int xPos { get; set; }
        protected int yPos { get; set; }
        protected int objectRadius { get; set; }
        protected int orbitalRadius{ get; set; }
        protected double orbitalPeriod { get; set; }
        protected double rotationalPeriod { get; set; }
        protected Color objectColor { get; set; }

        public CelestialObject(String name)
        {
            this.name = name;
        }
        public CelestialObject(String name, CelestialObject orbits, int objectRadius, long orbitalRadius, double orbitalPeriod, double rotationalPeriod, Color objectColor)
        {
            this.name = name;
            this.orbits = orbits;
            this.xPos = (int)(Scaling.sunRadius + ((objectRadius + orbitalRadius) / Scaling.scale) / 50);
            this.yPos = 0;
            this.objectRadius = objectRadius* Scaling.planetScale / Scaling.scale;
            this.orbitalRadius = (int)(Scaling.sunRadius + ((objectRadius + orbitalRadius) / Scaling.scale) / 50);
            this.orbitalPeriod = orbitalPeriod;
            this.rotationalPeriod = rotationalPeriod;
            this.objectColor = objectColor;
        }

        public virtual void updatePosition(int time)
        {
            xPos = (int)(orbits.xPos + (orbitalRadius * Math.Cos(time * orbitalPeriod * Math.PI / 180)));
            yPos = (int)(orbits.yPos + (orbitalRadius * Math.Sin(time * orbitalPeriod * Math.PI / 180)));
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

        public virtual void DrawForms(Graphics g)
        {
            updatePosition(0);
            Brush brush = new SolidBrush(objectColor);
            Rectangle rect = new Rectangle(xPos-objectRadius, yPos -objectRadius, 2*objectRadius, 2*objectRadius);
            g.FillEllipse(brush, rect);
            brush.Dispose();
        }

        public virtual void writePosition(int time)
        {
            updatePosition(time);
            Console.WriteLine("Current position:");
            Console.WriteLine("X: {0} ",this.xPos);
            Console.WriteLine("Y: {0} ",this.yPos);
        }

    }
}
