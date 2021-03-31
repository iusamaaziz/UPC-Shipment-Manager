
namespace UPC_Shipment_Manager_UI.UserControls.CRM
{
	partial class UC_SearchEntry
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
			this.CustomerName = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.dg = new Bunifu.Framework.UI.BunifuCustomDataGrid();
			this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.customerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.marketPlaceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.orderNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.orderDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.productDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.queryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.actionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.whatsappMessageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.customerEntryBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
			this.Whatsapp = new System.Windows.Forms.Button();
			this.WhatsappMessage = new System.Windows.Forms.TextBox();
			this.label15 = new System.Windows.Forms.Label();
			this.CloseEntry = new System.Windows.Forms.Button();
			this.Action = new System.Windows.Forms.TextBox();
			this.label14 = new System.Windows.Forms.Label();
			this.Query = new System.Windows.Forms.TextBox();
			this.label13 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.Marketplace = new System.Windows.Forms.ComboBox();
			this.Product = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.OrderDate = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.OrderNumber = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.Email = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.Phone = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.Customer = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.CustomerPhone = new System.Windows.Forms.TextBox();
			this.label16 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dg)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.customerEntryBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.bunifuCards1.SuspendLayout();
			this.SuspendLayout();
			// 
			// CustomerName
			// 
			this.CustomerName.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.CustomerName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.CustomerName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
			this.CustomerName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
			this.CustomerName.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.CustomerName.Location = new System.Drawing.Point(181, 29);
			this.CustomerName.Name = "CustomerName";
			this.CustomerName.Size = new System.Drawing.Size(173, 25);
			this.CustomerName.TabIndex = 0;
			this.CustomerName.Click += new System.EventHandler(this.CustomerName_Click);
			this.CustomerName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CustomerName_KeyDown);
			// 
			// label4
			// 
			this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.label4.ForeColor = System.Drawing.Color.Black;
			this.label4.Location = new System.Drawing.Point(136, 34);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(39, 15);
			this.label4.TabIndex = 77;
			this.label4.Text = "Name";
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
			this.label1.ForeColor = System.Drawing.Color.Black;
			this.label1.Location = new System.Drawing.Point(20, 52);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(104, 19);
			this.label1.TabIndex = 75;
			this.label1.Text = "Search Results";
			// 
			// label7
			// 
			this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
			this.label7.ForeColor = System.Drawing.Color.Black;
			this.label7.Location = new System.Drawing.Point(305, 6);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(156, 20);
			this.label7.TabIndex = 74;
			this.label7.Text = "Search Existing Entry";
			// 
			// dg
			// 
			this.dg.AllowUserToAddRows = false;
			this.dg.AllowUserToDeleteRows = false;
			dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.dg.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
			this.dg.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.dg.AutoGenerateColumns = false;
			this.dg.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dg.BackgroundColor = System.Drawing.Color.Gainsboro;
			this.dg.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dg.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.dg.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle14.BackColor = System.Drawing.Color.Maroon;
			dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 9F);
			dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dg.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
			this.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.customerNameDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.marketPlaceDataGridViewTextBoxColumn,
            this.orderNumberDataGridViewTextBoxColumn,
            this.orderDateDataGridViewTextBoxColumn,
            this.productDataGridViewTextBoxColumn,
            this.queryDataGridViewTextBoxColumn,
            this.actionDataGridViewTextBoxColumn,
            this.whatsappMessageDataGridViewTextBoxColumn});
			this.dg.DataSource = this.customerEntryBindingSource;
			dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI", 9F);
			dataGridViewCellStyle15.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.Transparent;
			dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dg.DefaultCellStyle = dataGridViewCellStyle15;
			this.dg.DoubleBuffered = true;
			this.dg.EnableHeadersVisualStyles = false;
			this.dg.HeaderBgColor = System.Drawing.Color.Maroon;
			this.dg.HeaderForeColor = System.Drawing.Color.White;
			this.dg.Location = new System.Drawing.Point(24, 92);
			this.dg.MultiSelect = false;
			this.dg.Name = "dg";
			this.dg.ReadOnly = true;
			this.dg.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.dg.RowHeadersVisible = false;
			dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.Transparent;
			dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.Black;
			this.dg.RowsDefaultCellStyle = dataGridViewCellStyle16;
			this.dg.Size = new System.Drawing.Size(736, 122);
			this.dg.TabIndex = 1;
			this.dg.TabStop = false;
			this.dg.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_CellContentClick);
			// 
			// idDataGridViewTextBoxColumn
			// 
			this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
			this.idDataGridViewTextBoxColumn.HeaderText = "Id";
			this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
			this.idDataGridViewTextBoxColumn.ReadOnly = true;
			this.idDataGridViewTextBoxColumn.Width = 30;
			// 
			// customerNameDataGridViewTextBoxColumn
			// 
			this.customerNameDataGridViewTextBoxColumn.DataPropertyName = "CustomerName";
			this.customerNameDataGridViewTextBoxColumn.HeaderText = "Customer name";
			this.customerNameDataGridViewTextBoxColumn.Name = "customerNameDataGridViewTextBoxColumn";
			this.customerNameDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// phoneDataGridViewTextBoxColumn
			// 
			this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
			this.phoneDataGridViewTextBoxColumn.HeaderText = "Phone";
			this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
			this.phoneDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// emailDataGridViewTextBoxColumn
			// 
			this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
			this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
			this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
			this.emailDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// typeDataGridViewTextBoxColumn
			// 
			this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
			this.typeDataGridViewTextBoxColumn.HeaderText = "Type";
			this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
			this.typeDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// statusDataGridViewTextBoxColumn
			// 
			this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
			this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
			this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
			this.statusDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// marketPlaceDataGridViewTextBoxColumn
			// 
			this.marketPlaceDataGridViewTextBoxColumn.DataPropertyName = "MarketPlace";
			this.marketPlaceDataGridViewTextBoxColumn.HeaderText = "Marketplace";
			this.marketPlaceDataGridViewTextBoxColumn.Name = "marketPlaceDataGridViewTextBoxColumn";
			this.marketPlaceDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// orderNumberDataGridViewTextBoxColumn
			// 
			this.orderNumberDataGridViewTextBoxColumn.DataPropertyName = "OrderNumber";
			this.orderNumberDataGridViewTextBoxColumn.HeaderText = "Order #";
			this.orderNumberDataGridViewTextBoxColumn.Name = "orderNumberDataGridViewTextBoxColumn";
			this.orderNumberDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// orderDateDataGridViewTextBoxColumn
			// 
			this.orderDateDataGridViewTextBoxColumn.DataPropertyName = "OrderDate";
			this.orderDateDataGridViewTextBoxColumn.HeaderText = "Order Date";
			this.orderDateDataGridViewTextBoxColumn.Name = "orderDateDataGridViewTextBoxColumn";
			this.orderDateDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// productDataGridViewTextBoxColumn
			// 
			this.productDataGridViewTextBoxColumn.DataPropertyName = "Product";
			this.productDataGridViewTextBoxColumn.HeaderText = "Product";
			this.productDataGridViewTextBoxColumn.Name = "productDataGridViewTextBoxColumn";
			this.productDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// queryDataGridViewTextBoxColumn
			// 
			this.queryDataGridViewTextBoxColumn.DataPropertyName = "Query";
			this.queryDataGridViewTextBoxColumn.HeaderText = "Query";
			this.queryDataGridViewTextBoxColumn.Name = "queryDataGridViewTextBoxColumn";
			this.queryDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// actionDataGridViewTextBoxColumn
			// 
			this.actionDataGridViewTextBoxColumn.DataPropertyName = "Action";
			this.actionDataGridViewTextBoxColumn.HeaderText = "Action";
			this.actionDataGridViewTextBoxColumn.Name = "actionDataGridViewTextBoxColumn";
			this.actionDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// whatsappMessageDataGridViewTextBoxColumn
			// 
			this.whatsappMessageDataGridViewTextBoxColumn.DataPropertyName = "WhatsappMessage";
			this.whatsappMessageDataGridViewTextBoxColumn.HeaderText = "Message";
			this.whatsappMessageDataGridViewTextBoxColumn.Name = "whatsappMessageDataGridViewTextBoxColumn";
			this.whatsappMessageDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// customerEntryBindingSource
			// 
			this.customerEntryBindingSource.DataSource = typeof(UPC.Library.CRMModels.CustomerEntry);
			// 
			// bunifuElipse1
			// 
			this.bunifuElipse1.ElipseRadius = 7;
			this.bunifuElipse1.TargetControl = this.dg;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox2.BackColor = System.Drawing.Color.White;
			this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pictureBox2.Image = global::UPC_Shipment_Manager_UI.Properties.Resources.icons8_file_excel_24px_1;
			this.pictureBox2.Location = new System.Drawing.Point(730, 56);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(30, 30);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pictureBox2.TabIndex = 78;
			this.pictureBox2.TabStop = false;
			this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
			// 
			// bunifuCards1
			// 
			this.bunifuCards1.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.bunifuCards1.BackColor = System.Drawing.Color.White;
			this.bunifuCards1.BorderRadius = 5;
			this.bunifuCards1.BottomSahddow = true;
			this.bunifuCards1.color = System.Drawing.Color.Maroon;
			this.bunifuCards1.Controls.Add(this.Whatsapp);
			this.bunifuCards1.Controls.Add(this.WhatsappMessage);
			this.bunifuCards1.Controls.Add(this.label15);
			this.bunifuCards1.Controls.Add(this.CloseEntry);
			this.bunifuCards1.Controls.Add(this.Action);
			this.bunifuCards1.Controls.Add(this.label14);
			this.bunifuCards1.Controls.Add(this.Query);
			this.bunifuCards1.Controls.Add(this.label13);
			this.bunifuCards1.Controls.Add(this.label9);
			this.bunifuCards1.Controls.Add(this.Marketplace);
			this.bunifuCards1.Controls.Add(this.Product);
			this.bunifuCards1.Controls.Add(this.label11);
			this.bunifuCards1.Controls.Add(this.OrderDate);
			this.bunifuCards1.Controls.Add(this.label12);
			this.bunifuCards1.Controls.Add(this.OrderNumber);
			this.bunifuCards1.Controls.Add(this.label10);
			this.bunifuCards1.Controls.Add(this.label8);
			this.bunifuCards1.Controls.Add(this.Email);
			this.bunifuCards1.Controls.Add(this.label3);
			this.bunifuCards1.Controls.Add(this.Phone);
			this.bunifuCards1.Controls.Add(this.label5);
			this.bunifuCards1.Controls.Add(this.Customer);
			this.bunifuCards1.Controls.Add(this.label6);
			this.bunifuCards1.LeftSahddow = false;
			this.bunifuCards1.Location = new System.Drawing.Point(24, 220);
			this.bunifuCards1.Name = "bunifuCards1";
			this.bunifuCards1.RightSahddow = true;
			this.bunifuCards1.ShadowDepth = 20;
			this.bunifuCards1.Size = new System.Drawing.Size(736, 239);
			this.bunifuCards1.TabIndex = 79;
			// 
			// Whatsapp
			// 
			this.Whatsapp.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.Whatsapp.BackgroundImage = global::UPC_Shipment_Manager_UI.Properties.Resources.icons8_whatsapp_24px;
			this.Whatsapp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.Whatsapp.Cursor = System.Windows.Forms.Cursors.Hand;
			this.Whatsapp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Whatsapp.ForeColor = System.Drawing.Color.White;
			this.Whatsapp.Location = new System.Drawing.Point(470, 191);
			this.Whatsapp.Name = "Whatsapp";
			this.Whatsapp.Size = new System.Drawing.Size(28, 25);
			this.Whatsapp.TabIndex = 1;
			this.toolTip1.SetToolTip(this.Whatsapp, "Send to Whatsapp");
			this.Whatsapp.UseVisualStyleBackColor = true;
			this.Whatsapp.Click += new System.EventHandler(this.Whatsapp_Click);
			// 
			// WhatsappMessage
			// 
			this.WhatsappMessage.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.WhatsappMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
			this.WhatsappMessage.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.WhatsappMessage.Location = new System.Drawing.Point(123, 191);
			this.WhatsappMessage.Name = "WhatsappMessage";
			this.WhatsappMessage.Size = new System.Drawing.Size(341, 25);
			this.WhatsappMessage.TabIndex = 0;
			// 
			// label15
			// 
			this.label15.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label15.AutoSize = true;
			this.label15.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.label15.ForeColor = System.Drawing.Color.Black;
			this.label15.Location = new System.Drawing.Point(58, 196);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(53, 15);
			this.label15.TabIndex = 99;
			this.label15.Text = "Message";
			// 
			// CloseEntry
			// 
			this.CloseEntry.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.CloseEntry.Location = new System.Drawing.Point(502, 189);
			this.CloseEntry.Name = "CloseEntry";
			this.CloseEntry.Size = new System.Drawing.Size(152, 29);
			this.CloseEntry.TabIndex = 2;
			this.CloseEntry.Text = "Close Entry";
			this.CloseEntry.UseVisualStyleBackColor = true;
			this.CloseEntry.Click += new System.EventHandler(this.CloseEntry_Click);
			// 
			// Action
			// 
			this.Action.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.Action.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
			this.Action.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.Action.Location = new System.Drawing.Point(418, 160);
			this.Action.Name = "Action";
			this.Action.ReadOnly = true;
			this.Action.Size = new System.Drawing.Size(236, 25);
			this.Action.TabIndex = 95;
			// 
			// label14
			// 
			this.label14.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label14.AutoSize = true;
			this.label14.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.label14.ForeColor = System.Drawing.Color.Black;
			this.label14.Location = new System.Drawing.Point(370, 165);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(42, 15);
			this.label14.TabIndex = 96;
			this.label14.Text = "Action";
			// 
			// Query
			// 
			this.Query.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.Query.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
			this.Query.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.Query.Location = new System.Drawing.Point(123, 160);
			this.Query.Name = "Query";
			this.Query.ReadOnly = true;
			this.Query.Size = new System.Drawing.Size(236, 25);
			this.Query.TabIndex = 93;
			// 
			// label13
			// 
			this.label13.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label13.AutoSize = true;
			this.label13.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.label13.ForeColor = System.Drawing.Color.Black;
			this.label13.Location = new System.Drawing.Point(76, 165);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(39, 15);
			this.label13.TabIndex = 94;
			this.label13.Text = "Query";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
			this.label9.ForeColor = System.Drawing.Color.Black;
			this.label9.Location = new System.Drawing.Point(11, 11);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(100, 19);
			this.label9.TabIndex = 92;
			this.label9.Text = "Fetched Entry";
			// 
			// Marketplace
			// 
			this.Marketplace.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.Marketplace.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.Marketplace.Enabled = false;
			this.Marketplace.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.Marketplace.FormattingEnabled = true;
			this.Marketplace.Items.AddRange(new object[] {
            "Amazon",
            "Flipkart",
            "Firstcry",
            "StarAndDaisy",
            "Others"});
			this.Marketplace.Location = new System.Drawing.Point(123, 98);
			this.Marketplace.Name = "Marketplace";
			this.Marketplace.Size = new System.Drawing.Size(236, 25);
			this.Marketplace.TabIndex = 81;
			// 
			// Product
			// 
			this.Product.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.Product.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
			this.Product.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.Product.Location = new System.Drawing.Point(418, 129);
			this.Product.Name = "Product";
			this.Product.ReadOnly = true;
			this.Product.Size = new System.Drawing.Size(236, 25);
			this.Product.TabIndex = 84;
			// 
			// label11
			// 
			this.label11.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.label11.ForeColor = System.Drawing.Color.Black;
			this.label11.Location = new System.Drawing.Point(363, 134);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(49, 15);
			this.label11.TabIndex = 91;
			this.label11.Text = "Product";
			// 
			// OrderDate
			// 
			this.OrderDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.OrderDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
			this.OrderDate.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.OrderDate.Location = new System.Drawing.Point(123, 129);
			this.OrderDate.Name = "OrderDate";
			this.OrderDate.ReadOnly = true;
			this.OrderDate.Size = new System.Drawing.Size(236, 25);
			this.OrderDate.TabIndex = 83;
			// 
			// label12
			// 
			this.label12.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.label12.ForeColor = System.Drawing.Color.Black;
			this.label12.Location = new System.Drawing.Point(53, 134);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(64, 15);
			this.label12.TabIndex = 90;
			this.label12.Text = "Order Date";
			// 
			// OrderNumber
			// 
			this.OrderNumber.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.OrderNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
			this.OrderNumber.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.OrderNumber.Location = new System.Drawing.Point(418, 98);
			this.OrderNumber.Name = "OrderNumber";
			this.OrderNumber.ReadOnly = true;
			this.OrderNumber.Size = new System.Drawing.Size(236, 25);
			this.OrderNumber.TabIndex = 82;
			// 
			// label10
			// 
			this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.label10.ForeColor = System.Drawing.Color.Black;
			this.label10.Location = new System.Drawing.Point(365, 103);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(47, 15);
			this.label10.TabIndex = 89;
			this.label10.Text = "Order #";
			// 
			// label8
			// 
			this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.label8.ForeColor = System.Drawing.Color.Black;
			this.label8.Location = new System.Drawing.Point(45, 103);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(72, 15);
			this.label8.TabIndex = 88;
			this.label8.Text = "Marketplace";
			// 
			// Email
			// 
			this.Email.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.Email.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
			this.Email.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.Email.Location = new System.Drawing.Point(418, 68);
			this.Email.Name = "Email";
			this.Email.ReadOnly = true;
			this.Email.Size = new System.Drawing.Size(236, 25);
			this.Email.TabIndex = 80;
			// 
			// label3
			// 
			this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.label3.ForeColor = System.Drawing.Color.Black;
			this.label3.Location = new System.Drawing.Point(376, 73);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(36, 15);
			this.label3.TabIndex = 87;
			this.label3.Text = "Email";
			// 
			// Phone
			// 
			this.Phone.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.Phone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
			this.Phone.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.Phone.Location = new System.Drawing.Point(123, 68);
			this.Phone.Name = "Phone";
			this.Phone.ReadOnly = true;
			this.Phone.Size = new System.Drawing.Size(236, 25);
			this.Phone.TabIndex = 79;
			// 
			// label5
			// 
			this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.label5.ForeColor = System.Drawing.Color.Black;
			this.label5.Location = new System.Drawing.Point(76, 74);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(41, 15);
			this.label5.TabIndex = 86;
			this.label5.Text = "Phone";
			// 
			// Customer
			// 
			this.Customer.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.Customer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
			this.Customer.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.Customer.Location = new System.Drawing.Point(123, 36);
			this.Customer.Name = "Customer";
			this.Customer.ReadOnly = true;
			this.Customer.Size = new System.Drawing.Size(531, 25);
			this.Customer.TabIndex = 78;
			this.Customer.TabStop = false;
			// 
			// label6
			// 
			this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.label6.ForeColor = System.Drawing.Color.Black;
			this.label6.Location = new System.Drawing.Point(78, 41);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(39, 15);
			this.label6.TabIndex = 85;
			this.label6.Text = "Name";
			// 
			// label2
			// 
			this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.label2.ForeColor = System.Drawing.Color.Black;
			this.label2.Location = new System.Drawing.Point(21, 74);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(321, 15);
			this.label2.TabIndex = 80;
			this.label2.Text = "Click the desired result row to fetch entry in following form:";
			// 
			// CustomerPhone
			// 
			this.CustomerPhone.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.CustomerPhone.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.CustomerPhone.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
			this.CustomerPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
			this.CustomerPhone.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.CustomerPhone.Location = new System.Drawing.Point(412, 29);
			this.CustomerPhone.Name = "CustomerPhone";
			this.CustomerPhone.Size = new System.Drawing.Size(173, 25);
			this.CustomerPhone.TabIndex = 81;
			this.CustomerPhone.Click += new System.EventHandler(this.CustomerPhone_Click);
			this.CustomerPhone.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CustomerPhone_KeyDown);
			// 
			// label16
			// 
			this.label16.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label16.AutoSize = true;
			this.label16.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.label16.ForeColor = System.Drawing.Color.Black;
			this.label16.Location = new System.Drawing.Point(365, 34);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(41, 15);
			this.label16.TabIndex = 82;
			this.label16.Text = "Phone";
			// 
			// UC_SearchEntry
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.Controls.Add(this.CustomerPhone);
			this.Controls.Add(this.label16);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.bunifuCards1);
			this.Controls.Add(this.CustomerName);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.dg);
			this.Controls.Add(this.pictureBox2);
			this.Name = "UC_SearchEntry";
			this.Size = new System.Drawing.Size(801, 473);
			this.Load += new System.EventHandler(this.UC_SearchEntry_Load);
			((System.ComponentModel.ISupportInitialize)(this.dg)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.customerEntryBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.bunifuCards1.ResumeLayout(false);
			this.bunifuCards1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox CustomerName;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label7;
		private Bunifu.Framework.UI.BunifuCustomDataGrid dg;
		private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.BindingSource customerEntryBindingSource;
		private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn customerNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn marketPlaceDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn orderNumberDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn orderDateDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn productDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn queryDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn actionDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn whatsappMessageDataGridViewTextBoxColumn;
		private Bunifu.Framework.UI.BunifuCards bunifuCards1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox Marketplace;
		private System.Windows.Forms.TextBox Product;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TextBox OrderDate;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.TextBox OrderNumber;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox Email;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox Phone;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox Customer;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox Query;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.TextBox Action;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Button CloseEntry;
		private System.Windows.Forms.TextBox WhatsappMessage;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Button Whatsapp;
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.TextBox CustomerPhone;
		private System.Windows.Forms.Label label16;
	}
}
