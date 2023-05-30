using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace RederFinish.Models
{
    public class ContinueStatement
    {
        [XmlElement("Дата")]
        public string Date { get; set; }

        [XmlElement("СтатусЗаявления")]
        public int Status { get; set; }
    }
}
