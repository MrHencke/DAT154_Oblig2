using System.Drawing;

namespace Celestials
{
    public class Sun : Star
    {
        public Sun() : base("Sun") {
            name = "Sun";
            orbitalRadius = 0;
            orbitalPeriod = 0;
            objectRadius = 696342; //695000;
            rotationalPeriod = 25;
            objectColor = Color.Yellow;
        }
        public override void Draw()
        {
            base.Draw();
        }
    }
}
