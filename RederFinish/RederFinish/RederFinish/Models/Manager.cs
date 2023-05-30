using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace RederFinish.Models
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
