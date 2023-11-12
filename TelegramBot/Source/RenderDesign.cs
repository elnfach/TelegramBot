using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TelegramBot.Source.pages;

namespace TelegramBot.Source
{
    internal static class RenderDesign
    {
        private static AuthorizationPage authorizationPage = null;

        public static void Init(Form form)
        {
            authorizationPage = new AuthorizationPage(form);
        }

        public static void ShowButtonSendCode()
        {

        }
    }
}
