namespace Celestials
{
    public class Moon : Planet
    {
        public Moon(String name) : base(name) { }
        public override void Draw()
        {
            //Console.Write("Moon : ");
            base.Draw();
        }
    }
}
