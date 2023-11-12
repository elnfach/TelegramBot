using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TelegramBot.Source.pages;
using TL;

namespace TelegramBot.Source
{
    internal static class Authorization
    {
        private static WTelegram.Client _client;
        public static async void Auth(string phone, string apiID, string apiHash)
        {
            _client = new WTelegram.Client(int.Parse(apiID), apiHash);
            await DoLogin(phone, 0);
        }

        public static async void SendCode(string code)
        {
            await DoLogin(code, 1);
        }

        public static void Close()
        {
            _client?.Dispose();
            Properties.Settings.Default.Save();
        }

        private static async Task DoLogin(string loginInfo, int scene_id)
        {
            string what = await _client.Login(loginInfo);
            if (what != null)
            {
                RenderDesign.ShowSendCodePage();
                return;
            }

            RenderDesign.ShowListBox();
        }

        public static async void buttonGetChats_Click()
        {
            if (_client.User == null)
            {
                MessageBox.Show("You must login first.");
                return;
            }
            var chats = await _client.Messages_GetAllDialogs();
            HistoryPage.listBox.Items.Clear();

            long chatId = long.Parse(Console.ReadLine());

            InputPeer peer = chats.users[chatId];
            for (int offset_id = 0; ;)
            {
                var messages = await _client.Messages_GetHistory(peer, offset_id);
                if (messages.Messages.Length == 0) break;
                foreach (var msgBase in messages.Messages)
                {
                    var from = messages.UserOrChat(msgBase.From ?? msgBase.Peer);

                    if ( msgBase is TL.Message msg)
                    {
                        Console.WriteLine($"{from}> {msg.message} {msg.media} {msg.date} UTC");
                        HistoryPage.listBox.Items.Add($"{from}> {msg.message} {msg.media} {msg.date} UTC");
                    }
                }
            }
        }
    }
}
