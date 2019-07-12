using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace SuperMarket.Classes
{
    class ClsPermissions
    {

        Data.DataAccessLayer DAL = new Data.DataAccessLayer();
        DataTable Dt = new DataTable();

        public DataTable SelectUserPermissions(string UserName)
        {
            DAL.Open();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@UserName", SqlDbType.VarChar, 50);
            param[0].Value = UserName;


            Dt = DAL.SelectData("SelectUserPermissions", param);
            DAL.Close();
            return Dt;
        }
        //public void AddUserPermissions(int User_Id, string UserName, string UserPassWord, string UserFullName,
        //   string UserType, bool M1, bool M2, bool M3, bool M4, bool M5, bool M6, bool M7, bool M8, bool M9, bool M10,
        //    bool M11, bool M12, bool M13, bool M14, bool M15, bool M16, bool M17, bool M18,
        //     bool M19, bool M20, bool M21, bool M22, bool M23, bool M24, bool M25, bool M26, bool M27, bool M28,
        //     bool M29, bool M30, bool M31, bool M32, bool M33, bool M34, bool M35, bool M36, bool M37, bool M38,
        //     bool M39, bool M40, bool M41, bool M42, bool M43, bool M44, bool M45, bool M46, bool M47, bool M48,
        //     bool M49, bool M50)
        //{

        //    DAL.Open();
        //    SqlParameter[] param = new SqlParameter[55];

        //    param[0] = new SqlParameter("@User_Id", SqlDbType.Int);
        //    param[0].Value = User_Id;

        //    param[1] = new SqlParameter("@UserName", SqlDbType.VarChar, 50);
        //    param[1].Value = UserName;

        //    param[2] = new SqlParameter("@UserPassMord", SqlDbType.VarChar, 30);
        //    param[2].Value = UserPassWord;

        //    param[3] = new SqlParameter("@UserFullName", SqlDbType.VarChar, 100);
        //    param[3].Value = UserFullName;

        //    param[4] = new SqlParameter("@UserType", SqlDbType.VarChar, 40);
        //    param[4].Value = UserType;

        //    param[5] = new SqlParameter("@M1", SqlDbType.);
        //    param[5].Value = M1;

        //    param[6] = new SqlParameter("@M2", SqlDbType.Bit);
        //    param[6].Value = M2;

        //    param[7] = new SqlParameter("@M3", SqlDbType.Bit);
        //    param[7].Value = M3;

        //    param[8] = new SqlParameter("@M4", SqlDbType.Bit);
        //    param[8].Value = M4;

        //    param[9] = new SqlParameter("@M5", SqlDbType.Bit);
        //    param[9].Value = M5;

        //    param[10] = new SqlParameter("@M6", SqlDbType.Bit);
        //    param[10].Value = M6;

        //    param[11] = new SqlParameter("@M7", SqlDbType.Bit);
        //    param[11].Value = M7;

        //    param[12] = new SqlParameter("@M8", SqlDbType.Bit);
        //    param[12].Value = M8;

        //    param[13] = new SqlParameter("@M9", SqlDbType.Bit);
        //    param[13].Value = M9;

        //    param[14] = new SqlParameter("@M10", SqlDbType.Bit);
        //    param[14].Value = M10;

        //    param[15] = new SqlParameter("@M11", SqlDbType.Bit);
        //    param[15].Value = M11;

        //    param[16] = new SqlParameter("@M12", SqlDbType.Bit);
        //    param[16].Value = M12;

        //    param[17] = new SqlParameter("@M13", SqlDbType.Bit);
        //    param[17].Value = M13;

        //    param[18] = new SqlParameter("@M14", SqlDbType.Bit);
        //    param[18].Value = M14;

        //    param[19] = new SqlParameter("@M15", SqlDbType.Bit);
        //    param[19].Value = M15;

        //    param[20] = new SqlParameter("@M16", SqlDbType.Bit);
        //    param[20].Value = M16;

        //    param[21] = new SqlParameter("@M17", SqlDbType.Bit);
        //    param[21].Value = M17;

        //    param[22] = new SqlParameter("@M18", SqlDbType.Bit);
        //    param[22].Value = M18;

        //    param[23] = new SqlParameter("@M19", SqlDbType.Bit);
        //    param[23].Value = M19;

        //    param[24] = new SqlParameter("@M20", SqlDbType.Bit);
        //    param[24].Value = M20;



        //    param[25] = new SqlParameter("@M21", SqlDbType.Bit);
        //    param[25].Value = M21;

        //    param[26] = new SqlParameter("@M22", SqlDbType.Bit);
        //    param[26].Value = M22;

        //    param[27] = new SqlParameter("@M23", SqlDbType.Bit);
        //    param[27].Value = M23;

        //    param[28] = new SqlParameter("@M24", SqlDbType.Bit);
        //    param[28].Value = M24;

        //    param[29] = new SqlParameter("@M25", SqlDbType.Bit);
        //    param[29].Value = M25;

        //    param[30] = new SqlParameter("@M26", SqlDbType.Bit);
        //    param[30].Value = M26;

        //    param[31] = new SqlParameter("@M27", SqlDbType.Bit);
        //    param[31].Value = M27;

        //    param[32] = new SqlParameter("@M28", SqlDbType.Bit);
        //    param[32].Value = M28;

        //    param[33] = new SqlParameter("@M29", SqlDbType.Bit);
        //    param[33].Value = M29;

        //    param[34] = new SqlParameter("@M30", SqlDbType.Bit);
        //    param[34].Value = M30;



        //    param[35] = new SqlParameter("@M31", SqlDbType.Bit);
        //    param[35].Value = M31;

        //    param[36] = new SqlParameter("@M32", SqlDbType.Bit);
        //    param[36].Value = M32;

        //    param[37] = new SqlParameter("@M33", SqlDbType.Bit);
        //    param[37].Value = M33;

        //    param[38] = new SqlParameter("@M34", SqlDbType.Bit);
        //    param[38].Value = M34;

        //    param[39] = new SqlParameter("@M35", SqlDbType.Bit);
        //    param[39].Value = M35;

        //    param[40] = new SqlParameter("@M36", SqlDbType.Bit);
        //    param[40].Value = M36;

        //    param[41] = new SqlParameter("@M37", SqlDbType.Bit);
        //    param[41].Value = M37;

        //    param[42] = new SqlParameter("@M38", SqlDbType.Bit);
        //    param[42].Value = M38;

        //    param[43] = new SqlParameter("@M39", SqlDbType.Bit);
        //    param[43].Value = M39;

        //    param[44] = new SqlParameter("@M40", SqlDbType.Bit);
        //    param[44].Value = M40;



        //    param[45] = new SqlParameter("@M41", SqlDbType.Bit);
        //    param[45].Value = M41;

        //    param[46] = new SqlParameter("@M42", SqlDbType.Bit);
        //    param[46].Value = M42;

        //    param[47] = new SqlParameter("@M43", SqlDbType.Bit);
        //    param[47].Value = M43;

        //    param[48] = new SqlParameter("@M44", SqlDbType.Bit);
        //    param[48].Value = M44;

        //    param[49] = new SqlParameter("@M45", SqlDbType.Bit);
        //    param[49].Value = M45;

        //    param[50] = new SqlParameter("@M46", SqlDbType.Bit);
        //    param[50].Value = M46;

        //    param[51] = new SqlParameter("@M47", SqlDbType.Bit);
        //    param[51].Value = M47;

        //    param[52] = new SqlParameter("@M48", SqlDbType.Bit);
        //    param[52].Value = M48;

        //    param[53] = new SqlParameter("@M49", SqlDbType.Bit);
        //    param[53].Value = M49;

        //    param[54] = new SqlParameter("@M50", SqlDbType.Bit);
        //    param[54].Value = M50;

        //    DAL.ExecuteCommand("AddUserPermissions", param);
        //    DAL.Close();

        //}
    }
}
