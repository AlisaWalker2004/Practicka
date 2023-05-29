using System;
using System.Xml.Serialization;

namespace Test.Models
{
    public class ZL
    {
        [XmlElement("СНИЛС", Namespace = "http://пф.рф/УТ/2017-08-21")]
        public string Insurance { get; set; }

        [XmlElement("ИНН")]
        public string INN { get; set; }

        [XmlElement("ФИО", Namespace = "http://пф.рф/УТ/2017-08-21")]
        public Fullname Fullname { get; set; }

        [XmlElement("ДатаРождения", Namespace = "http://пф.рф/УТ/2017-08-21")]
        public DateTime Birthday { get; set; }

        [XmlElement("СтатусЗЛ")]
        public string Status { get; set; }

        [XmlElement("Гражданство")]
        public string Citizenship { get; set; }

        [XmlElement("СЗВ-ТД")]
        public SZVTD SZVTD { get; set; }
    }
}
