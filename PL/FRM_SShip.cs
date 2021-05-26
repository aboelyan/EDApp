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
    public partial class FRM_SShip : Form
    {
        int ID = 0;
        SqlConnection conn = new SqlConnection(@"Server=.\SQLEXPRESS;Database=Go;Trusted_Connection=True;");
        public FRM_SShip()
        {
            InitializeComponent();
        }
        public void GetData()
        {
            string qry = "select * from  SchoolerShip";
            SqlCommand cmd = new SqlCommand(qry, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "dt");
            conn.Close();
            this.dataGridView1.DataSource = ds.Tables[0];
        }
        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            conn.Open();
            string qry = "insert into SchoolerShip (code,stname,stid,gender,center,vellige,unit,school,unv,colage,regdate,degree,phone,email,address)  Values " +
                "(@code,@stname,@stid,@gender,@center,@vellige,@unit,@school,@unv,@colage,@regdate,@degree,@phone,@email,@address)";
            SqlCommand cmd = new SqlCommand(qry, conn);
            cmd.Parameters.AddWithValue("@code", txtcode.Text);
            cmd.Parameters.AddWithValue("@stname", txtname.Text);
            cmd.Parameters.AddWithValue("@stid", txtidd.Text);
            cmd.Parameters.AddWithValue("@gender", cmbcenter.Text);
            cmd.Parameters.AddWithValue("@center", cmbcenter.Text);
            cmd.Parameters.AddWithValue("@vellige", txtvillege.Text);
            cmd.Parameters.AddWithValue("@unit", txtunit.Text);
            cmd.Parameters.AddWithValue("@school", txtschool.Text);
            cmd.Parameters.AddWithValue("@unv", txtunv.Text);
            cmd.Parameters.AddWithValue("@colage", txtcolage.Text);
            cmd.Parameters.AddWithValue("@regdate", dateTimePicker1.Value);
            cmd.Parameters.AddWithValue("@degree", txtdegree.Text);
            cmd.Parameters.AddWithValue("@phone", txtphone.Text);
            cmd.Parameters.AddWithValue("@email", txtemail.Text);
            cmd.Parameters.AddWithValue("@address", txtaddress.Text);

            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("تم الاضافة بنجاح");
            GetData();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
