using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Net.Mail;
using System.Net;
using DAL;
using System.Data.SqlClient;
using System.Data;

namespace DAL.Utilities
{
    public class SendEmail
    {
        Utilities.SQLCon _conn;

        public class MailConst
        {
            public static string Username = @"thongbao";
            public static string Password = @"lnNdtlsaa)(*7)(*";
            public const string SmtpServer = @"mail.ninomaxx.com.vn";
            public static string From = Username + "@ninomaxx.com.vn";
        }

        public bool NNSendMail(string recipient, string subject, string body, string[] attachments)
        {
            bool _rs = false;

            try
            {
                SmtpClient smtpClient = new SmtpClient();
                NetworkCredential basicCredential = new NetworkCredential(MailConst.Username, MailConst.Password);
                MailMessage message = new MailMessage();
                MailAddress fromAddress = new MailAddress(MailConst.From);

                smtpClient.Host = MailConst.SmtpServer;
                smtpClient.Port = 587;
                smtpClient.UseDefaultCredentials = false;
                smtpClient.Credentials = basicCredential;
                smtpClient.Timeout = (60 * 5 * 1000);
                smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;

                message.From = fromAddress;
                message.Subject = subject;
                message.IsBodyHtml = true;
                message.Body = body;
                message.To.Add(recipient);

                if (attachments != null)
                {
                    foreach (string attachment in attachments)
                    {
                        message.Attachments.Add(new Attachment(attachment));
                    }
                }

                smtpClient.Send(message);

                _rs = true;
            }
            catch (Exception)
            {
                _rs = false;
            }

            return _rs;
        }

        public bool SQLSendMail_ResetPassword(string _userid, string _newpass)
        {
            bool check = true;

            try
            {
                _conn = new Utilities.SQLCon();

                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "[MAIL].[spud_Send_ResetPassword]";
                command.Parameters.AddWithValue("@userid", _userid);
                command.Parameters.AddWithValue("@newPass", _newpass);

                SqlParameter _output = command.Parameters.Add("@output", SqlDbType.Bit);
                _output.Direction = ParameterDirection.Output;

                command.Connection = _conn.getConnection();

                command.ExecuteNonQuery();

                if (_output.Value.Equals("success"))
                {
                    check = true;
                }
                else
                {
                    check = false;
                }
            }
            catch (Exception ex)
            {
                check = false;
                throw new Exception(ex.Message);
            }

            return check;
        }
    }
}
