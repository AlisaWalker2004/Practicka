using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace RederFinish.Models
{
    public class ServiceInformation
    {
        [XmlElement("GUID", Namespace = "http://пф.рф/АФ/2018-12-07")]
        public string GUID { get; set; }

        [XmlElement("ДатаВремя", Namespace = "http://пф.рф/АФ/2018-12-07")]
        public string DateTime { get; set; }

        [XmlElement("ПрограммаПодготовки", Namespace = "http://пф.рф/АФ/2018-12-07")]
        public string TrainingProgram { get; set; }
    }
}
