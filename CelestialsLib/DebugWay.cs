using System.Drawing;

namespace CelestialsLib
{

    public class DebugWay : SolarSystem
    {
        public DebugWay()
        {
            Sun Sun = new Sun();
            Planet Mercury = new Planet(nameof(Mercury), Sun, 4879 / 2, 57909227, 87.97, 59, Color.Gray);
            Planet Venus = new Planet(nameof(Venus), Sun, 12104 / 2, 108209475, 224.7, 243, Color.OrangeRed);
            Planet Earth = new Planet(nameof(Earth), Sun, 12756 / 2, 149598262, 365.26, 1, Color.Blue);
            Planet Mars = new Planet(nameof(Mars), Sun, 6805 / 2, 227943824, 686.98, 24.6, Color.Red);
            Planet Jupiter = new Planet(nameof(Jupiter), Sun, 142984 / 2, 778340821, 4332.82, 10, Color.Brown);
            Planet Saturn = new Planet(nameof(Saturn), Sun, 120536 / 2, 142666422, 10755.7, 10.6, Color.Yellow);
            Planet Uranus = new Planet(nameof(Uranus), Sun, 51118 / 2, 2870658186, 30687.15, 17, Color.Blue);
            Planet Neptune = new Planet(nameof(Neptune), Sun, 49528 / 2, 4498396441, 60190.03, 16, Color.DarkBlue);
            Planet Pluto = new DwarfPlanet(nameof(Pluto), Sun, 2368 / 2, 5874000000, 247.92065, 153, Color.RosyBrown);

            this.Sun = Sun;
            this.objects = new List<CelestialObject>
            {
                Sun, Mercury, Venus, Earth, Mars, Jupiter, Uranus, Neptune, Pluto
            };
        }
    }
}

