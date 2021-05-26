using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElegoraDeskTop.BL
{
    class Acyivites  
    {
        public int Id { get; set; }
        public string Name { get; set; }

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
        public void adActivity(string acname, int projectid, int activityid,
                int trainerid, DateTime startdate, DateTime enddate, string place, int centerid
            , int mail, int fmail)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[10];
            param[0] = new SqlParameter("@acname", SqlDbType.NVarChar, 150);
            param[0].Value = acname;

            param[1] = new SqlParameter("@projectid", SqlDbType.Int);
            param[1].Value = projectid;

            param[2] = new SqlParameter("@activityid", SqlDbType.Int);
            param[2].Value = activityid;

            param[3] = new SqlParameter("@trainerid", SqlDbType.Int);
            param[3].Value = trainerid;

            param[4] = new SqlParameter("@startdate", SqlDbType.DateTime);
            param[4].Value = startdate;

            param[5] = new SqlParameter("@enddate", SqlDbType.DateTime);
            param[5].Value = enddate;

            param[6] = new SqlParameter("@place", SqlDbType.NVarChar, 250);
            param[6].Value = place;

            param[7] = new SqlParameter("@centerid", SqlDbType.Int);
            param[7].Value = centerid;

            param[8] = new SqlParameter("@mail", SqlDbType.Int);
            param[8].Value = mail;

            param[9] = new SqlParameter("@fmail", SqlDbType.Int);
            param[9].Value = fmail;

            DAL.ExecuteCommand("Add_Activity", param);
            DAL.Close();

        }
        public void Edit_Activity(string acname, int projectid, int activityid,
               int trainerid, DateTime startdate, DateTime enddate, string place, int centerid
           , int mail, int fmail)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[10];

            param[0] = new SqlParameter("@acname", SqlDbType.NVarChar, 150);
            param[0].Value = acname;

            param[1] = new SqlParameter("@projectid", SqlDbType.Int);
            param[1].Value = projectid;

            param[2] = new SqlParameter("@activityid", SqlDbType.Int);
            param[2].Value = activityid;

            param[3] = new SqlParameter("@trainerid", SqlDbType.Int);
            param[3].Value = trainerid;

            param[4] = new SqlParameter("@startdate", SqlDbType.DateTime);
            param[4].Value = startdate;

            param[5] = new SqlParameter("@enddate", SqlDbType.DateTime);
            param[5].Value = enddate;

            param[6] = new SqlParameter("@place", SqlDbType.NVarChar, 250);
            param[6].Value = place;

            param[7] = new SqlParameter("@centerid", SqlDbType.Int);
            param[7].Value = centerid;

            param[8] = new SqlParameter("@mail", SqlDbType.Int);
            param[8].Value = mail;

            param[9] = new SqlParameter("@fmail", SqlDbType.Int);
            param[9].Value = fmail;

            DAL.ExecuteCommand("Update_Activity", param);
            DAL.Close();
        }

        public void Delte_Activity(string ID)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DAL.Open();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@ID", SqlDbType.NVarChar, 50);
            param[0].Value = ID;

            DAL.ExecuteCommand("Delete_Activity", param);
            DAL.Close();

        }
        public DataTable Get_All_Activity()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("Get_All_Activites", null);
            DAL.Close();
            return Dt;
        }
        public DataTable Get_All_ActivityType()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("Get_All_ActivityType", null);
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
        public DataTable Get_Project()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("Get_ProNAme", null);
            DAL.Close();
            return Dt;
        }
        public DataTable Gett_TranerName()
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("Gett_TranerName", null);
            DAL.Close();
            return Dt;
        }


        public DataTable Search_Activity(string id)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            SqlParameter[] Param = new SqlParameter[1];
            Param[0] = new SqlParameter("@id", SqlDbType.NVarChar, 250);
            Param[0].Value = id;
            Dt = DAL.SelectData("Search_Activites", Param);
            DAL.Close();
            return Dt;
        }
        public DataTable Search_Single_Activity(string id)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            SqlParameter[] Param = new SqlParameter[1];
            Param[0] = new SqlParameter("@id", SqlDbType.NVarChar, 250);
            Param[0].Value = id;
            Dt = DAL.SelectData("searchSingleActv", Param);
            DAL.Close();
            return Dt;
        }
        public DataTable Search_SingleBenf(string id)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            SqlParameter[] Param = new SqlParameter[1];
            Param[0] = new SqlParameter("@id", SqlDbType.NVarChar, 250);
            Param[0].Value = id;
            Dt = DAL.SelectData("GetSingleBenf", Param);
            DAL.Close();
            return Dt;
        }
        public DataTable Search_Activity_Type(string name , DateTime date1 ,DateTime date2)
        {
            DAL.DataAccessLayer DAL = new DAL.DataAccessLayer();
            DataTable Dt = new DataTable();
            SqlParameter[] Param = new SqlParameter[3];
            Param[0] = new SqlParameter("@name", SqlDbType.NVarChar, 50);
            Param[0].Value = name;
            Param[1] = new SqlParameter("@date1", SqlDbType.DateTime);
            Param[1].Value = date1;
            Param[2] = new SqlParameter("@date2", SqlDbType.DateTime);
            Param[2].Value = date2;
            Dt = DAL.SelectData("GetActvType", Param);
            DAL.Close();
            return Dt;
        }

    }
}
