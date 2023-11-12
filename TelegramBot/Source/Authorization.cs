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
        //private static WTelegram.Client _client;
        public static async void Auth(string phone, string apiID, string apiHash)
        {
            //var _client = new WTelegram.Client(int.Parse("1130467807"), "f8525cb37c1763aa6f5040c9e760783c");
            var _client = new WTelegram.Client(int.Parse(Console.ReadLine()), "f8525cb37c1763aa6f5040c9e760783c");
            string what = await _client.Login(Console.ReadLine());
            /*var client = new WTelegram.Client();
            var myself = await client.LoginUserIfNeeded();*/
            //Console.WriteLine($"We are logged-in as {myself} (id {myself.id})");
            string vendcode = await _client.Login(Console.ReadLine());
            //await DoLogin(phone);
        }

        private static async Task DoLogin(string loginInfo)
        {
            //string what = await _client.Login(loginInfo);
            /*if (what != null)
            {
                RenderDesign.ShowButtonSendCode();
                return;
            }*/
        }
    }
}
