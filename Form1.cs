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

namespace ElegoraDeskTop
{
    public partial class frmProjects : Form
    {
        SqlConnection con = new SqlConnection("Data Source=.\\sqlexpress;Initial Catalog=true;Database=Gora;Integrated Security=true;");
        SqlCommand cmd;
        SqlDataAdapter adapt;
        //ID variable used in Updating and Deleting Record  
        int ID = 0;
        public frmProjects()
        {
            InitializeComponent();
            DisplayData();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtname.Text != "" && txtaid.Text != "")
            {
                con.Open();

                cmd = new SqlCommand("insert into project(proname,aidc,bdate,edate,benf_num,benf,earea) " +
                    "values('" + txtname.Text + "','" + txtaid.Text + "','" + this.dateTimePicker1.Text + "','" + this.dateTimePicker2.Text + "','" + txtbennum.Text + "','" + txtbenf.Text + "','" + txtearea.Text + "')", con);

                cmd.ExecuteNonQuery();
                con.Close();




                MessageBox.Show("Record Inserted Successfully");

                DisplayData();
                ClearData();

            }
            else
            {
                MessageBox.Show("Please Provide Details!");
            }
        }
        //Display Data in DataGridView  
        public void DisplayData()
        {
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select id, proname as'اسم المشروع',aidc as'الجهة الممولة',bdate as'بداية المشروع',edate as'نهاية المشروع',benf_num as'عدد المستهدفين',benf as'الفئة المستهدفة',earea as'النطاق الجغرافي'    from project", con);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
        //Clear Data  
        private void ClearData()
        {
            txtname.Text = "";
            txtaid.Text = "";
            txtbenf.Text = "";
            txtbennum.Text = "";
            txtearea.Text = "";
            ID = 0;
        }
        //dataGridView1 RowHeaderMouseClick Event  
        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            txtname.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtaid.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            dateTimePicker1.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            dateTimePicker2.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtbennum.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtbenf.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            txtearea.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txtname.Text != "" && txtaid.Text != "")
            {
                var cmd = new SqlCommand("update project set proname ='" + txtname.Text + "' ,aidc ='" + txtaid.Text + "' ,bdate ='" + this.dateTimePicker1.Text + "' ,edate ='" + this.dateTimePicker2.Text + "' ,benf_num ='" + txtbennum.Text + "' ,benf ='" + txtbenf.Text + "' ,earea ='" + txtearea.Text + "' where id='" + this.dataGridView1.CurrentRow.Cells[0].Value.ToString() + "'", con);
                con.Open();
                cmd.ExecuteNonQuery();

                //cmd.Parameters.AddWithValue("@proname", txtname.Text);
                //cmd.Parameters.AddWithValue("@aidc", txtaid.Text);
                //cmd.Parameters.AddWithValue("@bdate", dateTimePicker1.Value);
                //cmd.Parameters.AddWithValue("@edate", dateTimePicker2.Value);
                //cmd.Parameters.AddWithValue("@benf_num", txtbennum.Text);
                //cmd.Parameters.AddWithValue("@benf", txtbenf.Text);
                //cmd.Parameters.AddWithValue("@earea", txtearea.Text);      

                MessageBox.Show("Record Updated Successfully");
                con.Close();
                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Please Select Record to Update");
            }
        }
        //Delete Record  
        private void btn_Delete_Click(object sender, EventArgs e)
        {
        }

        private void button4_Click(object sender, EventArgs e)
        {
            {


                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {

                    DataGridViewRow dr = dataGridView1.Rows[i];
                    if (dr.Selected == true)
                    {
                        dataGridView1.Rows.RemoveAt(i);


                        cmd.CommandText = "Delete from project where id='" + i + "'";
                        cmd.ExecuteNonQuery();

                        // da.Update(ds, "transact1");
                        MessageBox.Show("Deleted");
                    }

                    con.Close();
                }



                //
                //    int i = dataGridView1.CurrentCell.RowIndex;
                //    if (ID != 0)
                //    {
                //       var cmd = new SqlCommand("delete  from project where id='"+dataGridView1.SelectedRows[0].Cells[0].Value.ToString() + "'", con);
                //        con.Open();

                //        cmd.Parameters.Add("id", dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                //        cmd.ExecuteNonQuery();
                //        con.Close();
                //        MessageBox.Show("Record Deleted Successfully!");
                //        DisplayData();
                //        ClearData();
                //    }
                //    else
                //    {
                //        MessageBox.Show("Please Select Record to Delete");
                //    }
                //}
            }
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtname.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtaid.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            dateTimePicker1.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            dateTimePicker2.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtbennum.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtbenf.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            txtearea.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();

        }
    }
    }
    

