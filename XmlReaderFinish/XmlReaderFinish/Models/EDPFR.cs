using System;
using System.Xml.Serialization;

namespace Test.Models
{
    [Serializable, XmlRoot("ЭДПФР", Namespace = "http://пф.рф/ЕФС-1/2022-09-22")]
    public class EDPFR
    {
        [XmlElement("ЕФС-1")]
        public EFC EFC { get; set; }

        [XmlElement("СлужебнаяИнформация")]
        public ServiceInformation ServiceInformation { get; set; }
    }
}
