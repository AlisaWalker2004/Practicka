using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Converter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnZapis_Click(object sender, EventArgs e)
        {
            if (tbFioSotr.Text != null)
            {
                string fioSotr = tbFioSotr.Text;
                string name = fioSotr.Split(' ')[1];
                string surname = fioSotr.Split(' ')[0];
                var firstCharsname = name[0];
                string name2 = Convert.ToString(firstCharsname);

                Translit translit = new Translit();
                string testIn = name2.ToLower() + " " + surname.ToLower();
                string testOut = translit.TranslitFileName(testIn);
                tbRes.Text = testOut;
            }
            else
                MessageBox.Show("Введите фио сотрудника!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
