using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace RederFinish.Models
{
    public class EFC
    {
        [XmlElement("Страхователь")]
        public Policyholder Policyholder { get; set; }


        [XmlElement("Руководитель")]
        public Manager Manager { get; set; }

        [XmlElement("СЗВ")]
        public SZV SZV { get; set; }

        [XmlElement("ДатаЗаполнения")]
        public DateTime FillDate { get; set; }
    }
}
