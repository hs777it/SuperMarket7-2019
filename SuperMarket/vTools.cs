using System.Drawing;
using System.Windows.Forms;

    class vTools
    {
        #region InpuxBox Tool
        public static string InputBox(string title, string text, bool NumberOnly = false,
                bool isPassword = false, bool isRTL = true, Color? txtColor = null, Color? frmColor = null, Color? buttonColor = null)
        {
            Form frm = new Form();
            Label lblHeader = new Label();
            TextBox txt = new TextBox();
            Button btnOK = new Button();
            Button btnClose = new Button();

            frm.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            frm.ControlBox = false;
            frm.MaximizeBox = false;
            frm.MinimizeBox = false;
            frm.Text = title;
            frm.Font = new Font("Arial", 12, FontStyle.Bold);
            frm.Size = new Size(400, 190);
            frm.StartPosition = FormStartPosition.Manual;
            frm.Location = new Point((Screen.PrimaryScreen.Bounds.Width - frm.Width) / 2,
                (Screen.PrimaryScreen.Bounds.Height - frm.Height) / 2);



            lblHeader.Text = text;
            lblHeader.AutoSize = true;
            lblHeader.Location = new Point(10, 10);
            if (txtColor == null) lblHeader.ForeColor = Color.Black;
            else lblHeader.ForeColor = (Color)txtColor;

            if (NumberOnly)
            {
                txt.KeyPress += delegate (object _sender, KeyPressEventArgs _e)
                {
                    if (!char.IsDigit(_e.KeyChar) && !char.IsControl(_e.KeyChar))
                        _e.Handled = true;
                };
            }
            if (isPassword) txt.PasswordChar = '•';
            txt.Location = new Point(10, 45);
            txt.BorderStyle = BorderStyle.FixedSingle;
            txt.Width = frm.Width - 40;

            btnOK.Location = new Point(10, txt.Top + txt.Height + 20);
            btnOK.Text = "OK";
            btnOK.Height += 7;
            btnOK.Width = 90;
            btnOK.Cursor = Cursors.Hand;
            btnOK.FlatStyle = FlatStyle.Popup;
            if (buttonColor == null) btnOK.BackColor = Color.Navy;
            else btnOK.BackColor = (Color)buttonColor;
            btnOK.ForeColor = Color.White;

            btnClose.Location = new Point(btnOK.Width + 20, btnOK.Top);
            btnClose.Text = "Cancel";
            btnClose.Height = btnOK.Height;
            btnClose.Width = btnOK.Width;
            btnClose.Cursor = btnOK.Cursor;
            btnClose.FlatStyle = btnOK.FlatStyle;
            if (buttonColor == null) btnClose.BackColor = Color.Navy;
            else btnClose.BackColor = (Color)buttonColor;
            btnClose.ForeColor = btnOK.ForeColor;



            frm.Controls.Add(lblHeader);
            frm.Controls.Add(txt);
            frm.Controls.Add(btnOK);
            frm.Controls.Add(btnClose);
            if (frmColor == null) frm.BackColor = Color.White;
            else frm.BackColor = (Color)frmColor;
            if (isRTL)
            {
                frm.RightToLeftLayout = true;
                frm.RightToLeft = RightToLeft.Yes;
                btnOK.Text = "موافق";
                btnClose.Text = "إلغاء";
            }

            string strText = "";
            btnOK.Click += delegate
            {
                strText = txt.Text;
                frm.Close();
            };

            btnClose.Click += delegate { frm.Close(); };
            txt.KeyDown += delegate (object MySender, KeyEventArgs MyE)
            {
                //OR //if(MyE.KeyData==Keys.Enter)
                if (MyE.KeyCode == Keys.Enter)
                {
                    strText = txt.Text;
                    frm.Close();
                }
            };


            frm.ShowDialog();

            if (NumberOnly)
            {
                if (strText.Trim() == "") strText = "0";
            }

            return strText;
        }

        public static string InputBox(string title, string text, bool NumberOnly = false,
            bool isPassword = false, bool isRTL = true, Color? frmColor = null, Color? buttonColor = null)
        {
            Form frm = new Form();
            Label lblHeader = new Label();
            TextBox txt = new TextBox();
            Button btnOK = new Button();
            Button btnClose = new Button();

            frm.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            frm.ControlBox = false;
            frm.MaximizeBox = false;
            frm.MinimizeBox = false;
            frm.Text = title;
            frm.Font = new Font("Arial", 12, FontStyle.Bold);
            frm.Size = new Size(400, 190);
            frm.StartPosition = FormStartPosition.Manual;
            frm.Location = new Point((Screen.PrimaryScreen.Bounds.Width - frm.Width) / 2,
                (Screen.PrimaryScreen.Bounds.Height - frm.Height) / 2);



            lblHeader.Text = text;
            lblHeader.AutoSize = true;
            lblHeader.Location = new Point(10, 10);
            lblHeader.ForeColor = Color.Black;

            if (NumberOnly)
            {
                txt.KeyPress += delegate (object _sender, KeyPressEventArgs _e)
                {
                    if (!char.IsDigit(_e.KeyChar) && !char.IsControl(_e.KeyChar))
                        _e.Handled = true;
                };
            }
            if (isPassword) txt.PasswordChar = '•';
            txt.Location = new Point(10, 45);
            txt.BorderStyle = BorderStyle.FixedSingle;
            txt.Width = frm.Width - 40;

            btnOK.Location = new Point(10, txt.Top + txt.Height + 20);
            btnOK.Text = "OK";
            btnOK.Height += 7;
            btnOK.Width = 90;
            btnOK.Cursor = Cursors.Hand;
            btnOK.FlatStyle = FlatStyle.Popup;
            if (buttonColor == null) btnOK.BackColor = Color.Navy;
            else btnOK.BackColor = (Color)buttonColor;
            btnOK.ForeColor = Color.White;

            btnClose.Location = new Point(btnOK.Width + 20, btnOK.Top);
            btnClose.Text = "Cancel";
            btnClose.Height = btnOK.Height;
            btnClose.Width = btnOK.Width;
            btnClose.Cursor = btnOK.Cursor;
            btnClose.FlatStyle = btnOK.FlatStyle;
            if (buttonColor == null) btnClose.BackColor = Color.Navy;
            else btnClose.BackColor = (Color)buttonColor;
            btnClose.ForeColor = btnOK.ForeColor;



            frm.Controls.Add(lblHeader);
            frm.Controls.Add(txt);
            frm.Controls.Add(btnOK);
            frm.Controls.Add(btnClose);
            if (frmColor == null) frm.BackColor = Color.White;
            else frm.BackColor = (Color)frmColor;
            if (isRTL)
            {
                frm.RightToLeftLayout = true;
                frm.RightToLeft = RightToLeft.Yes;
                btnOK.Text = "موافق";
                btnClose.Text = "إلغاء";
            }

            string strText = "";
            btnOK.Click += delegate
            {
                strText = txt.Text;
                frm.Close();
            };

            btnClose.Click += delegate { frm.Close(); };
            txt.KeyDown += delegate (object MySender, KeyEventArgs MyE)
            {
                if (MyE.KeyCode == Keys.Enter)
                {
                    strText = txt.Text;
                    frm.Close();
                }
            };


            frm.ShowDialog();

            if (NumberOnly)
            {
                if (strText.Trim() == "") strText = "0";
            }

            return strText;
        }

        public static string InputBox(string title, string text, bool NumberOnly = false,
            bool isPassword = false, bool isRTL = true)
        {
            Form frm = new Form();
            Label lblHeader = new Label();
            TextBox txt = new TextBox();
            Button btnOK = new Button();
            Button btnClose = new Button();

            frm.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            frm.ControlBox = false;
            frm.MaximizeBox = false;
            frm.MinimizeBox = false;
            frm.Text = title;
            frm.Font = new Font("Arial", 12, FontStyle.Bold);
            frm.Size = new Size(400, 190);
            frm.StartPosition = FormStartPosition.Manual;
            frm.Location = new Point((Screen.PrimaryScreen.Bounds.Width - frm.Width) / 2,
                (Screen.PrimaryScreen.Bounds.Height - frm.Height) / 2);



            lblHeader.Text = text;
            lblHeader.AutoSize = true;
            lblHeader.Location = new Point(10, 10);
            lblHeader.ForeColor = Color.Black;

            if (NumberOnly)
            {
                txt.KeyPress += delegate (object _sender, KeyPressEventArgs _e)
                {
                    if (!char.IsDigit(_e.KeyChar) && !char.IsControl(_e.KeyChar))
                        _e.Handled = true;
                };
            }
            if (isPassword) txt.PasswordChar = '•';
            txt.Location = new Point(10, 45);
            txt.BorderStyle = BorderStyle.FixedSingle;
            txt.Width = frm.Width - 40;

            btnOK.Location = new Point(10, txt.Top + txt.Height + 20);
            btnOK.Text = "OK";
            btnOK.Height += 7;
            btnOK.Width = 90;
            btnOK.Cursor = Cursors.Hand;
            btnOK.FlatStyle = FlatStyle.Popup;
            btnOK.BackColor = Color.Navy;
            btnOK.ForeColor = Color.White;

            btnClose.Location = new Point(btnOK.Width + 20, btnOK.Top);
            btnClose.Text = "Cancel";
            btnClose.Height = btnOK.Height;
            btnClose.Width = btnOK.Width;
            btnClose.Cursor = btnOK.Cursor;
            btnClose.FlatStyle = btnOK.FlatStyle;
            btnClose.BackColor = Color.Navy;
            btnClose.ForeColor = btnOK.ForeColor;



            frm.Controls.Add(lblHeader);
            frm.Controls.Add(txt);
            frm.Controls.Add(btnOK);
            frm.Controls.Add(btnClose);
            frm.BackColor = Color.White;
            if (isRTL)
            {
                frm.RightToLeftLayout = true;
                frm.RightToLeft = RightToLeft.Yes;
                btnOK.Text = "موافق";
                btnClose.Text = "إلغاء";
            }

            string strText = "";
            btnOK.Click += delegate
            {
                strText = txt.Text;
                frm.Close();
            };

            btnClose.Click += delegate { frm.Close(); };
            txt.KeyDown += delegate (object MySender, KeyEventArgs MyE)
            {
                if (MyE.KeyCode == Keys.Enter)
                {
                    strText = txt.Text;
                    frm.Close();
                }
            };


            frm.ShowDialog();

            if (NumberOnly)
            {
                if (strText.Trim() == "") strText = "0";
            }

            return strText;
        }

        public static string InputBox(string title, string text, bool NumberOnly = false,
            bool isPassword = false)
        {
            Form frm = new Form();
            Label lblHeader = new Label();
            TextBox txt = new TextBox();
            Button btnOK = new Button();
            Button btnClose = new Button();

            frm.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            frm.ControlBox = false;
            frm.MaximizeBox = false;
            frm.MinimizeBox = false;
            frm.Text = title;
            frm.Font = new Font("Arial", 12, FontStyle.Bold);
            frm.Size = new Size(400, 190);
            frm.StartPosition = FormStartPosition.Manual;
            frm.Location = new Point((Screen.PrimaryScreen.Bounds.Width - frm.Width) / 2,
                (Screen.PrimaryScreen.Bounds.Height - frm.Height) / 2);



            lblHeader.Text = text;
            lblHeader.AutoSize = true;
            lblHeader.Location = new Point(10, 10);
            lblHeader.ForeColor = Color.Black;

            if (NumberOnly)
            {
                txt.KeyPress += delegate (object _sender, KeyPressEventArgs _e)
                {
                    if (!char.IsDigit(_e.KeyChar) && !char.IsControl(_e.KeyChar))
                        _e.Handled = true;
                };
            }
            if (isPassword) txt.PasswordChar = '•';
            txt.Location = new Point(10, 45);
            txt.BorderStyle = BorderStyle.FixedSingle;
            txt.Width = frm.Width - 40;

            btnOK.Location = new Point(10, txt.Top + txt.Height + 20);
            btnOK.Text = "OK";
            btnOK.Height += 7;
            btnOK.Width = 90;
            btnOK.Cursor = Cursors.Hand;
            btnOK.FlatStyle = FlatStyle.Popup;
            btnOK.BackColor = Color.Navy;
            btnOK.ForeColor = Color.White;

            btnClose.Location = new Point(btnOK.Width + 20, btnOK.Top);
            btnClose.Text = "Cancel";
            btnClose.Height = btnOK.Height;
            btnClose.Width = btnOK.Width;
            btnClose.Cursor = btnOK.Cursor;
            btnClose.FlatStyle = btnOK.FlatStyle;
            btnClose.BackColor = Color.Navy;
            btnClose.ForeColor = btnOK.ForeColor;



            frm.Controls.Add(lblHeader);
            frm.Controls.Add(txt);
            frm.Controls.Add(btnOK);
            frm.Controls.Add(btnClose);
            frm.BackColor = Color.White;

            string strText = "";
            btnOK.Click += delegate
            {
                strText = txt.Text;
                frm.Close();
            };

            btnClose.Click += delegate { frm.Close(); };
            txt.KeyDown += delegate (object MySender, KeyEventArgs MyE)
            {
                if (MyE.KeyCode == Keys.Enter)
                {
                    strText = txt.Text;
                    frm.Close();
                }
            };


            frm.ShowDialog();

            if (NumberOnly)
            {
                if (strText.Trim() == "") strText = "0";
            }

            return strText;
        }

        public enum RTL { Yes = 1, No = 2 }
        public static string InputBox(string title, string text, bool NumberOnly = false,RTL isRTL = RTL.Yes)
        {
            Form frm = new Form();
            Label lblHeader = new Label();
            TextBox txt = new TextBox();
            Button btnOK = new Button();
            Button btnClose = new Button();

            frm.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            frm.ControlBox = false;
            frm.MaximizeBox = false;
            frm.MinimizeBox = false;
            frm.Text = title;
            frm.Font = new Font("Arial", 12, FontStyle.Bold);
            frm.Size = new Size(400, 190);
            frm.StartPosition = FormStartPosition.Manual;
            frm.Location = new Point((Screen.PrimaryScreen.Bounds.Width - frm.Width) / 2,
                (Screen.PrimaryScreen.Bounds.Height - frm.Height) / 2);



            lblHeader.Text = text;
            lblHeader.AutoSize = true;
            lblHeader.Location = new Point(10, 10);
            lblHeader.ForeColor = Color.Black;

            if (NumberOnly)
            {
                txt.KeyPress += delegate (object _sender, KeyPressEventArgs _e)
                {
                    if (!char.IsDigit(_e.KeyChar) && !char.IsControl(_e.KeyChar))
                        _e.Handled = true;
                };
            }
            txt.Location = new Point(10, 45);
            txt.BorderStyle = BorderStyle.FixedSingle;
            txt.Width = frm.Width - 40;

            btnOK.Location = new Point(10, txt.Top + txt.Height + 20);
            btnOK.Text = "OK";
            btnOK.Height += 7;
            btnOK.Width = 90;
            btnOK.Cursor = Cursors.Hand;
            btnOK.FlatStyle = FlatStyle.Popup;
            btnOK.BackColor = Color.Navy;
            btnOK.ForeColor = Color.White;

            btnClose.Location = new Point(btnOK.Width + 20, btnOK.Top);
            btnClose.Text = "Cancel";
            btnClose.Height = btnOK.Height;
            btnClose.Width = btnOK.Width;
            btnClose.Cursor = btnOK.Cursor;
            btnClose.FlatStyle = btnOK.FlatStyle;
            btnClose.BackColor = Color.Navy;
            btnClose.ForeColor = btnOK.ForeColor;



            frm.Controls.Add(lblHeader);
            frm.Controls.Add(txt);
            frm.Controls.Add(btnOK);
            frm.Controls.Add(btnClose);
            frm.BackColor = Color.White;
            if (isRTL == RTL.Yes)
            {
                frm.RightToLeftLayout = true;
                frm.RightToLeft = RightToLeft.Yes;
                btnOK.Text = "موافق";
                btnClose.Text = "إلغاء";
            }

            string strText = "";
            btnOK.Click += delegate
            {
                strText = txt.Text;
                frm.Close();
            };

            btnClose.Click += delegate { frm.Close(); };
            txt.KeyDown += delegate (object MySender, KeyEventArgs MyE)
            {
                if (MyE.KeyCode == Keys.Enter)
                {
                    strText = txt.Text;
                    frm.Close();
                }
            };


            frm.ShowDialog();

            if (NumberOnly)
            {
                if (strText.Trim() == "") strText = "0";
            }

            return strText;
        }
        public static string InputBox(string title, string text,RTL isRTL = RTL.Yes)
        {
            Form frm = new Form();
            Label lblHeader = new Label();
            TextBox txt = new TextBox();
            Button btnOK = new Button();
            Button btnClose = new Button();

            frm.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            frm.ControlBox = false;
            frm.MaximizeBox = false;
            frm.MinimizeBox = false;
            frm.Text = title;
            frm.Font = new Font("Arial", 12, FontStyle.Bold);
            frm.Size = new Size(400, 190);
            frm.StartPosition = FormStartPosition.Manual;
            frm.Location = new Point((Screen.PrimaryScreen.Bounds.Width - frm.Width) / 2,
                (Screen.PrimaryScreen.Bounds.Height - frm.Height) / 2);



            lblHeader.Text = text;
            lblHeader.AutoSize = true;
            lblHeader.Location = new Point(10, 10);
            lblHeader.ForeColor = Color.Black;


            txt.Location = new Point(10, 45);
            txt.BorderStyle = BorderStyle.FixedSingle;
            txt.Width = frm.Width - 40;

            btnOK.Location = new Point(10, txt.Top + txt.Height + 20);
            btnOK.Text = "OK";
            btnOK.Height += 7;
            btnOK.Width = 90;
            btnOK.Cursor = Cursors.Hand;
            btnOK.FlatStyle = FlatStyle.Popup;
            btnOK.BackColor = Color.Navy;
            btnOK.ForeColor = Color.White;

            btnClose.Location = new Point(btnOK.Width + 20, btnOK.Top);
            btnClose.Text = "Cancel";
            btnClose.Height = btnOK.Height;
            btnClose.Width = btnOK.Width;
            btnClose.Cursor = btnOK.Cursor;
            btnClose.FlatStyle = btnOK.FlatStyle;
            btnClose.BackColor = Color.Navy;
            btnClose.ForeColor = btnOK.ForeColor;



            frm.Controls.Add(lblHeader);
            frm.Controls.Add(txt);
            frm.Controls.Add(btnOK);
            frm.Controls.Add(btnClose);
            frm.BackColor = Color.White;
            if (isRTL == RTL.Yes)
            {
                frm.RightToLeftLayout = true;
                frm.RightToLeft = RightToLeft.Yes;
                btnOK.Text = "موافق";
                btnClose.Text = "إلغاء";
            }

            string strText = "";
            btnOK.Click += delegate
            {
                strText = txt.Text;
                frm.Close();
            };

            btnClose.Click += delegate { frm.Close(); };
            txt.KeyDown += delegate (object MySender, KeyEventArgs MyE)
            {
                if (MyE.KeyCode == Keys.Enter)
                {
                    strText = txt.Text;
                    frm.Close();
                }
            };


            frm.ShowDialog();

            return strText;
        }
        public static string InputBox(string title, string text, bool NumberOnly = false)
        {
            Form frm = new Form();
            Label lblHeader = new Label();
            TextBox txt = new TextBox();
            Button btnOK = new Button();
            Button btnClose = new Button();

            frm.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            frm.ControlBox = false;
            frm.MaximizeBox = false;
            frm.MinimizeBox = false;
            frm.Text = title;
            frm.Font = new Font("Arial", 12, FontStyle.Bold);
            frm.Size = new Size(400, 190);
            frm.StartPosition = FormStartPosition.Manual;
            frm.Location = new Point((Screen.PrimaryScreen.Bounds.Width - frm.Width) / 2,
                (Screen.PrimaryScreen.Bounds.Height - frm.Height) / 2);



            lblHeader.Text = text;
            lblHeader.AutoSize = true;
            lblHeader.Location = new Point(10, 10);
            lblHeader.ForeColor = Color.Black;

            if (NumberOnly)
            {
                txt.KeyPress += delegate (object _sender, KeyPressEventArgs _e)
                {
                    if (!char.IsDigit(_e.KeyChar) && !char.IsControl(_e.KeyChar))
                        _e.Handled = true;
                };
            }
            txt.Location = new Point(10, 45);
            txt.BorderStyle = BorderStyle.FixedSingle;
            txt.Width = frm.Width - 40;

            btnOK.Location = new Point(10, txt.Top + txt.Height + 20);
            btnOK.Text = "OK";
            btnOK.Height += 7;
            btnOK.Width = 90;
            btnOK.Cursor = Cursors.Hand;
            btnOK.FlatStyle = FlatStyle.Popup;
            btnOK.BackColor = Color.Navy;
            btnOK.ForeColor = Color.White;

            btnClose.Location = new Point(btnOK.Width + 20, btnOK.Top);
            btnClose.Text = "Cancel";
            btnClose.Height = btnOK.Height;
            btnClose.Width = btnOK.Width;
            btnClose.Cursor = btnOK.Cursor;
            btnClose.FlatStyle = btnOK.FlatStyle;
            btnClose.BackColor = Color.Navy;
            btnClose.ForeColor = btnOK.ForeColor;



            frm.Controls.Add(lblHeader);
            frm.Controls.Add(txt);
            frm.Controls.Add(btnOK);
            frm.Controls.Add(btnClose);
            frm.BackColor = Color.White;

            string strText = "";
            btnOK.Click += delegate
            {
                strText = txt.Text;
                frm.Close();
            };

            btnClose.Click += delegate { frm.Close(); };
            txt.KeyDown += delegate (object MySender, KeyEventArgs MyE)
            {
                if (MyE.KeyCode == Keys.Enter)
                {
                    strText = txt.Text;
                    frm.Close();
                }
            };


            frm.ShowDialog();

            if (NumberOnly)
            {
                if (strText.Trim() == "") strText = "0";
            }

            return strText;
        }
        public static string InputBox(string title, string text)
        {
            Form frm = new Form();
            Label lblHeader = new Label();
            TextBox txt = new TextBox();
            Button btnOK = new Button();
            Button btnClose = new Button();

            frm.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            frm.ControlBox = false;
            frm.MaximizeBox = false;
            frm.MinimizeBox = false;
            frm.Text = title;
            frm.Font = new Font("Arial", 12, FontStyle.Bold);
            frm.Size = new Size(400, 190);
            frm.StartPosition = FormStartPosition.Manual;
            frm.Location = new Point((Screen.PrimaryScreen.Bounds.Width - frm.Width) / 2,
                (Screen.PrimaryScreen.Bounds.Height - frm.Height) / 2);



            lblHeader.Text = text;
            lblHeader.AutoSize = true;
            lblHeader.Location = new Point(10, 10);
            lblHeader.ForeColor = Color.Black;

            txt.Location = new Point(10, 45);
            txt.BorderStyle = BorderStyle.FixedSingle;
            txt.Width = frm.Width - 40;

            btnOK.Location = new Point(10, txt.Top + txt.Height + 20);
            btnOK.Text = "OK";
            btnOK.Height += 7;
            btnOK.Width = 90;
            btnOK.Cursor = Cursors.Hand;
            btnOK.FlatStyle = FlatStyle.Popup;
            btnOK.BackColor = Color.Navy;
            btnOK.ForeColor = Color.White;

            btnClose.Location = new Point(btnOK.Width + 20, btnOK.Top);
            btnClose.Text = "Cancel";
            btnClose.Height = btnOK.Height;
            btnClose.Width = btnOK.Width;
            btnClose.Cursor = btnOK.Cursor;
            btnClose.FlatStyle = btnOK.FlatStyle;
            btnClose.BackColor = Color.Navy;
            btnClose.ForeColor = btnOK.ForeColor;



            frm.Controls.Add(lblHeader);
            frm.Controls.Add(txt);
            frm.Controls.Add(btnOK);
            frm.Controls.Add(btnClose);
            frm.BackColor = Color.White;

            string strText = "";
            btnOK.Click += delegate
            {
                strText = txt.Text;
                frm.Close();
            };

            btnClose.Click += delegate { frm.Close(); };
            txt.KeyDown += delegate (object MySender, KeyEventArgs MyE)
            {
                if (MyE.KeyCode == Keys.Enter)
                {
                    strText = txt.Text;
                    frm.Close();
                }
            };


            frm.ShowDialog();

            return strText;
        }
        #endregion


        
        #region MessageBox Tool 
        public static void MsgBox(string text)
        {
            MessageBox.Show(text);
        }
        public static void MsgBox(string text, string caption)
        {
            MessageBox.Show(text, caption);
        }
        public enum Buttons { Yes = 1, No = 2 }
        public static bool MsgBox(string text, string caption = "", Buttons YesNo = Buttons.Yes)
        {
            DialogResult result = MessageBox.Show(text, caption, MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes) return true;
            else return false;

        }
        public static bool MsgBoxYesNo(string text, string caption = "")
        {
            DialogResult result = MessageBox.Show(text, caption, MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes) return true;
            else return false;

        }
        #endregion










    //public static string InputBox(string title, string text, 
    //    bool isPassword = false)
    //{
    //    Form frm = new Form();
    //    Label lblHeader = new Label();
    //    TextBox txt = new TextBox();
    //    Button btnOK = new Button();
    //    Button btnClose = new Button();

    //    frm.FormBorderStyle = FormBorderStyle.FixedToolWindow;
    //    frm.ControlBox = false;
    //    frm.MaximizeBox = false;
    //    frm.MinimizeBox = false;
    //    frm.Text = title;
    //    frm.Font = new Font("Arial", 12, FontStyle.Bold);
    //    frm.Size = new Size(400, 190);
    //    frm.StartPosition = FormStartPosition.Manual;
    //    frm.Location = new Point((Screen.PrimaryScreen.Bounds.Width - frm.Width) / 2,
    //        (Screen.PrimaryScreen.Bounds.Height - frm.Height) / 2);



    //    lblHeader.Text = text;
    //    lblHeader.AutoSize = true;
    //    lblHeader.Location = new Point(10, 10);
    //    lblHeader.ForeColor = Color.Black;


    //    if (isPassword) txt.PasswordChar = '•';
    //    txt.Location = new Point(10, 45);
    //    txt.BorderStyle = BorderStyle.FixedSingle;
    //    txt.Width = frm.Width - 40;

    //    btnOK.Location = new Point(10, txt.Top + txt.Height + 20);
    //    btnOK.Text = "OK";
    //    btnOK.Height += 7;
    //    btnOK.Width = 90;
    //    btnOK.Cursor = Cursors.Hand;
    //    btnOK.FlatStyle = FlatStyle.Popup;
    //    btnOK.BackColor = Color.Navy;
    //    btnOK.ForeColor = Color.White;

    //    btnClose.Location = new Point(btnOK.Width + 20, btnOK.Top);
    //    btnClose.Text = "Cancel";
    //    btnClose.Height = btnOK.Height;
    //    btnClose.Width = btnOK.Width;
    //    btnClose.Cursor = btnOK.Cursor;
    //    btnClose.FlatStyle = btnOK.FlatStyle;
    //    btnClose.BackColor = Color.Navy;
    //    btnClose.ForeColor = btnOK.ForeColor;



    //    frm.Controls.Add(lblHeader);
    //    frm.Controls.Add(txt);
    //    frm.Controls.Add(btnOK);
    //    frm.Controls.Add(btnClose);
    //    frm.BackColor = Color.White;

    //    string strText = "";
    //    btnOK.Click += delegate
    //    {
    //        strText = txt.Text;
    //        frm.Close();
    //    };

    //    btnClose.Click += delegate { frm.Close(); };
    //    txt.KeyDown += delegate (object MySender, KeyEventArgs MyE)
    //    {
    //        if (MyE.KeyCode == Keys.Enter)
    //        {
    //            strText = txt.Text;
    //            frm.Close();
    //        }
    //    };


    //    frm.ShowDialog();

    //    if (NumberOnly)
    //    {
    //        if (strText.Trim() == "") strText = "0";
    //    }

    //    return strText;
    //}

}

