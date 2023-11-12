using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TL;

namespace TelegramBot.Source
{
    internal static class Authorization
    {
        private static WTelegram.Client _client;
        public static async void Auth(string phone, string apiID, string apiHash)
        {
            _client = new WTelegram.Client(int.Parse(apiID), apiHash);
            await DoLogin(phone);
        }

        private static async Task DoLogin(string loginInfo)
        {
            string what = await _client.Login(loginInfo);
            if (what != null)
            {
                RenderDesign.ShowButtonSendCode();
                return;
            }
        }
    }
}
