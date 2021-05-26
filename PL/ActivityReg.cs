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
    public partial class ActivityReg : Form
    {
        BL.Acyivites act = new BL.Acyivites();
        int ID = 0;
       SqlConnection conn = new SqlConnection(@"Server=.\SQLEXPRESS;Database=Go;Trusted_Connection=True;");
         string qry = "select a.acname,a.activityid,a.startdate,a.enddate,a.place,a.centerid,b.bnfname,b.ssn,b.qualification " +
                "from  ABRecorder inner join benifitors as b on benfn=b.id  inner join Activites as a on actn=a.id";

        public ActivityReg()
        {
            InitializeComponent();
            this.dataGridView2.DataSource =qry;
            try
            {
                string query = "select acname, id from Activites";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                conn.Open();
                DataSet ds = new DataSet();
                da.Fill(ds, "Fleet");
                comboBox1.DisplayMember = "acname";
                comboBox1.ValueMember = "id";
                comboBox1.DataSource = ds.Tables["Fleet"];
                conn.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Error occured!");
            }
            try
            {
                string query = "select bnfname, id from benifitors ";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                conn.Open();
                DataSet ds = new DataSet();
                da.Fill(ds, "Fleet");
                comboBox2.DisplayMember = "bnfname";
                comboBox2.ValueMember = "id";
                comboBox2.DataSource = ds.Tables["Fleet"];
                conn.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Error occured!");
            }
        }
        public void GetData()
        {


            SqlCommand cmd = new SqlCommand(qry, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "dt");
            conn.Close();

            this.dataGridView2.DataSource = ds.Tables[0];


        }
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string qry = "insert into ABRecorder (actn,benfn)  Values (@actn,@benfn)";
                SqlCommand cmd = new SqlCommand(qry, conn);
                cmd.Parameters.AddWithValue("@actn", Convert.ToInt32(comboBox1.SelectedValue));
                cmd.Parameters.AddWithValue("@benfn", Convert.ToInt32(comboBox2.SelectedValue));
                cmd.ExecuteNonQuery();
                GetData();
                conn.Close();
                MessageBox.Show("تم الاضافة بنجاح");

            }
            catch (Exception)
            {

                MessageBox.Show("حاول مجددا");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string qry = "Update  ABRecorder SET actn = @actn,benfn = @benfn  where   id ='" + this.dataGridView2.CurrentRow.Cells[0].Value.ToString() + "'";
                SqlCommand cmd = new SqlCommand(qry, conn);
                cmd.Parameters.AddWithValue("@actn", Convert.ToInt32(comboBox1.SelectedValue));
                cmd.Parameters.AddWithValue("@benfn", Convert.ToInt32(comboBox2.SelectedValue));
                cmd.ExecuteNonQuery();
                GetData();
                conn.Close();
                MessageBox.Show("تم التعديل بنجاح");

            }
            catch (Exception)
            {

                MessageBox.Show("try agane");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("delete  from  ABRecorder where id='" + this.dataGridView2.CurrentRow.Cells[0].Value.ToString() + "'", conn);
                conn.Open();
                cmd.Parameters.AddWithValue("@id", ID);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("تم الحذف بنجاح!");
                GetData();

            }
            catch (Exception)
            {

                MessageBox.Show(":) :) :) :)");
            }
        }
    }
}
