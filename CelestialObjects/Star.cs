namespace Celestials
{
    public class Star : CelestialObject
    {
        public Star(String name) : base(name) { }
        public override void Draw()
        {
            //Console.Write("Star : ");
            base.Draw();
        }
    }
}
