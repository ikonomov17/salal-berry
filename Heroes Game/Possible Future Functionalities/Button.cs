namespace Main_Program
{
    using System;
    using System.Windows.Forms;
    using System.Net.Mail;

    public class Button
    {
        private void button_Click(object sender, EventArgs e)
        {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress("gameDev@gmail.com");
                mail.To.Add("to_address");
                mail.Subject = "More competitions ahead";
                mail.Body = @"Congrats!
                            Your great performance give you the chance
                            to compete in our future multiplayer tournaments.";

                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential("username", "password");
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);
                MessageBox.Show("mail Send");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }            
        }
    }
}