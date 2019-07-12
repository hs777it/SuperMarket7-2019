using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
namespace SuperMarket.Classes
{
    class ClsPos
    {
        Data.DataAccessLayer DAL = new Data.DataAccessLayer();
        DataTable Dt = new DataTable();

        public DataTable PosOrderMaxId()
        {
            Dt = DAL.SelectData("PosOrderMaxId", null);
            //DAL.Close();
            return Dt;
        }
        public void Add_PosOrder(int PosOrder_Id, DateTime PosOrder_Date,
                           string User_Name, string User_Type, double Pos_Madfoa, double Pos_Motabqi,
                           double Total_Amount, double Item_Discount, double TotalBill, string TotalBillAr, string PosBillType)
        {

            
                        DAL.Open();
            SqlParameter[] param = new SqlParameter[11];
            param[0] = new SqlParameter("@PosOrder_Id", SqlDbType.Int);
            param[0].Value = PosOrder_Id;

            param[1] = new SqlParameter("@PosOrder_Date", SqlDbType.DateTime);
            param[1].Value = PosOrder_Date;

            param[2] = new SqlParameter("@User_Name", SqlDbType.VarChar, 100);
            param[2].Value = User_Name;

            param[3] = new SqlParameter("@User_Type", SqlDbType.VarChar, 40);
            param[3].Value = User_Type;

            param[4] = new SqlParameter("@Pos_Madfoa", SqlDbType.Float);
            param[4].Value = Pos_Madfoa;

            param[5] = new SqlParameter("@Pos_Motabqi", SqlDbType.Float);
            param[5].Value = Pos_Motabqi;

            param[6] = new SqlParameter("@Total_Amount", SqlDbType.Float);
            param[6].Value = Total_Amount;

            param[7] = new SqlParameter("@Item_Discount", SqlDbType.Float);
            param[7].Value = Item_Discount;

            param[8] = new SqlParameter("@TotalBill", SqlDbType.Float);
            param[8].Value = TotalBill;

            param[9] = new SqlParameter("@TotalBillAr", SqlDbType.VarChar, 250);
            param[9].Value = TotalBillAr;

            param[10] = new SqlParameter("@PosBillType", SqlDbType.VarChar, 30);
            param[10].Value = PosBillType;



            DAL.ExecuteCommand("Add_PosOrder", param);
            DAL.Close();

        }


        public void Add_PosOrderDetailes(int Item_Id, int Pos_Order_Id, string Pos_BarCode,
                       string Pos_Item_Name, double Pos_SalePrice, double Item_QTE, double Total_Amount)
        {

            DAL.Open();
            SqlParameter[] param = new SqlParameter[7];

            param[0] = new SqlParameter("@Item_Id", SqlDbType.Int);
            param[0].Value = Item_Id;

            param[1] = new SqlParameter("@Pos_Order_Id", SqlDbType.Int);
            param[1].Value = Pos_Order_Id;

            param[2] = new SqlParameter("@Pos_BarCode", SqlDbType.VarChar, 60);
            param[2].Value = Pos_BarCode;

            param[3] = new SqlParameter("@Pos_Item_Name", SqlDbType.VarChar, 50);
            param[3].Value = Pos_Item_Name;

            param[4] = new SqlParameter("@Pos_SalePrice", SqlDbType.Float);
            param[4].Value = Pos_SalePrice;

            param[5] = new SqlParameter("@Item_QTE", SqlDbType.Float);
            param[5].Value = Item_QTE;

            param[6] = new SqlParameter("@Total_Amount", SqlDbType.Float);
            param[6].Value = Total_Amount;

            DAL.ExecuteCommand("Add_PosOrderDetailes", param);
            DAL.Close();

        }
        public DataTable GetSum_Pos_Today()
        {
            Dt = new DataTable();
            Dt = DAL.SelectData("GetSum_Pos_Today", null);
            return Dt;
        }

        //-----------------------------------------------------
        public DataTable PrintPOsBill(int ID)
        {
            Dt = new DataTable();

            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@ID", SqlDbType.Int);
            param[0].Value = ID;

            Dt = DAL.SelectData("PrintPOsBill", param);
            return Dt;
        }
    }
}
