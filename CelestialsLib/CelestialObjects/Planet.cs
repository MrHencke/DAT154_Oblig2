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
        public override void DrawForms(Graphics g, int x = -1, int y = -1)
        {
            base.DrawForms(g, x, y);
            if (Moons != null) Moons.ForEach(m => m.DrawForms(g,x,y));
        }
    }
}
