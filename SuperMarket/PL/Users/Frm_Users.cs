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

namespace SuperMarket.PL.Users
{
    public partial class Frm_Users : DevExpress.XtraEditors.XtraForm
    {
        Classes.ClsUsers ClsUsers = new Classes.ClsUsers();
        public Frm_Users()
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
        /// <summary>
        /// /////////////
        /// </summary>
        /// 
        void clear()
        {
            TxtId.Text = "";
            UserName.Text = "";
            UserPassWord.Text = "";
            UserPassWordConfirm.Text = "";
            TxtFullName.Text = "";
            CmbType.SelectedItem = null;
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
        /// <summary>
        /// ////////////////////////////
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// /////////////////
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// ///////////////////
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (UserPassWord.Text != UserPassWordConfirm.Text)
            {
                MessageBox.Show("كلمة المرور غير متطابقة", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if(TxtId.Text==string.Empty || UserName.Text == string.Empty || UserPassWord .Text == string.Empty
                || UserPassWordConfirm .Text == string.Empty || TxtFullName.Text == string.Empty || CmbType.SelectedItem  == null)
            {
                MessageBox.Show("رجاء اكمال البيانات!!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try
            {
                ClsUsers.UsersAdd(Convert.ToInt32(TxtId.Text), UserName.Text,UserPassWord.Text, 
                    TxtFullName.Text, DateUser.DateTime ,CmbType.Text );
                MessageBox.Show("تم العملية بنجاح", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BtnNew.Enabled = true;
                BtnAdd.Enabled = false;
                clear();
                DGvPreview();
            }
            catch
            {
                return;
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (UserPassWord.Text != UserPassWordConfirm.Text)
            {
                MessageBox.Show("كلمة المرور غير متطابقة", "واى إن للبرمجيات", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (TxtId.Text == string.Empty || UserName.Text == string.Empty || UserPassWord.Text == string.Empty
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
                int Id = Convert.ToInt32(TxtId.Text );
                ClsUsers .UsersEdite(UserName.Text,UserPassWord.Text,TxtFullName.Text,DateUser.DateTime ,CmbType.Text , Id);
                MessageBox.Show("تم تعديل البيانات بنجاح", "واى إن للبرمجيات", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                ClsUsers .deleteUsers(Id);
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                UserName.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                UserPassWord.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                //UserPassWordConfirm.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
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

        private void UserName_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter )
            {
                UserPassWord.Focus();
            }
        }

        private void UserPassWord_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                UserPassWordConfirm.Focus();
            }
        }

        private void UserPassWordConfirm_EditValueChanged(object sender, EventArgs e)
        {
            if (UserPassWord.Text != UserPassWordConfirm.Text)
            {
                PDoneC.SendToBack();
                PUnCorrect1.Visible = true;
                UserPassWordConfirm.Focus();
            }
            else
            {
                PDoneC.BringToFront ();
                PUnCorrect1.Visible = false ;
                PDoneC.Visible = true;

            }
        }

        private void TxtFullName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CmbType.Focus();
            }
        }

        private void UserPassWordConfirm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TxtFullName.Focus();
            }
        }

        private void UserPassWordConfirm_Validated(object sender, EventArgs e)
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

        private void UserPassWord_EditValueChanged(object sender, EventArgs e)
        {
            
        }

        private void UserPassWordConfirm_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
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

        private void UserPassWordConfirm_EnabledChanged(object sender, EventArgs e)
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

        private void SearchUsers_SelectedIndexChanged(object sender, EventArgs e)
        {        
               
        }

        private void SearchUsers_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.dataGridView1.DataSource = ClsUsers.SearchUsers(SearchUsers.Text);
            }
            catch
            {
                return;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void تعديلToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BtnEdit_Click(sender, e);
        }

        private void حذفToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BtnDel_Click(sender, e);
        }
    }
    }
