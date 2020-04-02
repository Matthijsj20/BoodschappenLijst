using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Windows.Forms;

namespace Boodschappen_lijst
{
    class Mail
    {
        public int Sendmail(string username, string password,string destination, Form1 f1, string notes)
        {
            DateTime thisDay = DateTime.Today.Date;
            string msg = "";
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress(username);
                mail.To.Add(destination);
                mail.Subject = "Boodschappenlijst van " + username + " " + thisDay.ToString("dd/MM/yyyy");
                
                for(int i =0; i< f1.boodschappenLijst.Count(); i++)
                {
                    msg += f1.boodschappenLijst[i].Amount + "   |   " + f1.boodschappenLijst[i].Item + "\n";
                }
                mail.Body = "Opmerkingen: " + notes + "\n\n" + msg;
                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential(username, password);
                SmtpServer.EnableSsl = true;
                SmtpServer.Send(mail);
                return 1;
            }
            catch (Exception e)
            {
                MessageBox.Show("Er is iets verkeerd gegaan met het sturen van de mail. Controleer inlog gegevens. \n\nError: \n" + e.ToString());
                return 0;
            }
        }
    }
}
