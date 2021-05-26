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
    public partial class ActivitySearch : Form
    {
        BL.Acyivites prd = new BL.Acyivites();
        BL.Benfetiors prd2 = new BL.Benfetiors();
        
        SqlConnection con = new SqlConnection(@"Data Source=.\SqlExpress;Initial Catalog=Go;Integrated Security=True");

        public ActivitySearch()
        {
            InitializeComponent();
            comboBox1.DataSource = prd.Get_All_ActivityType();
            comboBox1.DisplayMember = "name";
            comboBox1.ValueMember = "id";
            //
            comboBox3.DataSource = prd.Get_centers();
            comboBox3.DisplayMember = "cname";
            comboBox3.ValueMember = "id";
            //

            SqlCommand cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM Activites";
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox4.Items.Add(dr["acname"]);
            }
            con.Close();

            SqlCommand cm = new SqlCommand();
            con.Open();
            cm.Connection = con;
            cm.CommandText = "SELECT * FROM project";
            SqlDataReader d = cm.ExecuteReader();
            while (d.Read())
            {
                comboBox5.Items.Add(d["proname"]);
            }
            con.Close();
            SqlCommand cmd1 = new SqlCommand();
            con.Open();
            cmd1.Connection = con;
            cmd1.CommandText = "SELECT * FROM benifitors";
            SqlDataReader dr1 = cmd1.ExecuteReader();
            while (dr1.Read())
            {
                comboBox2.Items.Add(dr1["bnfname"]);
            }
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            DataTable Dt = new DataTable();
            Dt = prd.Search_Activity_Type(comboBox1.Text,dateTimePicker1.Value,dateTimePicker2.Value);
            this.dataGridView1.DataSource = Dt;
        }    

        private void button2_Click(object sender, EventArgs e)
        {
            RPT.Acctivitytype myReport = new RPT.Acctivitytype();
            myReport.SetDataSource ( prd.Search_Activity_Type(comboBox1.Text,dateTimePicker1.Value,dateTimePicker2.Value));
            //("@name,@date1,@date2",comboBox1.Text,dateTimePicker1.Value,dateTimePicker2.Value);
            RPT.View myForm = new RPT.View();
            myForm.crystalReportViewer1.ReportSource = myReport;
            myForm.Show();
            //ActivitySearch.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RPT.GetSingleBenf myReport = new RPT.GetSingleBenf();
            myReport.SetParameterValue("@ID", this.comboBox2.Text);
            RPT.View myForm = new RPT.View();
            myForm.crystalReportViewer1.ReportSource = myReport;
            myForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            RPT.GetBenfsCenter myReport = new RPT.GetBenfsCenter();
            myReport.SetParameterValue("@ID", this.comboBox3.Text);
            RPT.View myForm = new RPT.View();
            myForm.crystalReportViewer1.ReportSource = myReport;
            myForm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            RPT.Search_Single_Activity myReport = new RPT.Search_Single_Activity();
            myReport.SetParameterValue("@ID", this.comboBox4.Text);
            RPT.View myForm = new RPT.View();
            myForm.crystalReportViewer1.ReportSource = myReport;
            myForm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            RPT.ProhActivites myReport = new RPT.ProhActivites();
            myReport.SetParameterValue("@ID", this.comboBox5.Text);
            RPT.View myForm = new RPT.View();
            myForm.crystalReportViewer1.ReportSource = myReport;
            myForm.Show();
        }
    }
}
