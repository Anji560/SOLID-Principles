using System.Net.Mail;

namespace SOLID_Principles_Sample_Project.Single_Responsibility_Principle.After_SRP
{
    public class EmailService
    {
        SmtpClient _smtpClient;

        public EmailService(SmtpClient smtpClient)
        {
            _smtpClient = smtpClient;
        }

        public bool ValidateEmail(string email)
        {
            return email.Contains("@");
        }

        public void SendEmail(MailMessage message)
        {
            _smtpClient.Send(message);
        }
    }
}
