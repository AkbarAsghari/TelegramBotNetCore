using Microsoft.Extensions.Options;
using PolicyRobot.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Telegram.Bot;

namespace PolicyRobot.Services
{
    public class MessageService
    {
        static ITelegramBotClient botClient;
        public MessageService(IOptions<ConfigureModel> options)
        {
            botClient = new TelegramBotClient(options.Value.AccessToken);
        }

    }
}
