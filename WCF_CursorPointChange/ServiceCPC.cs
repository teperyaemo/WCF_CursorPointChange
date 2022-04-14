using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_CursorPointChange
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class ServiceCPC : IServiceCPC
    {
        List<ServerUser> Users = new List<ServerUser>();
        int NextId = 1;
        public int Connect(string login)
        {
            ServerUser user = new ServerUser
            {
                Id = NextId,
                Login = login,
                OperationContext = OperationContext.Current
            };
            NextId++;
            Users.Add(user);

            return user.Id;
        }

        public void Disconnect(int id)
        {
            var DiconnectedUser = Users.FirstOrDefault(i => i.Id == id);
            if (DiconnectedUser != null)
            {
                Users.Remove(DiconnectedUser);
            }

        }

        public void SendMessage(string message, int id)
        {
            // отправитель - устанавливаем адрес и отображаемое в письме имя
            MailAddress from = new MailAddress("ivan.lapshin.2000@inbox.ru", "WCF_Project");
            // кому отправляем
            MailAddress to = new MailAddress("rokudenas@bk.ru");
            // создаем объект сообщения
            MailMessage m = new MailMessage(from, to);
            // тема письма
            m.Subject = "Тест";
            // текст письма
            m.Body = "<h2>Письмо-тест работы smtp-клиента</h2>";
            // письмо представляет код html
            m.IsBodyHtml = true;
            // адрес smtp-сервера и порт, с которого будем отправлять письмо
            SmtpClient smtp = new SmtpClient("smtp.mail.ru", 465);
            // логин и пароль
            smtp.Credentials = new NetworkCredential("ivan.lapshin.2000@inbox.ru", "tyumnb306");
            smtp.EnableSsl = true;
            smtp.Send(m);
            Console.Read();
        }

        public DataTable GetData()
        {
            string connstr = "Server=localhost;Uid=root;Pwd=root;Database=wcf";
            using (MySqlConnection conn = new MySqlConnection(connstr))
            {
                try
                {
                    conn.Open();
                    MySqlDataAdapter adapter = new MySqlDataAdapter("select * from cursorchanges", conn);
                    DataSet ds = new DataSet();
                    adapter.Fill(ds, "item_info");
                    return ds.Tables[0];
                }
                catch (MySqlException ex)
                {
                    return null;
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        public string InsertData(string description)
        {
            string connstr = "Server=localhost;Uid=root;Pwd=root;Database=wcf";
            using (MySqlConnection conn = new MySqlConnection(connstr))
            {
                try
                {
                    conn.Open();
                    string query = $"INSERT INTO cursorchanges (DateTime, Desc) VALUES ({DateTime.Now}, {description})";
                    MySqlCommand command = new MySqlCommand(query, conn);
                    command.ExecuteNonQuery();
                    return null;
                }
                catch (MySqlException ex)
                {
                    return ex.Message.ToString();
                }
                finally
                {
                    conn.Close();
                }
            }
        }
    }
}
