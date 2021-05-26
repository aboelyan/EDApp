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
    public partial class FRM_ADD_USER : Form
    {
        public FRM_ADD_USER()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (txtID.Text == string.Empty || txtPWD.Text == string.Empty
                || txtFullName.Text == string.Empty || txtPWDConfirm.Text == string.Empty)
            {
                MessageBox.Show("رجاء أدخل جميع البيانات", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtPWD.Text != txtPWDConfirm.Text)
            {
                MessageBox.Show("رجاء كلمات السر غير متطابقة", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (btnSave.Text == "حفظ المستخدم")
            {

                BL.CLS_LOGIN user = new BL.CLS_LOGIN();
                user.ADD_USER(txtID.Text, txtFullName.Text, txtPWD.Text, cmbType.Text);
                MessageBox.Show("تم إنشاء المستخدم بنجاح", "إضافة مستخدم جديد", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (btnSave.Text == "تعديل المستخدم")
            {

                BL.CLS_LOGIN user = new BL.CLS_LOGIN();
                user.EDIT_USER(txtID.Text, txtFullName.Text, txtPWD.Text, cmbType.Text);
                MessageBox.Show("تم تعديل المستخدم بنجاح", "تعديل مستخدم", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }




            txtID.Clear();
            txtFullName.Clear();
            txtPWD.Clear();
            txtPWDConfirm.Clear();
            txtID.Focus();

        }

        private void txtPWDConfirm_Validated(object sender, EventArgs e)
        {
            if (txtPWD.Text != txtPWDConfirm.Text)
            {
                MessageBox.Show("رجاء كلمات السر غير متطابقة", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
        }
    }
}
