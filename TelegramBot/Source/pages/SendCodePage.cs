using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelegramBot.Source.pages
{
    internal class SendCodePage
    {
        Form _form = null;

        Panel sendCodePanel = null;
        Label code = null;
        Label password = null;
        TextBox textBoxCode = null;
        TextBox textBoxPassword = null;
        Button buttonLogin = null;

        public SendCodePage(Form form)
        {
            _form = form;
            sendCodePanel = new Panel
            {
                Visible = true,
                Anchor = System.Windows.Forms.AnchorStyles.Top,
                BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(237)))), ((int)(((byte)(231))))),
                Location = new System.Drawing.Point(115, 40),
                Name = "sendCodePanel",
                Size = new System.Drawing.Size(696, 384),
                TabIndex = 0
            };

            code = new Label
            {
                AutoSize = true,
                BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(237)))), ((int)(((byte)(231))))),
                Font = new System.Drawing.Font("Bahnschrift", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204))),
                ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(23))))),
                Location = new System.Drawing.Point(30, 100),
                Name = "code",
                Size = new System.Drawing.Size(115, 34),
                TabIndex = 2,
                Text = "Code: "
            };

            password = new Label
            {
                AutoSize = true,
                BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(237)))), ((int)(((byte)(231))))),
                Font = new System.Drawing.Font("Bahnschrift", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204))),
                ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(23))))),
                Location = new System.Drawing.Point(30, 142),
                Name = "password",
                Size = new System.Drawing.Size(115, 34),
                TabIndex = 2,
                Text = "Password: "
            };

            textBoxCode = new TextBox
            {
                BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(239))))),
                ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(23))))),
                Location = new System.Drawing.Point(150, 105),
                Name = "textBoxApiID",
                Size = new System.Drawing.Size(152, 22),
                TabIndex = 6,
                Text = null
            };
            textBoxCode.KeyPress += new KeyPressEventHandler(textBoxCode_KeyPress);

            textBoxPassword = new TextBox()
            {
                BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(239))))),
                ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(23))))),
                Location = new System.Drawing.Point(150, 147),
                Name = "textBoxPassword",
                Size = new System.Drawing.Size(152, 22),
                TabIndex = 6,
                Text = null
            };
            textBoxPassword.KeyPress += new KeyPressEventHandler(textBoxPassword_KeyPress);

            buttonLogin = new Button
            {
                BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(139)))), ((int)(((byte)(164))))),
                Anchor = AnchorStyles.Top,
                FlatStyle = FlatStyle.Flat,
                Name = "buttonLogin",
                Text = "Войти",
                Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204))),
                ForeColor = System.Drawing.Color.White,
                Location = new System.Drawing.Point(265, 300),
                Size = new System.Drawing.Size(160, 50),
                TabIndex = 0
            };
            buttonLogin.Click += new EventHandler(buttonLogin_Click);

            sendCodePanel.Controls.Add(code);
            sendCodePanel.Controls.Add(password);
            sendCodePanel.Controls.Add(textBoxCode);
            sendCodePanel.Controls.Add(textBoxPassword);
            sendCodePanel.Controls.Add(buttonLogin);

            form.Controls.Add(sendCodePanel);
        }
        public void Hide()
        {
            _form.Controls.Clear();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (textBoxCode.Text != "")
            {
                Authorization.SendCode(textBoxCode.Text);
                return;
            }
            MessageBox.Show("Заполните поля!");
        }

        private void textBoxPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void textBoxCode_KeyPress(object sender, KeyPressEventArgs e)
        {
        }
    }
}
