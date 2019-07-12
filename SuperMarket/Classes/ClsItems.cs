using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace SuperMarket.Classes
{
    class ClsItems
    {
        Data.DataAccessLayer DAL = new Data.DataAccessLayer();
        DataTable Dt = new DataTable();

        public DataTable MaxItemId()
        {
            Dt = new DataTable();
            Dt = DAL.SelectData("MaxItemId", null);
            return Dt;
        }
        public DataTable GatAllItems()
        {
            Dt = new DataTable();
            Dt = DAL.SelectData("GatAllItems", null);
            return Dt;
        }
        public DataTable GatAllItemsPrintAll()
        {
            Dt = new DataTable();
            Dt = DAL.SelectData("GatAllItemsPrintAll", null);
            return Dt;
        }

        public void InsertItems(int Item_Id, string Item_Barcode,
                          string Item_Name, DateTime Item_Dat, double Item_PurPrice, double Item_SalePrice,
                          double Item_Qte, double Item_Descoun,int Cat_Id,int StoreId)
        {

            DAL.Open();
            SqlParameter[] param = new SqlParameter[10];
            param[0] = new SqlParameter("@Item_Id", SqlDbType.Int);
            param[0].Value = Item_Id;

            param[1] = new SqlParameter("@Item_Barcode", SqlDbType.VarChar, 60);
            param[1].Value = Item_Barcode;

            param[2] = new SqlParameter("@Item_Name", SqlDbType.VarChar, 50);
            param[2].Value = Item_Name;

            param[3] = new SqlParameter("@Item_Date", SqlDbType.Date);
            param[3].Value = Item_Dat;

            param[4] = new SqlParameter("@Item_PurPrice", SqlDbType.Float);
            param[4].Value = Item_PurPrice;

            param[5] = new SqlParameter("@Item_SalePrice", SqlDbType.Float);
            param[5].Value = Item_SalePrice;

            param[6] = new SqlParameter("@Item_Qte", SqlDbType.Float);
            param[6].Value = Item_Qte;

            param[7] = new SqlParameter("@Item_Descount", SqlDbType.Float);
            param[7].Value = Item_Descoun;

            param[8] = new SqlParameter("@Cat_Id", SqlDbType.Int);
            param[8].Value = Cat_Id;

            param[9] = new SqlParameter("@StoreId ", SqlDbType.Int);
            param[9].Value = StoreId;

            DAL.ExecuteCommand("InsertItems", param);
            DAL.Close();

        }
        public void updateItems(int Item_Id, string Item_Barcode,
                          string Item_Name, DateTime Item_Dat, double Item_PurPrice, double Item_SalePrice,
                          double Item_Qte, double Item_Descoun, int Cat_Id, int StoreId)
        {

            DAL.Open();
            SqlParameter[] param = new SqlParameter[10];
            param[0] = new SqlParameter("@Item_Id", SqlDbType.Int);
            param[0].Value = Item_Id;

            param[1] = new SqlParameter("@Item_Barcode", SqlDbType.VarChar, 60);
            param[1].Value = Item_Barcode;

            param[2] = new SqlParameter("@Item_Name", SqlDbType.VarChar, 50);
            param[2].Value = Item_Name;

            param[3] = new SqlParameter("@Item_Date", SqlDbType.Date);
            param[3].Value = Item_Dat;

            param[4] = new SqlParameter("@Item_PurPrice", SqlDbType.Float);
            param[4].Value = Item_PurPrice;

            param[5] = new SqlParameter("@Item_SalePrice", SqlDbType.Float);
            param[5].Value = Item_SalePrice;

            param[6] = new SqlParameter("@Item_Qte", SqlDbType.Float);
            param[6].Value = Item_Qte;

            param[7] = new SqlParameter("@Item_Descount", SqlDbType.Float);
            param[7].Value = Item_Descoun;

            param[8] = new SqlParameter("@Cat_Id", SqlDbType.Int);
            param[8].Value = Cat_Id;

            param[9] = new SqlParameter("@StoreId ", SqlDbType.Int);
            param[9].Value = StoreId;

            DAL.ExecuteCommand("updateItems", param);
            DAL.Close();

        }
        public void UdateStatus(string Status, string Item_Name)
        {

            DAL.Open();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@Status", SqlDbType.VarChar, 50);
            param[0].Value = Status;

            param[1] = new SqlParameter("@Item_Name", SqlDbType.VarChar, 50);
            param[1].Value = Item_Name;

            //param[2] = new SqlParameter("@id", SqlDbType.Int);
            //param[2].Value = id;
         
            DAL.ExecuteCommand("UdateStatus", param);
            DAL.Close();

        }
        public void DeletItmes( int id)
        {

            DAL.Open();
            SqlParameter[] param = new SqlParameter[1];
            

            param[0] = new SqlParameter("@Id", SqlDbType.Int);
            param[0].Value = id;

            DAL.ExecuteCommand("DeletItmes", param);
            DAL.Close();

        }
        public DataTable SearchItems(string Criterion)
        {
            DAL.Open();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@Criterion", SqlDbType.VarChar, 50);
            param[0].Value = Criterion;


            Dt = DAL.SelectData("SearchItems", param);
            DAL.Close();
            return Dt;
        }
    }

}
