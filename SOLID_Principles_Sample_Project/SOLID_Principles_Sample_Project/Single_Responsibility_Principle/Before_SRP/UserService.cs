using System.ComponentModel.DataAnnotations;
using System.Net.Mail;

namespace SOLID_Principles_Sample_Project.Single_Responsibility_Principle.Before_SRP
{
    public class UserService
    {
        SmtpClient _smtpClient = new SmtpClient();

        public void Register(string email, string password)
        {
            if (!ValidateEmail(email))
                throw new ValidationException("Email is not an email");

            // Save user to database code here

            SendEmail(new MailMessage("sample@gmail.com", email) { Subject = "User Registerd" });
        }

        public virtual bool ValidateEmail(string email)
        {
            return email.Contains("@");
        }

        public void SendEmail(MailMessage message)
        {
            _smtpClient.Send(message);
        }
    }
}
