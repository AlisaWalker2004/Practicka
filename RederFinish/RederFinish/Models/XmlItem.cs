using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace RederFinish.Models
{
    public class XmlItem
    {
        public XmlItem(string path)
        {
            using (var fs = new FileStream(path, FileMode.Open))
            {
                _data = (EDPFR)new XmlSerializer(typeof(EDPFR)).Deserialize(fs);

                //это прям весь объект
                //я бы попробовал посокращать такие путя, но я немного заебался ლ(́◉◞౪◟◉‵ლ)
            }
        }

        public Policyholder Policyholder => _data.EFC.Policyholder;




        private EDPFR _data;
    }
}
