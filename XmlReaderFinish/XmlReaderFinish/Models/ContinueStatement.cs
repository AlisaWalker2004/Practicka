using System;
using System.Xml.Serialization;

namespace Test.Models
{
    public class ContinueStatement
    {
        [XmlElement("Дата")]
        public DateTime Date { get; set; }

        [XmlElement("СтатусЗаявления")]
        public int Status { get; set; }
    }
}
