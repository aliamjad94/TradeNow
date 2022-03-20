namespace TradeNow
{
    partial class loginForm
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
            this.usernameTextbox = new System.Windows.Forms.TextBox();
            this.passwordTextbox = new System.Windows.Forms.TextBox();
            this.UserName = new System.Windows.Forms.Label();
            this.PassWord = new System.Windows.Forms.Label();
            this.LoginButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // usernameTextbox
            // 
            this.usernameTextbox.Location = new System.Drawing.Point(283, 130);
            this.usernameTextbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.usernameTextbox.Name = "usernameTextbox";
            this.usernameTextbox.PlaceholderText = "User";
            this.usernameTextbox.Size = new System.Drawing.Size(253, 23);
            this.usernameTextbox.TabIndex = 1;
            this.usernameTextbox.TextChanged += new System.EventHandler(this.usernameTextbox_TextChanged);
            // 
            // passwordTextbox
            // 
            this.passwordTextbox.Location = new System.Drawing.Point(283, 175);
            this.passwordTextbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.passwordTextbox.Name = "passwordTextbox";
            this.passwordTextbox.PlaceholderText = "********";
            this.passwordTextbox.Size = new System.Drawing.Size(253, 23);
            this.passwordTextbox.TabIndex = 2;
            this.passwordTextbox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // UserName
            // 
            this.UserName.AutoSize = true;
            this.UserName.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UserName.Location = new System.Drawing.Point(176, 131);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(105, 24);
            this.UserName.TabIndex = 3;
            this.UserName.Text = "Username";
            this.UserName.Click += new System.EventHandler(this.label1_Click);
            // 
            // PassWord
            // 
            this.PassWord.AutoSize = true;
            this.PassWord.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PassWord.Location = new System.Drawing.Point(176, 175);
            this.PassWord.Name = "PassWord";
            this.PassWord.Size = new System.Drawing.Size(103, 24);
            this.PassWord.TabIndex = 4;
            this.PassWord.Text = "Password";
            // 
            // LoginButton
            // 
            this.LoginButton.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LoginButton.Location = new System.Drawing.Point(326, 229);
            this.LoginButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(117, 41);
            this.LoginButton.TabIndex = 5;
            this.LoginButton.Text = "Log-In";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(265, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 56);
            this.label1.TabIndex = 6;
            this.label1.Text = "TradeNow";
            // 
            // loginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 355);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.PassWord);
            this.Controls.Add(this.UserName);
            this.Controls.Add(this.passwordTextbox);
            this.Controls.Add(this.usernameTextbox);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "loginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox usernameTextbox;
        private System.Windows.Forms.TextBox passwordTextbox;
        private System.Windows.Forms.Label UserName;
        private System.Windows.Forms.Label PassWord;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Label label1;
    }
}
