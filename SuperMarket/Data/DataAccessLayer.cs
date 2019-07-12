using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.IO;
namespace SuperMarket.Data
{
    class DataAccessLayer
    {
        SqlConnection sqlconnection;

        //This Constructor Inisialize the connection object
        public DataAccessLayer()
        {
            //string Patch = Application.StartupPath + @"\\settings\\conn.txt";
            //sqlconnection = new SqlConnection(File.ReadAllText(Patch));
            sqlconnection = new SqlConnection(@"Server=.; Database=SuperMarket_DB; Integrated Security=true");
        }

        //Method to open the connection
        public void Open()
        {
            if (sqlconnection.State != ConnectionState.Open)
            {
                sqlconnection.Open();
            }
            else
            {
                MessageBox.Show("خطأ: فشلت عملية الاتصال بقاعدة البيانات", "واى إن للبرمجيات", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        //Method to close the connection
        public void Close()
        {
            if (sqlconnection.State == ConnectionState.Open)
            {
                sqlconnection.Close();

            }
        }

        //Method To Read Data From Database
        public DataTable SelectData(string stored_procedure, SqlParameter[] param)
        {
            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.CommandText = stored_procedure;
            sqlcmd.Connection = sqlconnection;

            if (param != null)
            {
                for (int i = 0; i < param.Length; i++)
                {
                    sqlcmd.Parameters.Add(param[i]);
                }
            }
            SqlDataAdapter da = new SqlDataAdapter(sqlcmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        //Method to Insert, Update, and Delete Data From Database
        public void ExecuteCommand(string stored_procedure, SqlParameter[] param)
        {
            try
            {
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.CommandType = CommandType.StoredProcedure;
                sqlcmd.CommandText = stored_procedure;
                sqlcmd.Connection = sqlconnection;
                if (param != null)
                {
                    sqlcmd.Parameters.AddRange(param);
                }
                sqlcmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                MessageBox.Show("خطأ: فشلت عملية الاتصال بقاعدة البيانات" + ex.ToString(), "واى إن للبرمجيات", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            }
        
    }
}
