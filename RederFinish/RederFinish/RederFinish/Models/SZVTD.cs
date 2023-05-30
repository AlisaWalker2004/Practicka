using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace RederFinish.Models
{
    public class SZVTD
    {
        [XmlElement("Заявления")]
        public Statement Statements { get; set; }


        [XmlElement("ТД")]
        public TD TD { get; set; }
    }
}
