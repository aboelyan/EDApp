using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElegoraDeskTop.BL
{
    class Projects
    {
        public void Add_P(string name)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@name", SqlDbType.NVarChar, 50);
            param[0].Value = name;
            DAL.ExecuteCommand("Add_ActivityType", param);
            DAL.Close();

        }
        public void ADD_PROJECT(string proname, string aidc, DateTime bdate,
                DateTime edate, int benf_num, string benf, string earea)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[7];
            param[0] = new SqlParameter("@proname", SqlDbType.NVarChar, 250);
            param[0].Value = proname;

            param[1] = new SqlParameter("@aidc", SqlDbType.NVarChar, 250);
            param[1].Value = aidc;

            param[2] = new SqlParameter("@bdate", SqlDbType.DateTime);
            param[2].Value = bdate;

            param[3] = new SqlParameter("@edate", SqlDbType.DateTime);
            param[3].Value = edate;

            param[4] = new SqlParameter("@benf_num", SqlDbType.Int);
            param[4].Value = benf_num;

            param[5] = new SqlParameter("@benf", SqlDbType.NVarChar, 250);
            param[5].Value = benf;

            param[6] = new SqlParameter("@earea", SqlDbType.NVarChar, 250);
            param[6].Value = earea;

            DAL.ExecuteCommand("Add_Project", param);
            DAL.Close();

        }
        public void UPDATE_PROJECT(string proname, string aidc, DateTime bdate,
                 DateTime edate, int benf_num, string benf, string earea)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[7];
            param[0] = new SqlParameter("@proname", SqlDbType.NVarChar, 250);
            param[0].Value = proname;

            param[1] = new SqlParameter("@aidc", SqlDbType.NVarChar, 250);
            param[1].Value = aidc;

            param[2] = new SqlParameter("@bdate", SqlDbType.DateTime);
            param[2].Value = bdate;

            param[3] = new SqlParameter("@edate", SqlDbType.DateTime);
            param[3].Value = edate;

            param[4] = new SqlParameter("@benf_num", SqlDbType.Int);
            param[4].Value = benf_num;

            param[5] = new SqlParameter("@benf", SqlDbType.NVarChar, 250);
            param[5].Value = benf;

            param[6] = new SqlParameter("@earea", SqlDbType.NVarChar, 250);
            param[6].Value = earea;

            DAL.ExecuteCommand("Update_Projects", param);
            DAL.Close();
        }

        public void Delete_Projects(string ID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@ID", SqlDbType.NVarChar, 50);
            param[0].Value = ID;

            DAL.ExecuteCommand("Delete_Projects", param);
            DAL.Close();

        }
        public DataTable Get_All_Projects()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("Get_All_Projects", null);
            DAL.Close();
            return Dt;
        }


        public DataTable Search_Projects(string id)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            SqlParameter[] Param = new SqlParameter[1];
            Param[0] = new SqlParameter("@id", SqlDbType.VarChar, 250);
            Param[0].Value = id;
            Dt = DAL.SelectData("Search_Projects", Param);
            DAL.Close();
            return Dt;
        }


    }

}
