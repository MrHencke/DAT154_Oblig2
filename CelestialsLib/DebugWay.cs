using System.Drawing;

namespace CelestialsLib
{

    public class DebugWay : SolarSystem
    {
        public DebugWay()
        {
            Sun Sun = new Sun();
            Planet Mercury = new Planet(nameof(Mercury), Sun, 4879 / 2, 57909227, 88, 59, Color.Gray);
            Planet Venus = new Planet(nameof(Venus), Sun, 12104 / 2, 108209475, 225, 243, Color.OrangeRed);
            Planet Earth = new Planet(nameof(Earth), Sun, 12756 / 2, 149598262, 365, 1, Color.Blue);
            Earth.Moons.Add(new Moon("Moon", Earth, 3475/2, 384400, 384, 27, Color.LightSlateGray));
            Planet Mars = new Planet(nameof(Mars), Sun, 6805 / 2, 227943824, 686.98, 25, Color.Red);
            Planet Jupiter = new Planet(nameof(Jupiter), Sun, 142984 / 2, 778340821, 4333, 10, Color.SandyBrown);
            Planet Saturn = new Planet(nameof(Saturn), Sun, 120536 / 2, 1426664220, 10756, 10.6, Color.Yellow);
            Planet Uranus = new Planet(nameof(Uranus), Sun, 51118 / 2, 2870658186, 30687, 17, Color.Blue);
            Planet Neptune = new Planet(nameof(Neptune), Sun, 49528 / 2, 4498396441, 60190, 16, Color.DarkBlue);
            Planet Pluto = new DwarfPlanet(nameof(Pluto), Sun, 2368 / 2, 5874000000, 248*365, 153, Color.RosyBrown);

            this.GravitationalCenter = Sun;
            this.objects = new List<CelestialObject>
            {
                Sun, Mercury, Venus, Earth, Mars, Jupiter, Saturn, Uranus, Neptune, Pluto
            };
        }
    }
}
