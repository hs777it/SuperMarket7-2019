using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;
using System.IO;
using DevComponents.DotNetBar;
using SuperMarket.Data;

namespace SuperMarket.PL.Users
{
    public partial class FrmPermissions : DevExpress.XtraEditors.XtraForm
    {
        Classes.ClsUsers ClsUsers = new Classes.ClsUsers();
        Classes.ClsPermissions ClsPermissions = new Classes.ClsPermissions();
        //SqlConnection con1 = new SqlConnection(File.ReadAllText(@"\settings\conn.txt"));
        SqlConnection con = new SqlConnection(@"Server=.; Database=SuperMarket_DB; Integrated Security=true");

        public FrmPermissions()
        {
            InitializeComponent();
            TxtId.Visible = false;
            BtnAdd.Enabled = false;
            BtnEdit.Enabled = false;
            BtnDel.Enabled = false;
            PUnCorrect1.Visible = false;
            PDoneC.Visible = false;
            clear();
            DGvPreview();
            var dateNow = DateTime.Now;
            var date = new DateTime(dateNow.Year, dateNow.Month, dateNow.Day);
            DateUser.DateTime = dateNow;
        }
        void DGvPreview()
        {
            try
            {
                
                dataGridView1.DataSource = ClsUsers.GetAllUsers();
                dataGridView1.Columns[1].Visible = false;
                dataGridView1.Columns[2].Visible = false;
                dataGridView1.Columns[3].Visible = false;
                dataGridView1.Columns[4].Visible = false;
                dataGridView1.Columns[5].Visible = false;
            }
            catch
            {
                return;
            }
        }
            void clear()
        {
 
                TxtUserName.Text = "";
                UserPassWord.Text = "";
                UserPassWordConfirm.Text = "";
                TxtFullName.Text = "";
                CmbType.SelectedItem = null;
            }
        
        private void checkBox20_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                TxtUserName.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                UserPassWord.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                TxtFullName.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                DateUser.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                CmbType.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                TxtId.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                BtnEdit.Enabled = true;
                BtnDel.Enabled = true;
            }
            catch
            {
                return;
            }
        }

        private void UserPassWordConfirm_TextChanged(object sender, EventArgs e)
        {
            if (UserPassWord.Text != UserPassWordConfirm.Text)
            {
                //PDoneC.SendToBack();
                PUnCorrect1.Visible = true;
                UserPassWordConfirm.Focus();
            }
            else
            {
                PUnCorrect1.Visible = false;
                PDoneC.Visible = true;

            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
           
            try
            {
               

                if (UserPassWord.Text != UserPassWordConfirm.Text)
                {
                    MessageBox.Show("كلمة المرور غير متطابقة", "واى إن للبرمجيات", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (TxtUserName.Text == string.Empty || UserPassWord.Text == string.Empty
                    || UserPassWordConfirm.Text == string.Empty || TxtFullName.Text == string.Empty || CmbType.SelectedItem == null)
                {
                    MessageBox.Show("رجاء اكمال البيانات!!", "واى إن للبرمجيات", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }


                SqlDataAdapter adp=new SqlDataAdapter("select * from Tb_Users where UserName = N'" + TxtUserName.Text + "'",con);
                DataSet ds = new DataSet();
                adp.Fill(ds);
                DataTable dt = new DataTable();
                dt = ds.Tables[0];
                if(dt.Rows.Count > 0)
                {
                    MessageBox.Show("إسم المستخدم موجود مسبقا", "واى إن للبرمجيات", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                DataRow r = dt.NewRow();
                r[0] = TxtId.Text;
                r[1] = TxtUserName.Text;
                r[2] = UserPassWord.Text;
                r[3] = TxtFullName.Text;
                r[4] = CmbType.Text;
                r[5] = M1.Checked;
                r[6] = M2.Checked;
                r[7] = M3.Checked;
                r[8] = M4.Checked;
                r[9] = M5.Checked;
                r[10] = M6.Checked;
                r[11] = M7.Checked;
                r[12] = M8.Checked;
                r[13] = M9.Checked;
                r[14] = M10.Checked;
                r[15] = M11.Checked;
                r[16] = M12.Checked;
                r[17] = M13.Checked;
                r[18] = M14.Checked;
                r[19] = M15.Checked;
                r[20] = M16.Checked;
                r[21] = M17.Checked;
                r[22] = M18.Checked;
                r[23] = M19.Checked;
                r[24] = M20.Checked;
                r[25] = M21.Checked;
                r[26] = M22.Checked;
                r[27] = M23.Checked;
                r[28] = M24.Checked;
                r[29] = M25.Checked;
                r[30] = M26.Checked;
                r[31] = M27.Checked;
                r[32] = M28.Checked;
                r[33] = M29.Checked;
                r[34] = M30.Checked;
                r[35] = M31.Checked;
                r[36] = M32.Checked;
                r[37] = M33.Checked;
                r[38] = M34.Checked;
                r[39] = M35.Checked;
                r[40] = M36.Checked;
                r[41] = M37.Checked;
                r[42] = M38.Checked;
                r[43] = M39.Checked;
                r[44] = M40.Checked;
                r[45] = M41.Checked;
                r[46] = M42.Checked;
                r[47] = M43.Checked;
                r[48] = M44.Checked;
                r[49] = M45.Checked;
                r[50] = M46.Checked;
                r[51] = M47.Checked;
                r[52] = M48.Checked;
                r[53] = M49.Checked;
                r[54] = M50.Checked;


                dt.Rows.Add(r);
                SqlCommandBuilder cmd_Builder1 = new SqlCommandBuilder(adp);
                adp.Update(dt);

                MessageBox.Show("تم إضافة المستخدم بنجاح", "إضافة مستخدم جديد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clear();
                DGvPreview();
            }
            catch
            {
                return;
            }
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            try
            {
                TxtId.Text = ClsUsers.UsersMaxId().Rows[0][0].ToString();
                BtnNew.Enabled = false;
                BtnAdd.Enabled = true;
            }
            catch
            {
                return;
            }
        }

        private void M1_CheckedChanged(object sender, EventArgs e)
        {
            if (M1.Checked == true )
            {
                M2.Checked = true;
                M3.Checked = true;
                M4.Checked = true;
            }
            else
            {
                M2.Checked = false ;
                M3.Checked = false;
                M4.Checked = false;
            }
        }

        private void M5_CheckedChanged(object sender, EventArgs e)
        {
            if (M5.Checked == true)
            {
                M6.Checked = true;
                M7.Checked = true;
               
            }
            else
            {
                M6.Checked = false;
                M7.Checked = false;
              
            }
        }

        private void M8_CheckedChanged(object sender, EventArgs e)
        {
            if (M8.Checked == true)
            {
                M9.Checked = true;
                M10.Checked = true;

            }
            else
            {
                M9.Checked = false;
                M10.Checked = false;

            }
        }

        private void Mall_CheckedChanged(object sender, EventArgs e)
        {
           
                if(Mall.Checked == true )
                {
                Mall.Text = "إلغاء تحديد الكل";
                M1.Checked = true;
                M2.Checked = true;
                M3.Checked = true;
                M4.Checked = true;
                M5.Checked = true;
                M6.Checked = true;
                M7.Checked = true;
                M8.Checked = true;
                M9.Checked = true;
                M10.Checked = true;
                M11.Checked = true;
                M12.Checked = true;
                M13.Checked = true;
                M14.Checked = true;
                M15.Checked = true;
                M16.Checked = true;
                M17.Checked = true;
                M18.Checked = true;
                M19.Checked = true;
                M20.Checked = true;
                M21.Checked = true;
                M22.Checked = true;
                M23.Checked = true;
                M24.Checked = true;
                M25.Checked = true;
                M26.Checked = true;
                M27.Checked = true;
                M28.Checked = true;
                M29.Checked = true;
                M30.Checked = true;
                M31.Checked = true;
                M32.Checked = true;
                M33.Checked = true;
                M34.Checked = true;
                M35.Checked = true;
                M36.Checked = true;
                M37.Checked = true;
                M38.Checked = true;
                M39.Checked = true;
                M40.Checked = true;
                M41.Checked = true;
                M42.Checked = true;
                M43.Checked = true;
                M44.Checked = true;
                M45.Checked = true;
                M46.Checked = true;
                M47.Checked = true;
                M48.Checked = true;
                M49.Checked = true;
                M50.Checked = true;
            }
                else
            {
                Mall.Text = " تحديد الكل";

                M1.Checked = false;
                M2.Checked = false;
                M3.Checked = false;
                M4.Checked = false;
                M5.Checked = false;
                M6.Checked = false;
                M7.Checked = false;
                M8.Checked = false;
                M9.Checked = false;
                M10.Checked = false;
                M11.Checked = false;
                M12.Checked = false;
                M13.Checked = false;
                M14.Checked = false;
                M15.Checked = false;
                M16.Checked = false;
                M17.Checked = false;
                M18.Checked = false;
                M19.Checked = false;
                M20.Checked = false;
                M21.Checked = false;
                M22.Checked = false;
                M23.Checked = false;
                M24.Checked = false;
                M25.Checked = false;
                M26.Checked = false;
                M27.Checked = false;
                M28.Checked = false;
                M29.Checked = false;
                M30.Checked = false;
                M31.Checked = false;
                M32.Checked = false;
                M33.Checked = false;
                M34.Checked = false;
                M35.Checked = false;
                M36.Checked = false;
                M37.Checked = false;
                M38.Checked = false;
                M39.Checked = false;
                M40.Checked = false;
                M41.Checked = false;
                M42.Checked = false;
                M43.Checked = false;
                M44.Checked = false;
                M45.Checked = false;
                M46.Checked = false;
                M47.Checked = false;
                M48.Checked = false;
                M49.Checked = false;
                M50.Checked = false;
            }
           
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (Program.UserName == TxtUserName.Text)
            {
                MessageBox.Show("كلمة المرور غير متطابقة", "واى إن للبرمجيات", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (UserPassWord.Text != UserPassWordConfirm.Text)
            {
                MessageBox.Show("كلمة المرور غير متطابقة", "واى إن للبرمجيات", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (TxtId.Text == string.Empty || TxtUserName.Text == string.Empty || UserPassWord.Text == string.Empty
                || UserPassWordConfirm.Text == string.Empty || TxtFullName.Text == string.Empty || CmbType.SelectedItem == null)
            {
                MessageBox.Show("رجاء اكمال البيانات!!", "واى إن للبرمجيات", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            DialogResult dialog = MessageBox.Show("هل انت متأكد من انك تريد تعديل البيانات؟", "واى إن للبرمجيات", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.No)
            {
                return;
            }

            try
            {

                SqlDataAdapter adp = new SqlDataAdapter("select * from Tb_Users where UserName = N'" + TxtUserName.Text + "'", con);
                DataSet ds = new DataSet();
                adp.Fill(ds);
                DataTable dt = new DataTable();
                dt = ds.Tables[0];
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("إسم المستخدم موجود مسبقا", "واى إن للبرمجيات", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                DataRow r = dt.Rows[0];


                r[0] = TxtId.Text;
                r[1] = TxtUserName.Text;
                r[2] = UserPassWord.Text;
                r[3] = TxtFullName.Text;
                r[4] = DateUser.EditValue;
                r[5] = CmbType.Text;
                r[6] = M1.Checked; 
                r[7] = M2.Checked;
                r[8] = M3.Checked;
                r[9] = M4.Checked;
                r[10] = M5.Checked;
                r[11] = M6.Checked;
                r[12] = M7.Checked;
                r[13] = M8.Checked;
                r[14] = M9.Checked;
                r[15] = M10.Checked;
                r[16] = M11.Checked;
                r[17] = M12.Checked;
                r[18] = M13.Checked;
                r[19] = M14.Checked;
                r[20] = M15.Checked;
                r[21] = M16.Checked;
                r[22] = M17.Checked;
                r[23] = M18.Checked;
                r[24] = M19.Checked;
                r[25] = M20.Checked;
                r[26] = M21.Checked;
                r[27] = M22.Checked;
                r[28] = M23.Checked;
                r[23] = M24.Checked;
                r[30] = M25.Checked;
                r[31] = M26.Checked;
                r[32] = M27.Checked;
                r[33] = M28.Checked;
                r[34] = M29.Checked;
                r[35] = M30.Checked;
                r[36] = M31.Checked;
                r[37] = M32.Checked;
                r[38] = M33.Checked;
                r[39] = M34.Checked;
                r[40] = M35.Checked;
                r[41] = M36.Checked;
                r[42] = M37.Checked;
                r[43] = M38.Checked;
                r[44] = M39.Checked;
                r[45] = M40.Checked;
                r[46] = M41.Checked;
                r[47] = M42.Checked;
                r[48] = M43.Checked;
                r[49] = M44.Checked;
                r[50] = M45.Checked;
                r[51] = M46.Checked;
                r[52] = M47.Checked;
                r[53] = M48.Checked;
                r[54] = M49.Checked;
                r[55] = M50.Checked;


                
                SqlCommandBuilder cmd_Builder1 = new SqlCommandBuilder(adp);
                adp.Update(dt);

                MessageBox.Show("تم تعديل المستخدم بنجاح", "إضافة مستخدم جديد", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clear();
                DGvPreview();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnDel_Click(object sender, EventArgs e)
        {

            DialogResult dialog = MessageBox.Show("هل انت متأكد من انك تريد حذف المستخدم؟", "واى إن للبرمجيات", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.No)
            {
                return;
            }

            try
            {
                int Id = Convert.ToInt32(TxtId.Text);
                ClsUsers.deleteUsers(Id);
                MessageBox.Show("تم حذف إسم المستخدم بنجاح", "واى إن للبرمجيات", MessageBoxButtons.OK, MessageBoxIcon.Information);

                BtnEdit.Enabled = false;
                BtnDel.Enabled = false;
                clear();
                DGvPreview();
            }
            catch
            {
                return;
            }
        }

        private void FrmPermissions_Load(object sender, EventArgs e)
        {
            BtnNew_Click(sender, e);
        }

        private void M11_CheckedChanged(object sender, EventArgs e)
        {
            if (M11.Checked == true)
            {
                M12.Checked = true;
                M13.Checked = true;

            }
            else
            {
                M12.Checked = false;
                M13.Checked = false;

            }
        }

        private void M14_CheckedChanged(object sender, EventArgs e)
        {
            if (M14.Checked == true)
            {
                M15.Checked = true;
                M16.Checked = true;

            }
            else
            {
                M15.Checked = false;
                M16.Checked = false;

            }
        }

        private void M17_CheckedChanged(object sender, EventArgs e)
        {
            if (M17.Checked == true)
            {
                M18.Checked = true;
                M20.Checked = true;

            }
            else
            {
                M18.Checked = false;
                M20.Checked = false;

            }
        }

        private void M21_CheckedChanged(object sender, EventArgs e)
        {
            if (M21.Checked == true)
            {
                M22.Checked = true;
                M23.Checked = true;

            }
            else
            {
                M22.Checked = false;
                M23.Checked = false;

            }
        }

        private void M24_CheckedChanged(object sender, EventArgs e)
        {
            if (M24.Checked == true)
            {
                M25.Checked = true;
                M26.Checked = true;

            }
            else
            {
                M25.Checked = false;
                M26.Checked = false;

            }
        }

        private void M27_CheckedChanged(object sender, EventArgs e)
        {
            if (M27.Checked == true)
            {
                M28.Checked = true;
                M29.Checked = true;

            }
            else
            {
                M28.Checked = false;
                M29.Checked = false;

            }
        }

        private void M30_CheckedChanged(object sender, EventArgs e)
        {
            if (M30.Checked == true)
            {
                M31.Checked = true;
                M32.Checked = true;

            }
            else
            {
                M31.Checked = false;
                M32.Checked = false;

            }
        }

        private void M33_CheckedChanged(object sender, EventArgs e)
        {
            if (M33.Checked == true)
            {
                M34.Checked = true;
                M35.Checked = true;
                M36.Checked = true;
            }
            else
            {
                M34.Checked = false;
                M35.Checked = false;
                M36.Checked = false;
            }
        }

        private void M37_CheckedChanged(object sender, EventArgs e)
        {
            if (M37.Checked == true)
            {
                M38.Checked = true;
                M39.Checked = true;
                M40.Checked = true;
            }
            else
            {
                M38.Checked = false;
                M39.Checked = false;
                M40.Checked = false;
            }
        }

        private void M41_CheckedChanged(object sender, EventArgs e)
        {
            if (M41.Checked == true)
            {
                M42.Checked = true;
                M43.Checked = true;

            }
            else
            {
                M42.Checked = false;
                M43.Checked = false;

            }
        }

        private void M44_CheckedChanged(object sender, EventArgs e)
        {
            if (M44.Checked == true)
            {
                M45.Checked = true;
                M46.Checked = true;

            }
            else
            {
                M45.Checked = false;
                M46.Checked = false;

            }
        }

        private void M47_CheckedChanged(object sender, EventArgs e)
        {
            if (M47.Checked == true)
            {
                M48.Checked = true;
                M49.Checked = true;
                M50.Checked = true;
            }
            else
            {
                M48.Checked = false;
                M49.Checked = false;
                M50.Checked = false;
            }
        }
    }
}