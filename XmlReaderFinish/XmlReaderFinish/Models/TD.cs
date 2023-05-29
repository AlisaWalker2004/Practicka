using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Test.Models
{
    public class TD
    {
        [XmlElement("Мероприятие")]
        public Event Event { get; set; }
    }
}
