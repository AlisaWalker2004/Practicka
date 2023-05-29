using System.Xml.Serialization;

namespace Test.Models
{
    public class Statement
    {
        [XmlElement("ЗаявлениеОПродолжении")]
        public ContinueStatement continueStatement;
    }
}
