using EmailApplication.Models;
using EmailApplication.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmailApplication.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmailController : Controller
    {
        private IEmailService _emailService;
        public EmailController(IEmailService emailService) 
        { 
               _emailService = emailService;
        }
        [HttpPost]
        public async Task<IActionResult> SendAsync([FromBody] MessageDetails messageDetails)
        {
            var message = new Message(new string[] { messageDetails.To }, messageDetails.Subject, messageDetails.Body);
            _emailService.SendMail(message);
            return StatusCode(StatusCodes.Status200OK, new Response { Status = "Status", Message = "Email Sent SuccessFully" });
        }
    }
   
}
