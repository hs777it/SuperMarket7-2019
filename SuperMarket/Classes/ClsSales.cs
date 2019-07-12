using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace SuperMarket.Classes
{
    class ClsSales
    {
        Data.DataAccessLayer DAL = new Data.DataAccessLayer();
        DataTable Dt = new DataTable();

        public DataTable SalesOrderMaxId()
        {
            Dt = DAL.SelectData("SalesOrderMaxId", null);
            //DAL.Close();
            return Dt;
        }


        public DataTable GatBarCodeSales(string Item_Barcode)
        {
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@Item_Barcode", SqlDbType.VarChar, 60);
            param[0].Value = Item_Barcode;

            Dt = DAL.SelectData("GatBarCodeSales", param);
            return Dt;

        }


        public DataTable VerifyItemsQty(int Item_Id, double Qty_Entered)
        {
            
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@Item_Id", SqlDbType.Int);
            param[0].Value = Item_Id;

            param[1] = new SqlParameter("@Qty_Entered", SqlDbType.Float);
            param[1].Value = Qty_Entered;

            Dt = DAL.SelectData("VerifyItemsQty", param);
            return Dt;
        }
        //public void ItemsQty(int Item_Id)
        //{
        //    DAL.Open();
        //    SqlParameter[] param = new SqlParameter[1];

        //    param[0] = new SqlParameter("@Item_Id", SqlDbType.Int);
        //    param[0].Value = Item_Id;

        //    DAL.ExecuteCommand("ItemsQty", param);
        //    DAL.Close();

        //}
        public DataTable QtyMinItems(int Item_Id, double Qty_Entered)
        {

            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@Item_Id", SqlDbType.Int);
            param[0].Value = Item_Id;

            param[1] = new SqlParameter("@Qty_Entered", SqlDbType.Float);
            param[1].Value = Qty_Entered;

            Dt = DAL.SelectData("QtyMinItems", param);
            return Dt;
        }
        public void Add_SalesOrder(int Order_Id, DateTime Order_Date,
                            string Order_Desc, int Cust_ID, string User_Order)
        {

            DAL.Open();
            SqlParameter[] param = new SqlParameter[5];
            param[0] = new SqlParameter("@Order_Id", SqlDbType.Int);
            param[0].Value = Order_Id;

            param[1] = new SqlParameter("@Order_Date", SqlDbType.DateTime);
            param[1].Value = Order_Date;

            param[2] = new SqlParameter("@Order_Desc", SqlDbType.VarChar, 250);
            param[2].Value = Order_Desc;

            param[3] = new SqlParameter("@Cust_ID", SqlDbType.Int);
            param[3].Value = Cust_ID;

            param[4] = new SqlParameter("@User_Order", SqlDbType.VarChar, 50);
            param[4].Value = User_Order;


            DAL.ExecuteCommand("Add_SalesOrder", param);
            DAL.Close();

        }


    
        public void AddSalesOrderDetailes(int Item_Id, int Order_Id, string BarCode,
                       string Item_Name, double Item_SalesPrice, double Item_QTE, double Item_Discount,
                       double Amount, double Total_Amount, string Total_Amount_Ar)
        {

            DAL.Open();
            SqlParameter[] param = new SqlParameter[10];

            param[0] = new SqlParameter("@Item_Id", SqlDbType.Int);
            param[0].Value = Item_Id;

            param[1] = new SqlParameter("@Order_Id", SqlDbType.Int);
            param[1].Value = Order_Id;

            param[2] = new SqlParameter("@BarCode", SqlDbType.VarChar, 60);
            param[2].Value = BarCode;

            param[3] = new SqlParameter("@Item_Name", SqlDbType.VarChar, 50);
            param[3].Value = Item_Name;

            param[4] = new SqlParameter("@Item_SalesPrice", SqlDbType.Float);
            param[4].Value = Item_SalesPrice;

            param[5] = new SqlParameter("@Item_QTE", SqlDbType.Float);
            param[5].Value = Item_QTE;

            param[6] = new SqlParameter("@Item_Discount", SqlDbType.Float);
            param[6].Value = Item_Discount;

            param[7] = new SqlParameter("@Amount", SqlDbType.Float);
            param[7].Value = Amount;

            param[8] = new SqlParameter("@Total_Amount", SqlDbType.Float);
            param[8].Value = Total_Amount;

            param[9] = new SqlParameter("@Total_Amount_Ar", SqlDbType.VarChar, 250);
            param[9].Value = Total_Amount_Ar;

            

            DAL.ExecuteCommand("AddSalesOrderDetailes", param);
            DAL.Close();

        }
        public DataTable GetAllSalesManger()
        {
            Dt = new DataTable();
            Dt = DAL.SelectData("GetAllSalesManger", null);
            //DAL.Close();
            return Dt;
        }

        public DataTable PrintOne(int ID)
        {
            Dt = new DataTable();

            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@ID", SqlDbType.Int);
            param[0].Value = ID;

            Dt = DAL.SelectData("PrintSingleSaleBill", param);
            return Dt;
        }

        public DataTable PrintAllSalesBill()
        {
            Dt = new DataTable();
            Dt = DAL.SelectData("PrintAllSalesBill", null);
            //DAL.Close();
            return Dt;
        }


        public void DeleteSalesBill(int ID)
        {

            DAL.Open();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@ID", SqlDbType.Int);
            param[0].Value = ID;

            DAL.ExecuteCommand("DeleteSalesBill", param);
            DAL.Close();

        }

        public DataTable GetAllSalesMangerOrderDetailes()
        {
            Dt = new DataTable();
            Dt = DAL.SelectData("GetAllSalesMangerOrderDetailes", null);
            //DAL.Close();
            return Dt;
        }
    }
}
