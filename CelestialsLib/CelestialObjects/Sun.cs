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

        public void SetPosition(Tuple<int, int> center)
        {
            this.XPos = center.Item1;
            this.YPos = center.Item2;
        }
        public override void DrawObjectOrbit(Graphics g)
        {
           //
        }
    }
}
