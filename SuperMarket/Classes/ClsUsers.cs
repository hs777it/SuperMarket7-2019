using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace SuperMarket.Classes
{
    class ClsUsers
    {
        Data.DataAccessLayer DAL = new Data.DataAccessLayer();
        DataTable Dt = new DataTable();

        public DataTable GetAllUsers()
        {
            Dt = DAL.SelectData("GetAllUsers", null);
            //DAL.Close();
            return Dt;
        }

        public DataTable UsersMaxId()
        {
            Dt = DAL.SelectData("UsersMaxId", null);
            //DAL.Close();
            return Dt;
        }

        /////////////////////////////////////////////////

        public void UsersAdd(int User_Id, string UserName, string UserPassWord, string UserFullName,
            DateTime UserDateTime, string UserType)
        {

            DAL.Open();
            SqlParameter[] param = new SqlParameter[6];
            param[0] = new SqlParameter("@User_Id", SqlDbType.Int);
            param[0].Value = User_Id;

            param[1] = new SqlParameter("@UserName", SqlDbType.VarChar, 50);
            param[1].Value = UserName;

            param[2] = new SqlParameter("@UserPassWord", SqlDbType.VarChar, 30);
            param[2].Value = UserPassWord;

            param[3] = new SqlParameter("@UserFullName", SqlDbType.VarChar, 100);
            param[3].Value = UserFullName;

            param[4] = new SqlParameter("@UserDateTime", SqlDbType.DateTime);
            param[4].Value = UserDateTime;

            param[5] = new SqlParameter("@UserType", SqlDbType.VarChar, 40);
            param[5].Value = UserType;

            DAL.ExecuteCommand("UsersAdd", param);
            DAL.Close();

        }
        //////////////////////////////////////////////

        public void UsersEdite(string UserName, string UserPassWord, string UserFullName,
            DateTime UserDateTime, string UserType, int Id)
        {

            DAL.Open();
            SqlParameter[] param = new SqlParameter[6];


            param[0] = new SqlParameter("@UserName", SqlDbType.VarChar, 50);
            param[0].Value = UserName;

            param[1] = new SqlParameter("@UserPassWord", SqlDbType.VarChar, 30);
            param[1].Value = UserPassWord;

            param[2] = new SqlParameter("@UserFullName", SqlDbType.VarChar, 100);
            param[2].Value = UserFullName;

            param[3] = new SqlParameter("@UserDateTime", SqlDbType.DateTime);
            param[3].Value = UserDateTime;

            param[4] = new SqlParameter("@UserType", SqlDbType.VarChar, 40);
            param[4].Value = UserType;

            param[5] = new SqlParameter("@Id", SqlDbType.Int);
            param[5].Value = Id;

            DAL.ExecuteCommand("UsersEdite", param);
            DAL.Close();
        }

        public void deleteUsers(int Id)
        {

            DAL.Open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@Id", SqlDbType.Int);
            param[0].Value = Id;
            DAL.ExecuteCommand("deleteUsers", param);
            DAL.Close();

        }
        public DataTable SearchUsers(string Criterion)
        {
            DAL.Open();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@Criterion", SqlDbType.VarChar, 50);
            param[0].Value = Criterion;


            Dt = DAL.SelectData("SearchUsers", param);
            DAL.Close();
            return Dt;
        }

        public DataTable LOGIN(string ID, string PWD)
        {

           
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@UserName", SqlDbType.VarChar, 50);
            param[0].Value = ID;

            param[1] = new SqlParameter("@UserPassWord", SqlDbType.VarChar, 50);
            param[1].Value = PWD;

            DataTable Dt = new DataTable();
            Dt = DAL.SelectData("UserLogin", param);
            DAL.Close();
            return Dt;
        }
    }
}
