using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace SuperMarket.Classes
{
    class ClsSuppliers
    {
        Data.DataAccessLayer DAL = new Data.DataAccessLayer();
        DataTable Dt = new DataTable();

        public DataTable SuppliersMaxId()
        {
            Dt = DAL.SelectData("SuppliersMaxId", null);
            //DAL.Close();
            return Dt;
        }
        public DataTable GetAllSuppliers()
        {
            Dt = DAL.SelectData("GetAllSuppliers", null);
            //DAL.Close();
            return Dt;
        }

        public void SuppliersAdd(int Sup_ID, string Sup_Name, string Sup_Phone, string Sup_Company,
            string Sup_Address, string Sup_Desc, string Sup_Facebook, string Sup_Twitter,
            string Sup_WebSite, string Sup_Email, DateTime Sup_DateAdded, string Sup_UserAdd, double credit, double debit)
        {

            DAL.Open();
            SqlParameter[] param = new SqlParameter[14];
            param[0] = new SqlParameter("@Sup_ID", SqlDbType.Int);
            param[0].Value = Sup_ID;

            param[1] = new SqlParameter("@Sup_Name", SqlDbType.VarChar, 50);
            param[1].Value = Sup_Name;

            param[2] = new SqlParameter("@Sup_Phone", SqlDbType.VarChar, 30);
            param[2].Value = Sup_Phone;

            param[3] = new SqlParameter("@Sup_Company", SqlDbType.VarChar, 50);
            param[3].Value = Sup_Company;

            param[4] = new SqlParameter("@Sup_Address", SqlDbType.VarChar, 100);
            param[4].Value = Sup_Address;

            param[5] = new SqlParameter("@Sup_Desc", SqlDbType.VarChar, 200);
            param[5].Value = Sup_Desc;

            param[6] = new SqlParameter("@Sup_Facebook", SqlDbType.VarChar, 50);
            param[6].Value = Sup_Facebook;

            param[7] = new SqlParameter("@Sup_Twitter", SqlDbType.VarChar, 50);
            param[7].Value = Sup_Twitter;

            param[8] = new SqlParameter("@Sup_WebSite", SqlDbType.VarChar, 50);
            param[8].Value = Sup_WebSite;

            param[9] = new SqlParameter("@Sup_Email", SqlDbType.VarChar, 30);
            param[9].Value = Sup_Email;

            param[10] = new SqlParameter("@Sup_DateAdded", SqlDbType.Date);
            param[10].Value = Sup_DateAdded;

            param[11] = new SqlParameter("@Sup_UserAdd", SqlDbType.VarChar, 50);
            param[11].Value = Sup_UserAdd;

            param[12] = new SqlParameter("@credit", SqlDbType.Float);
            param[12].Value = credit;

            param[13] = new SqlParameter("@debit", SqlDbType.Float);
            param[13].Value = debit;

            DAL.ExecuteCommand("SuppliersAdd", param);
            DAL.Close();

        }

        public void SuppliersEdite( string Sup_Name, string Sup_Phone, string Sup_Company,
           string Sup_Address, string Sup_Desc, string Sup_Facebook, string Sup_Twitter,
           string Sup_WebSite, string Sup_Email, DateTime Sup_DateAdded, string Sup_UserAdd, int Id, double credit, double debit)
        {

            DAL.Open();
            SqlParameter[] param = new SqlParameter[14];
           

            param[0] = new SqlParameter("@Sup_Name", SqlDbType.VarChar, 50);
            param[0].Value = Sup_Name;

            param[1] = new SqlParameter("@Sup_Phone", SqlDbType.VarChar, 30);
            param[1].Value = Sup_Phone;

            param[2] = new SqlParameter("@Sup_Company", SqlDbType.VarChar, 50);
            param[2].Value = Sup_Company;

            param[3] = new SqlParameter("@Sup_Address", SqlDbType.VarChar, 100);
            param[3].Value = Sup_Address;

            param[4] = new SqlParameter("@Sup_Desc", SqlDbType.VarChar, 200);
            param[4].Value = Sup_Desc;

            param[5] = new SqlParameter("@Sup_Facebook", SqlDbType.VarChar, 50);
            param[5].Value = Sup_Facebook;

            param[6] = new SqlParameter("@Sup_Twitter", SqlDbType.VarChar, 50);
            param[6].Value = Sup_Twitter;

            param[7] = new SqlParameter("@Sup_WebSite", SqlDbType.VarChar, 50);
            param[7].Value = Sup_WebSite;

            param[8] = new SqlParameter("@Sup_Email", SqlDbType.VarChar, 30);
            param[8].Value = Sup_Email;

            param[9] = new SqlParameter("@Sup_DateAdded", SqlDbType.Date);
            param[9].Value = Sup_DateAdded;

            param[10] = new SqlParameter("@Sup_UserAdd", SqlDbType.VarChar, 50);
            param[10].Value = Sup_UserAdd;

            param[11] = new SqlParameter("@Id", SqlDbType.Int);
            param[11].Value = Id;

            param[12] = new SqlParameter("@credit", SqlDbType.Float);
            param[12].Value = credit;

            param[13] = new SqlParameter("@debit", SqlDbType.Float);
            param[13].Value = debit;

            DAL.ExecuteCommand("SuppliersEdite", param);
            DAL.Close();

        }

        public void SuppliersDelete(int Id)
        {

            DAL.Open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@Id", SqlDbType.Int);
            param[0].Value = Id;
            DAL.ExecuteCommand("SuppliersDelete", param);
            DAL.Close();

        }
        public DataTable SuppliersSearch(string Criterion)
        {
            DAL.Open();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@Criterion", SqlDbType.VarChar, 50);
            param[0].Value = Criterion;


            Dt = DAL.SelectData("SuppliersSearch", param);
            DAL.Close();
            return Dt;
        }
    }

}


