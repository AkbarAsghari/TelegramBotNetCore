using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PolicyRobot.Services;

namespace PolicyRobot.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class BotMessageController : ControllerBase
    {
        private readonly IMessageService _messageService;
        public BotMessageController(IMessageService messageService)
        {
            _messageService = messageService;
        }

        public IActionResult Start()
        {
            Task.Factory.StartNew(() => _messageService.StartListen());
            return Ok();
        }
    }
}