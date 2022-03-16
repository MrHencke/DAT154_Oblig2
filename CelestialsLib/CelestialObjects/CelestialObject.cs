using System.Drawing;

namespace CelestialsLib
{

    public class CelestialObject
    {
        public String name { get; protected set; }
        public CelestialObject orbits { get; protected set; }
        public int xPos { get; protected set; }
        public int yPos { get; protected set; }
        public int objectRadius { get; protected set; }
        public int o_objectRadius { get; protected set; }
        public int orbitalRadius{ get; protected set; }
        public long o_orbitalRadius{ get; protected set; }
        public double orbitalPeriod { get; protected set; }
        public double rotationalPeriod { get; protected set; }
        protected Color objectColor { get; set; }

        public CelestialObject(String name)
        {
            this.name = name;
        }
        public CelestialObject(String name, CelestialObject orbits, int objectRadius, long orbitalRadius, double orbitalPeriod, double rotationalPeriod, Color objectColor)
        {
            this.name = name;
            this.orbits = orbits;
            this.xPos = 0;
            this.yPos = 0;
            this.objectRadius = (int)(Math.Sqrt(objectRadius)/Math.Log(objectRadius));
            this.o_objectRadius = objectRadius;
            this.orbitalRadius = (int)(Math.Sqrt(200 * Math.Sqrt(orbitalRadius) / Math.Log(orbitalRadius))) - 200;
            this.o_orbitalRadius = orbitalRadius;
            this.orbitalPeriod = orbitalPeriod;
            this.rotationalPeriod = rotationalPeriod;
            this.objectColor = objectColor;
        }

        public virtual void updatePosition(int time)
        {
            this.xPos = (int)(this.orbits.xPos + (this.orbitalRadius * Math.Cos((time / this.orbitalPeriod) * Math.PI)));
            this.yPos = (int)(this.orbits.yPos + (this.orbitalRadius * Math.Sin((time / this.orbitalPeriod) * Math.PI)));
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
            Brush brush = new SolidBrush(objectColor);
            Rectangle rect = new Rectangle(xPos - objectRadius, yPos - objectRadius, 2 * objectRadius, 2 * objectRadius);
            g.FillEllipse(brush, rect);
            brush.Dispose();
        }

        public virtual void DrawObjectName(Graphics g, int x = -1, int y = -1)
        {
            FontFamily fontFamily = new FontFamily("Lucida Console");
            Font font = new Font(
               fontFamily,
               14,
               FontStyle.Regular,
               GraphicsUnit.Point   
               );
            Point point = x == -1 && y == -1 ? new Point(this.xPos-10, this.yPos+this.objectRadius+10)
                : new Point(x, y + this.objectRadius+10);
            StringFormat stringFormat = new StringFormat();
            SolidBrush brush = new SolidBrush(Color.Black);
            stringFormat.FormatFlags = StringFormatFlags.DirectionVertical;
            g.DrawString(this.name, font, brush, point, stringFormat);
            brush.Dispose();
        }

        public virtual void DrawObjectOrbit(Graphics g)
        {
            Pen pen = new Pen(Color.White);
            pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            pen.DashPattern = new float[] { 5, 4 };
            Rectangle rect = new Rectangle(this.orbits.xPos - orbitalRadius, this.orbits.yPos - orbitalRadius, 2 * orbitalRadius, 2 * orbitalRadius);
            g.DrawEllipse(pen, rect);
            pen.Dispose();
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
