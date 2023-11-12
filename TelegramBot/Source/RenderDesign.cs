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
        private static Form _form = null;
        private static AuthorizationPage authorizationPage = null;
        private static SendCodePage sendCodePage = null;

        public static void Init(Form form)
        {
            _form = form;
            authorizationPage = new AuthorizationPage(form);
        }

        public static void ShowSendCodePage()
        {
            authorizationPage.Hide();
            sendCodePage = new SendCodePage(_form);
        }
    }
}
