using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace SuperMarket.Classes
{
    class ClsPosReturn
    {
        Data.DataAccessLayer DAL = new Data.DataAccessLayer();
        DataTable Dt = new DataTable();

        public DataTable ReturnItemsMaxId()
        {
            Dt = new DataTable();
            Dt = DAL.SelectData("ReturnPosItemsMaxId", null);
            //DAL.Close();
            return Dt;
        }
        //----------------------------------------------------------------

        public DataTable GetAllReturnItems()
        {
            Dt = new DataTable();
            Dt = DAL.SelectData("GetAllPosReturnItems", null);
            //DAL.Close();
            return Dt;
        }
        //----------------------------------------------------------------

        public DataTable GetAllReturnSales()
        {
            Dt = new DataTable();
            Dt = DAL.SelectData("GetAllPOOsReturnItems", null);
            //DAL.Close();
            return Dt;
        }
        //----------------------------------------------------------------

        public DataTable GatBarCode(string Item_Barcode)
        {
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@id", SqlDbType.VarChar, 50);
            param[0].Value = Item_Barcode;

            Dt = DAL.SelectData("AllPosReturnItems", param);
            return Dt;

        }
        //----------------------------------------------------------------

        public DataTable VerifyReturnSales(string ReturnId)
        {
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@ReturnId", SqlDbType.VarChar, 50);
            param[0].Value = ReturnId;

            Dt = DAL.SelectData("VerifyPosReturnSales", param);
            return Dt;

        }
        //----------------------------------------------------------------

        public DataTable GetAllReturnSearch(string SEarchTxt)
        {
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@id", SqlDbType.VarChar, 50);
            param[0].Value = SEarchTxt;

            Dt = DAL.SelectData("GetAllPosReturnSearch", param);
            return Dt;

        }
        //----------------------------------------------------------------
        public void UpdateReturn_Status(string Id, int ReturnId)
        {

            DAL.Open();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@Id", SqlDbType.VarChar, 50);
            param[0].Value = Id;

            param[1] = new SqlParameter("@ReturnId", SqlDbType.Int);
            param[1].Value = ReturnId;

            DAL.ExecuteCommand("UpdatePosReturn_Status", param);
            DAL.Close();

        }
        //----------------------------------------------------------------

        public void UpdateReturnSalesQTE(int Item_Id, double Item_Qte)
        {

            DAL.Open();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@Item_Id", SqlDbType.Int);
            param[0].Value = Item_Id;

            param[1] = new SqlParameter("@Item_Qte", SqlDbType.Float);
            param[1].Value = Item_Qte;

            DAL.ExecuteCommand("UpdatePosReturnSalesQTE", param);
            DAL.Close();

        }
        //----------------------------------------------------------------

        public void DeleteReturnSales(int ReturnId)
        {

            DAL.Open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ReturnId", SqlDbType.Int);
            param[0].Value = ReturnId;
            DAL.ExecuteCommand("DeletePosReturnSales", param);
            DAL.Close();

        }

        //----------------------------------------------------------------

        public void InsertReturnItems(int ReturnId, int PosOrder_Id,
                          string barcode, string Return_Item, double Return_ItemPrice,
                          double Return_Discount, double Return_QTE, double Return_Total,
                          DateTime Return_Date, string Return_User, string StatusId, string Notes, string ReturnAmouT_Ar, int ItemId)
        {

            DAL.Open();
            SqlParameter[] param = new SqlParameter[14];

            param[0] = new SqlParameter("@ReturnId", SqlDbType.Int);
            param[0].Value = ReturnId;

            param[1] = new SqlParameter("@PosOrder_Id", SqlDbType.Int);
            param[1].Value = PosOrder_Id;

            param[2] = new SqlParameter("@barcode", SqlDbType.VarChar, 50);
            param[2].Value = barcode;

            param[3] = new SqlParameter("@Return_Item", SqlDbType.VarChar, 50);
            param[3].Value = Return_Item;

            param[4] = new SqlParameter("@Return_ItemPrice", SqlDbType.Float);
            param[4].Value = Return_ItemPrice;

            param[5] = new SqlParameter("@Return_Discount", SqlDbType.Float);
            param[5].Value = Return_Discount;

            param[6] = new SqlParameter("@Return_QTE", SqlDbType.Float);
            param[6].Value = Return_QTE;

            param[7] = new SqlParameter("@Return_Total", SqlDbType.Float);
            param[7].Value = Return_Total;

            param[8] = new SqlParameter("@Return_Date", SqlDbType.Date);
            param[8].Value = Return_Date;

            param[9] = new SqlParameter("@Return_User", SqlDbType.VarChar, 50);
            param[9].Value = Return_User;

            param[10] = new SqlParameter("@StatusId", SqlDbType.VarChar, 50);
            param[10].Value = StatusId;

            param[11] = new SqlParameter("@Notes", SqlDbType.VarChar, 250);
            param[11].Value = Notes;

            param[12] = new SqlParameter("@ReturnAmouT_Ar", SqlDbType.VarChar, 250);
            param[12].Value = ReturnAmouT_Ar;

            param[13] = new SqlParameter("@ItemId", SqlDbType.Int);
            param[13].Value = ItemId;

            DAL.ExecuteCommand("InsertPosReturnItems", param);
            DAL.Close();

        }
        //----------------------------------------------------------------

        public void UpdateReturnSales(int ReturnId, int PosOrder_Id,
                          string barcode, string Return_Item, double Return_ItemPrice,
                          double Return_Discount, double Return_QTE, double Return_Total,
                          DateTime Return_Date, string Return_User, string StatusId, string Notes, string ReturnAmouT_Ar, int ItemId)
        {

            DAL.Open();
            SqlParameter[] param = new SqlParameter[14];

            param[0] = new SqlParameter("@ReturnId", SqlDbType.Int);
            param[0].Value = ReturnId;

            param[1] = new SqlParameter("@PosOrder_Id", SqlDbType.Int);
            param[1].Value = PosOrder_Id;

            param[2] = new SqlParameter("@barcode", SqlDbType.VarChar, 50);
            param[2].Value = barcode;

            param[3] = new SqlParameter("@Return_Item", SqlDbType.VarChar, 50);
            param[3].Value = Return_Item;

            param[4] = new SqlParameter("@Return_ItemPrice", SqlDbType.Float);
            param[4].Value = Return_ItemPrice;

            param[5] = new SqlParameter("@Return_Discount", SqlDbType.Float);
            param[5].Value = Return_Discount;

            param[6] = new SqlParameter("@Return_QTE", SqlDbType.Float);
            param[6].Value = Return_QTE;

            param[7] = new SqlParameter("@Return_Total", SqlDbType.Float);
            param[7].Value = Return_Total;

            param[8] = new SqlParameter("@Return_Date", SqlDbType.Date);
            param[8].Value = Return_Date;

            param[9] = new SqlParameter("@Return_User", SqlDbType.VarChar, 50);
            param[9].Value = Return_User;

            param[10] = new SqlParameter("@StatusId", SqlDbType.VarChar, 50);
            param[10].Value = StatusId;

            param[11] = new SqlParameter("@Notes", SqlDbType.VarChar, 250);
            param[11].Value = Notes;

            param[12] = new SqlParameter("@ReturnAmouT_Ar", SqlDbType.VarChar, 250);
            param[12].Value = ReturnAmouT_Ar;


            param[13] = new SqlParameter("@ItemId", SqlDbType.Int);
            param[13].Value = ItemId;

            DAL.ExecuteCommand("UpdatePosReturnSales", param);
            DAL.Close();

        }
        //----------------------------------------------------------------

        public DataTable SearchReturnSales(string Criterion)
        {
            DAL.Open();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@Criterion", SqlDbType.VarChar, 50);
            param[0].Value = Criterion;


            Dt = DAL.SelectData("SearchPosReturnSales", param);
            DAL.Close();
            return Dt;
        }
    }
}
