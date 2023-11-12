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
        private static HistoryPage historyPage = null;

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

        public static void ShowListBox()
        {
            sendCodePage.Hide();
            historyPage = new HistoryPage(_form);
        }
    }
}
