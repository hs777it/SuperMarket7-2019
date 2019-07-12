using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace SuperMarket.Classes
{
  
    class ClsItemCompany
    {
        Data.DataAccessLayer DAL = new Data.DataAccessLayer();
        DataTable Dt = new DataTable();
       
        public DataTable GetAllItemsComapny()
        {
            Dt = new DataTable();
            Dt = DAL.SelectData("GetAllItemsComapny", null);
            return Dt;
        }
        public DataTable GetAllCompanyForSales(int id)
        {
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;

            Dt = DAL.SelectData("GetAllCompanyForSales", param);
            return Dt;

        }
        public void InsertItemsComapny(int Item_Id, string Co_Name, string Co_Phone,  string Co_Address)
        {

            DAL.Open();
            SqlParameter[] param = new SqlParameter[4];
            param[0] = new SqlParameter("@Item_Id", SqlDbType.Int);
            param[0].Value = Item_Id;

            param[1] = new SqlParameter("@Co_Name", SqlDbType.VarChar, 50);
            param[1].Value = Co_Name;

            param[2] = new SqlParameter("@Co_Phone", SqlDbType.VarChar, 30);
            param[2].Value = Co_Phone;

            param[3] = new SqlParameter("@Co_Address", SqlDbType.VarChar, 100);
            param[3].Value = Co_Address;
            
            DAL.ExecuteCommand("InsertItemsComapny", param);
            DAL.Close();

        }

        public void UpdateItemsComapny(int Item_Id, string Co_Name, string Co_Phone, string Co_Address)
        {

            DAL.Open();
            SqlParameter[] param = new SqlParameter[4];
            param[0] = new SqlParameter("@Item_Id", SqlDbType.Int);
            param[0].Value = Item_Id;

            param[1] = new SqlParameter("@Co_Name", SqlDbType.VarChar, 50);
            param[1].Value = Co_Name;

            param[2] = new SqlParameter("@Co_Phone", SqlDbType.VarChar, 30);
            param[2].Value = Co_Phone;

            param[3] = new SqlParameter("@Co_Address", SqlDbType.VarChar, 100);
            param[3].Value = Co_Address;

            DAL.ExecuteCommand("UpdateItemsComapny", param);
            DAL.Close();

        }
        public void DeleteItemsComapny(int Id)
        {

            DAL.Open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@Id", SqlDbType.Int);
            param[0].Value = Id;
            DAL.ExecuteCommand("DeleteItemsComapny", param);
            DAL.Close();

        }
        public DataTable SearchAllItemsComapny(string Criterion)
        {
            DAL.Open();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@Criterion", SqlDbType.VarChar, 50);
            param[0].Value = Criterion;


            Dt = DAL.SelectData("SearchAllItemsComapny", param);
            DAL.Close();
            return Dt;
        }
    }
}
