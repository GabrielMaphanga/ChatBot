using System;
using Telegram.Bot;
using Telegram.Bot.Args;

namespace ChatBot
{
    class Program
    {
        static readonly TelegramBotClient bot = new TelegramBotClient("1063168687:AAEqGK3Hqdmltv1RVj8x_JtjSjnFA8eSqxs");
        static void Main(string[] args)
        {
            bot.IsReceiving = true;

            bot.OnMessage += Botmessage;
            bot.StartReceiving();
            Console.ReadLine();
            bot.StopReceiving();


        }
        private static void Botmessage(object sender, MessageEventArgs e)
        {
            if (e.Message.Type == Telegram.Bot.Types.Enums.MessageType.Text)
                PrepareQuestionnaires(e);

        }
        public static void PrepareQuestionnaires(MessageEventArgs e)
        {
            if (e.Message.Text.ToLower() == "hi")
                bot.SendTextMessageAsync(e.Message.Chat.Id, "hello dude" + Environment.NewLine + "Whats happening ?");
            if (e.Message.Text.ToLower().Contains("nothing much"))
                bot.SendTextMessageAsync(e.Message.Chat.Id, "alright man" + Environment.NewLine + "enjoy you chill time" + Environment.NewLine + "If you need something let me know !!");
            else
                bot.SendTextMessageAsync(e.Message.Chat.Id, "This bot is under development");
        }
    }
}
