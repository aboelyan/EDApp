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
    public partial class FRM_PROJECT_List : Form
    {
        BL.Projects prd = new BL.Projects();

        public FRM_PROJECT_List()
        {
            InitializeComponent();
            this.dataGridView1.DataSource = prd.Get_All_Projects();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            DataTable Dt = new DataTable();
            Dt = prd.Search_Projects(txtSearch.Text);
            this.dataGridView1.DataSource = Dt;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FRM_ADD_PROJECT frm = new FRM_ADD_PROJECT();
            frm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد فعلا حذف المنتوج المحدد؟", "عملية الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                prd.Delete_Projects(this.dataGridView1.CurrentRow.Cells[0].Value.ToString());
                MessageBox.Show("تمت عملية الحذف بنجاح", "عملية الحذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.dataGridView1.DataSource = prd.Get_All_Projects();
            }
            else
            {
                MessageBox.Show("تم إلغاء عملية الحذف", "عملية الحذف", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FRM_ADD_PROJECT frm = new FRM_ADD_PROJECT();
            frm.txtname.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            frm.txtaid.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            frm.dateTimePicker1.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            frm.dateTimePicker2.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
            frm.txtbenfnum.Text = this.dataGridView1.CurrentRow.Cells[5].Value.ToString();
            frm.txtbenf.Text = this.dataGridView1.CurrentRow.Cells[6].Value.ToString();
            frm.txtearea.Text = this.dataGridView1.CurrentRow.Cells[7].Value.ToString();
           // ID = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
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
