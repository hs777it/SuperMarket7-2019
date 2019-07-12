using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace SuperMarket.Classes
{
    class ClsStores
    {
        Data.DataAccessLayer DAL = new Data.DataAccessLayer();
        DataTable Dt = new DataTable();

        public DataTable GetAllStores()
        {
            Dt = DAL.SelectData("GetAllStores", null);
            //DAL.Close();
            return Dt;
        }
        public DataTable UsersMaxId()
        {
            Dt = DAL.SelectData("MaxAllStores", null);
            //DAL.Close();
            return Dt;
        }
      

        public void AddStore(int StoreId, string StoreName, string StoreAdress, string StoreAdmin, string UserAdd)
        {

            DAL.Open();
            SqlParameter[] param = new SqlParameter[5];
            param[0] = new SqlParameter("@StoreId", SqlDbType.Int);
            param[0].Value = StoreId;

            param[1] = new SqlParameter("@StoreName", SqlDbType.VarChar, 50);
            param[1].Value = StoreName;

            param[2] = new SqlParameter("@StoreAdress", SqlDbType.VarChar, 250);
            param[2].Value = StoreAdress;

            param[3] = new SqlParameter("@StoreAdmin", SqlDbType.VarChar, 100);
            param[3].Value = StoreAdmin;

            param[4] = new SqlParameter("@UserAdd", SqlDbType.VarChar, 50);
            param[4].Value = UserAdd;

          
            DAL.ExecuteCommand("AddStore", param);
            DAL.Close();

        }
        public void UpdateStore(int StoreId, string StoreName, string StoreAdress, string StoreAdmin, string UserAdd)
        {

            DAL.Open();
            SqlParameter[] param = new SqlParameter[5];
            param[0] = new SqlParameter("@StoreId", SqlDbType.Int);
            param[0].Value = StoreId;

            param[1] = new SqlParameter("@StoreName", SqlDbType.VarChar, 50);
            param[1].Value = StoreName;

            param[2] = new SqlParameter("@StoreAdress", SqlDbType.VarChar, 250);
            param[2].Value = StoreAdress;

            param[3] = new SqlParameter("@StoreAdmin", SqlDbType.VarChar, 100);
            param[3].Value = StoreAdmin;

            param[4] = new SqlParameter("@UserAdd", SqlDbType.VarChar, 50);
            param[4].Value = UserAdd;


            DAL.ExecuteCommand("UpdateStore", param);
            DAL.Close();

        }
        public void deleteStore(int Id)
        {

            DAL.Open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@Id", SqlDbType.Int);
            param[0].Value = Id;
            DAL.ExecuteCommand("deleteStore", param);
            DAL.Close();

        }
        public DataTable SearshStore(string Criterion)
        {
            DAL.Open();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@Criterion", SqlDbType.VarChar, 50);
            param[0].Value = Criterion;


            Dt = DAL.SelectData("SearshStore", param);
            DAL.Close();
            return Dt;
        }

    }
}
