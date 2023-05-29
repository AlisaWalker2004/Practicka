using System.Collections.Generic;
using System.Xml.Serialization;

namespace Test.Models
{
    public class SZV
    {
        [XmlElement("ЗЛ")]
        public List<ZL> Collection { get; set; }
    }
}
