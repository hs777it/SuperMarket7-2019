using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace SuperMarket.Classes
{
    class ClsPruChaseOrder
    {
        Data.DataAccessLayer DAL = new Data.DataAccessLayer();
        DataTable Dt = new DataTable();

        public DataTable PruChaseOrderMaxId()
        {
            Dt = DAL.SelectData("PruChaseOrderMaxId", null);
            //DAL.Close();
            return Dt;
        }

        public void Add_PruChaseOrder(int PurOrder_Id, DateTime PurOrder_Date,
                            string PurOrder_Desc, int PurSup_ID, string User_PurOrder)
        {

            DAL.Open();
            SqlParameter[] param = new SqlParameter[5];
            param[0] = new SqlParameter("@PurOrder_Id", SqlDbType.Int);
            param[0].Value = PurOrder_Id;

            param[1] = new SqlParameter("@PurOrder_Date", SqlDbType.DateTime);
            param[1].Value = PurOrder_Date;

            param[2] = new SqlParameter("@PurOrder_Desc", SqlDbType.VarChar, 250);
            param[2].Value = PurOrder_Desc;

            param[3] = new SqlParameter("@PurSup_ID", SqlDbType.Int);
            param[3].Value = PurSup_ID;

            param[4] = new SqlParameter("@User_PurOrder", SqlDbType.VarChar, 50);
            param[4].Value = User_PurOrder;


            DAL.ExecuteCommand("Add_PruChaseOrder", param);
            DAL.Close();

        }
        
        public void InsertPruchaseOrderDetailes(int PurOrder_Id, string Org_Bill,
                            string BarCode, string PurItem_Name, double PurItem_Price , double PurItem_QTE,
                            double Amount, double Total_Amount, string Total_Amount_Ar,string Stautes, double PriceUnit)
        {
            DAL.Open();
            SqlParameter[] param = new SqlParameter[11];

            param[0] = new SqlParameter("@PurOrder_Id", SqlDbType.Int);
            param[0].Value = PurOrder_Id;

            param[1] = new SqlParameter("@Org_Bill", SqlDbType.VarChar, 50);
            param[1].Value = Org_Bill;

            param[2] = new SqlParameter("@BarCode", SqlDbType.VarChar, 60);
            param[2].Value = BarCode;

            param[3] = new SqlParameter("@PurItem_Name", SqlDbType.VarChar, 50);
            param[3].Value = PurItem_Name;

            param[4] = new SqlParameter("@PurItem_Price", SqlDbType.Float);
            param[4].Value = PurItem_Price;

            param[5] = new SqlParameter("@PurItem_QTE", SqlDbType.Float);
            param[5].Value = PurItem_QTE;

            param[6] = new SqlParameter("@Amount", SqlDbType.Float);
            param[6].Value = Amount;

            param[7] = new SqlParameter("@Total_Amount", SqlDbType.Float);
            param[7].Value = Total_Amount;

            param[8] = new SqlParameter("@Total_Amount_Ar", SqlDbType.VarChar, 250);
            param[8].Value = Total_Amount_Ar;

            param[9] = new SqlParameter("@Stautes", SqlDbType.VarChar, 50);
            param[9].Value = Stautes;

            param[10] = new SqlParameter("@PriceUnit", SqlDbType.Float);
            param[10].Value = PriceUnit;


            DAL.ExecuteCommand("AddPruchaseOrderDetailes", param);
            DAL.Close();

        }

        public DataTable GetAllPurshceManger()
        {
            Dt = new DataTable();
            Dt = DAL.SelectData("GetAllPurshceManger", null);
            //DAL.Close();
            return Dt;
        }

        public DataTable PrintOne(int ID)
        {
            Dt = new DataTable();

            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@ID", SqlDbType.Int);
            param[0].Value = ID;

            Dt = DAL.SelectData("GetOnePruchaseBill", param);
            return Dt;
        }

        public DataTable PrintAllPuchase()
        {
            Dt = new DataTable();
            Dt = DAL.SelectData("PrintAllPuchase", null);
            return Dt;
        }

        public void DeletePurBill(int ID)
        {

            DAL.Open();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@ID", SqlDbType.Int);
            param[0].Value = ID;
           
            DAL.ExecuteCommand("DeletePurBill", param);
            DAL.Close();

        }

        public DataTable GetAllPruchaseOrderDetailes()
        {
            Dt = new DataTable();
            Dt = DAL.SelectData("GetAllPruchaseOrderDetailes", null);
            //DAL.Close();
            return Dt;
        }
    }


}
