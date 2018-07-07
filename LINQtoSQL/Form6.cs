using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LINQtoSQL
{
    public partial class Form6 : Form
    {
        TestDBDataContext dc;
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            dc = new TestDBDataContext();
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            dc.AddNewEmpDetails(textBoxName.Text,textBoxCity.Text,textBoxAddress.Text);
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox)
                {
                    TextBox tb = ctrl as TextBox;
                    tb.Clear();
                }
            }
            textBoxNo.Focus();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
