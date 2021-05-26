using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElegoraDeskTop.PL
{
    public partial class FRM_ADD_BACKUP : Form
    {
        SqlConnection con = new SqlConnection(@"Server=.\SQLEXPRESS; Database= Go; Integrated Security=True");
        SqlCommand cmd;

        public FRM_ADD_BACKUP()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txtFileName.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string fileName = txtFileName.Text + "\\Go" + DateTime.Now.ToShortDateString().Replace('/', '-')
             + " - " + DateTime.Now.ToLongTimeString().Replace(':', '-');
            string strQuery = "Backup Database Go to Disk='" + fileName + ".bak'";
            cmd = new SqlCommand(strQuery, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("تم إنشاء النسخة الاحتياطية بنجاح", "إنشاء النسخة الاحتياطية", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void l_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
