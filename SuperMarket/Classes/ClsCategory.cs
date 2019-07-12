using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace SuperMarket.Classes
{
    class ClsCategory
    {
        Data .DataAccessLayer DAL = new Data.DataAccessLayer();
        DataTable Dt = new DataTable();

        public DataTable CategoryMaxId()
        {
            Dt = new DataTable();
            Dt = DAL.SelectData("CategoryMaxId", null);
            //DAL.Close();
            return Dt;
        }
        public DataTable GetAllCategory()
        {
            Dt = new DataTable();
            Dt = DAL.SelectData("AllCategory", null);
            //DAL.Close();
            return Dt;
        }
        public void AddCategory(int Cat_Id, string Cat_Name)
        {
            
            DAL.Open();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@Cat_Id", SqlDbType.Int);
            param[0].Value = Cat_Id;

            param[1] = new SqlParameter("@Cat_Name", SqlDbType.VarChar, 50);
            param[1].Value = Cat_Name;

            DAL.ExecuteCommand("AddCategory", param);
            DAL.Close();

        }

        public void updateCategory(string Cat_Name, int Id)
        {

            DAL.Open();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@Cat_Name", SqlDbType.VarChar, 50);
            param[0].Value = Cat_Name;

            param[1] = new SqlParameter("@Id", SqlDbType.Int );
            param[1].Value = Id;

            DAL.ExecuteCommand("updateCategory", param);
            DAL.Close();

        }
        public void deleteCategory(int Id)
        {

            DAL.Open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@Id", SqlDbType.Int );
            param[0].Value = Id;
            DAL.ExecuteCommand("deleteCategory", param);
            DAL.Close();

        }
    }
}
