namespace SistemaEmpeños
{
    partial class FrmSales
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.titleBar = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.mainContainer = new System.Windows.Forms.Panel();
            this.tabsContainer = new System.Windows.Forms.TableLayoutPanel();
            this.cartContainer = new System.Windows.Forms.Panel();
            this.lblArticlesCounter = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.articlesTabPage = new System.Windows.Forms.TabPage();
            this.dgvArticles = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.salePointTabPage = new System.Windows.Forms.TabPage();
            this.detailsContainer = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.lblInvoicingDetailsHeader = new System.Windows.Forms.Label();
            this.dgvFacturedArticles = new System.Windows.Forms.DataGridView();
            this.maskedTextBox3 = new System.Windows.Forms.MaskedTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSaleDetailsHeader = new System.Windows.Forms.Label();
            this.lblSalePointTab = new System.Windows.Forms.Label();
            this.lblArticlesTab = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnInvoice = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.titleBar.SuspendLayout();
            this.mainContainer.SuspendLayout();
            this.tabsContainer.SuspendLayout();
            this.cartContainer.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.articlesTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticles)).BeginInit();
            this.salePointTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.detailsContainer)).BeginInit();
            this.detailsContainer.Panel1.SuspendLayout();
            this.detailsContainer.Panel2.SuspendLayout();
            this.detailsContainer.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturedArticles)).BeginInit();
            this.SuspendLayout();
            // 
            // titleBar
            // 
            this.titleBar.Controls.Add(this.btnClose);
            this.titleBar.Controls.Add(this.label1);
            this.titleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.titleBar.Location = new System.Drawing.Point(0, 0);
            this.titleBar.Name = "titleBar";
            this.titleBar.Size = new System.Drawing.Size(900, 40);
            this.titleBar.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 36);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tienda";
            // 
            // mainContainer
            // 
            this.mainContainer.Controls.Add(this.tabsContainer);
            this.mainContainer.Controls.Add(this.tabControl);
            this.mainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainContainer.Location = new System.Drawing.Point(0, 40);
            this.mainContainer.Name = "mainContainer";
            this.mainContainer.Padding = new System.Windows.Forms.Padding(8, 0, 8, 8);
            this.mainContainer.Size = new System.Drawing.Size(900, 410);
            this.mainContainer.TabIndex = 1;
            // 
            // tabsContainer
            // 
            this.tabsContainer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabsContainer.ColumnCount = 2;
            this.tabsContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tabsContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tabsContainer.Controls.Add(this.cartContainer, 1, 0);
            this.tabsContainer.Controls.Add(this.lblArticlesTab, 0, 0);
            this.tabsContainer.Location = new System.Drawing.Point(8, 0);
            this.tabsContainer.Name = "tabsContainer";
            this.tabsContainer.RowCount = 1;
            this.tabsContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tabsContainer.Size = new System.Drawing.Size(880, 24);
            this.tabsContainer.TabIndex = 5;
            // 
            // cartContainer
            // 
            this.cartContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(30)))), ((int)(((byte)(31)))));
            this.cartContainer.Controls.Add(this.lblArticlesCounter);
            this.cartContainer.Controls.Add(this.lblSalePointTab);
            this.cartContainer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cartContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cartContainer.Location = new System.Drawing.Point(440, 0);
            this.cartContainer.Margin = new System.Windows.Forms.Padding(0);
            this.cartContainer.Name = "cartContainer";
            this.cartContainer.Size = new System.Drawing.Size(440, 24);
            this.cartContainer.TabIndex = 8;
            // 
            // lblArticlesCounter
            // 
            this.lblArticlesCounter.BackColor = System.Drawing.Color.Transparent;
            this.lblArticlesCounter.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblArticlesCounter.Font = new System.Drawing.Font("Bauhaus 93", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArticlesCounter.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblArticlesCounter.Location = new System.Drawing.Point(402, 0);
            this.lblArticlesCounter.Name = "lblArticlesCounter";
            this.lblArticlesCounter.Size = new System.Drawing.Size(38, 24);
            this.lblArticlesCounter.TabIndex = 7;
            this.lblArticlesCounter.Text = "10+";
            this.lblArticlesCounter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblArticlesCounter.Click += new System.EventHandler(this.LblArticlesCounter_Click);
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.articlesTabPage);
            this.tabControl.Controls.Add(this.salePointTabPage);
            this.tabControl.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.ItemSize = new System.Drawing.Size(1, 1);
            this.tabControl.Location = new System.Drawing.Point(8, 20);
            this.tabControl.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl.Name = "tabControl";
            this.tabControl.Padding = new System.Drawing.Point(0, 0);
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(884, 382);
            this.tabControl.TabIndex = 0;
            // 
            // articlesTabPage
            // 
            this.articlesTabPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(249)))), ((int)(((byte)(254)))));
            this.articlesTabPage.Controls.Add(this.dgvArticles);
            this.articlesTabPage.Controls.Add(this.button1);
            this.articlesTabPage.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.articlesTabPage.ImageKey = "(ninguno)";
            this.articlesTabPage.Location = new System.Drawing.Point(4, 5);
            this.articlesTabPage.Margin = new System.Windows.Forms.Padding(0);
            this.articlesTabPage.Name = "articlesTabPage";
            this.articlesTabPage.Size = new System.Drawing.Size(876, 373);
            this.articlesTabPage.TabIndex = 0;
            // 
            // dgvArticles
            // 
            this.dgvArticles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvArticles.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvArticles.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvArticles.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(197)))), ((int)(((byte)(8)))));
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(30)))), ((int)(((byte)(31)))));
            dataGridViewCellStyle16.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(197)))), ((int)(((byte)(8)))));
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvArticles.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.dgvArticles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticles.EnableHeadersVisualStyles = false;
            this.dgvArticles.Location = new System.Drawing.Point(17, 112);
            this.dgvArticles.Name = "dgvArticles";
            this.dgvArticles.ReadOnly = true;
            this.dgvArticles.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(30)))), ((int)(((byte)(31)))));
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(30)))), ((int)(((byte)(31)))));
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvArticles.RowHeadersDefaultCellStyle = dataGridViewCellStyle17;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(30)))), ((int)(((byte)(31)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            this.dgvArticles.RowsDefaultCellStyle = dataGridViewCellStyle18;
            this.dgvArticles.Size = new System.Drawing.Size(842, 164);
            this.dgvArticles.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(42, 50);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // salePointTabPage
            // 
            this.salePointTabPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(249)))), ((int)(((byte)(254)))));
            this.salePointTabPage.Controls.Add(this.detailsContainer);
            this.salePointTabPage.Location = new System.Drawing.Point(4, 5);
            this.salePointTabPage.Name = "salePointTabPage";
            this.salePointTabPage.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.salePointTabPage.Size = new System.Drawing.Size(876, 373);
            this.salePointTabPage.TabIndex = 1;
            // 
            // detailsContainer
            // 
            this.detailsContainer.BackColor = System.Drawing.SystemColors.Control;
            this.detailsContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.detailsContainer.Location = new System.Drawing.Point(0, 3);
            this.detailsContainer.Name = "detailsContainer";
            // 
            // detailsContainer.Panel1
            // 
            this.detailsContainer.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(249)))), ((int)(((byte)(254)))));
            this.detailsContainer.Panel1.Controls.Add(this.tableLayoutPanel2);
            this.detailsContainer.Panel1.Controls.Add(this.btnDelete);
            this.detailsContainer.Panel1.Controls.Add(this.button2);
            this.detailsContainer.Panel1.Controls.Add(this.lblInvoicingDetailsHeader);
            this.detailsContainer.Panel1.Controls.Add(this.dgvFacturedArticles);
            this.detailsContainer.Panel1.Enter += new System.EventHandler(this.DetailsContainer_Panel1_Enter);
            this.detailsContainer.Panel1.Leave += new System.EventHandler(this.DetailsContainer_Panel1_Leave);
            this.detailsContainer.Panel1MinSize = 530;
            // 
            // detailsContainer.Panel2
            // 
            this.detailsContainer.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(249)))), ((int)(((byte)(254)))));
            this.detailsContainer.Panel2.Controls.Add(this.maskedTextBox3);
            this.detailsContainer.Panel2.Controls.Add(this.label13);
            this.detailsContainer.Panel2.Controls.Add(this.label12);
            this.detailsContainer.Panel2.Controls.Add(this.maskedTextBox2);
            this.detailsContainer.Panel2.Controls.Add(this.maskedTextBox1);
            this.detailsContainer.Panel2.Controls.Add(this.label11);
            this.detailsContainer.Panel2.Controls.Add(this.textBox4);
            this.detailsContainer.Panel2.Controls.Add(this.label5);
            this.detailsContainer.Panel2.Controls.Add(this.textBox3);
            this.detailsContainer.Panel2.Controls.Add(this.textBox2);
            this.detailsContainer.Panel2.Controls.Add(this.label4);
            this.detailsContainer.Panel2.Controls.Add(this.label3);
            this.detailsContainer.Panel2.Controls.Add(this.textBox1);
            this.detailsContainer.Panel2.Controls.Add(this.label2);
            this.detailsContainer.Panel2.Controls.Add(this.btnInvoice);
            this.detailsContainer.Panel2.Controls.Add(this.lblSaleDetailsHeader);
            this.detailsContainer.Panel2.Enter += new System.EventHandler(this.DetailsContainer_Panel2_Enter);
            this.detailsContainer.Panel2.Leave += new System.EventHandler(this.DetailsContainer_Panel2_Leave);
            this.detailsContainer.Panel2MinSize = 250;
            this.detailsContainer.Size = new System.Drawing.Size(876, 370);
            this.detailsContainer.SplitterDistance = 618;
            this.detailsContainer.SplitterWidth = 8;
            this.detailsContainer.TabIndex = 7;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.panel3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel4, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel6, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.panel7, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.panel8, 1, 2);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 29);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(616, 92);
            this.tableLayoutPanel2.TabIndex = 19;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.textBox5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(302, 24);
            this.panel3.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(11, 4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "No. Factura:";
            // 
            // textBox5
            // 
            this.textBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox5.BackColor = System.Drawing.SystemColors.Control;
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox5.Enabled = false;
            this.textBox5.Location = new System.Drawing.Point(96, 1);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(203, 21);
            this.textBox5.TabIndex = 9;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.dateTimePicker1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(311, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(302, 24);
            this.panel4.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(3, 4);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 16);
            this.label7.TabIndex = 11;
            this.label7.Text = "Fecha:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker1.Location = new System.Drawing.Point(72, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(213, 21);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // panel6
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.panel6, 2);
            this.panel6.Controls.Add(this.label8);
            this.panel6.Controls.Add(this.comboBox1);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(3, 33);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(610, 24);
            this.panel6.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(11, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 16);
            this.label8.TabIndex = 12;
            this.label8.Text = "Empleado:";
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(95, 0);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(498, 24);
            this.comboBox1.TabIndex = 1;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.textBox6);
            this.panel7.Controls.Add(this.label9);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(3, 63);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(302, 26);
            this.panel7.TabIndex = 4;
            // 
            // textBox6
            // 
            this.textBox6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox6.Location = new System.Drawing.Point(96, 1);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(203, 21);
            this.textBox6.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(11, 4);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 16);
            this.label9.TabIndex = 13;
            this.label9.Text = "Cliente:";
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.label10);
            this.panel8.Controls.Add(this.comboBox2);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(311, 63);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(302, 26);
            this.panel8.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(3, 4);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 16);
            this.label10.TabIndex = 17;
            this.label10.Text = "Tipo de pago:";
            // 
            // comboBox2
            // 
            this.comboBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(93, 1);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(192, 24);
            this.comboBox2.TabIndex = 3;
            // 
            // lblInvoicingDetailsHeader
            // 
            this.lblInvoicingDetailsHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(30)))), ((int)(((byte)(31)))));
            this.lblInvoicingDetailsHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblInvoicingDetailsHeader.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblInvoicingDetailsHeader.Location = new System.Drawing.Point(0, 0);
            this.lblInvoicingDetailsHeader.Name = "lblInvoicingDetailsHeader";
            this.lblInvoicingDetailsHeader.Padding = new System.Windows.Forms.Padding(3);
            this.lblInvoicingDetailsHeader.Size = new System.Drawing.Size(618, 20);
            this.lblInvoicingDetailsHeader.TabIndex = 5;
            this.lblInvoicingDetailsHeader.Text = "Detalles de facturación";
            // 
            // dgvFacturedArticles
            // 
            this.dgvFacturedArticles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvFacturedArticles.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvFacturedArticles.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvFacturedArticles.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(197)))), ((int)(((byte)(8)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(30)))), ((int)(((byte)(31)))));
            dataGridViewCellStyle13.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(197)))), ((int)(((byte)(8)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFacturedArticles.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dgvFacturedArticles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFacturedArticles.EnableHeadersVisualStyles = false;
            this.dgvFacturedArticles.Location = new System.Drawing.Point(20, 137);
            this.dgvFacturedArticles.Name = "dgvFacturedArticles";
            this.dgvFacturedArticles.ReadOnly = true;
            this.dgvFacturedArticles.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(30)))), ((int)(((byte)(31)))));
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(30)))), ((int)(((byte)(31)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFacturedArticles.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(30)))), ((int)(((byte)(31)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            this.dgvFacturedArticles.RowsDefaultCellStyle = dataGridViewCellStyle15;
            this.dgvFacturedArticles.Size = new System.Drawing.Size(578, 157);
            this.dgvFacturedArticles.TabIndex = 4;
            // 
            // maskedTextBox3
            // 
            this.maskedTextBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.maskedTextBox3.Location = new System.Drawing.Point(94, 182);
            this.maskedTextBox3.Name = "maskedTextBox3";
            this.maskedTextBox3.Size = new System.Drawing.Size(135, 21);
            this.maskedTextBox3.TabIndex = 10;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(17, 212);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(55, 16);
            this.label13.TabIndex = 14;
            this.label13.Text = "Cambio:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(17, 185);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 16);
            this.label12.TabIndex = 13;
            this.label12.Text = "Cobrado:";
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.maskedTextBox2.Location = new System.Drawing.Point(94, 117);
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(135, 21);
            this.maskedTextBox2.TabIndex = 9;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.maskedTextBox1.Location = new System.Drawing.Point(94, 90);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(135, 21);
            this.maskedTextBox1.TabIndex = 8;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(16, 120);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 16);
            this.label11.TabIndex = 10;
            this.label11.Text = "Descuento:";
            // 
            // textBox4
            // 
            this.textBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox4.BackColor = System.Drawing.SystemColors.Control;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox4.Enabled = false;
            this.textBox4.Location = new System.Drawing.Point(94, 209);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(135, 21);
            this.textBox4.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Envío:";
            // 
            // textBox3
            // 
            this.textBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox3.BackColor = System.Drawing.SystemColors.Control;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(94, 144);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(135, 21);
            this.textBox3.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.BackColor = System.Drawing.SystemColors.Control;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(94, 63);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(135, 21);
            this.textBox2.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Total:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Impuestos:";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(94, 36);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(135, 21);
            this.textBox1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Subtotal:";
            // 
            // lblSaleDetailsHeader
            // 
            this.lblSaleDetailsHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(30)))), ((int)(((byte)(31)))));
            this.lblSaleDetailsHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSaleDetailsHeader.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblSaleDetailsHeader.Location = new System.Drawing.Point(0, 0);
            this.lblSaleDetailsHeader.Name = "lblSaleDetailsHeader";
            this.lblSaleDetailsHeader.Padding = new System.Windows.Forms.Padding(3);
            this.lblSaleDetailsHeader.Size = new System.Drawing.Size(250, 20);
            this.lblSaleDetailsHeader.TabIndex = 0;
            this.lblSaleDetailsHeader.Text = "Detalles de la venta";
            // 
            // lblSalePointTab
            // 
            this.lblSalePointTab.BackColor = System.Drawing.Color.Transparent;
            this.lblSalePointTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSalePointTab.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalePointTab.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblSalePointTab.Image = global::SistemaEmpeños.Properties.Resources.icon_sale_point;
            this.lblSalePointTab.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblSalePointTab.Location = new System.Drawing.Point(0, 0);
            this.lblSalePointTab.Name = "lblSalePointTab";
            this.lblSalePointTab.Size = new System.Drawing.Size(440, 24);
            this.lblSalePointTab.TabIndex = 6;
            this.lblSalePointTab.Text = "              Punto de ventas";
            this.lblSalePointTab.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblSalePointTab.Click += new System.EventHandler(this.LblSalePointTab_Click);
            // 
            // lblArticlesTab
            // 
            this.lblArticlesTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(30)))), ((int)(((byte)(31)))));
            this.lblArticlesTab.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblArticlesTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblArticlesTab.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArticlesTab.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblArticlesTab.Image = global::SistemaEmpeños.Properties.Resources.icon_product;
            this.lblArticlesTab.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblArticlesTab.Location = new System.Drawing.Point(3, 0);
            this.lblArticlesTab.Name = "lblArticlesTab";
            this.lblArticlesTab.Size = new System.Drawing.Size(434, 24);
            this.lblArticlesTab.TabIndex = 5;
            this.lblArticlesTab.Text = "              Artículos";
            this.lblArticlesTab.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblArticlesTab.Click += new System.EventHandler(this.LblArticlesTab_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(30)))), ((int)(((byte)(31)))));
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnDelete.Image = global::SistemaEmpeños.Properties.Resources.icon_delete;
            this.btnDelete.Location = new System.Drawing.Point(161, 311);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(135, 40);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "ELIMINAR";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(30)))), ((int)(((byte)(31)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button2.Image = global::SistemaEmpeños.Properties.Resources.icon_search;
            this.button2.Location = new System.Drawing.Point(20, 311);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(135, 40);
            this.button2.TabIndex = 5;
            this.button2.Text = "BUSCAR";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // btnInvoice
            // 
            this.btnInvoice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInvoice.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(30)))), ((int)(((byte)(31)))));
            this.btnInvoice.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.btnInvoice.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(30)))), ((int)(((byte)(31)))));
            this.btnInvoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInvoice.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInvoice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(30)))), ((int)(((byte)(31)))));
            this.btnInvoice.Image = global::SistemaEmpeños.Properties.Resources.icon_invoice;
            this.btnInvoice.Location = new System.Drawing.Point(20, 245);
            this.btnInvoice.Name = "btnInvoice";
            this.btnInvoice.Size = new System.Drawing.Size(209, 40);
            this.btnInvoice.TabIndex = 11;
            this.btnInvoice.Text = "FACTURAR";
            this.btnInvoice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInvoice.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInvoice.UseVisualStyleBackColor = true;
            this.btnInvoice.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BtnInvoice_KeyDown);
            this.btnInvoice.KeyUp += new System.Windows.Forms.KeyEventHandler(this.BtnInvoice_KeyUp);
            this.btnInvoice.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BtnInvoice_MouseDown);
            this.btnInvoice.MouseEnter += new System.EventHandler(this.BtnInvoice_MouseEnter);
            this.btnInvoice.MouseLeave += new System.EventHandler(this.BtnInvoice_MouseLeave);
            this.btnInvoice.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BtnInvoice_MouseUp);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::SistemaEmpeños.Properties.Resources.icon_fix;
            this.btnClose.Location = new System.Drawing.Point(850, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(50, 40);
            this.btnClose.TabIndex = 2;
            this.btnClose.TabStop = false;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            this.btnClose.MouseEnter += new System.EventHandler(this.BtnClose_MouseEnter);
            this.btnClose.MouseLeave += new System.EventHandler(this.BtnClose_MouseLeave);
            // 
            // FrmSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 450);
            this.Controls.Add(this.mainContainer);
            this.Controls.Add(this.titleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmSales";
            this.Text = "Tienda";
            this.Load += new System.EventHandler(this.FrmSales_Load);
            this.titleBar.ResumeLayout(false);
            this.titleBar.PerformLayout();
            this.mainContainer.ResumeLayout(false);
            this.tabsContainer.ResumeLayout(false);
            this.cartContainer.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.articlesTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticles)).EndInit();
            this.salePointTabPage.ResumeLayout(false);
            this.detailsContainer.Panel1.ResumeLayout(false);
            this.detailsContainer.Panel2.ResumeLayout(false);
            this.detailsContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.detailsContainer)).EndInit();
            this.detailsContainer.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturedArticles)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel titleBar;
        private System.Windows.Forms.Panel mainContainer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage articlesTabPage;
        private System.Windows.Forms.TabPage salePointTabPage;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvArticles;
        private System.Windows.Forms.Panel cartContainer;
        private System.Windows.Forms.Label lblArticlesCounter;
        private System.Windows.Forms.Label lblSalePointTab;
        private System.Windows.Forms.Label lblArticlesTab;
        private System.Windows.Forms.TableLayoutPanel tabsContainer;
        private System.Windows.Forms.SplitContainer detailsContainer;
        private System.Windows.Forms.DataGridView dgvFacturedArticles;
        private System.Windows.Forms.Label lblInvoicingDetailsHeader;
        private System.Windows.Forms.Label lblSaleDetailsHeader;
        private System.Windows.Forms.Button btnInvoice;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.MaskedTextBox maskedTextBox3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label label11;
    }
}