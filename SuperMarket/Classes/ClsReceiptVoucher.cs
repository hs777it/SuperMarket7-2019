using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace SuperMarket.Classes
{
    class ClsReceiptVoucher
    {
        Data.DataAccessLayer DAL = new Data.DataAccessLayer();
        DataTable Dt = new DataTable();

        public DataTable GetAllVoucher()
        {
            Dt = DAL.SelectData("GetAllVoucher", null);
            //DAL.Close();
            return Dt;
        }
        public DataTable GetMaxVoucher()
        {
            Dt = DAL.SelectData("GetMaxVoucher", null);
            //DAL.Close();
            return Dt;
        }
        public DataTable GetAllCustomers()
        {
            Dt = DAL.SelectData("GetAllCustomers", null);
            //DAL.Close();
            return Dt;
        }
        public DataTable getDataForReceiptVoucher(string VoucherFrom)
        {
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@VoucherFrom", SqlDbType.VarChar, 60);
            param[0].Value = VoucherFrom;

            Dt = DAL.SelectData("getDataForReceiptVoucher", param);
            return Dt;

        }
        public void AddVoucher(int VoucherCode, string VoucherRNum, DateTime VoucherDate, double VoucherAmount, 
                                string VoucherAmountAr, string VoucherFrom, string statement, string UserVoucher, double NewDofaa,
                                string NewDofaaAr, double Baqi,string BaqiAr)
        {
            DAL.Open();
            SqlParameter[] param = new SqlParameter[12];
            param[0] = new SqlParameter("@VoucherCode", SqlDbType.Int);
            param[0].Value = VoucherCode;

            param[1] = new SqlParameter("@VoucherRNum", SqlDbType.VarChar, 25);
            param[1].Value = VoucherRNum;

            param[2] = new SqlParameter("@VoucherDate", SqlDbType.Date);
            param[2].Value = VoucherDate;

            param[3] = new SqlParameter("@VoucherAmount", SqlDbType.Float);
            param[3].Value = VoucherAmount;

            param[4] = new SqlParameter("@VoucherAmountAr", SqlDbType.VarChar, 250);
            param[4].Value = VoucherAmountAr;

            param[5] = new SqlParameter("@VoucherFrom", SqlDbType.VarChar, 250);
            param[5].Value = VoucherFrom;

            param[6] = new SqlParameter("@statement", SqlDbType.VarChar, 250);
            param[6].Value = statement;

            param[7] = new SqlParameter("@UserVoucher", SqlDbType.VarChar, 50);
            param[7].Value = UserVoucher;

            param[8] = new SqlParameter("@NewDofaa", SqlDbType.Float);
            param[8].Value = NewDofaa;

            param[9] = new SqlParameter("@NewDofaaAr", SqlDbType.VarChar, 250);
            param[9].Value = NewDofaaAr;

            param[10] = new SqlParameter("@Baqi", SqlDbType.Float);
            param[10].Value = Baqi;

            param[11] = new SqlParameter("@BaqiAr", SqlDbType.VarChar, 250);
            param[11].Value = BaqiAr;

            DAL.ExecuteCommand("AddVoucher", param);
            DAL.Close();

        }
        public void UpdateVoucher(int VoucherCode, string VoucherRNum, DateTime VoucherDate, double VoucherAmount,
                                string VoucherAmountAr, string VoucherFrom, string statement, string UserVoucher, double NewDofaa,
                                string NewDofaaAr, double Baqi, string BaqiAr,int id)
        {

            DAL.Open();
            SqlParameter[] param = new SqlParameter[13];
            param[0] = new SqlParameter("@VoucherCode", SqlDbType.Int);
            param[0].Value = VoucherCode;

            param[1] = new SqlParameter("@VoucherRNum", SqlDbType.VarChar, 25);
            param[1].Value = VoucherRNum;

            param[2] = new SqlParameter("@VoucherDate", SqlDbType.Date);
            param[2].Value = VoucherDate;

            param[3] = new SqlParameter("@VoucherAmount", SqlDbType.Float);
            param[3].Value = VoucherAmount;

            param[4] = new SqlParameter("@VoucherAmountAr", SqlDbType.VarChar, 250);
            param[4].Value = VoucherAmountAr;

            param[5] = new SqlParameter("@VoucherFrom", SqlDbType.VarChar, 250);
            param[5].Value = VoucherFrom;

            param[6] = new SqlParameter("@statement", SqlDbType.VarChar, 250);
            param[6].Value = statement;

            param[7] = new SqlParameter("@UserVoucher", SqlDbType.VarChar, 50);
            param[7].Value = UserVoucher;

            param[8] = new SqlParameter("@NewDofaa", SqlDbType.Float);
            param[8].Value = NewDofaa;

            param[9] = new SqlParameter("@NewDofaaAr", SqlDbType.VarChar, 250);
            param[9].Value = NewDofaaAr;

            param[10] = new SqlParameter("@Baqi", SqlDbType.Float);
            param[10].Value = Baqi;

            param[11] = new SqlParameter("@BaqiAr", SqlDbType.VarChar, 250);
            param[11].Value = BaqiAr;

            param[12] = new SqlParameter("@Id", SqlDbType.Int);
            param[12].Value = id;
           
            DAL.ExecuteCommand("UpdateVoucher", param);
            DAL.Close();

        }

        public void DeleteVoucher(int Id)
        {

            DAL.Open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@Id", SqlDbType.Int);
            param[0].Value = Id;
            DAL.ExecuteCommand("DeleteVoucher", param);
            DAL.Close();

        }
        public DataTable SearchVoucher(string Criterion)
        {
            DAL.Open();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@Criterion", SqlDbType.VarChar, 50);
            param[0].Value = Criterion;


            Dt = DAL.SelectData("SearchVoucher", param);
            DAL.Close();
            return Dt;
        }
    }
}
