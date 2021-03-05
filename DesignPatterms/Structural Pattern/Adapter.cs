using Newtonsoft.Json;
using System.Collections.Generic;
using System.Xml;

namespace DesignPatterns.Structural_Pattern
{
    /*
        Allow a system to use classes of another system that is incompatible with it.

        Allow communication between a new and already existing system which are independent of each other

        Ado.Net SqlAdapter, OracleAdapter, MySqlAdapter are the best example of Adapter Pattern.

    Eg :I have an interface which return list of Lumia Mobiles in JSON, 
    but Client is expecting the list of Lumia Mobile features in XML format.     
     */
    public class LumiaJSONAdaptee
    {
        public string GetLumiaMobilesJSONSpecifications()
        {
            List<LumiaMobile> LumiaMobiles = new List<LumiaMobile>();
            LumiaMobiles.Add(new LumiaMobile
            {
                ModelId = "lumia550",
                Height = "136.1 mm",
                Width = "67.8 mm",
                Thickness = "9.9 mm",
                Weight = "141.9 g"
            });
            LumiaMobiles.Add(new LumiaMobile
            {
                ModelId = "lumia950",
                Height = "145 mm",
                Width = "73.2 mm",
                Thickness = "8.2 mm",
                Weight = "150 g"
            });
            LumiaMobiles.Add(new LumiaMobile
            {
                ModelId = "Text",
                Height = "",
                Width = "",
                Thickness = "8.2 mm",
                Weight = "150 g"
            });
            dynamic collectionLumiaMobiles = new
            {
                lumiaMobiles = LumiaMobiles
            };
            return JsonConvert.SerializeObject(collectionLumiaMobiles);
        }
    }

    public class LumiaMobile
    {
        public string ModelId
        {
            get;
            set;
        }
        public string Height
        {
            get;
            set;
        }
        public string Width
        {
            get;
            set;
        }
        public string Thickness
        {
            get;
            set;
        }
        public string Weight
        {
            get;
            set;
        }
    }
    public interface ILumiaXMLTarget
    {
        XmlDocument GetLumiaMobilesXMLSpecifications();
    }
    public class LumiaXMLAdapter : ILumiaXMLTarget
    {
        public XmlDocument GetLumiaMobilesXMLSpecifications()
        {
            LumiaJSONAdaptee lumiaJsonAdaptee = new LumiaJSONAdaptee();
            string jsonLumia = lumiaJsonAdaptee.GetLumiaMobilesJSONSpecifications();
            XmlDocument doc = JsonConvert.DeserializeXmlNode(jsonLumia, "MicrosoftLumiaMoblies", true);
            return doc;
        }
    }

    public class MyLumiaClient
    {
        private ILumiaXMLTarget _lumiaXmlTarget;
        public MyLumiaClient(ILumiaXMLTarget lumiaXmlTarget)
        {
            _lumiaXmlTarget = lumiaXmlTarget;
        }
        public XmlDocument GetLumiaData()
        {
            return _lumiaXmlTarget.GetLumiaMobilesXMLSpecifications();
        }
    }
}
