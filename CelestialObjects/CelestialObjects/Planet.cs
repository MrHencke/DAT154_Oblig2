using System.Drawing;

namespace Celestials
{
    
    public class Planet : CelestialObject
    {
        public List<Moon> Moons { get; set; }

        public Planet(String name) : base(name) { }

        public Planet(String name, double objectRadius, long orbitalRadius, double orbitalPeriod, double rotationalPeriod, Color objectColor) : 
            base(name, objectRadius, orbitalRadius, orbitalPeriod, rotationalPeriod, objectColor) 
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
    }
}
