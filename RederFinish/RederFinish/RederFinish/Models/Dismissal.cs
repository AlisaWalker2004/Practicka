using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace RederFinish.Models
{
    public class Dismissal
    {
        [XmlElement("КодПричиныУвольнения", Namespace = "http://пф.рф/ВС/ЕФС/2022-09-22")]
        public string CodePrich { get; set; }

        [XmlElement("НормативныйДокумент", Namespace = "http://пф.рф/ВС/ЕФС/2022-09-22")]
        public string NormDoc { get; set; }

        [XmlElement("Статья", Namespace = "http://пф.рф/ВС/ЕФС/2022-09-22")]
        public string State { get; set; }

        [XmlElement("Часть", Namespace = "http://пф.рф/ВС/ЕФС/2022-09-22")]
        public string Chapter { get; set; }

        [XmlElement("Пункт", Namespace = "http://пф.рф/ВС/ЕФС/2022-09-22")]
        public string Punkt { get; set; }
    }
}
