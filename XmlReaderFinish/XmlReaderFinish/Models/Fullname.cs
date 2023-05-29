using System.Xml.Serialization;

namespace Test.Models
{
    public class Fullname
    {
        [XmlElement("Имя", Namespace = "http://пф.рф/УТ/2017-08-21")]
        public string FirstName { get; set; }


        [XmlElement("Фамилия", Namespace = "http://пф.рф/УТ/2017-08-21")]
        public string SecondName { get; set; }


        [XmlElement("Отчество", Namespace = "http://пф.рф/УТ/2017-08-21")]
        public string Patronimyc { get; set; }
    }
}
