using System;
using System.Xml.Serialization;

namespace Test.Models
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
