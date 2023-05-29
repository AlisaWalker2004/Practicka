using System;
using System.Xml.Serialization;

namespace Test.Models
{
    public class Event
    {
        [XmlElement("UUID", Namespace = "http://пф.рф/ВС/ЕФС/2022-09-22")]
        public string UUID { get; set; }

        [XmlElement("Дата", Namespace = "http://пф.рф/ВС/ЕФС/2022-09-22")]
        public DateTime Date { get; set; }
        
        [XmlElement("Вид", Namespace = "http://пф.рф/ВС/ЕФС/2022-09-22")]
        public int Type { get; set; }

        [XmlElement("Должность", Namespace = "http://пф.рф/ВС/ЕФС/2022-09-22")]
        public string Post { get; set; }

        [XmlElement("ЯвляетсяСовместителем", Namespace = "http://пф.рф/ВС/ЕФС/2022-09-22")]
        public bool IsCooperator { get; set; }

        [XmlElement("СтруктурноеПодразделение", Namespace = "http://пф.рф/ВС/ЕФС/2022-09-22")]
        public string Subdivision { get; set; }

        [XmlElement("КодВФпоОКЗ", Namespace = "http://пф.рф/ВС/ЕФС/2022-09-22")]
        public string Code { get; set; }

        [XmlElement("Основание", Namespace = "http://пф.рф/ВС/ЕФС/2022-09-22")]
        public Reason Reason { get; set; }
    }
}
