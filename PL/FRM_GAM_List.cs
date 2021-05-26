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
    public partial class FRM_GAM_List : Form
    {
        BL.GAM prd = new BL.GAM();

        public FRM_GAM_List()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FRM_Add_GAM frm = new FRM_Add_GAM();
            frm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد فعلا حذف المنتوج المحدد؟", "عملية الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                prd.Delte_GAM(this.dataGridView1.CurrentRow.Cells[0].Value.ToString());
                MessageBox.Show("تمت عملية الحذف بنجاح", "عملية الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.dataGridView1.DataSource = prd.Get_All_GAM();
            }
            else
            {
                MessageBox.Show("تم إلغاء عملية الحذف", "عملية الحذف", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            FRM_Add_GAM frm = new FRM_Add_GAM();
            frm.txtide.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            frm.txtname.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            frm.txtssn.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            frm.cmbtype.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
            frm.txtwork.Text = this.dataGridView1.CurrentRow.Cells[5].Value.ToString();
            frm.dateTimePicker1.Text = this.dataGridView1.CurrentRow.Cells[6].Value.ToString();
            frm.dateTimePicker2.Text = this.dataGridView1.CurrentRow.Cells[7].Value.ToString();
            frm.btnsave.Text = "تحديث";
            frm.state = "update";
            frm.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FRM_GAM_List_Load(object sender, EventArgs e)
        {

        }
    }
}
