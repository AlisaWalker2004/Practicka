using System.Xml.Serialization;

namespace Test.Models
{
    public class Manager
    {
        [XmlElement("Должность", Namespace = "http://пф.рф/УТ/2017-08-21")]
        public string Post { get; set; }

        
        /// <summary>
        /// потому что Аллах так велел
        /// </summary>
        [XmlElement("ФИО", Namespace = "http://пф.рф/УТ/2017-08-21")]
        public Fullname FullName { get; set; }
    }
}
