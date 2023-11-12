using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WTelegram;

namespace TelegramBot.Source.pages
{
    internal class HistoryPage
    {
        public static ListBox listBox = null;

        public HistoryPage(Form form)
        {
            listBox = new ListBox()
            {
                FormattingEnabled = true,
                ItemHeight = 16,
                Location = new System.Drawing.Point(210, 45),
                Name = "listBox1",
                Size = new System.Drawing.Size(636, 436),
                TabIndex = 0,
            };

            form.Controls.Add(listBox);
            Authorization.buttonGetChats_Click();
        }
    }
}
