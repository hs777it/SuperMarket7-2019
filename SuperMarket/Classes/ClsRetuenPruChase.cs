using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace SuperMarket.Classes
{
    class ClsRetuenPruChase
    {

        Data.DataAccessLayer DAL = new Data.DataAccessLayer();
        DataTable Dt = new DataTable();
        public DataTable PurReturnItemsMaxId()
        {
            Dt = new DataTable();
            Dt = DAL.SelectData("PurReturnItemsMaxId", null);
            //DAL.Close();
            return Dt;
        }
        //----------------------------------------------------------------

    
        //----------------------------------------------------------------
        public DataTable GetAllReturnPurItems()
        {
            Dt = new DataTable();
            Dt = DAL.SelectData("GetAllReturnPurItems", null);
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

            Dt = DAL.SelectData("AllReturnPurItems", param);
            return Dt;

        }
        //----------------------------------------------------------------

        public DataTable VerifyPurReturnItems(string ReturnId)
        {
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@ReturnId", SqlDbType.VarChar, 50);
            param[0].Value = ReturnId;

            Dt = DAL.SelectData("VerifyPurReturnItems", param);
            return Dt;

        }
        //----------------------------------------------------------------

        public DataTable GetAllReturnSearch(string SEarchTxt)
        {
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@id", SqlDbType.VarChar, 50);
            param[0].Value = SEarchTxt;

            Dt = DAL.SelectData("GetAllReturnSearch", param);
            return Dt;

        }
        //----------------------------------------------------------------
        public void UpdateurReturnItemsStatus(string Id, int ReturnId)
        {

            DAL.Open();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@Id", SqlDbType.VarChar, 50);
            param[0].Value = Id;

            param[1] = new SqlParameter("@ReturnId", SqlDbType.Int);
            param[1].Value = ReturnId;

            DAL.ExecuteCommand("UpdateurReturnItemsStatus", param);
            DAL.Close();

        }
        //----------------------------------------------------------------

        public void UpdateurReturnItemsQTE(string BarCode, double Item_Qte)
        {

            DAL.Open();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@BarCode", SqlDbType.VarChar, 60);
            param[0].Value = BarCode;

            param[1] = new SqlParameter("@Item_Qte", SqlDbType.Float);
            param[1].Value = Item_Qte;

            DAL.ExecuteCommand("UpdateurReturnItemsQTE", param);
            DAL.Close();

        }
        //----------------------------------------------------------------

        public void DeleteReturnPurItems(int ReturnId)
        {

            DAL.Open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@ReturnId", SqlDbType.Int);
            param[0].Value = ReturnId;
            DAL.ExecuteCommand("DeleteReturnPurItems", param);
            DAL.Close();

        }

        //----------------------------------------------------------------

        public void InsertPurReturnItems(int ReturnId, int Order_Id, string Org_Bill,
                          string barcode, string Return_Item, double Return_ItemPrice,
                          double Return_QTE, double Return_Total, string ReturnAmouT_Ar, double PriceUnit,
                          DateTime Return_Date, string PurSup_Name, string StatusId, string Notes,
                          string Return_User, int PurOrder_Id)
        {

            DAL.Open();
            SqlParameter[] param = new SqlParameter[16];

            param[0] = new SqlParameter("@ReturnId", SqlDbType.Int);
            param[0].Value = ReturnId;

            param[1] = new SqlParameter("@Order_Id", SqlDbType.Int);
            param[1].Value = Order_Id;

            param[2] = new SqlParameter("@Org_Bill", SqlDbType.VarChar, 50);
            param[2].Value = Org_Bill;

            param[3] = new SqlParameter("@barcode", SqlDbType.VarChar, 50);
            param[3].Value = barcode;

            param[4] = new SqlParameter("@Return_Item", SqlDbType.VarChar, 50);
            param[4].Value = Return_Item;

            param[5] = new SqlParameter("@Return_ItemPrice", SqlDbType.Float);
            param[5].Value = Return_ItemPrice;
         
            param[6] = new SqlParameter("@Return_QTE", SqlDbType.Float);
            param[6].Value = Return_QTE;

            param[7] = new SqlParameter("@Return_Total", SqlDbType.Float);
            param[7].Value = Return_Total;

            param[8] = new SqlParameter("@ReturnAmouT_Ar", SqlDbType.VarChar, 250);
            param[8].Value = ReturnAmouT_Ar;

            param[9] = new SqlParameter("@PriceUnit", SqlDbType.Float);
            param[9].Value = PriceUnit;

            param[10] = new SqlParameter("@Return_Date", SqlDbType.Date);
            param[10].Value = Return_Date;

            param[11] = new SqlParameter("@PurSup_Name", SqlDbType.VarChar, 50);
            param[11].Value = PurSup_Name;

            param[12] = new SqlParameter("@StatusId", SqlDbType.VarChar, 50);
            param[12].Value = StatusId;

            param[13] = new SqlParameter("@Notes", SqlDbType.VarChar, 250);
            param[13].Value = Notes;
           
            param[14] = new SqlParameter("@Return_User", SqlDbType.VarChar, 50);
            param[14].Value = Return_User;

            param[15] = new SqlParameter("@PurOrder_Id", SqlDbType.Int);
            param[15].Value = PurOrder_Id;


            DAL.ExecuteCommand("InsertPurReturnItems", param);
            DAL.Close();

        }
        //----------------------------------------------------------------


        public void UpdateurReturnItems(int ReturnId, int Order_Id, string Org_Bill,
                          string barcode, string Return_Item, double Return_ItemPrice,
                          double Return_QTE, double Return_Total, string ReturnAmouT_Ar, double PriceUnit,
                          DateTime Return_Date, string PurSup_Name, string StatusId, string Notes,
                          string Return_User, int PurOrder_Id)
        {

            DAL.Open();
            SqlParameter[] param = new SqlParameter[16];

            param[0] = new SqlParameter("@ReturnId", SqlDbType.Int);
            param[0].Value = ReturnId;

            param[1] = new SqlParameter("@Order_Id", SqlDbType.Int);
            param[1].Value = Order_Id;

            param[2] = new SqlParameter("@Org_Bill", SqlDbType.VarChar, 50);
            param[2].Value = Org_Bill;

            param[3] = new SqlParameter("@barcode", SqlDbType.VarChar, 50);
            param[3].Value = barcode;

            param[4] = new SqlParameter("@Return_Item", SqlDbType.VarChar, 50);
            param[4].Value = Return_Item;

            param[5] = new SqlParameter("@Return_ItemPrice", SqlDbType.Float);
            param[5].Value = Return_ItemPrice;

            param[6] = new SqlParameter("@Return_QTE", SqlDbType.Float);
            param[6].Value = Return_QTE;

            param[7] = new SqlParameter("@Return_Total", SqlDbType.Float);
            param[7].Value = Return_Total;

            param[8] = new SqlParameter("@ReturnAmouT_Ar", SqlDbType.VarChar, 250);
            param[8].Value = ReturnAmouT_Ar;

            param[9] = new SqlParameter("@PriceUnit", SqlDbType.Float);
            param[9].Value = PriceUnit;

            param[10] = new SqlParameter("@Return_Date", SqlDbType.Date);
            param[10].Value = Return_Date;

            param[11] = new SqlParameter("@PurSup_Name", SqlDbType.VarChar, 50);
            param[11].Value = PurSup_Name;

            param[12] = new SqlParameter("@StatusId", SqlDbType.VarChar, 50);
            param[12].Value = StatusId;

            param[13] = new SqlParameter("@Notes", SqlDbType.VarChar, 250);
            param[13].Value = Notes;

            param[14] = new SqlParameter("@Return_User", SqlDbType.VarChar, 50);
            param[14].Value = Return_User;

            param[15] = new SqlParameter("@PurOrder_Id", SqlDbType.Int);
            param[15].Value = PurOrder_Id;


            DAL.ExecuteCommand("UpdateurReturnItems", param);
            DAL.Close();

        }
        //----------------------------------------------------------------

        public DataTable GetAllReturnPurItemsSearch(string Criterion)
        {
            DAL.Open();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@id", SqlDbType.VarChar, 50);
            param[0].Value = Criterion;


            Dt = DAL.SelectData("GetAllReturnPurItemsSearch", param);
            DAL.Close();
            return Dt;
        }
    }
}
