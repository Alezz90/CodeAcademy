
using AcademyCode.DAL.Model;
using System;  
using System.Net;  
using System.Net.Mail;  
namespace AcademyCode.Helper
{
    public class EmailSend
    {
        private readonly IConfiguration _configuration;

        public EmailSend(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        //MailKit
        public bool EmailSending(EmaiL emaiL)
        {
            bool status = false;

            try
            {
                string HostAddress = _configuration["EmailSettings:Host"];
                string FormEmailId = _configuration["EmailSettings:MailFrom"];
                string Password = _configuration["EmailSettings:Password"];
                string Port = _configuration["EmailSettings:Port"];

                // ... rest of your code ...

                return status;
            }
            catch (Exception e)
            {
                // Handle the exception gracefully (log or provide more detailed information)
                return status;
            }
        }
    }
}