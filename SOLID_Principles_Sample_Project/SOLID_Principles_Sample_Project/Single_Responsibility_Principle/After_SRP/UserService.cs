using System.ComponentModel.DataAnnotations;
using System.Net.Mail;

namespace SOLID_Principles_Sample_Project.Single_Responsibility_Principle.After_SRP
{
    public class UserService
    {
        EmailService _emailService;

        public UserService(EmailService emailService)
        {
            _emailService = emailService;
        }
        public void Register(string email, string password)
        {
            if (!_emailService.ValidateEmail(email))
                throw new ValidationException("Email is not an email");

            // Save user to database code here

            _emailService.SendEmail(new MailMessage("sample@gmail.com", email) { Subject = "User Registered" });

        }
    }
}
