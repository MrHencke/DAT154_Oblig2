using System.Drawing;

namespace CelestialsLib
{

    public class CelestialObject
    {
        public String Name { get; protected set; }
        public CelestialObject Orbits { get; protected set; }
        public int XPos { get; protected set; }
        public int YPos { get; protected set; }
        public int ObjectRadius { get; protected set; }
        public int UnscaledObjectRadius { get; protected set; }
        public int OrbitalRadius{ get; protected set; }
        public long UnscaledOrbitalRadius { get; protected set; }
        public double OrbitalPeriod { get; protected set; }
        public double RotationalPeriod { get; protected set; }
        protected Color ObjectColor { get; set; }

        public CelestialObject(String name)
        {
            this.Name = name;
        }
        public CelestialObject(String name, CelestialObject orbits, int objectRadius, long orbitalRadius, double orbitalPeriod, double rotationalPeriod, Color objectColor)
        {
            this.Name = name;
            this.Orbits = orbits;
            this.XPos = 0;
            this.YPos = 0;
            this.ObjectRadius = (int)(Math.Sqrt(objectRadius)/Math.Log(objectRadius));
            this.UnscaledObjectRadius = objectRadius;
            this.OrbitalRadius = (int)(Math.Sqrt(200 * Math.Sqrt(orbitalRadius) / Math.Log(orbitalRadius))) - 200;
            this.UnscaledOrbitalRadius = orbitalRadius;
            this.OrbitalPeriod = orbitalPeriod;
            this.RotationalPeriod = rotationalPeriod;
            this.ObjectColor = objectColor;
        }

        public virtual void UpdatePositionEvent(object sender, EventArgs e)
        {
            //UpdatePosition();
        }

        public virtual void UpdatePosition(int time)
        {
            this.XPos = (int)(this.Orbits.XPos + (this.OrbitalRadius * Math.Cos(time / this.OrbitalPeriod * 2*Math.PI)));
            this.YPos = (int)(this.Orbits.YPos + (this.OrbitalRadius * Math.Sin(time / this.OrbitalPeriod * 2*Math.PI)));
        }

        public virtual void Draw()
        {
            Console.WriteLine();
            Console.WriteLine("{0}: {1}", this.GetType().Name, this.Name);
        }

        public virtual void Draw(int time)
        {
            Draw();
            WritePosition(time);
        }

        public virtual void DrawForms(Graphics g)
        {
            Brush brush = new SolidBrush(ObjectColor);
            Rectangle rect = new Rectangle(XPos - ObjectRadius, YPos - ObjectRadius, 2 * ObjectRadius, 2 * ObjectRadius);
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
            Point point = x == -1 && y == -1 ? new Point(this.XPos-10, this.YPos+this.ObjectRadius+10)
                : new Point(x, y + this.ObjectRadius+10);
            StringFormat stringFormat = new StringFormat();
            SolidBrush brush = new SolidBrush(Color.Black);
            stringFormat.FormatFlags = StringFormatFlags.DirectionVertical;
            g.DrawString(this.Name, font, brush, point, stringFormat);
            brush.Dispose();
        }

        public virtual void DrawObjectOrbit(Graphics g)
        {
            Pen pen = new Pen(Color.White);
            pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            pen.DashPattern = new float[] { 5, 4 };
            Rectangle rect = new Rectangle(this.Orbits.XPos - OrbitalRadius, this.Orbits.YPos - OrbitalRadius, 2 * OrbitalRadius, 2 * OrbitalRadius);
            g.DrawEllipse(pen, rect);
            pen.Dispose();
        }

        public virtual void WritePosition(int time)
        {
            UpdatePosition(time);
            Console.WriteLine("Current position:");
            Console.WriteLine("X: {0} ",this.XPos);
            Console.WriteLine("Y: {0} ",this.YPos);
        }

    }
}
