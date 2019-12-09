namespace SistemaEmpeños
{
    partial class FrmClients
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmClients));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.titleBar = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.mainContainer = new System.Windows.Forms.Panel();
            this.wrapper = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblPanel1Header = new System.Windows.Forms.Label();
            this.dgvCliente = new System.Windows.Forms.DataGridView();
            this.btnClean = new System.Windows.Forms.Button();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtCorr = new System.Windows.Forms.MaskedTextBox();
            this.txtTel = new System.Windows.Forms.MaskedTextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCedula = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPanel2Header = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.titleBar.SuspendLayout();
            this.mainContainer.SuspendLayout();
            this.wrapper.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Clientes";
            // 
            // titleBar
            // 
            this.titleBar.Controls.Add(this.btnClose);
            this.titleBar.Controls.Add(this.label1);
            this.titleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.titleBar.Location = new System.Drawing.Point(0, 0);
            this.titleBar.Name = "titleBar";
            this.titleBar.Size = new System.Drawing.Size(900, 40);
            this.titleBar.TabIndex = 2;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(850, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(50, 40);
            this.btnClose.TabIndex = 4;
            this.btnClose.TabStop = false;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            this.btnClose.MouseEnter += new System.EventHandler(this.BtnClose_MouseEnter);
            this.btnClose.MouseLeave += new System.EventHandler(this.BtnClose_MouseLeave);
            // 
            // mainContainer
            // 
            this.mainContainer.Controls.Add(this.wrapper);
            this.mainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainContainer.Location = new System.Drawing.Point(0, 40);
            this.mainContainer.Name = "mainContainer";
            this.mainContainer.Size = new System.Drawing.Size(900, 410);
            this.mainContainer.TabIndex = 3;
            // 
            // wrapper
            // 
            this.wrapper.Controls.Add(this.splitContainer1);
            this.wrapper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wrapper.Location = new System.Drawing.Point(0, 0);
            this.wrapper.Name = "wrapper";
            this.wrapper.Padding = new System.Windows.Forms.Padding(8, 0, 8, 8);
            this.wrapper.Size = new System.Drawing.Size(900, 410);
            this.wrapper.TabIndex = 3;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(8, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(249)))), ((int)(((byte)(254)))));
            this.splitContainer1.Panel1.Controls.Add(this.txtFilter);
            this.splitContainer1.Panel1.Controls.Add(this.button1);
            this.splitContainer1.Panel1.Controls.Add(this.lblPanel1Header);
            this.splitContainer1.Panel1.Controls.Add(this.dgvCliente);
            this.splitContainer1.Panel1.Enter += new System.EventHandler(this.MainContainer_Panel1_Enter);
            this.splitContainer1.Panel1.Leave += new System.EventHandler(this.MainContainer_Panel1_Leave);
            this.splitContainer1.Panel1MinSize = 533;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(249)))), ((int)(((byte)(254)))));
            this.splitContainer1.Panel2.Controls.Add(this.btnClean);
            this.splitContainer1.Panel2.Controls.Add(this.txtDireccion);
            this.splitContainer1.Panel2.Controls.Add(this.txtCorr);
            this.splitContainer1.Panel2.Controls.Add(this.txtTel);
            this.splitContainer1.Panel2.Controls.Add(this.txtApellido);
            this.splitContainer1.Panel2.Controls.Add(this.txtNombre);
            this.splitContainer1.Panel2.Controls.Add(this.txtCedula);
            this.splitContainer1.Panel2.Controls.Add(this.label10);
            this.splitContainer1.Panel2.Controls.Add(this.label8);
            this.splitContainer1.Panel2.Controls.Add(this.label7);
            this.splitContainer1.Panel2.Controls.Add(this.label5);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.lblPanel2Header);
            this.splitContainer1.Panel2.Controls.Add(this.btnSave);
            this.splitContainer1.Panel2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.splitContainer1.Panel2.Enter += new System.EventHandler(this.MainContainer_Panel2_Enter);
            this.splitContainer1.Panel2.Leave += new System.EventHandler(this.MainContainer_Panel2_Leave);
            this.splitContainer1.Panel2MinSize = 250;
            this.splitContainer1.Size = new System.Drawing.Size(884, 402);
            this.splitContainer1.SplitterDistance = 563;
            this.splitContainer1.SplitterWidth = 8;
            this.splitContainer1.TabIndex = 7;
            // 
            // txtFilter
            // 
            this.txtFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFilter.Location = new System.Drawing.Point(20, 38);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(523, 20);
            this.txtFilter.TabIndex = 0;
            this.txtFilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFilter_KeyPress);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(30)))), ((int)(((byte)(31)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(20, 336);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 40);
            this.button1.TabIndex = 5;
            this.button1.Text = "EDITAR";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblPanel1Header
            // 
            this.lblPanel1Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(30)))), ((int)(((byte)(31)))));
            this.lblPanel1Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblPanel1Header.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPanel1Header.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblPanel1Header.Location = new System.Drawing.Point(0, 0);
            this.lblPanel1Header.Name = "lblPanel1Header";
            this.lblPanel1Header.Padding = new System.Windows.Forms.Padding(3);
            this.lblPanel1Header.Size = new System.Drawing.Size(563, 20);
            this.lblPanel1Header.TabIndex = 1;
            this.lblPanel1Header.Text = "Lista de empleados actualez";
            // 
            // dgvCliente
            // 
            this.dgvCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCliente.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCliente.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(197)))), ((int)(((byte)(8)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(30)))), ((int)(((byte)(31)))));
            dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(197)))), ((int)(((byte)(8)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCliente.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCliente.DataMember = "Empleado";
            this.dgvCliente.EnableHeadersVisualStyles = false;
            this.dgvCliente.Location = new System.Drawing.Point(20, 77);
            this.dgvCliente.Name = "dgvCliente";
            this.dgvCliente.ReadOnly = true;
            this.dgvCliente.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(30)))), ((int)(((byte)(31)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(30)))), ((int)(((byte)(31)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCliente.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(30)))), ((int)(((byte)(31)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            this.dgvCliente.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvCliente.Size = new System.Drawing.Size(523, 237);
            this.dgvCliente.TabIndex = 3;
            this.dgvCliente.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PasarDatosCampo);
            // 
            // btnClean
            // 
            this.btnClean.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClean.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(30)))), ((int)(((byte)(31)))));
            this.btnClean.FlatAppearance.BorderSize = 0;
            this.btnClean.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.btnClean.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnClean.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClean.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClean.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnClean.Image = ((System.Drawing.Image)(resources.GetObject("btnClean.Image")));
            this.btnClean.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClean.Location = new System.Drawing.Point(20, 260);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(256, 40);
            this.btnClean.TabIndex = 24;
            this.btnClean.Text = "LIMPIAR";
            this.btnClean.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClean.UseVisualStyleBackColor = false;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDireccion.Location = new System.Drawing.Point(104, 118);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(172, 21);
            this.txtDireccion.TabIndex = 14;
            // 
            // txtCorr
            // 
            this.txtCorr.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCorr.Location = new System.Drawing.Point(104, 172);
            this.txtCorr.Name = "txtCorr";
            this.txtCorr.Size = new System.Drawing.Size(172, 21);
            this.txtCorr.TabIndex = 17;
            // 
            // txtTel
            // 
            this.txtTel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTel.Location = new System.Drawing.Point(104, 145);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(172, 21);
            this.txtTel.TabIndex = 15;
            // 
            // txtApellido
            // 
            this.txtApellido.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtApellido.Location = new System.Drawing.Point(104, 91);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(172, 21);
            this.txtApellido.TabIndex = 11;
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombre.Location = new System.Drawing.Point(104, 64);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(172, 21);
            this.txtNombre.TabIndex = 10;
            // 
            // txtCedula
            // 
            this.txtCedula.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCedula.Location = new System.Drawing.Point(104, 37);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(172, 21);
            this.txtCedula.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(17, 175);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 16);
            this.label10.TabIndex = 12;
            this.label10.Text = "Correo:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(17, 148);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 16);
            this.label8.TabIndex = 10;
            this.label8.Text = "Teléfono:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(17, 121);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 16);
            this.label7.TabIndex = 9;
            this.label7.Text = "Dirección:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Apellidos:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nombres:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cédula:";
            // 
            // lblPanel2Header
            // 
            this.lblPanel2Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(30)))), ((int)(((byte)(31)))));
            this.lblPanel2Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblPanel2Header.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPanel2Header.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblPanel2Header.Location = new System.Drawing.Point(0, 0);
            this.lblPanel2Header.Name = "lblPanel2Header";
            this.lblPanel2Header.Padding = new System.Windows.Forms.Padding(3);
            this.lblPanel2Header.Size = new System.Drawing.Size(313, 20);
            this.lblPanel2Header.TabIndex = 3;
            this.lblPanel2Header.Text = "Datos del empleado";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(30)))), ((int)(((byte)(31)))));
            this.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(30)))), ((int)(((byte)(31)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(30)))), ((int)(((byte)(31)))));
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.Location = new System.Drawing.Point(20, 214);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(256, 40);
            this.btnSave.TabIndex = 18;
            this.btnSave.Text = "GUARDAR";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // FrmClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 450);
            this.Controls.Add(this.mainContainer);
            this.Controls.Add(this.titleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmClients";
            this.Text = "Clientes";
            this.titleBar.ResumeLayout(false);
            this.titleBar.PerformLayout();
            this.mainContainer.ResumeLayout(false);
            this.wrapper.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel titleBar;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel mainContainer;
        private System.Windows.Forms.Panel wrapper;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblPanel1Header;
        private System.Windows.Forms.DataGridView dgvCliente;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.MaskedTextBox txtCorr;
        private System.Windows.Forms.MaskedTextBox txtTel;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.MaskedTextBox txtCedula;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPanel2Header;
        private System.Windows.Forms.Button btnSave;
    }
}