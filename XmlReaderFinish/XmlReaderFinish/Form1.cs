using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Schema;
using System.Xml.Serialization;
using Test.Models;

namespace XmlReaderFinish
{
    public partial class Form1 : Form 
    {
        public Form1()
        {
            InitializeComponent();
            
            openFileDialog1.Filter =
                "XML - files (*.xml)|*.xml|All files (*.*)|*.*";
            openFileDialog1.RestoreDirectory = true;
        }
       
        private void lbRegNomer_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void lbInn_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void labelName_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (var fs = new FileStream(@"D:\Практика\ПФР_083-025-047175_083025_ЕФС-1_20230510_0f243d97-2166-451b-9ec9-acacbf8246c3.XML", FileMode.Open))
                {
                    var data = new XmlSerializer(typeof(EDPFR)).Deserialize(fs);

                    //lbRegNomer.DataBindings.Add(new Binding());
                    //это прям весь объект
                    //я бы попробовал посокращать такие путя, но я немного заебался ლ(́◉◞౪◟◉‵ლ)

                }





                //if (openFileDialog1.ShowDialog() == DialogResult.OK)
                //{
                //XDocument xdoc = XDocument.Load("D:\\Практика\\ПФР_083-025-047175_083025_ЕФС-1_20230510_0f243d97-2166-451b-9ec9-acacbf8246c3.XML");
                //XElement xel = xdoc.Element("ЭДПФР").Element("ЕФС-1");
                //if (xel != null)
                //{

                //foreach (XElement page in xdoc.Element("ЭДПФР").Elements("ЕФС-1"))
                //{
                //    foreach (var rn in xdoc.Elements("Страхователь"))
                //    {
                //        //XElement regNom = rn.Element("РегНомер");
                //        //XElement nameOrg = rn.Element("Наименование");
                //        //XElement inn = rn.Element("ИНН");
                //        //XElement kpp = rn.Element("КПП");
                //        //XElement ocved = rn.Element("КодПоОКВЭД");
                //        //XElement ogrn = rn.Element("ОГРН");
                //        //XElement telepone = rn.Element("Телефон");

                //        //lbRegNomer.Text = regNom.Value;
                //        //lbName.Text = nameOrg.Value;
                //        //lbInn.Text = inn.Value;
                //        //lbKpp.Text = kpp.Value;
                //        //lbOKVED.Text = ocved.Value;
                //        //lbOGRN.Text = ogrn.Value;
                //        //lbPhone.Text = telepone.Value;
                //    }
                //}
                //}
                //}

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
