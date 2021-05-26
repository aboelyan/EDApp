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
    public partial class Add_ActType : Form
    {
        BL.Acyivites prd = new BL.Acyivites();
        public Add_ActType()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            prd.ADD_ActivityType(textBox1.Text);

            MessageBox.Show("تمت الإضافة بنجاح", "عملية الإضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
