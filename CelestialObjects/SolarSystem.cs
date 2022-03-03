
using System.Text.Json;
using System.IO;
using System.Xml.Serialization;

namespace Celestials
{
    
    public class SolarSystem
    {
        public List<CelestialObject> objects { get; protected set; }
        public SolarSystem()
        {
            objects = new List<CelestialObject>();
        }
    }
}
