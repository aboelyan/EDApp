using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElegoraDeskTop.PL
{
    public partial class FRM_ADD_PROJECT : Form
    {
        BL.Projects prd = new BL.Projects();
        public string state = "add";
        int ID;

        public FRM_ADD_PROJECT()
        {
            InitializeComponent();
        }
        public void Cleare()
        {
            txtname.Text = "";
            txtearea.Text = "";
            txtbenfnum.Text = "";
            txtbenf.Text = "";
            txtaid.Text = "";

        }
        private void btnsave_Click(object sender, EventArgs e)
        {
            if (state == "add")
            {
                prd.ADD_PROJECT(txtname.Text, txtaid.Text, dateTimePicker1.Value, dateTimePicker2.Value, Convert.ToInt32(txtbenfnum.Text), txtbenf.Text, txtearea.Text);

                MessageBox.Show("تمت الإضافة بنجاح", "عملية الإضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Cleare();
            }
            else
            {
                prd.UPDATE_PROJECT(txtname.Text, txtaid.Text, dateTimePicker1.Value, dateTimePicker2.Value, Convert.ToInt32(txtbenfnum.Text), txtbenf.Text, txtearea.Text);

                MessageBox.Show("تم التعديل بنجاح", "عملية التعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Cleare();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
