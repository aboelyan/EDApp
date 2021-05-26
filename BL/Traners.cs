using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElegoraDeskTop.BL
{
    class Traners
    {
        public void ADD_ActivityType(string name)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@name", SqlDbType.NVarChar, 50);
            param[0].Value = name;
            DAL.ExecuteCommand("Add_ActivityType", param);
            DAL.Close();

        }
        public void Add_Tranner(string tname, string ssn, string qualification,
               string phone, string Email, string allocated)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[6];
            param[0] = new SqlParameter("@tname", SqlDbType.NVarChar, 250);
            param[0].Value = tname;

            param[1] = new SqlParameter("@ssn", SqlDbType.NVarChar, 15);
            param[1].Value = ssn;

            param[2] = new SqlParameter("@qualification", SqlDbType.NVarChar, 250);
            param[2].Value = qualification;

            param[3] = new SqlParameter("@phone", SqlDbType.NVarChar, 15);
            param[3].Value = phone;

            param[4] = new SqlParameter("@Email", SqlDbType.NVarChar, 50);
            param[4].Value = Email;

            param[5] = new SqlParameter("@allocated", SqlDbType.NVarChar, 50);
            param[5].Value = allocated;

            DAL.ExecuteCommand("Add_Tranner", param);
            DAL.Close();

        }
        public void Edit_Tranner(string tname, string ssn, string qualification,
               string phone, string Email, string allocated)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[6];
            param[0] = new SqlParameter("@tname", SqlDbType.NVarChar, 250);
            param[0].Value = tname;

            param[1] = new SqlParameter("@ssn", SqlDbType.NVarChar, 15);
            param[1].Value = ssn;

            param[2] = new SqlParameter("@qualification", SqlDbType.NVarChar, 250);
            param[2].Value = qualification;

            param[3] = new SqlParameter("@phone", SqlDbType.NVarChar, 15);
            param[3].Value = phone;

            param[4] = new SqlParameter("@Email", SqlDbType.NVarChar, 50);
            param[4].Value = Email;

            param[5] = new SqlParameter("@allocated", SqlDbType.NVarChar, 50);
            param[5].Value = allocated;

            DAL.ExecuteCommand("Update_Tranner", param);
            DAL.Close();
        }

        public void Delete_Traner(string ID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@ID", SqlDbType.NVarChar, 50);
            param[0].Value = ID;

            DAL.ExecuteCommand("Delete_Traner", param);
            DAL.Close();

        }

        public DataTable Get_All_Traners()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("Get_All_Traners", null);
            DAL.Close();
            return Dt;
        }



        public DataTable Search_Traner(string ID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            SqlParameter[] Param = new SqlParameter[1];
            Param[0] = new SqlParameter("@id", SqlDbType.NVarChar, 150);
            Param[0].Value = ID;
            Dt = DAL.SelectData("Search_Traners", Param);
            DAL.Close();
            return Dt;
        }


    }
}
