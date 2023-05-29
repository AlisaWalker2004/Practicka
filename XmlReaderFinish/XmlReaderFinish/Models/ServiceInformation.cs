using System;
using System.Xml.Serialization;

namespace Test.Models
{
    public class ServiceInformation
    {
        [XmlElement("GUID", Namespace = "http://пф.рф/АФ/2018-12-07")]
        public string GUID { get; set; }

        [XmlElement("ДатаВремя", Namespace = "http://пф.рф/АФ/2018-12-07")]
        public DateTime DateTime { get; set; }

        [XmlElement("ПрограммаПодготовки", Namespace = "http://пф.рф/АФ/2018-12-07")]
        public string TrainingProgram { get; set; }
    }
}
