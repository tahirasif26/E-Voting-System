
namespace AdminPanel
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.ButtonRegister = new Bunifu.Framework.UI.BunifuThinButton2();
            this.ButtonExit = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Checkbox1 = new Bunifu.Framework.UI.BunifuCheckbox();
            this.ButtonLogin = new Bunifu.Framework.UI.BunifuThinButton2();
            this.TextboxPassword = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.TextboxUsername = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.ButtonRegister);
            this.panel1.Controls.Add(this.ButtonExit);
            this.panel1.Controls.Add(this.bunifuCustomLabel1);
            this.panel1.Controls.Add(this.Checkbox1);
            this.panel1.Controls.Add(this.ButtonLogin);
            this.panel1.Controls.Add(this.TextboxPassword);
            this.panel1.Controls.Add(this.TextboxUsername);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(45, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(582, 376);
            this.panel1.TabIndex = 0;
            // 
            // ButtonRegister
            // 
            this.ButtonRegister.ActiveBorderThickness = 1;
            this.ButtonRegister.ActiveCornerRadius = 20;
            this.ButtonRegister.ActiveFillColor = System.Drawing.Color.RoyalBlue;
            this.ButtonRegister.ActiveForecolor = System.Drawing.SystemColors.MenuHighlight;
            this.ButtonRegister.ActiveLineColor = System.Drawing.SystemColors.MenuHighlight;
            this.ButtonRegister.BackColor = System.Drawing.Color.White;
            this.ButtonRegister.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonRegister.BackgroundImage")));
            this.ButtonRegister.ButtonText = "Register";
            this.ButtonRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonRegister.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonRegister.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.ButtonRegister.IdleBorderThickness = 1;
            this.ButtonRegister.IdleCornerRadius = 20;
            this.ButtonRegister.IdleFillColor = System.Drawing.SystemColors.MenuHighlight;
            this.ButtonRegister.IdleForecolor = System.Drawing.Color.White;
            this.ButtonRegister.IdleLineColor = System.Drawing.SystemColors.Highlight;
            this.ButtonRegister.Location = new System.Drawing.Point(100, 301);
            this.ButtonRegister.Margin = new System.Windows.Forms.Padding(5);
            this.ButtonRegister.Name = "ButtonRegister";
            this.ButtonRegister.Size = new System.Drawing.Size(181, 41);
            this.ButtonRegister.TabIndex = 14;
            this.ButtonRegister.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ButtonRegister.Click += new System.EventHandler(this.ButtonRegister_Click);
            // 
            // ButtonExit
            // 
            this.ButtonExit.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ButtonExit.Image = ((System.Drawing.Image)(resources.GetObject("ButtonExit.Image")));
            this.ButtonExit.ImageActive = null;
            this.ButtonExit.Location = new System.Drawing.Point(494, 271);
            this.ButtonExit.Name = "ButtonExit";
            this.ButtonExit.Size = new System.Drawing.Size(71, 71);
            this.ButtonExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ButtonExit.TabIndex = 12;
            this.ButtonExit.TabStop = false;
            this.ButtonExit.Zoom = 10;
            this.ButtonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(147, 271);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(104, 16);
            this.bunifuCustomLabel1.TabIndex = 11;
            this.bunifuCustomLabel1.Text = "Show Password";
            this.bunifuCustomLabel1.Click += new System.EventHandler(this.bunifuCustomLabel1_Click);
            // 
            // Checkbox1
            // 
            this.Checkbox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.Checkbox1.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.Checkbox1.Checked = false;
            this.Checkbox1.CheckedOnColor = System.Drawing.SystemColors.MenuHighlight;
            this.Checkbox1.Enabled = false;
            this.Checkbox1.ForeColor = System.Drawing.Color.White;
            this.Checkbox1.Location = new System.Drawing.Point(121, 267);
            this.Checkbox1.Name = "Checkbox1";
            this.Checkbox1.Size = new System.Drawing.Size(20, 20);
            this.Checkbox1.TabIndex = 10;
            this.Checkbox1.OnChange += new System.EventHandler(this.bunifuCheckbox1_OnChange);
            this.Checkbox1.Enter += new System.EventHandler(this.chechbox);
            // 
            // ButtonLogin
            // 
            this.ButtonLogin.ActiveBorderThickness = 1;
            this.ButtonLogin.ActiveCornerRadius = 20;
            this.ButtonLogin.ActiveFillColor = System.Drawing.Color.SteelBlue;
            this.ButtonLogin.ActiveForecolor = System.Drawing.SystemColors.MenuHighlight;
            this.ButtonLogin.ActiveLineColor = System.Drawing.SystemColors.MenuHighlight;
            this.ButtonLogin.BackColor = System.Drawing.Color.White;
            this.ButtonLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonLogin.BackgroundImage")));
            this.ButtonLogin.ButtonText = "Login";
            this.ButtonLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonLogin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonLogin.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.ButtonLogin.IdleBorderThickness = 1;
            this.ButtonLogin.IdleCornerRadius = 20;
            this.ButtonLogin.IdleFillColor = System.Drawing.SystemColors.MenuHighlight;
            this.ButtonLogin.IdleForecolor = System.Drawing.Color.White;
            this.ButtonLogin.IdleLineColor = System.Drawing.SystemColors.Highlight;
            this.ButtonLogin.Location = new System.Drawing.Point(291, 301);
            this.ButtonLogin.Margin = new System.Windows.Forms.Padding(5);
            this.ButtonLogin.Name = "ButtonLogin";
            this.ButtonLogin.Size = new System.Drawing.Size(181, 41);
            this.ButtonLogin.TabIndex = 9;
            this.ButtonLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ButtonLogin.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            this.ButtonLogin.Enter += new System.EventHandler(this.txtUserEnter);
            this.ButtonLogin.Leave += new System.EventHandler(this.txtUserLeave);
            // 
            // TextboxPassword
            // 
            this.TextboxPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextboxPassword.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TextboxPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TextboxPassword.HintForeColor = System.Drawing.Color.Empty;
            this.TextboxPassword.HintText = "";
            this.TextboxPassword.isPassword = true;
            this.TextboxPassword.LineFocusedColor = System.Drawing.Color.Blue;
            this.TextboxPassword.LineIdleColor = System.Drawing.Color.Gray;
            this.TextboxPassword.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.TextboxPassword.LineThickness = 3;
            this.TextboxPassword.Location = new System.Drawing.Point(102, 215);
            this.TextboxPassword.Margin = new System.Windows.Forms.Padding(4);
            this.TextboxPassword.Name = "TextboxPassword";
            this.TextboxPassword.Size = new System.Drawing.Size(370, 44);
            this.TextboxPassword.TabIndex = 7;
            this.TextboxPassword.Text = "Password";
            this.TextboxPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextboxPassword.Enter += new System.EventHandler(this.txtPassEnter);
            this.TextboxPassword.Leave += new System.EventHandler(this.txtPassLeave);
            // 
            // TextboxUsername
            // 
            this.TextboxUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextboxUsername.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TextboxUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TextboxUsername.HintForeColor = System.Drawing.Color.Empty;
            this.TextboxUsername.HintText = "";
            this.TextboxUsername.isPassword = false;
            this.TextboxUsername.LineFocusedColor = System.Drawing.Color.Blue;
            this.TextboxUsername.LineIdleColor = System.Drawing.Color.Gray;
            this.TextboxUsername.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.TextboxUsername.LineThickness = 3;
            this.TextboxUsername.Location = new System.Drawing.Point(102, 149);
            this.TextboxUsername.Margin = new System.Windows.Forms.Padding(4);
            this.TextboxUsername.Name = "TextboxUsername";
            this.TextboxUsername.Size = new System.Drawing.Size(370, 44);
            this.TextboxUsername.TabIndex = 3;
            this.TextboxUsername.Text = "Username";
            this.TextboxUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextboxUsername.Enter += new System.EventHandler(this.TextboxUsername_Enter);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(196, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(181, 110);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel2.Location = new System.Drawing.Point(2, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(680, 153);
            this.panel2.TabIndex = 0;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 432);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(30, 80);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuThinButton2 ButtonLogin;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TextboxPassword;
        private Bunifu.Framework.UI.BunifuMaterialTextbox TextboxUsername;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCheckbox Checkbox1;
        private Bunifu.Framework.UI.BunifuImageButton ButtonExit;
        private Bunifu.Framework.UI.BunifuThinButton2 ButtonRegister;
    }
}

