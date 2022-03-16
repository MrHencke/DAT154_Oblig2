using System.Drawing;

namespace CelestialsLib
{
    
    public class Planet : CelestialObject
    {
        public List<Moon> Moons { get; set; }

        public Planet(String name) : base(name) { }

        public Planet(String name, CelestialObject orbits, int objectRadius, long orbitalRadius, double orbitalPeriod, double rotationalPeriod, Color objectColor) : 
            base(name, orbits, objectRadius, orbitalRadius, orbitalPeriod, rotationalPeriod, objectColor) 
        { 
            this.Moons = new List<Moon>();
        }
        public override void Draw()
        {
            base.Draw();
        }
        public override void Draw(int time)
        {
            base.Draw(time);
            if( Moons != null ) Moons.ForEach(m => m.Draw(time));
        }

        public override void UpdatePosition(int time)
        {
            base.UpdatePosition(time);
            if (Moons.Count > 0) Moons.ForEach(m => m.UpdatePosition(time));
        }
        public override void DrawForms(Graphics g)
        {
            base.DrawForms(g);
            if (Moons.Count > 0) Moons.ForEach(m => m.DrawForms(g));
        }

        public override void DrawObjectName(Graphics g, int x = -1, int y = -1)
        {
            base.DrawObjectName(g, x, y);
            if (Moons.Count > 0) Moons.ForEach(m => m.DrawObjectName(g));
        }

        public override void DrawObjectOrbit(Graphics g)
        {
            base.DrawObjectOrbit(g);
            if (Moons.Count > 0) Moons.ForEach(m => m.DrawObjectOrbit(g));
        }
    }
}
