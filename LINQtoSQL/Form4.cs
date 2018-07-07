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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            TestDBDataContext dc = new TestDBDataContext();
            if (textBoxNo.ReadOnly == false)//Insert
            {
                Employee obj = new Employee();
                obj.ID = int.Parse(textBoxNo.Text);
                obj.Name = textBoxName.Text;
                obj.City = textBoxCity.Text;
                obj.Address = textBoxAddress.Text;
                dc.Employees.InsertOnSubmit(obj);
                dc.SubmitChanges();
                MessageBox.Show("Records inserted into the table");
            }
            else//Update
            {
                Employee obj = dc.Employees.SingleOrDefault(E => E.ID == int.Parse(textBoxNo.Text));
                obj.Name = textBoxName.Text;
                obj.City = textBoxCity.Text;
                obj.Address = textBoxAddress.Text;
                dc.SubmitChanges();
                MessageBox.Show("Record updated in table");
            }   
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
