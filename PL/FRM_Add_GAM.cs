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
    public partial class FRM_Add_GAM : Form
    {
        public string state = "add";
        BL.GAM prd = new BL.GAM();

        public FRM_Add_GAM()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
             this.Close();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (state == "add")
            {
                prd.Add_GAM(txtide.Text, txtname.Text, txtssn.Text, Convert.ToInt32(cmbtype.SelectedValue), txtwork.Text,
                    dateTimePicker1.Value, dateTimePicker2.Value);

                MessageBox.Show("تمت الإضافة بنجاح", "عملية الإضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {

                prd.Edit_GAM(txtide.Text, txtname.Text, txtssn.Text, Convert.ToInt32(cmbtype.SelectedValue), txtwork.Text,
                                   dateTimePicker1.Value, dateTimePicker2.Value);
                MessageBox.Show("تم التعديل بنجاح", "عملية التعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
    }

