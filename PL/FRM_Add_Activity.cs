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
    public partial class FRM_Add_Activity : Form
    {
        public string state = "add";
        BL.Acyivites prd = new BL.Acyivites();

        public FRM_Add_Activity()
        {
            InitializeComponent();
            cmbcenter.DataSource = prd.Get_centers();
            cmbcenter.DisplayMember = "cname";
            cmbcenter.ValueMember = "id";

            cmbactivityType.DataSource = prd.Get_All_ActivityType();
            cmbactivityType.DisplayMember = "name";
            cmbactivityType.ValueMember = "id";

            cmbproject.DataSource = prd.Get_Project();
            cmbproject.DisplayMember = "proname";
            cmbproject.ValueMember = "id";

            cmbtraner.DataSource = prd.Gett_TranerName();
            cmbtraner.DisplayMember = "tname";
            cmbtraner.ValueMember = "id";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {

            if (state == "add")
            {
                prd.adActivity(acname.Text, Convert.ToInt32(cmbproject.SelectedValue), Convert.ToInt32(cmbactivityType.SelectedValue), Convert.ToInt32(cmbtraner.SelectedValue),
                    dateTimePicker1.Value, dateTimePicker2.Value, place.Text, Convert.ToInt32(cmbtraner.SelectedValue), Convert.ToInt32(mail.Text), Convert.ToInt32(fmail.Text));

                MessageBox.Show("تمت الإضافة بنجاح", "عملية الإضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

                prd.Edit_Activity(acname.Text, Convert.ToInt32(cmbproject.SelectedValue), Convert.ToInt32(cmbactivityType.SelectedValue), Convert.ToInt32(cmbtraner.SelectedValue),
                  dateTimePicker1.Value, dateTimePicker2.Value, place.Text, Convert.ToInt32(cmbcenter.SelectedValue), Convert.ToInt32(mail.Text), Convert.ToInt32(fmail.Text));

                MessageBox.Show("تم التعديل بنجاح", "عملية التعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
.

