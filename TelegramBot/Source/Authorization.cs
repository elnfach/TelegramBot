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
                
                return;
            }
            switch (scene_id)
            {
                case 0:
                    RenderDesign.ShowSendCodePage();
                    break;
                case 1:
                    RenderDesign.ShowListBox();
                    break;
            }

        }

        public static async void buttonGetChats_Click()
        {
            if (_client.User == null)
            {
                MessageBox.Show("You must login first.");
                return;
            }
            var chats = await _client.Messages_GetAllChats();
            HistoryPage.listBox.Items.Clear();
            foreach (var chat in chats.chats.Values)
                if (chat.IsActive)
                {
                    Console.WriteLine(chat);
                    HistoryPage.listBox.Items.Add(chat);
                }
        }
    }
}
