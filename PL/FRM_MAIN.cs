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
    public partial class FRM_MAIN : Form
    {
        private static FRM_MAIN frm;

        static void frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm = null;
        }

        public FRM_MAIN()
        {
            InitializeComponent();
            if (frm == null)
                frm = this;
            this.التقاريرToolStripMenuItem.Enabled = true;
            this.المدربينToolStripMenuItem.Enabled = true;
            this.العملاءToolStripMenuItem.Enabled = false;
            this.ادارةالمستفيدينToolStripMenuItem.Enabled = true;
            this.مجلسالادارةToolStripMenuItem.Enabled = true;
            this.ادارةالمدربينToolStripMenuItem.Enabled = true;
            this.إدارةالمنتوجاتToolStripMenuItem.Enabled = true;
            this.المستخدمونToolStripMenuItem.Enabled = false;
            this.إنشاءنسخةاحتياطيةToolStripMenuItem.Enabled = false;
            this.استعادةنسخةمحفوظةToolStripMenuItem.Enabled = false;
        }
        public static FRM_MAIN getMainForm
        {
            get
            {
                if (frm == null)
                {
                    frm = new FRM_MAIN();
                    frm.FormClosed += new FormClosedEventHandler(frm_FormClosed);
                }
                return frm;
            }
        }
        private void إنشاءنسخةاحتياطيةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_ADD_BACKUP frm = new FRM_ADD_BACKUP();
            frm.ShowDialog();
        }

        private void إضافةمنتوججديدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_ADD_PROJECT frm = new FRM_ADD_PROJECT();
            frm.ShowDialog();

        }

        private void إدارةالمنتوجاتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_PROJECT_List frm = new FRM_PROJECT_List();
            frm.ShowDialog();
        }

        private void إضافةعميلجديدToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FRM_Add_Activity frm = new FRM_Add_Activity();
            frm.ShowDialog();
        }

        private void إضافةعميلجديدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_Activity_List frm = new FRM_Activity_List();
            frm.ShowDialog();
        }

        private void إضافةبيعجديدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add_ActType frm = new Add_ActType();
            frm.ShowDialog();
        }

        private void اضافةمدربجديدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_Add_Traner frm = new FRM_Add_Traner();
            frm.ShowDialog();
        }

        private void ادارةالمدربينToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_Traner_List frm = new FRM_Traner_List();
            frm.ShowDialog();
        }

        private void اضافةمستفيدجديدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_Add_Benf frm = new FRM_Add_Benf();
            frm.ShowDialog();
        }

        private void ادارةالمستفيدينToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_Benf_List frm = new FRM_Benf_List();
            frm.ShowDialog();
        }

        private void اضافةعضوجديدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_Add_GAM frm = new FRM_Add_GAM();
            frm.ShowDialog();
        }

        private void ادارةالاعضاءToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_GAM_List frm = new FRM_GAM_List();
            frm.ShowDialog();
        }

        private void اضافةنوعيةعضويةجديدةToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void اضافةطالبToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_SShip frm = new FRM_SShip();
            frm.ShowDialog();
        }

        private void المستفيدينمنالانشطةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ActivitySearch frm = new ActivitySearch();
            frm.ShowDialog();
        }

        private void التقاريرToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ActivitySearch frm = new ActivitySearch();
            frm.Show();
        }

        private void تسجيلالخروجToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FRM_MAIN_Load(object sender, EventArgs e)
        {

        }

        private void العملاءToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void المدربينToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void المستفيدينToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void إضافةمستخدمجديدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_ADD_USER frm = new FRM_ADD_USER();
            frm.ShowDialog();

        }

        private void إدارةالمستخدمينToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_USERS_LIST frm = new FRM_USERS_LIST();
            frm.ShowDialog();
        }

        private void تسجيلالدخولToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_LOGIN frm = new FRM_LOGIN();
            frm.ShowDialog();
        }

        private void التسجيلفيالانشطةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ActivityReg frm = new ActivityReg();
            frm.ShowDialog();
        }
    }
}
