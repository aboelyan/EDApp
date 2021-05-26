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
    public partial class FRM_Add_Traner : Form
    {
        public string state = "add";
        BL.Traners prd = new BL.Traners();
        public FRM_Add_Traner()
        {
            InitializeComponent();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (state == "add")
            {
                prd.Add_Tranner(txtname.Text, txtssn.Text, txtq.Text, txtphone.Text, txtemail.Text, txtcont.Text);

                MessageBox.Show("تمت الإضافة بنجاح", "عملية الإضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

                prd.Edit_Tranner(txtname.Text, txtssn.Text, txtq.Text, txtphone.Text, txtemail.Text, txtcont.Text);

                MessageBox.Show("تم التعديل بنجاح", "عملية التعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
