using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System;
using System.Data;
using System.Management;
using System.Net;
using System.Net.Mail;


public static class vUtility
{

   
    public static string GetHDDInfo()
    {
        string val = "";
        ManagementObjectSearcher mgmt = new ManagementObjectSearcher("select * from win32_DiskDrive");
        try
        {
            foreach (ManagementObject obj in mgmt.Get())
                return val = obj["SerialNumber"].ToString().Trim();
        }
        catch (ManagementException)
        {
            return "";
        }
        return val;
    }

    

    #region Send Email Method
    public static void SendEmailMessage(string from, string to, string subject, string body)
    {
        using (MailMessage Msg = new MailMessage(from, to, subject, body))
        {
            Msg.IsBodyHtml = true;
            using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587))
            {
                smtp.Credentials = new NetworkCredential("hussainafndy@gmail.com", "2ccd*44cc");
                smtp.EnableSsl = true;
                smtp.Send(Msg);
            }
        }
    }
    public static void SendEmailMessage(string from, string to, string subject, string body, string email, string password)
    {
        using (MailMessage Msg = new MailMessage(from, to, subject, body))
        {
            Msg.IsBodyHtml = true;
            using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587))
            {
                smtp.Credentials = new NetworkCredential(email, password);
                smtp.EnableSsl = true;
                smtp.Send(Msg);
            }
        }
    }

    /*
    // List of email recipients
    string mails = "11111@gmail.com;22222@gmail.com;33333@gmail.com;44444@gmail.com;55555@gmail.com";
    MailMessage Msg;
            foreach (var address in mails.Split(new[] { ";" }, StringSplitOptions.RemoveEmptyEntries))
            {
               Msg = new MailMessage(to, address.Replace(";", ","));
            }
    */
    /// <summary>
    /// 
    /// </summary>
    /// <param name="from"></param>
    /// <param name="to"></param>
    /// <param name="subject"></param>
    /// <param name="body">Pure Text and HTML</param>
    /// <param name="attachmentFilename">Write null or "" if no attachment</param>
    /// <param name="displayName">Paramater is optional</param>
    public static void SendEmail(string from, string to, string subject, string body,string attachmentFilename, string displayName = "")
    {
        using (MailMessage Msg = new MailMessage())
        {
            Msg.From = new MailAddress(from, displayName);
            Msg.To.Add(to);
            Msg.Subject = subject;
            Msg.IsBodyHtml = true;
            Msg.Body = body;
            if (!string.IsNullOrEmpty(attachmentFilename))
            {
                Msg.Attachments.Add(new Attachment(attachmentFilename));
            }

            string[] Titles = { "dndshafndy07@gmail.com", "hussainafndy@gmail.com" };
            string email = Titles[new Random().Next(0, Titles.Length)];

            using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587))
            {
                smtp.Credentials = new NetworkCredential(email, "2ccd*44cc");
                smtp.EnableSsl = true;
                smtp.Send(Msg);
            }
        }

    }
    /// <summary>
    /// 
    /// </summary>
    /// <param name="from"></param>
    /// <param name="to"></param>
    /// <param name="subject"></param>
    /// <param name="body">Pure Text and HTML</param>
    /// <param name="email">Email ID you want to send by it</param>
    /// <param name="password">Password for Email ID</param>
    /// <param name="attachmentFilename">Write null or "" if no attachment</param>
    /// <param name="displayName">Paramater is optional</param>
    public static void SendEmail(string from, string to, string subject, string body, string email, string password,string attachmentFilename, string displayName = "")
    {
        using (MailMessage Msg = new MailMessage())
        {
            Msg.From = new MailAddress(from, displayName);
            Msg.To.Add(to);
            Msg.Subject = subject;
            Msg.IsBodyHtml = true;
            Msg.Body = body;
            if (!string.IsNullOrEmpty(attachmentFilename))
            {
                Msg.Attachments.Add(new Attachment(attachmentFilename));
            }
            using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587))
            {
                smtp.Credentials = new NetworkCredential(email, password);
                smtp.EnableSsl = true;
                smtp.Send(Msg);
            }
        }
    }
    #endregion


     #region Generate String Coupon Method
    /*  How to use:
        Random rnd = new Random();
        string[] coupon = new string[7];
        for (int i = 0; i < coupon.Length; i++)
                coupon[i] =vUtility.GenerateCoupon(10, rnd);
        MessageBox.Show(String.Join(Environment.NewLine, coupon));
     */
    public static string GenerateCoupon(int length, Random random)
    {
        string characters = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
        StringBuilder result = new StringBuilder(length);
        for (int i = 0; i < length; i++)
        {
            result.Append(characters[random.Next(characters.Length)]);
        }
        return result.ToString();
    }
    public static string GenerateCoupon(int length,string separator)
    {
        Random rnd = new Random((int)DateTime.Now.Ticks);
        //int no = rnd.Next(1, 20);
        string[] coupon = new string[20];
        for (int i = 0; i < coupon.Length; i++)
        {
            coupon[i] = GenerateCoupon(length, rnd);
        }
        return string.Join(separator, coupon); //Concatenates
    }
    public static string GenerateCoupon(int charsLength, int numberOfString, string separator)
    {
        Random rnd = new Random((int)DateTime.Now.Ticks);
        string[] coupon = new string[numberOfString];

        for (int j = 0; j < coupon.Length; j++)
        {
            coupon[j] = GenerateCoupon(charsLength, rnd);
        }
        return string.Join(separator, coupon);
    }
    #endregion



    #region Generate Random Characters Method
    /*
         var randomCharacters = vUtility.GetRandomCharacters(8, true);
         MessageBox.Show(new string(randomCharacters.ToArray()));
     */
    private static List<char> getAvailableRandomCharacters(bool includeLowerCase)
    {
        var integers = Enumerable.Empty<int>();
        integers = integers.Concat(Enumerable.Range('A', 26));
        integers = integers.Concat(Enumerable.Range('0', 10));

        if (includeLowerCase)
            integers = integers.Concat(Enumerable.Range('a', 26));

        return integers.Select(i => (char)i).ToList();
    }

    public static IEnumerable<char> GetRandomCharacters(int count, bool includeLowerCase)
    {
        var characters = getAvailableRandomCharacters(includeLowerCase);
        var random = new Random();
        var result = Enumerable.Range(0, count)
            .Select(_ => characters[random.Next(characters.Count)]);

        return result;
    }
    #endregion


    #region Random Extension Method
    /* use 
    var random = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".Random();
    // OR
    var random = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789".Random(16);
    // OR
      string[] password = new string[10];
            for (int i = 0; i < password.Length; i++)
                password[i] = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789".Random(16);
            MessageBox.Show(string.Join(Environment.NewLine, password));
     */
    public static string Random(this string chars, int length = 8)
    {
        var randomString = new StringBuilder();
        var random = new Random();

        for (int i = 0; i < length; i++)
            randomString.Append(chars[random.Next(chars.Length)]);

        return randomString.ToString();
    }
    #endregion




    #region Application Methods
    // Set Application icon
    public static void SetAppIcon(this Form form)
    {
        form.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
    }
   
    // Change color all background of (Form, TabContro, TabPage, ToolStrip)
    public static void ChangeColors(TabControl tabControl, Color color)
    {
        foreach (TabPage tp in tabControl.TabPages)
        {
            tp.BackColor = color;
            foreach (Control ctrl in tp.Controls)
            {
                if (ctrl is ToolStrip) ctrl.BackColor = color;
            }
        }
        foreach (Form frm in Application.OpenForms)
        {
            frm.BackColor = color;
        }
    }

    private static void CreateSettingsFolder()
    {
        if (!Directory.Exists("settings")) Directory.CreateDirectory("settings");
    }
    #endregion




    /*
        Random rnd = new Random();
        //or
        Random rnd = new Random((int)DateTime.Now.Ticks);
        //or
        rnd.Next(1, 12);
        string[] coupon = new string[7];
        for (int i = 0; i < coupon.Length; i++)
        {
            coupon[i] = GenerateCoupon(10, rnd);
        }
        Console.WriteLine(String.Join(Environment.NewLine, coupon));
        Console.WriteLine(String.Join(",", coupon));
         */

    /*
        SqlTransaction objTrans = null;  
        using (SqlConnection objConn = new SqlConnection(strConnString))  
        {  
           objConn.Open();  
           objTrans = objConn.BeginTransaction();  
           SqlCommand objCmd1 = new SqlCommand("insert into tblProject values(1, 'TestProject')", objConn);  
           SqlCommand objCmd2 = new SqlCommand("insert into tblProjectMember(MemberID, ProjectID) values(2, 1)", objConn);  
           try  
           {  
              objCmd1.ExecuteNonQuery();  
              objCmd2.ExecuteNonQuery();

              objTrans.Commit();  
           }  
           catch (Exception)  
           {  
              objTrans.Rollback();  
           }  
           finally  
           {  
              objConn.Close();  
           }  
        }  
     */

    /*
    byte.ToString("X2")
    //docs.microsoft.com/en-us/dotnet/standard/base-types/standard-numeric-format-strings



    */

    /*
     *https://docs.microsoft.com/en-us/dotnet/api/system.net.mail.smtpexception.statuscode?view=netframework-4.7.2 
     try
        {
            client.Send(message);
        }
        catch (SmtpFailedRecipientsException ex)
        {
            for (int i = 0; i < ex.InnerExceptions.Length; i++)
            {
                SmtpStatusCode status = ex.InnerExceptions[i].StatusCode;
                if (status == SmtpStatusCode.MailboxBusy ||
                    status == SmtpStatusCode.MailboxUnavailable)
                {
                    Console.WriteLine("Delivery failed - retrying in 5 seconds.");
                    System.Threading.Thread.Sleep(5000);
                    client.Send(message);
                }
                else
                {
                    Console.WriteLine("Failed to deliver message to {0}", 
                        ex.InnerExceptions[i].FailedRecipient);
                }
            }
        }
              catch (Exception ex)
              {
                  Console.WriteLine("Exception caught in RetryIfBusy(): {0}", 
                          ex.ToString() );
              }  
     */

}


