using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Telegram.Bot.Args;

namespace PolicyRobot.Services
{
    public class MessageService: IMessageService
    {
        private readonly IBotService _botService;
        public MessageService(IBotService botService)
        {
            _botService = botService;
        }
        public void StartListen()
        {
            _botService.Client.OnMessage += Bot_OnMessage;
            _botService.Client.StartReceiving();
            Thread.Sleep(int.MaxValue);
        }

        private async void Bot_OnMessage(object sender, MessageEventArgs e)
        {
            if (e.Message.Text != null)
            {
                Console.WriteLine($"Received a text message in chat {e.Message.Chat.Id}.");

                await _botService.Client.SendTextMessageAsync(
                   chatId: e.Message.Chat,
                   text: "You said:\n" + e.Message.Text
                 );
            }
        }
    }

    public interface IMessageService
    {
        void StartListen();
    }
}
