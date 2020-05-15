using Microsoft.Extensions.Options;
using PolicyRobot.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Telegram.Bot;

namespace PolicyRobot.Services
{
    public class BotService : IBotService
    {
        public TelegramBotClient Client { get; }

        public BotService(IOptions<BotConfigureModel> options)
        {
            Client = new TelegramBotClient(options.Value.AccessToken);
        }
    }

    public interface IBotService
    {
        TelegramBotClient Client { get; }
    }
}
