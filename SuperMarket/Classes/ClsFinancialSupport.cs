using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace SuperMarket.Classes
{
    class ClsFinancialSupport
    {
        Data.DataAccessLayer DAL = new Data.DataAccessLayer();
        DataTable Dt = new DataTable();

        public DataTable GetAllFinancialSupport()
        {
            Dt = DAL.SelectData("GetAllFinancialSupport", null);
            //DAL.Close();
            return Dt;
        }
        public DataTable GetAllFinancialSupportaMax()
        {
            Dt = DAL.SelectData("GetAllFinancialSupportaMax", null);
            //DAL.Close();
            return Dt;
        }
        public DataTable GetAllSuppliers()
        {
            Dt = DAL.SelectData("GetAllSuppliers", null);
            //DAL.Close();
            return Dt;
        }
        public DataTable getDataForFinancialSupport(string NameToSupport)
        {
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@NameToSupport", SqlDbType.VarChar, 60);
            param[0].Value = NameToSupport;

            Dt = DAL.SelectData("getDataForFinancialSupport", param);
            return Dt;

        }
        public void AddAllFinancialSupport(int VoucherCode, DateTime VoucherDate, double VoucherAmount,
                                string VoucherAmountAr, string VoucherFrom, string statement, string UserVoucher,
                                double NewDofaa,string NewDofaaAr, double Baqi, string BaqiAr)
        {
           DAL.Open();
            SqlParameter[] param = new SqlParameter[11];
            param[0] = new SqlParameter("@VoucherCode", SqlDbType.Int);
            param[0].Value = VoucherCode;

            param[1] = new SqlParameter("@VoucherDate", SqlDbType.Date);
            param[1].Value = VoucherDate;

            param[2] = new SqlParameter("@Amount", SqlDbType.Float);
            param[2].Value = VoucherAmount;

            param[3] = new SqlParameter("@AmountArabic", SqlDbType.VarChar, 250);
            param[3].Value = VoucherAmountAr;

            param[4] = new SqlParameter("@NameToSupport", SqlDbType.VarChar, 250);
            param[4].Value = VoucherFrom;

            param[5] = new SqlParameter("@statement", SqlDbType.VarChar, 250);
            param[5].Value = statement;

            param[6] = new SqlParameter("@UserVoucher", SqlDbType.VarChar, 50);
            param[6].Value = UserVoucher;

            param[7] = new SqlParameter("@NewDofaa", SqlDbType.Float);
            param[7].Value = NewDofaa;

            param[8] = new SqlParameter("@NewDofaaAr", SqlDbType.VarChar, 250);
            param[8].Value = NewDofaaAr;

            param[9] = new SqlParameter("@Baqi", SqlDbType.Float);
            param[9].Value = Baqi;

            param[10] = new SqlParameter("@BaqiAr", SqlDbType.VarChar, 250);
            param[10].Value = BaqiAr;

            DAL.ExecuteCommand("AddAllFinancialSupport", param);
            DAL.Close();

        }
        public void UpdateAllFinancialSupport(int VoucherCode, DateTime VoucherDate, double VoucherAmount,
                               string VoucherAmountAr, string VoucherFrom, string statement, string UserVoucher, double NewDofaa,
                                string NewDofaaAr, double Baqi, string BaqiAr,int id)
        {


            DAL.Open();
            SqlParameter[] param = new SqlParameter[12];
            param[0] = new SqlParameter("@VoucherCode", SqlDbType.Int);
            param[0].Value = VoucherCode;

            param[1] = new SqlParameter("@VoucherDate", SqlDbType.Date);
            param[1].Value = VoucherDate;

            param[2] = new SqlParameter("@Amount", SqlDbType.Float);
            param[2].Value = VoucherAmount;

            param[3] = new SqlParameter("@AmountArabic", SqlDbType.VarChar, 250);
            param[3].Value = VoucherAmountAr;

            param[4] = new SqlParameter("@NameToSupport", SqlDbType.VarChar, 250);
            param[4].Value = VoucherFrom;

            param[5] = new SqlParameter("@statement", SqlDbType.VarChar, 250);
            param[5].Value = statement;

            param[6] = new SqlParameter("@UserVoucher", SqlDbType.VarChar, 50);
            param[6].Value = UserVoucher;


            param[7] = new SqlParameter("@NewDofaa", SqlDbType.Float);
            param[7].Value = NewDofaa;

            param[8] = new SqlParameter("@NewDofaaAr", SqlDbType.VarChar, 250);
            param[8].Value = NewDofaaAr;

            param[9] = new SqlParameter("@Baqi", SqlDbType.Float);
            param[9].Value = Baqi;

            param[10] = new SqlParameter("@BaqiAr", SqlDbType.VarChar, 250);
            param[10].Value = BaqiAr;

            param[11] = new SqlParameter("@Id", SqlDbType.Int);
            param[11].Value = id;

            DAL.ExecuteCommand("UpdateAllFinancialSupport", param);
            DAL.Close();

        }

        public void DeleteFinancialSupport(int Id)
        {

            DAL.Open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@Id", SqlDbType.Int);
            param[0].Value = Id;
            DAL.ExecuteCommand("DeleteFinancialSupport", param);
            DAL.Close();

        }
        public DataTable SearchFinancialSupport(string Criterion)
        {
            DAL.Open();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@Criterion", SqlDbType.VarChar, 50);
            param[0].Value = Criterion;


            Dt = DAL.SelectData("SearchFinancialSupport", param);
            DAL.Close();
            return Dt;
        }
    }
}
