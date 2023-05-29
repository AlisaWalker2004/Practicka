using System.Xml.Serialization;

namespace Test.Models
{
    public class Policyholder
    {
        [XmlElement("РегНомер", Namespace = "http://пф.рф/ВС/ЕФС/2022-09-22")]
        public string RegistrationNumber { get; set; }

        [XmlElement("Наименование", Namespace = "http://пф.рф/ВС/ЕФС/2022-09-22")]
        public string Name { get; set; }

        [XmlElement("ИНН", Namespace = "http://пф.рф/УТ/2017-08-21")]
        public string TIN { get; set; }

        [XmlElement("КПП", Namespace = "http://пф.рф/УТ/2017-08-21")]
        public string Checkpoint { get; set; }

        [XmlElement("КодПоОКВЭД", Namespace = "http://пф.рф/УТ/2017-08-21")]
        public string Code { get; set; }

        [XmlElement("ОГРН", Namespace = "http://пф.рф/ВС/ЕФС/2022-09-22")]
        public string OGRN { get; set; }

        [XmlElement("Телефон", Namespace = "http://пф.рф/УТ/2017-08-21" )]
        public string Phone { get; set; }
    }
}
