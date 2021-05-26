using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElegoraDeskTop.BL
{
    class Benfetiors
    {
        public void Add_Benf(string bnfname, string ssn, string qualification,
                string phone, int centerid, int sexid, string email)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[7];
            param[0] = new SqlParameter("@bnfname", SqlDbType.NVarChar, 250);
            param[0].Value = bnfname;

            param[1] = new SqlParameter("@ssn", SqlDbType.NVarChar, 50);
            param[1].Value = ssn;

            param[2] = new SqlParameter("@qualification", SqlDbType.NVarChar, 250);
            param[2].Value = qualification;

            param[3] = new SqlParameter("@phone", SqlDbType.NVarChar, 50);
            param[3].Value = phone;

            param[4] = new SqlParameter("@centerid", SqlDbType.Int);
            param[4].Value = centerid;

            param[5] = new SqlParameter("@sexid", SqlDbType.Int);
            param[5].Value = sexid;

            param[6] = new SqlParameter("@email", SqlDbType.NVarChar, 50);
            param[6].Value = email;

            DAL.ExecuteCommand("Add_Benf", param);
            DAL.Close();

        }
        public void Update_Benf(string bnfname, string ssn, string qualification,
                 string phone, int centerid, int sexid, string email)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[7];
            param[0] = new SqlParameter("@bnfname", SqlDbType.NVarChar, 250);
            param[0].Value = bnfname;

            param[1] = new SqlParameter("@ssn", SqlDbType.NVarChar, 50);
            param[1].Value = ssn;

            param[2] = new SqlParameter("@qualification", SqlDbType.NVarChar, 250);
            param[2].Value = qualification;

            param[3] = new SqlParameter("@phone", SqlDbType.NVarChar, 50);
            param[3].Value = phone;

            param[4] = new SqlParameter("@centerid", SqlDbType.Int);
            param[4].Value = centerid;

            param[5] = new SqlParameter("@sexid", SqlDbType.Int);
            param[5].Value = sexid;

            param[6] = new SqlParameter("@email", SqlDbType.NVarChar, 50);
            param[6].Value = email;

            DAL.ExecuteCommand("Update_Benf", param);
            DAL.Close();
        }

        public void Delte_Benf(string ID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@ID", SqlDbType.NVarChar, 50);
            param[0].Value = ID;

            DAL.ExecuteCommand("Delte_Benf", param);
            DAL.Close();

        }
        public DataTable Get_All_Benf()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("Get_All_Benf", null);
            DAL.Close();
            return Dt;
        }

        public DataTable VerifyBenf(string ID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ID", SqlDbType.VarChar, 50);
            param[0].Value = ID;
            Dt = DAL.SelectData("Verifybenf", param);
            DAL.Close();
            return Dt;
        }
        public DataTable getsex()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("getsex", null);
            DAL.Close();
            return Dt;
        }

        public DataTable Get_centers()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("Get_center", null);
            DAL.Close();
            return Dt;
        }
        public DataTable Search_Benf(string id)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            SqlParameter[] Param = new SqlParameter[1];
            Param[0] = new SqlParameter("@id", SqlDbType.NVarChar, 250);
            Param[0].Value = id;
            Dt = DAL.SelectData("Search_Benf", Param);
            DAL.Close();
            return Dt;
        }
        public DataTable Search_Benf_Activity(string id)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            SqlParameter[] Param = new SqlParameter[1];
            Param[0] = new SqlParameter("@id", SqlDbType.VarChar, 250);
            Param[0].Value = id;
            Dt = DAL.SelectData("GetBenfsCenter", Param);
            DAL.Close();
            return Dt;
        }
    }
}
