using System.Drawing;

namespace CelestialsLib
{
    public class Sun : Star
    {
        public Sun() :
            base("Sun", null, 696342, 0, 0, 25, Color.Yellow)
        {
            this.Orbits = this;
        }

        public override void UpdatePosition(int time)
        { 
        }

        public void SetPosition(int x, int y)
        {
            this.XPos = x;
            this.YPos = y;
        }
        public override void DrawObjectOrbit(Graphics g)
        {
           //
        }
    }
}
