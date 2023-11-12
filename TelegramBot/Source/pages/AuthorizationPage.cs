using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelegramBot.Source.pages
{
    internal class AuthorizationPage
    {
        Panel authorizationPanel = null;
        Label apiID = null;
        Label apiHash = null;
        Label phone = null;
        TextBox textBoxApiID = null;
        TextBox textBoxApiHash = null;
        TextBox textBoxPhone = null;
        Button buttonLogin = null;

        public AuthorizationPage(Form form)
        {
            authorizationPanel = new Panel
            {
                Visible = true,
                Anchor = System.Windows.Forms.AnchorStyles.Top,
                BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(237)))), ((int)(((byte)(231))))),
                Location = new System.Drawing.Point(115, 40),
                Name = "authorizationPanel",
                Size = new System.Drawing.Size(696, 384),
                TabIndex = 0
            };

            apiID = new Label
            {
                AutoSize = true,
                BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(237)))), ((int)(((byte)(231))))),
                Font = new System.Drawing.Font("Bahnschrift", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204))),
                ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(23))))),
                Location = new System.Drawing.Point(30, 100),
                Name = "apiID",
                Size = new System.Drawing.Size(115, 34),
                TabIndex = 2,
                Text = "API ID: "
            };

            apiHash = new Label
            {
                AutoSize = true,
                BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(237)))), ((int)(((byte)(231))))),
                Font = new System.Drawing.Font("Bahnschrift", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204))),
                ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(23))))),
                Location = new System.Drawing.Point(30, 142),
                Name = "apiHash",
                Size = new System.Drawing.Size(115, 34),
                TabIndex = 2,
                Text = "API Hash: "
            };

            phone = new Label
            {
                AutoSize = true,
                BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(237)))), ((int)(((byte)(231))))),
                Font = new System.Drawing.Font("Bahnschrift", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204))),
                ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(23))))),
                Location = new System.Drawing.Point(30, 184),
                Name = "phone",
                Size = new System.Drawing.Size(115, 34),
                TabIndex = 2,
                Text = "Phone: "
            };

            textBoxApiID = new TextBox
            {
                BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(239))))),
                ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(23))))),
                Location = new System.Drawing.Point(150, 105),
                Name = "textBoxApiID",
                Size = new System.Drawing.Size(152, 22),
                TabIndex = 6,
                Text = null
            };
            textBoxApiID.KeyPress += new KeyPressEventHandler(textBoxApiID_KeyPress);

            textBoxApiHash = new TextBox()
            {
                BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(239))))),
                ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(23))))),
                Location = new System.Drawing.Point(150, 147),
                Name = "textBoxApiHash",
                Size = new System.Drawing.Size(152, 22),
                TabIndex = 6,
                Text = null
            };
            textBoxApiHash.KeyPress += new KeyPressEventHandler(textBoxApiHash_KeyPress);

            textBoxPhone = new TextBox()
            {
                BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(239))))),
                ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(23))))),
                Location = new System.Drawing.Point(150, 189),
                Name = "textBoxPhone",
                Size = new System.Drawing.Size(152, 22),
                TabIndex = 6,
                Text = null
            };
            textBoxPhone.KeyPress += new KeyPressEventHandler(textBoxPhone_KeyPress);

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

            authorizationPanel.Controls.Add(apiID);
            authorizationPanel.Controls.Add(apiHash);
            authorizationPanel.Controls.Add(phone);
            authorizationPanel.Controls.Add(textBoxApiHash);
            authorizationPanel.Controls.Add(textBoxApiID);
            authorizationPanel.Controls.Add(textBoxPhone);
            authorizationPanel.Controls.Add(buttonLogin);

            form.Controls.Add(authorizationPanel);
        }

        private void textBoxPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            /*char number = e.KeyChar;

            if (!Char.IsDigit(number) && number != 8 && number != 43)
            {
                e.Handled = true;
            }*/
        }

        private void textBoxApiHash_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void textBoxApiID_KeyPress(object sender, KeyPressEventArgs e)
        {
            /*char number = e.KeyChar;

            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }*/
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (textBoxApiID.Text != "" && textBoxApiHash.Text != "" && textBoxPhone.Text != "")
            {
                Authorization.Auth(textBoxPhone.Text, textBoxApiID.Text, textBoxApiHash.Text);
                return;
            }
            MessageBox.Show("Заполните поля!");
        }
    }
}
