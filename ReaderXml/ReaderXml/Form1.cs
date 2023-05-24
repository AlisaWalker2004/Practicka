using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ReaderXml
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            openFileDialog1.Filter =
                "XML - files (*.xml)|*.xml|All files (*.*)|*.*";
            openFileDialog1.RestoreDirectory = true;
            dataSet = new DataSet();
        }

        private DataSet dataSet;

        private void UpdateTableList()
        {
            listTables.Items.Clear();
            foreach (DataTable table in dataSet.Tables) 
            {
                listTables.Items.Add(table.TableName);
            }

            if(listTables.Items.Count>0)
                listTables.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataSet.Tables.Clear();
            listTables.Items.Clear();
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    dataSet.ReadXml(openFileDialog1.FileName);

                    dataSet.AcceptChanges();
                    this.UpdateTableList();


                    //string filname = openFileDialog1.FileName;
                    //DataSet ds = new DataSet("table");

                    //ds.ReadXml(filname);
                    //var xd = XDocument.Load(filname);

                    //foreach (var x in xd.Descendants())
                    //foreach (var x in ds.Tables)
                    //for (var x = 0; x <= ds.Tables.Count; x++)
                    //{
                    //    //if (x.HasElements)
                    //    //{
                    //    dataGridView1.DataSource = ds.Tables[x];
                    //    //listBox1.Items.Add("\n" + x.Name + "\n");
                    //    //}
                    //    //else
                    //    //{
                    //    //    dataGridView1.DataSource = x;
                    //    //    //listBox1.Items.Add("\n" + x.Name + "\t" + x.Value + "\n");
                    //    //}
                    //}
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listTables_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGrid.DataSource = dataSet;
            dataGrid.DataMember = listTables.SelectedItem.ToString();
        }
    }
}
