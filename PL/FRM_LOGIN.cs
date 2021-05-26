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
    public partial class FRM_LOGIN : Form
    {
        BL.CLS_LOGIN log = new BL.CLS_LOGIN();
        public FRM_LOGIN()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            DataTable Dt = log.LOGIN(txtID.Text, txtPWD.Text);
            if (Dt.Rows.Count > 0)
            {
                if (Dt.Rows[0][2].ToString() == "مدير")
                {
                    FRM_MAIN.getMainForm.ملفToolStripMenuItem.Enabled= true;
                  //  FRM_MAIN.getMainForm.ال.Enabled = true;
                    FRM_MAIN.getMainForm.العملاءToolStripMenuItem.Enabled = true;
                    FRM_MAIN.getMainForm.المستخدمونToolStripMenuItem.Enabled = true;
                    FRM_MAIN.getMainForm.المنتوجاتToolStripMenuItem.Enabled = true;
                   // FRM_MAIN.getMainForm.المدربينToolStripMenuItem.Enabled = false;
                    //this.المدربينToolStripMenuItem.Enabled = false;
                    //this.العملاءToolStripMenuItem.Enabled = false;
                    FRM_MAIN.getMainForm.إنشاءنسخةاحتياطيةToolStripMenuItem.Enabled = true;
                    FRM_MAIN.getMainForm.استعادةنسخةمحفوظةToolStripMenuItem.Enabled = true;
                    FRM_MAIN.getMainForm.المستخدمونToolStripMenuItem.Visible = true;
                   // Program.SalesMan = Dt.Rows[0]["FullName"].ToString();
                    this.Close();
                }
                else if (Dt.Rows[0][2].ToString() == "عادي")
                {
                    FRM_MAIN.getMainForm.المنتوجاتToolStripMenuItem.Enabled = true;
                    FRM_MAIN.getMainForm.العملاءToolStripMenuItem.Enabled = true;
                    FRM_MAIN.getMainForm.المستخدمونToolStripMenuItem.Visible = false;
                    FRM_MAIN.getMainForm.إنشاءنسخةاحتياطيةToolStripMenuItem.Enabled = true;
                    FRM_MAIN.getMainForm.استعادةنسخةمحفوظةToolStripMenuItem.Enabled = true;
                  //  Program.SalesMan = Dt.Rows[0]["FullName"].ToString();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Login failed !");
                }
            }

        }
        }
}
