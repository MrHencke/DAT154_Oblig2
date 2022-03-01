namespace Celestials
{
    public class Planet : CelestialObject
    {   
        protected List<Moon> Moons;
        public Planet(String name) : base(name) { }
        public override void Draw()
        {
            //Console.Write("Planet: ");
            base.Draw();
        }
    }
}
