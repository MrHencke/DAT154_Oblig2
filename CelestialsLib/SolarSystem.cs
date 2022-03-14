
using System.Text.Json;
using System.IO;
using System.Xml.Serialization;

namespace CelestialsLib
{
    
    public class SolarSystem
    {
        public Sun Sun { get; protected set; }
        public List<CelestialObject> objects { get; protected set; }
        public SolarSystem()
        {
            this.Sun = new Sun();
            this.objects = new List<CelestialObject>();
        }
    }
}
