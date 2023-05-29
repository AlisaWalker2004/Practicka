using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace RederFinish.Models
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
