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
    public partial class FRM_Add_Benf : Form
    {
        public string state = "add";
        BL.Benfetiors prd = new BL.Benfetiors();

        public FRM_Add_Benf()
        {
            InitializeComponent();
            cmbcenter.DataSource = prd.Get_centers();
            cmbcenter.DisplayMember = "cname";
            cmbcenter.ValueMember = "id";

            cmbsex.DataSource = prd.getsex();
            cmbsex.DisplayMember = "name";
            cmbsex.ValueMember = "id";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void Cleare()
        {
            txname.Text = "";
            txtemail.Text = "";
            txtssn.Text = "";
            txtq.Text = "";
            txtphone.Text = "";

        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (state == "add")
            {
                prd.Add_Benf(txname.Text, txtssn.Text, txtq.Text, txtphone.Text, Convert.ToInt32(cmbcenter.SelectedValue), Convert.ToInt32(cmbsex.SelectedValue), txtemail.Text);

                MessageBox.Show("تمت الإضافة بنجاح", "عملية الإضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Cleare();
            }
            else
            {

                prd.Update_Benf(txname.Text, txtssn.Text, txtq.Text, txtphone.Text, Convert.ToInt32(cmbcenter.SelectedValue), Convert.ToInt32(cmbsex.SelectedValue), txtemail.Text);

                MessageBox.Show("تم التعديل بنجاح", "عملية التعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Cleare();
            }
        }

        private void txtssn_Validated(object sender, EventArgs e)
        {
            if (state == "add")
            {
                DataTable Dt = new DataTable();
                Dt = prd.VerifyBenf(txtssn.Text);
                if (Dt.Rows.Count > 0)
                {

                    MessageBox.Show("هذا الاسم موجود مسبقا", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtssn.Focus();
                    txtssn.SelectionStart = 0;
                    txtssn.SelectionLength = txtssn.TextLength;
                }
            }
        }
    }
}
