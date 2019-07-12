using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace SuperMarket.Classes
{
    class ClsMain
    {
        Data.DataAccessLayer DAL = new Data.DataAccessLayer();
        DataTable Dt = new DataTable();

        public DataTable GetSum_SalessOrderDetails()
        {
            Dt = new DataTable();
            Dt = DAL.SelectData("GetSum_SalessOrderDetails", null);
            return Dt;
        }

        public DataTable GetSum_PruchaseOrder()
        {
            Dt = new DataTable();
            Dt = DAL.SelectData("GetSum_PruchaseOrder", null);
            return Dt;
        }
        public DataTable GetSum_SalesOrderDetails_Today()
        {
            Dt = new DataTable();
            Dt = DAL.SelectData("GetSum_SalesOrderDetails_Today", null);
            return Dt;
        }

        public DataTable BetweenPurChase(DateTime Date1, DateTime Date2)
        {
            Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@Date1", SqlDbType.DateTime);
            param[0].Value = Date1;

            param[1] = new SqlParameter("@Date2", SqlDbType.DateTime);
            param[1].Value = Date2;

            Dt = DAL.SelectData("BetweenPurChase", param);          
            return Dt;
        }

        public DataTable BetweenSales(DateTime Date1, DateTime Date2)
        {
            Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@Date1", SqlDbType.DateTime);
            param[0].Value = Date1;

            param[1] = new SqlParameter("@Date2", SqlDbType.DateTime);
            param[1].Value = Date2;

            Dt = DAL.SelectData("BetweenSales", param);
            return Dt;
        }
        public DataTable BetweenPosSales(DateTime Date1, DateTime Date2)
        {
            Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@Date1", SqlDbType.DateTime);
            param[0].Value = Date1;

            param[1] = new SqlParameter("@Date2", SqlDbType.DateTime);
            param[1].Value = Date2;

            Dt = DAL.SelectData("BetweenPosSales", param);
            return Dt;
        }
    }
}
