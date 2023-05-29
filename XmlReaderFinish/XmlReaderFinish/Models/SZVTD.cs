using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Test.Models
{
    public class SZVTD
    {
        [XmlElement("Заявления")]
        public List<Statement> Statements { get; set; }

     
        [XmlElement("ТД")]
        public TD TD { get; set; }
    }
}
