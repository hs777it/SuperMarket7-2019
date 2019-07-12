using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace SuperMarket.Classes
{
    class ClsPlaces
    {
        Data.DataAccessLayer DAL = new Data.DataAccessLayer();
        DataTable Dt = new DataTable();

        public DataTable GetAllPlaces()
        {
            Dt = DAL.SelectData("GetAllPlaces", null);
            //DAL.Close();
            return Dt;
        }
        public DataTable GetAllPlacesForSales(int id)
        {
            DataTable Dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;

            Dt = DAL.SelectData("GetAllPlacesForSales", param);
            return Dt;

        }
        public void InsertAllPlaces(int Item_Id, string Pl_Floar, string Pl_Stand, string Pl_Place)
        {

            DAL.Open();
            SqlParameter[] param = new SqlParameter[4];
            param[0] = new SqlParameter("@Item_Id", SqlDbType.Int);
            param[0].Value = Item_Id;

            param[1] = new SqlParameter("@Pl_Floar", SqlDbType.VarChar, 50);
            param[1].Value = Pl_Floar;

            param[2] = new SqlParameter("@Pl_Stand", SqlDbType.VarChar, 50);
            param[2].Value = Pl_Stand;

            param[3] = new SqlParameter("@Pl_Place", SqlDbType.VarChar, 50);
            param[3].Value = Pl_Place;

            DAL.ExecuteCommand("InsertAllPlaces", param);
            DAL.Close();

        }
        public void UpdateAllPlaces(int Item_Id, string Pl_Floar, string Pl_Stand, string Pl_Place)
        {

            DAL.Open();
            SqlParameter[] param = new SqlParameter[4];
            param[0] = new SqlParameter("@Item_Id", SqlDbType.Int);
            param[0].Value = Item_Id;

            param[1] = new SqlParameter("@Pl_Floar", SqlDbType.VarChar, 50);
            param[1].Value = Pl_Floar;

            param[2] = new SqlParameter("@Pl_Stand", SqlDbType.VarChar, 50);
            param[2].Value = Pl_Stand;

            param[3] = new SqlParameter("@Pl_Place", SqlDbType.VarChar, 50);
            param[3].Value = Pl_Place;

            DAL.ExecuteCommand("UpdateAllPlaces", param);
            DAL.Close();

        }

        public void DeletePlaces(int Id)
        {

            DAL.Open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@Id", SqlDbType.Int);
            param[0].Value = Id;
            DAL.ExecuteCommand("DeletePlaces", param);
            DAL.Close();

        }
        public DataTable SearchPlaces(string Criterion)
        {
            DAL.Open();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@Criterion", SqlDbType.VarChar, 50);
            param[0].Value = Criterion;


            Dt = DAL.SelectData("SearchPlaces", param);
            DAL.Close();
            return Dt;
        }
    }
}
