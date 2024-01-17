using EmailApplication.Models;
using MimeKit;

namespace EmailApplication.Services
{
    public interface IEmailService
    {
        void SendMail(Message message);
    }
}
