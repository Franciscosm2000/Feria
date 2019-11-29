namespace SistemaEmpeños
{
    partial class FrmMain
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.mainContainer = new System.Windows.Forms.Panel();
            this.footerBar = new System.Windows.Forms.Panel();
            this.windowsContainer = new System.Windows.Forms.Panel();
            this.menuSideBar = new System.Windows.Forms.Panel();
            this.titleBar = new System.Windows.Forms.Panel();
            this.tmHideMenu = new System.Windows.Forms.Timer(this.components);
            this.tmShowMenu = new System.Windows.Forms.Timer(this.components);
            this.btnResize = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSideMenu = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.btnPawns = new System.Windows.Forms.Button();
            this.btnEmployees = new System.Windows.Forms.Button();
            this.btnClients = new System.Windows.Forms.Button();
            this.btnStore = new System.Windows.Forms.Button();
            this.btnMax = new System.Windows.Forms.Button();
            this.btnMin = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnRes = new System.Windows.Forms.Button();
            this.mainContainer.SuspendLayout();
            this.footerBar.SuspendLayout();
            this.windowsContainer.SuspendLayout();
            this.menuSideBar.SuspendLayout();
            this.titleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // mainContainer
            // 
            this.mainContainer.Controls.Add(this.footerBar);
            this.mainContainer.Controls.Add(this.windowsContainer);
            this.mainContainer.Controls.Add(this.menuSideBar);
            this.mainContainer.Controls.Add(this.titleBar);
            this.mainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainContainer.Location = new System.Drawing.Point(0, 0);
            this.mainContainer.Name = "mainContainer";
            this.mainContainer.Size = new System.Drawing.Size(1284, 611);
            this.mainContainer.TabIndex = 0;
            // 
            // footerBar
            // 
            this.footerBar.BackColor = System.Drawing.SystemColors.Control;
            this.footerBar.Controls.Add(this.btnResize);
            this.footerBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.footerBar.Location = new System.Drawing.Point(250, 595);
            this.footerBar.Name = "footerBar";
            this.footerBar.Size = new System.Drawing.Size(1034, 16);
            this.footerBar.TabIndex = 3;
            // 
            // windowsContainer
            // 
            this.windowsContainer.Controls.Add(this.pictureBox1);
            this.windowsContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.windowsContainer.Location = new System.Drawing.Point(250, 40);
            this.windowsContainer.Name = "windowsContainer";
            this.windowsContainer.Size = new System.Drawing.Size(1034, 571);
            this.windowsContainer.TabIndex = 2;
            // 
            // menuSideBar
            // 
            this.menuSideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(197)))), ((int)(((byte)(8)))));
            this.menuSideBar.Controls.Add(this.btnSideMenu);
            this.menuSideBar.Controls.Add(this.btnReports);
            this.menuSideBar.Controls.Add(this.btnPawns);
            this.menuSideBar.Controls.Add(this.btnEmployees);
            this.menuSideBar.Controls.Add(this.btnClients);
            this.menuSideBar.Controls.Add(this.btnStore);
            this.menuSideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuSideBar.Location = new System.Drawing.Point(0, 40);
            this.menuSideBar.Name = "menuSideBar";
            this.menuSideBar.Size = new System.Drawing.Size(250, 571);
            this.menuSideBar.TabIndex = 1;
            // 
            // titleBar
            // 
            this.titleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(30)))), ((int)(((byte)(31)))));
            this.titleBar.Controls.Add(this.btnMax);
            this.titleBar.Controls.Add(this.btnMin);
            this.titleBar.Controls.Add(this.btnClose);
            this.titleBar.Controls.Add(this.btnRes);
            this.titleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.titleBar.Location = new System.Drawing.Point(0, 0);
            this.titleBar.Name = "titleBar";
            this.titleBar.Size = new System.Drawing.Size(1284, 40);
            this.titleBar.TabIndex = 0;
            this.titleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitleBar_MouseDown);
            this.titleBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TitleBar_MouseMove);
            this.titleBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TitleBar_MouseUp);
            // 
            // tmHideMenu
            // 
            this.tmHideMenu.Interval = 1;
            this.tmHideMenu.Tick += new System.EventHandler(this.TmHideMenu_Tick);
            // 
            // tmShowMenu
            // 
            this.tmShowMenu.Interval = 1;
            this.tmShowMenu.Tick += new System.EventHandler(this.TmShowMenu_Tick);
            // 
            // btnResize
            // 
            this.btnResize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnResize.Cursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.btnResize.FlatAppearance.BorderSize = 0;
            this.btnResize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResize.Image = global::SistemaEmpeños.Properties.Resources.icon_resize;
            this.btnResize.Location = new System.Drawing.Point(1018, 0);
            this.btnResize.Name = "btnResize";
            this.btnResize.Size = new System.Drawing.Size(16, 16);
            this.btnResize.TabIndex = 1;
            this.btnResize.TabStop = false;
            this.btnResize.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::SistemaEmpeños.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1034, 571);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnSideMenu
            // 
            this.btnSideMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSideMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSideMenu.FlatAppearance.BorderSize = 0;
            this.btnSideMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(170)))), ((int)(((byte)(23)))));
            this.btnSideMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSideMenu.Image = global::SistemaEmpeños.Properties.Resources.icon_menu;
            this.btnSideMenu.Location = new System.Drawing.Point(190, 0);
            this.btnSideMenu.Name = "btnSideMenu";
            this.btnSideMenu.Size = new System.Drawing.Size(60, 40);
            this.btnSideMenu.TabIndex = 1;
            this.btnSideMenu.UseVisualStyleBackColor = true;
            this.btnSideMenu.Click += new System.EventHandler(this.BtnSideMenu_Click);
            // 
            // btnReports
            // 
            this.btnReports.FlatAppearance.BorderSize = 0;
            this.btnReports.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnReports.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(30)))), ((int)(((byte)(31)))));
            this.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReports.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReports.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(30)))), ((int)(((byte)(31)))));
            this.btnReports.Image = global::SistemaEmpeños.Properties.Resources.icon_reports;
            this.btnReports.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReports.Location = new System.Drawing.Point(0, 276);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(250, 40);
            this.btnReports.TabIndex = 6;
            this.btnReports.Text = "REPORTES";
            this.btnReports.UseVisualStyleBackColor = true;
            this.btnReports.Click += new System.EventHandler(this.BtnReports_Click);
            this.btnReports.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BtnReports_KeyDown);
            this.btnReports.KeyUp += new System.Windows.Forms.KeyEventHandler(this.BtnReports_KeyUp);
            this.btnReports.MouseEnter += new System.EventHandler(this.BtnReports_MouseEnter);
            this.btnReports.MouseLeave += new System.EventHandler(this.BtnReports_MouseLeave);
            // 
            // btnPawns
            // 
            this.btnPawns.FlatAppearance.BorderSize = 0;
            this.btnPawns.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnPawns.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(30)))), ((int)(((byte)(31)))));
            this.btnPawns.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPawns.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPawns.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(30)))), ((int)(((byte)(31)))));
            this.btnPawns.Image = ((System.Drawing.Image)(resources.GetObject("btnPawns.Image")));
            this.btnPawns.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPawns.Location = new System.Drawing.Point(0, 92);
            this.btnPawns.Name = "btnPawns";
            this.btnPawns.Size = new System.Drawing.Size(250, 40);
            this.btnPawns.TabIndex = 2;
            this.btnPawns.Text = "PRÉSTAMOS";
            this.btnPawns.UseVisualStyleBackColor = true;
            this.btnPawns.Click += new System.EventHandler(this.BtnPawns_Click);
            this.btnPawns.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BtnPawns_KeyDown);
            this.btnPawns.KeyUp += new System.Windows.Forms.KeyEventHandler(this.BtnPawns_KeyUp);
            this.btnPawns.MouseEnter += new System.EventHandler(this.BtnPawns_MouseEnter);
            this.btnPawns.MouseLeave += new System.EventHandler(this.BtnPawns_MouseLeave);
            // 
            // btnEmployees
            // 
            this.btnEmployees.FlatAppearance.BorderSize = 0;
            this.btnEmployees.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnEmployees.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(30)))), ((int)(((byte)(31)))));
            this.btnEmployees.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmployees.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployees.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(30)))), ((int)(((byte)(31)))));
            this.btnEmployees.Image = global::SistemaEmpeños.Properties.Resources.icon_employees;
            this.btnEmployees.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmployees.Location = new System.Drawing.Point(0, 230);
            this.btnEmployees.Name = "btnEmployees";
            this.btnEmployees.Size = new System.Drawing.Size(250, 40);
            this.btnEmployees.TabIndex = 5;
            this.btnEmployees.Text = "EMPLEADOS";
            this.btnEmployees.UseVisualStyleBackColor = true;
            this.btnEmployees.Click += new System.EventHandler(this.BtnEmployees_Click);
            this.btnEmployees.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BtnEmployees_KeyDown);
            this.btnEmployees.KeyUp += new System.Windows.Forms.KeyEventHandler(this.BtnEmployees_KeyUp);
            this.btnEmployees.MouseEnter += new System.EventHandler(this.BtnEmployees_MouseEnter);
            this.btnEmployees.MouseLeave += new System.EventHandler(this.BtnEmployees_MouseLeave);
            // 
            // btnClients
            // 
            this.btnClients.FlatAppearance.BorderSize = 0;
            this.btnClients.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnClients.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(30)))), ((int)(((byte)(31)))));
            this.btnClients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClients.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClients.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(30)))), ((int)(((byte)(31)))));
            this.btnClients.Image = global::SistemaEmpeños.Properties.Resources.icon_clients;
            this.btnClients.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClients.Location = new System.Drawing.Point(0, 138);
            this.btnClients.Name = "btnClients";
            this.btnClients.Size = new System.Drawing.Size(250, 40);
            this.btnClients.TabIndex = 3;
            this.btnClients.Text = "CLIENTES";
            this.btnClients.UseVisualStyleBackColor = true;
            this.btnClients.Click += new System.EventHandler(this.BtnClients_Click);
            this.btnClients.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BtnClients_KeyDown);
            this.btnClients.KeyUp += new System.Windows.Forms.KeyEventHandler(this.BtnClients_KeyUp);
            this.btnClients.MouseEnter += new System.EventHandler(this.BtnClients_MouseEnter);
            this.btnClients.MouseLeave += new System.EventHandler(this.BtnClients_MouseLeave);
            // 
            // btnStore
            // 
            this.btnStore.FlatAppearance.BorderSize = 0;
            this.btnStore.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnStore.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(30)))), ((int)(((byte)(31)))));
            this.btnStore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStore.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(30)))), ((int)(((byte)(31)))));
            this.btnStore.Image = global::SistemaEmpeños.Properties.Resources.icon_store;
            this.btnStore.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStore.Location = new System.Drawing.Point(0, 184);
            this.btnStore.Name = "btnStore";
            this.btnStore.Size = new System.Drawing.Size(250, 40);
            this.btnStore.TabIndex = 4;
            this.btnStore.Text = "TIENDA";
            this.btnStore.UseVisualStyleBackColor = true;
            this.btnStore.Click += new System.EventHandler(this.BtnStore_Click);
            this.btnStore.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BtnStore_KeyDown);
            this.btnStore.KeyUp += new System.Windows.Forms.KeyEventHandler(this.BtnStore_KeyUp);
            this.btnStore.MouseEnter += new System.EventHandler(this.BtnStore_MouseEnter);
            this.btnStore.MouseLeave += new System.EventHandler(this.BtnStore_MouseLeave);
            // 
            // btnMax
            // 
            this.btnMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMax.FlatAppearance.BorderSize = 0;
            this.btnMax.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnMax.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.btnMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMax.Image = global::SistemaEmpeños.Properties.Resources.icon_max;
            this.btnMax.Location = new System.Drawing.Point(1183, 0);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(50, 40);
            this.btnMax.TabIndex = 1;
            this.btnMax.TabStop = false;
            this.btnMax.UseVisualStyleBackColor = true;
            this.btnMax.Click += new System.EventHandler(this.BtnMax_Click);
            // 
            // btnMin
            // 
            this.btnMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMin.FlatAppearance.BorderSize = 0;
            this.btnMin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnMin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMin.Image = global::SistemaEmpeños.Properties.Resources.icon_min;
            this.btnMin.Location = new System.Drawing.Point(1132, 0);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(50, 40);
            this.btnMin.TabIndex = 0;
            this.btnMin.TabStop = false;
            this.btnMin.UseVisualStyleBackColor = true;
            this.btnMin.Click += new System.EventHandler(this.BtnMin_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(51)))), ((int)(((byte)(45)))));
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::SistemaEmpeños.Properties.Resources.icon_close;
            this.btnClose.Location = new System.Drawing.Point(1234, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(50, 40);
            this.btnClose.TabIndex = 3;
            this.btnClose.TabStop = false;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // btnRes
            // 
            this.btnRes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRes.FlatAppearance.BorderSize = 0;
            this.btnRes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnRes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.btnRes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRes.Image = global::SistemaEmpeños.Properties.Resources.icon_rest;
            this.btnRes.Location = new System.Drawing.Point(1183, 0);
            this.btnRes.Name = "btnRes";
            this.btnRes.Size = new System.Drawing.Size(50, 40);
            this.btnRes.TabIndex = 2;
            this.btnRes.TabStop = false;
            this.btnRes.UseVisualStyleBackColor = true;
            this.btnRes.Click += new System.EventHandler(this.BtnRes_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 611);
            this.Controls.Add(this.mainContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            this.mainContainer.ResumeLayout(false);
            this.footerBar.ResumeLayout(false);
            this.windowsContainer.ResumeLayout(false);
            this.menuSideBar.ResumeLayout(false);
            this.titleBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainContainer;
        private System.Windows.Forms.Panel titleBar;
        private System.Windows.Forms.Panel windowsContainer;
        private System.Windows.Forms.Panel menuSideBar;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnRes;
        private System.Windows.Forms.Button btnMax;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Button btnStore;
        private System.Windows.Forms.Button btnClients;
        private System.Windows.Forms.Button btnPawns;
        private System.Windows.Forms.Button btnSideMenu;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Button btnEmployees;
        private System.Windows.Forms.Panel footerBar;
        private System.Windows.Forms.Button btnResize;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer tmHideMenu;
        private System.Windows.Forms.Timer tmShowMenu;
    }
}

