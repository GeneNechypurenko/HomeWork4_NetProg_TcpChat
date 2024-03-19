namespace ChatApp_Client
{
    partial class ClientForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            userInfoLabel = new Label();
            exitButton = new Button();
            connectButton = new Button();
            usernameTextBox = new TextBox();
            groupBox2 = new GroupBox();
            sendButton = new Button();
            sendTextBox = new TextBox();
            groupBox3 = new GroupBox();
            usersListBox = new ListBox();
            groupBox4 = new GroupBox();
            chatTextBox = new TextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.MidnightBlue;
            groupBox1.Controls.Add(userInfoLabel);
            groupBox1.Controls.Add(exitButton);
            groupBox1.Controls.Add(connectButton);
            groupBox1.Controls.Add(usernameTextBox);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.ForeColor = Color.Ivory;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(800, 62);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "ENTER USERNAME";
            // 
            // userInfoLabel
            // 
            userInfoLabel.AutoSize = true;
            userInfoLabel.Location = new Point(6, 29);
            userInfoLabel.Name = "userInfoLabel";
            userInfoLabel.Size = new Size(148, 20);
            userInfoLabel.TabIndex = 4;
            userInfoLabel.Text = "WELCOME TO CHAT";
            // 
            // exitButton
            // 
            exitButton.FlatStyle = FlatStyle.Popup;
            exitButton.Location = new Point(741, 25);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(53, 29);
            exitButton.TabIndex = 3;
            exitButton.Text = "EXIT";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // connectButton
            // 
            connectButton.FlatStyle = FlatStyle.Popup;
            connectButton.Location = new Point(650, 25);
            connectButton.Name = "connectButton";
            connectButton.Size = new Size(94, 29);
            connectButton.TabIndex = 2;
            connectButton.Text = "CONNECT";
            connectButton.UseVisualStyleBackColor = true;
            connectButton.Click += connectButton_Click;
            // 
            // usernameTextBox
            // 
            usernameTextBox.BackColor = Color.Ivory;
            usernameTextBox.ForeColor = Color.MidnightBlue;
            usernameTextBox.Location = new Point(409, 26);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(235, 27);
            usernameTextBox.TabIndex = 1;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.MidnightBlue;
            groupBox2.Controls.Add(sendButton);
            groupBox2.Controls.Add(sendTextBox);
            groupBox2.Dock = DockStyle.Bottom;
            groupBox2.ForeColor = Color.Ivory;
            groupBox2.Location = new Point(0, 388);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(800, 62);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "SEND MESSAGE";
            // 
            // sendButton
            // 
            sendButton.FlatStyle = FlatStyle.Popup;
            sendButton.Location = new Point(700, 25);
            sendButton.Name = "sendButton";
            sendButton.Size = new Size(94, 29);
            sendButton.TabIndex = 2;
            sendButton.Text = "SEND";
            sendButton.UseVisualStyleBackColor = true;
            sendButton.Click += sendButton_Click;
            // 
            // sendTextBox
            // 
            sendTextBox.BackColor = Color.Ivory;
            sendTextBox.ForeColor = Color.MidnightBlue;
            sendTextBox.Location = new Point(6, 26);
            sendTextBox.Name = "sendTextBox";
            sendTextBox.Size = new Size(688, 27);
            sendTextBox.TabIndex = 1;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.MidnightBlue;
            groupBox3.Controls.Add(usersListBox);
            groupBox3.Dock = DockStyle.Right;
            groupBox3.ForeColor = Color.Ivory;
            groupBox3.Location = new Point(550, 62);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(250, 326);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            groupBox3.Text = "USERS:";
            // 
            // usersListBox
            // 
            usersListBox.BackColor = Color.Ivory;
            usersListBox.Dock = DockStyle.Fill;
            usersListBox.ForeColor = Color.MidnightBlue;
            usersListBox.FormattingEnabled = true;
            usersListBox.Location = new Point(3, 23);
            usersListBox.Name = "usersListBox";
            usersListBox.Size = new Size(244, 300);
            usersListBox.TabIndex = 0;
            // 
            // groupBox4
            // 
            groupBox4.BackColor = Color.MidnightBlue;
            groupBox4.Controls.Add(chatTextBox);
            groupBox4.Dock = DockStyle.Fill;
            groupBox4.ForeColor = Color.Ivory;
            groupBox4.Location = new Point(0, 62);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(550, 326);
            groupBox4.TabIndex = 5;
            groupBox4.TabStop = false;
            groupBox4.Text = "CHAT:";
            // 
            // chatTextBox
            // 
            chatTextBox.BackColor = Color.White;
            chatTextBox.Dock = DockStyle.Fill;
            chatTextBox.ForeColor = Color.Black;
            chatTextBox.Location = new Point(3, 23);
            chatTextBox.Multiline = true;
            chatTextBox.Name = "chatTextBox";
            chatTextBox.Size = new Size(544, 300);
            chatTextBox.TabIndex = 0;
            // 
            // ClientForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "ClientForm";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button connectButton;
        private TextBox usernameTextBox;
        private GroupBox groupBox2;
        private Button sendButton;
        private TextBox sendTextBox;
        private GroupBox groupBox3;
        private ListBox usersListBox;
        private GroupBox groupBox4;
        private TextBox chatTextBox;
        private Button exitButton;
        private Label userInfoLabel;
    }
}
