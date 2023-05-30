using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace RederFinish.Models
{
    public class Event
    {
        [XmlElement("UUID", Namespace = "http://пф.рф/ВС/ЕФС/2022-09-22")]
        public string UUID { get; set; }

        [XmlElement("Дата", Namespace = "http://пф.рф/ВС/ЕФС/2022-09-22")]
        public string Date { get; set; }

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

        [XmlElement("ОснованиеУвольнения", Namespace = "http://пф.рф/ВС/ЕФС/2022-09-22")]
        public Dismissal Dismissal { get; set; }

        [XmlElement("Причина", Namespace = "http://пф.рф/ВС/ЕФС/2022-09-22")]
        public string PrichinaYvol { get; set; }

    }
}
