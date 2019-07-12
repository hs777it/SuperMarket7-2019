using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace SuperMarket.Classes
{
    class clsCustomers
    {
        Data.DataAccessLayer DAL = new Data.DataAccessLayer();
        DataTable Dt = new DataTable();

        public DataTable GetMaxCustomers()
        {
            Dt = DAL.SelectData("GetMaxCustomers", null);
            //DAL.Close();
            return Dt;
        }
        public DataTable GetAllCustomers()
        {
            Dt = DAL.SelectData("GetAllCustomers", null);
            //DAL.Close();
            return Dt;
        }

    
        public void CustomersAdd(int Cust_ID, string Cust_Name, string Cust_Phone, string Cust_Facebook,
            string Cust_Twitter, string Cust_Email, string Cust_Desc, string Cust_Company,
            string Cust_Address,  DateTime Cust_DateAdded, string Cust_UserAdd, double credit, double debit)
        {
 
            DAL.Open();
            SqlParameter[] param = new SqlParameter[13];
            param[0] = new SqlParameter("@Cust_ID", SqlDbType.Int);
            param[0].Value = Cust_ID;

            param[1] = new SqlParameter("@Cust_Name", SqlDbType.VarChar, 50);
            param[1].Value = Cust_Name;

            param[2] = new SqlParameter("@Cust_Phone", SqlDbType.VarChar, 30);
            param[2].Value = Cust_Phone;

            param[3] = new SqlParameter("@Cust_Facebook", SqlDbType.VarChar, 50);
            param[3].Value = Cust_Facebook;

            param[4] = new SqlParameter("@Cust_Twitter", SqlDbType.VarChar, 50);
            param[4].Value = Cust_Twitter;

            param[5] = new SqlParameter("@Cust_Email", SqlDbType.VarChar, 30);
            param[5].Value = Cust_Email;

            param[6] = new SqlParameter("@Cust_Desc", SqlDbType.VarChar, 250);
            param[6].Value = Cust_Desc;

            param[7] = new SqlParameter("@Cust_Company", SqlDbType.VarChar, 50);
            param[7].Value = Cust_Company;

            param[8] = new SqlParameter("@Cust_Address", SqlDbType.VarChar, 100);
            param[8].Value = Cust_Address;

            param[9] = new SqlParameter("@Cust_DateAdded", SqlDbType.Date);
            param[9].Value = Cust_DateAdded;

            param[10] = new SqlParameter("@Cust_UserAdd", SqlDbType.VarChar, 50);
            param[10].Value = Cust_UserAdd;

            param[11] = new SqlParameter("@credit", SqlDbType.Float);
            param[11].Value = credit;

            param[12] = new SqlParameter("@debit", SqlDbType.Float);
            param[12].Value = debit;

            DAL.ExecuteCommand("CustomersAdd", param);
            DAL.Close();

        }
        public void CustomersEdite( string Cust_Name, string Cust_Phone, string Cust_Facebook,
           string Cust_Twitter, string Cust_Email, string Cust_Desc, string Cust_Company,
           string Cust_Address, DateTime Cust_DateAdded, string Cust_UserAdd,int ID, double credit, double debit)
        {

            DAL.Open();
            SqlParameter[] param = new SqlParameter[13];
            

            param[0] = new SqlParameter("@Cust_Name", SqlDbType.VarChar, 50);
            param[0].Value = Cust_Name;

            param[1] = new SqlParameter("@Cust_Phone", SqlDbType.VarChar, 30);
            param[1].Value = Cust_Phone;

            param[2] = new SqlParameter("@Cust_Facebook", SqlDbType.VarChar, 50);
            param[2].Value = Cust_Facebook;

            param[3] = new SqlParameter("@Cust_Twitter", SqlDbType.VarChar, 50);
            param[3].Value = Cust_Twitter;

            param[4] = new SqlParameter("@Cust_Email", SqlDbType.VarChar, 30);
            param[4].Value = Cust_Email;

            param[5] = new SqlParameter("@Cust_Desc", SqlDbType.VarChar, 250);
            param[5].Value = Cust_Desc;

            param[6] = new SqlParameter("@Cust_Company", SqlDbType.VarChar, 50);
            param[6].Value = Cust_Company;

            param[7] = new SqlParameter("@Cust_Address", SqlDbType.VarChar, 100);
            param[7].Value = Cust_Address;

            param[8] = new SqlParameter("@Cust_DateAdded", SqlDbType.Date);
            param[8].Value = Cust_DateAdded;

            param[9] = new SqlParameter("@Cust_UserAdd", SqlDbType.VarChar, 50);
            param[9].Value = Cust_UserAdd;

            param[10] = new SqlParameter("@Id", SqlDbType.Int);
            param[10].Value = ID;

            param[11] = new SqlParameter("@credit", SqlDbType.Float);
            param[11].Value = credit;

            param[12] = new SqlParameter("@debit", SqlDbType.Float);
            param[12].Value = debit;

            DAL.ExecuteCommand("CustomersEdite", param);
            DAL.Close();

        }
        public void CustomersDelete(int Id)
        {

            DAL.Open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@Id", SqlDbType.Int);
            param[0].Value = Id;
            DAL.ExecuteCommand("CustomersDelete", param);
            DAL.Close();

        }
        public DataTable CustomersSearch(string Criterion)
        {
            DAL.Open();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@Criterion", SqlDbType.VarChar, 50);
            param[0].Value = Criterion;


            Dt = DAL.SelectData("CustomersSearch", param);
            DAL.Close();
            return Dt;
        }
    }
}
