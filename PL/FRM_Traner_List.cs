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
    public partial class FRM_Traner_List : Form
    {
        BL.Traners prd = new BL.Traners();

        public FRM_Traner_List()
        {
            InitializeComponent();
            this.dataGridView1.DataSource = prd.Get_All_Traners();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            DataTable Dt = new DataTable();
            Dt = prd.Search_Traner(txtSearch.Text);
            this.dataGridView1.DataSource = Dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FRM_Add_Traner frm = new FRM_Add_Traner();
            frm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد فعلا حذف المنتوج المحدد؟", "عملية الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                prd.Delete_Traner(this.dataGridView1.CurrentRow.Cells[0].Value.ToString());
                MessageBox.Show("تمت عملية الحذف بنجاح", "عملية الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.dataGridView1.DataSource = prd.Get_All_Traners();
            }
            else
            {
                MessageBox.Show("تم إلغاء عملية الحذف", "عملية الحذف", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FRM_Add_Traner frm = new FRM_Add_Traner();
            frm.txtname.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            frm.txtssn.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            frm.txtq.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            frm.txtphone.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
            frm.txtemail.Text = this.dataGridView1.CurrentRow.Cells[5].Value.ToString();
            frm.txtcont.Text = this.dataGridView1.CurrentRow.Cells[6].Value.ToString();
            frm.btnsave.Text = "تحديث";
            frm.state = "update";
            frm.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
