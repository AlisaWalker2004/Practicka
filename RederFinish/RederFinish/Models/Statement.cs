using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace RederFinish.Models
{
    public class Statement
    {
        [XmlElement("ЗаявлениеОПродолжении")]
        public ContinueStatement continueStatement;
    }
}
