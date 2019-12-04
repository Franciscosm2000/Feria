namespace SistemaEmpeños
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.titleBar = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnMin = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblUsernameErrorMessage = new System.Windows.Forms.Label();
            this.lblPasswordErrorMessage = new System.Windows.Forms.Label();
            this.linkLostPassword = new System.Windows.Forms.LinkLabel();
            this.btnLogin = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.titleBar.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(197)))), ((int)(((byte)(8)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 375);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SistemaEmpeños.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(38, 60);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(173, 255);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // titleBar
            // 
            this.titleBar.Controls.Add(this.label2);
            this.titleBar.Controls.Add(this.btnClose);
            this.titleBar.Controls.Add(this.btnMin);
            this.titleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.titleBar.Location = new System.Drawing.Point(250, 0);
            this.titleBar.Name = "titleBar";
            this.titleBar.Size = new System.Drawing.Size(450, 40);
            this.titleBar.TabIndex = 1;
            this.titleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitleBar_MouseDown);
            this.titleBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TitleBar_MouseMove);
            this.titleBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TitleBar_MouseUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightGray;
            this.label2.Location = new System.Drawing.Point(3, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 33);
            this.label2.TabIndex = 4;
            this.label2.Text = "REGISTRO";
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(51)))), ((int)(((byte)(45)))));
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::SistemaEmpeños.Properties.Resources.icon_close;
            this.btnClose.Location = new System.Drawing.Point(400, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(50, 40);
            this.btnClose.TabIndex = 1;
            this.btnClose.TabStop = false;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // btnMin
            // 
            this.btnMin.FlatAppearance.BorderSize = 0;
            this.btnMin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnMin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMin.Image = global::SistemaEmpeños.Properties.Resources.icon_min;
            this.btnMin.Location = new System.Drawing.Point(349, 0);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(50, 40);
            this.btnMin.TabIndex = 0;
            this.btnMin.TabStop = false;
            this.btnMin.UseVisualStyleBackColor = true;
            this.btnMin.Click += new System.EventHandler(this.BtnMin_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblUsernameErrorMessage);
            this.panel2.Controls.Add(this.lblPasswordErrorMessage);
            this.panel2.Controls.Add(this.linkLostPassword);
            this.panel2.Controls.Add(this.btnLogin);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtPassword);
            this.panel2.Controls.Add(this.txtUsername);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(250, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(450, 335);
            this.panel2.TabIndex = 2;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // lblUsernameErrorMessage
            // 
            this.lblUsernameErrorMessage.AutoSize = true;
            this.lblUsernameErrorMessage.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsernameErrorMessage.ForeColor = System.Drawing.Color.DimGray;
            this.lblUsernameErrorMessage.Image = ((System.Drawing.Image)(resources.GetObject("lblUsernameErrorMessage.Image")));
            this.lblUsernameErrorMessage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblUsernameErrorMessage.Location = new System.Drawing.Point(41, 84);
            this.lblUsernameErrorMessage.Name = "lblUsernameErrorMessage";
            this.lblUsernameErrorMessage.Size = new System.Drawing.Size(126, 17);
            this.lblUsernameErrorMessage.TabIndex = 7;
            this.lblUsernameErrorMessage.Text = "      Mensaje de error";
            this.lblUsernameErrorMessage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblUsernameErrorMessage.Visible = false;
            // 
            // lblPasswordErrorMessage
            // 
            this.lblPasswordErrorMessage.AutoSize = true;
            this.lblPasswordErrorMessage.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasswordErrorMessage.ForeColor = System.Drawing.Color.DimGray;
            this.lblPasswordErrorMessage.Image = ((System.Drawing.Image)(resources.GetObject("lblPasswordErrorMessage.Image")));
            this.lblPasswordErrorMessage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblPasswordErrorMessage.Location = new System.Drawing.Point(41, 151);
            this.lblPasswordErrorMessage.Name = "lblPasswordErrorMessage";
            this.lblPasswordErrorMessage.Size = new System.Drawing.Size(126, 17);
            this.lblPasswordErrorMessage.TabIndex = 6;
            this.lblPasswordErrorMessage.Text = "      Mensaje de error";
            this.lblPasswordErrorMessage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblPasswordErrorMessage.Visible = false;
            // 
            // linkLostPassword
            // 
            this.linkLostPassword.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(197)))), ((int)(((byte)(8)))));
            this.linkLostPassword.AutoSize = true;
            this.linkLostPassword.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLostPassword.LinkColor = System.Drawing.Color.DimGray;
            this.linkLostPassword.Location = new System.Drawing.Point(133, 263);
            this.linkLostPassword.Name = "linkLostPassword";
            this.linkLostPassword.Size = new System.Drawing.Size(181, 17);
            this.linkLostPassword.TabIndex = 1;
            this.linkLostPassword.TabStop = true;
            this.linkLostPassword.Text = "¿Ha olvidado su contraseña?";
            this.linkLostPassword.VisitedLinkColor = System.Drawing.Color.DimGray;
            this.linkLostPassword.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLostPassword_LinkClicked);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(30)))), ((int)(((byte)(31)))));
            this.btnLogin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(197)))), ((int)(((byte)(8)))));
            this.btnLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(170)))), ((int)(((byte)(23)))));
            this.btnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(197)))), ((int)(((byte)(8)))));
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(197)))), ((int)(((byte)(8)))));
            this.btnLogin.Image = global::SistemaEmpeños.Properties.Resources.icon_login;
            this.btnLogin.Location = new System.Drawing.Point(44, 186);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(355, 40);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "ACCEDER";
            this.btnLogin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            this.btnLogin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BtnLogin_KeyDown);
            this.btnLogin.KeyUp += new System.Windows.Forms.KeyEventHandler(this.BtnLogin_KeyUp);
            this.btnLogin.MouseEnter += new System.EventHandler(this.BtnLogin_MouseEnter);
            this.btnLogin.MouseLeave += new System.EventHandler(this.BtnLogin_MouseLeave);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(41, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(358, 1);
            this.label3.TabIndex = 5;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(30)))), ((int)(((byte)(31)))));
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.DimGray;
            this.txtPassword.Location = new System.Drawing.Point(44, 119);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(355, 19);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.Text = "CONTRASEÑA";
            this.txtPassword.Enter += new System.EventHandler(this.TxtPassword_Enter);
            this.txtPassword.Leave += new System.EventHandler(this.TxtPassword_Leave);
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(30)))), ((int)(((byte)(31)))));
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsername.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.ForeColor = System.Drawing.Color.DimGray;
            this.txtUsername.Location = new System.Drawing.Point(44, 52);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(355, 19);
            this.txtUsername.TabIndex = 2;
            this.txtUsername.Text = "USUARIO";
            this.txtUsername.Enter += new System.EventHandler(this.TxtUsername_Enter);
            this.txtUsername.Leave += new System.EventHandler(this.TxtUsername_Leave);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(41, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(358, 1);
            this.label1.TabIndex = 2;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(30)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(700, 375);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.titleBar);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmLogin";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.titleBar.ResumeLayout(false);
            this.titleBar.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel titleBar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.LinkLabel linkLostPassword;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblPasswordErrorMessage;
        private System.Windows.Forms.Label lblUsernameErrorMessage;
    }
}