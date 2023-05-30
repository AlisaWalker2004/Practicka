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
            }
        }

        public Policyholder Policyholder => _data.EFC.Policyholder;
        public Manager Manager => _data.EFC.Manager;
        public Fullname Fullname => _data.EFC.Manager.FullName;
        public EFC EFC => _data.EFC;
        public ServiceInformation ServiceInformation => _data.ServiceInformation;
        public List<ZL> ZLs => _data.EFC.SZV.ZLs;



        private EDPFR _data;
    }
}
