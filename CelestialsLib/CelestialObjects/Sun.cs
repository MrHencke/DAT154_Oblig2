using System.Drawing;

namespace CelestialsLib
{
    public class Sun : Star
    {
        public Sun() :
            base("Sun", null, 696342, 0, 0, 25, Color.Yellow)
        {
            this.objectRadius = Scaling.sunRadius;
            this.orbits = this;
        }

        public void setPosition(Tuple<int, int> center)
        {
            this.xPos = center.Item1;
            this.yPos = center.Item2;
        }

    }
}
