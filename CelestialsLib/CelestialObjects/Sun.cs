using System.Drawing;

namespace CelestialsLib
{
    public class Sun : Star
    {
        public Sun() :
            base("Sun", null, 696342, 0, 0, 25, Color.Yellow)
        {
            this.orbits = this;
        }

        public override void updatePosition(int time)
        { 
        }

        public void setPosition(Tuple<int, int> center)
        {
            this.xPos = center.Item1;
            this.yPos = center.Item2;
        }
        public override void DrawObjectOrbit(Graphics g)
        {
           //
        }
    }
}
