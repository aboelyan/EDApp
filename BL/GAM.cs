using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElegoraDeskTop.BL
{
    class GAM
    {
        public void ADD_GAMTYPE(string name)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@namee", SqlDbType.NVarChar, 150);
            param[0].Value = name;
            DAL.ExecuteCommand("Add_GAMTYPE", param);
            DAL.Close();

        }
        public void Add_GAM(string adGAMNUM, string name, string ssn,
               int gamid, string work, DateTime pdate, DateTime joindate)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[7];
            param[0] = new SqlParameter("@adGAMNUM", SqlDbType.NVarChar, 50);
            param[0].Value = adGAMNUM;

            param[1] = new SqlParameter("@name", SqlDbType.NVarChar, 250);
            param[1].Value = name;

            param[2] = new SqlParameter("@ssn", SqlDbType.NVarChar, 50);
            param[2].Value = ssn;

            param[3] = new SqlParameter("@gamid", SqlDbType.Int);
            param[3].Value = gamid;

            param[4] = new SqlParameter("@work", SqlDbType.NVarChar, 50);
            param[4].Value = work;

            param[5] = new SqlParameter("@pdate", SqlDbType.DateTime);
            param[5].Value = pdate;

            param[6] = new SqlParameter("@joindate", SqlDbType.DateTime);
            param[6].Value = joindate;

            DAL.ExecuteCommand("Add_GAM", param);
            DAL.Close();

        }
        public void Edit_GAM(string adGAMNUM, string name, string ssn,
               int gamid, string work, DateTime pdate, DateTime joindate)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[7];
            param[0] = new SqlParameter("@adGAMNUM", SqlDbType.NVarChar, 50);
            param[0].Value = adGAMNUM;

            param[1] = new SqlParameter("@name", SqlDbType.NVarChar, 250);
            param[1].Value = name;

            param[2] = new SqlParameter("@ssn", SqlDbType.NVarChar, 50);
            param[2].Value = ssn;

            param[3] = new SqlParameter("@gamid", SqlDbType.Int);
            param[3].Value = gamid;

            param[4] = new SqlParameter("@work", SqlDbType.NVarChar, 50);
            param[4].Value = work;

            param[5] = new SqlParameter("@pdate", SqlDbType.DateTime);
            param[5].Value = pdate;

            param[6] = new SqlParameter("@joindate", SqlDbType.DateTime);
            param[6].Value = joindate;

            DAL.ExecuteCommand("Update_GAM", param);
            DAL.Close();
        }

        public void Delte_GAM(string ID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@ID", SqlDbType.NVarChar, 50);
            param[0].Value = ID;

            DAL.ExecuteCommand("Delete_GAM", param);
            DAL.Close();

        }
        public DataTable Get_All_GAM()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("Get_All_Gam", null);
            DAL.Close();
            return Dt;
        }
        public DataTable Get_GAMTYPE()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("Get_GAMTYPE", null);
            DAL.Close();
            return Dt;
        }



        public DataTable Search_Gam(string id)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            SqlParameter[] Param = new SqlParameter[1];
            Param[0] = new SqlParameter("@id", SqlDbType.VarChar, 250);
            Param[0].Value = id;
            Dt = DAL.SelectData("Searchl_Gam", Param);
            DAL.Close();
            return Dt;
        }


    }
}
