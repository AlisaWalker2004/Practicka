using System;
using System.Xml.Serialization;

namespace Test.Models
{
    public class Reason
    {
        [XmlElement("Наименование", Namespace = "http://пф.рф/ВС/ЕФС/2022-09-22")]
        public string Name { get; set; }

        [XmlElement("Дата", Namespace = "http://пф.рф/ВС/ЕФС/2022-09-22")]
        public DateTime Date { get; set; }

        [XmlElement("Номер", Namespace = "http://пф.рф/ВС/ЕФС/2022-09-22")]
        public string Number { get; set; }
    }
}