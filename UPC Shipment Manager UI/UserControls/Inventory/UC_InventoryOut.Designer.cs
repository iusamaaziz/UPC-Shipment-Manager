
namespace UPC_Shipment_Manager_UI.UserControls.Inventory
{
	partial class UC_InventoryOut
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.SingleItem = new System.Windows.Forms.TabPage();
			this.CreatePicklist = new System.Windows.Forms.TabPage();
			this.label5 = new System.Windows.Forms.Label();
			this.OutDate = new System.Windows.Forms.DateTimePicker();
			this.button1 = new System.Windows.Forms.Button();
			this.label7 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.bunifuCustomDataGrid1 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
			this.label3 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.Quantity = new System.Windows.Forms.NumericUpDown();
			this.Remarks = new System.Windows.Forms.RichTextBox();
			this.ItemName = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.Godown = new System.Windows.Forms.ComboBox();
			this.SoftwareName = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.PLOutDate = new System.Windows.Forms.DateTimePicker();
			this.AddToPicklist = new System.Windows.Forms.Button();
			this.label9 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.ItemsAddedGrid = new Bunifu.Framework.UI.BunifuCustomDataGrid();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.PLQuantity = new System.Windows.Forms.NumericUpDown();
			this.PLRemarks = new System.Windows.Forms.RichTextBox();
			this.PLItemName = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.PLGodown = new System.Windows.Forms.ComboBox();
			this.label15 = new System.Windows.Forms.Label();
			this.Checkout = new System.Windows.Forms.Button();
			this.Export = new System.Windows.Forms.PictureBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.tabControl1.SuspendLayout();
			this.SingleItem.SuspendLayout();
			this.CreatePicklist.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Quantity)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemsAddedGrid)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PLQuantity)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Export)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.SingleItem);
			this.tabControl1.Controls.Add(this.CreatePicklist);
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl1.HotTrack = true;
			this.tabControl1.Location = new System.Drawing.Point(0, 0);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(801, 498);
			this.tabControl1.TabIndex = 0;
			// 
			// SingleItem
			// 
			this.SingleItem.Controls.Add(this.label5);
			this.SingleItem.Controls.Add(this.OutDate);
			this.SingleItem.Controls.Add(this.Export);
			this.SingleItem.Controls.Add(this.button1);
			this.SingleItem.Controls.Add(this.label7);
			this.SingleItem.Controls.Add(this.panel1);
			this.SingleItem.Controls.Add(this.bunifuCustomDataGrid1);
			this.SingleItem.Controls.Add(this.label3);
			this.SingleItem.Controls.Add(this.label1);
			this.SingleItem.Controls.Add(this.Quantity);
			this.SingleItem.Controls.Add(this.Remarks);
			this.SingleItem.Controls.Add(this.ItemName);
			this.SingleItem.Controls.Add(this.label6);
			this.SingleItem.Controls.Add(this.label4);
			this.SingleItem.Controls.Add(this.label2);
			this.SingleItem.Controls.Add(this.Godown);
			this.SingleItem.Controls.Add(this.SoftwareName);
			this.SingleItem.Location = new System.Drawing.Point(4, 24);
			this.SingleItem.Name = "SingleItem";
			this.SingleItem.Padding = new System.Windows.Forms.Padding(3);
			this.SingleItem.Size = new System.Drawing.Size(793, 470);
			this.SingleItem.TabIndex = 0;
			this.SingleItem.Text = "Single Item";
			this.SingleItem.UseVisualStyleBackColor = true;
			// 
			// CreatePicklist
			// 
			this.CreatePicklist.Controls.Add(this.Checkout);
			this.CreatePicklist.Controls.Add(this.label8);
			this.CreatePicklist.Controls.Add(this.PLOutDate);
			this.CreatePicklist.Controls.Add(this.pictureBox1);
			this.CreatePicklist.Controls.Add(this.AddToPicklist);
			this.CreatePicklist.Controls.Add(this.label9);
			this.CreatePicklist.Controls.Add(this.panel2);
			this.CreatePicklist.Controls.Add(this.ItemsAddedGrid);
			this.CreatePicklist.Controls.Add(this.label10);
			this.CreatePicklist.Controls.Add(this.label11);
			this.CreatePicklist.Controls.Add(this.PLQuantity);
			this.CreatePicklist.Controls.Add(this.PLRemarks);
			this.CreatePicklist.Controls.Add(this.PLItemName);
			this.CreatePicklist.Controls.Add(this.label12);
			this.CreatePicklist.Controls.Add(this.label13);
			this.CreatePicklist.Controls.Add(this.label14);
			this.CreatePicklist.Controls.Add(this.PLGodown);
			this.CreatePicklist.Controls.Add(this.label15);
			this.CreatePicklist.Location = new System.Drawing.Point(4, 24);
			this.CreatePicklist.Name = "CreatePicklist";
			this.CreatePicklist.Padding = new System.Windows.Forms.Padding(3);
			this.CreatePicklist.Size = new System.Drawing.Size(793, 470);
			this.CreatePicklist.TabIndex = 1;
			this.CreatePicklist.Text = "Create Picklist";
			this.CreatePicklist.UseVisualStyleBackColor = true;
			// 
			// label5
			// 
			this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.label5.ForeColor = System.Drawing.Color.Black;
			this.label5.Location = new System.Drawing.Point(64, 39);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(393, 15);
			this.label5.TabIndex = 52;
			this.label5.Text = "Please fill out the following information to take out single inventory item:";
			// 
			// OutDate
			// 
			this.OutDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.OutDate.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
			this.OutDate.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
			this.OutDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.OutDate.Location = new System.Drawing.Point(144, 129);
			this.OutDate.Name = "OutDate";
			this.OutDate.Size = new System.Drawing.Size(236, 23);
			this.OutDate.TabIndex = 4;
			// 
			// button1
			// 
			this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.button1.Location = new System.Drawing.Point(331, 162);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(141, 29);
			this.button1.TabIndex = 5;
			this.button1.Text = "Confirm";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// label7
			// 
			this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
			this.label7.ForeColor = System.Drawing.Color.Black;
			this.label7.Location = new System.Drawing.Point(329, 7);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(144, 20);
			this.label7.TabIndex = 50;
			this.label7.Text = "New Inventory Out";
			// 
			// panel1
			// 
			this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.panel1.BackColor = System.Drawing.Color.Maroon;
			this.panel1.Location = new System.Drawing.Point(148, 206);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(517, 1);
			this.panel1.TabIndex = 49;
			// 
			// bunifuCustomDataGrid1
			// 
			dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.bunifuCustomDataGrid1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
			this.bunifuCustomDataGrid1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.bunifuCustomDataGrid1.BackgroundColor = System.Drawing.Color.Gainsboro;
			this.bunifuCustomDataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.bunifuCustomDataGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle8.BackColor = System.Drawing.Color.Maroon;
			dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 9F);
			dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.bunifuCustomDataGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
			this.bunifuCustomDataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.bunifuCustomDataGrid1.DoubleBuffered = true;
			this.bunifuCustomDataGrid1.EnableHeadersVisualStyles = false;
			this.bunifuCustomDataGrid1.HeaderBgColor = System.Drawing.Color.Maroon;
			this.bunifuCustomDataGrid1.HeaderForeColor = System.Drawing.Color.White;
			this.bunifuCustomDataGrid1.Location = new System.Drawing.Point(80, 242);
			this.bunifuCustomDataGrid1.Name = "bunifuCustomDataGrid1";
			this.bunifuCustomDataGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.bunifuCustomDataGrid1.Size = new System.Drawing.Size(648, 218);
			this.bunifuCustomDataGrid1.TabIndex = 48;
			// 
			// label3
			// 
			this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.label3.ForeColor = System.Drawing.Color.Black;
			this.label3.Location = new System.Drawing.Point(107, 128);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(31, 15);
			this.label3.TabIndex = 47;
			this.label3.Text = "Date";
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.label1.ForeColor = System.Drawing.Color.Black;
			this.label1.Location = new System.Drawing.Point(85, 102);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(53, 15);
			this.label1.TabIndex = 46;
			this.label1.Text = "Quantity";
			// 
			// Quantity
			// 
			this.Quantity.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.Quantity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
			this.Quantity.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.Quantity.Location = new System.Drawing.Point(144, 98);
			this.Quantity.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
			this.Quantity.Name = "Quantity";
			this.Quantity.Size = new System.Drawing.Size(236, 25);
			this.Quantity.TabIndex = 2;
			// 
			// Remarks
			// 
			this.Remarks.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.Remarks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
			this.Remarks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Remarks.Location = new System.Drawing.Point(468, 98);
			this.Remarks.Name = "Remarks";
			this.Remarks.Size = new System.Drawing.Size(247, 52);
			this.Remarks.TabIndex = 3;
			this.Remarks.Text = "";
			// 
			// ItemName
			// 
			this.ItemName.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.ItemName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
			this.ItemName.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.ItemName.Location = new System.Drawing.Point(468, 67);
			this.ItemName.Name = "ItemName";
			this.ItemName.Size = new System.Drawing.Size(247, 25);
			this.ItemName.TabIndex = 1;
			// 
			// label6
			// 
			this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.label6.ForeColor = System.Drawing.Color.Black;
			this.label6.Location = new System.Drawing.Point(409, 102);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(52, 15);
			this.label6.TabIndex = 45;
			this.label6.Text = "Remarks";
			// 
			// label4
			// 
			this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.label4.ForeColor = System.Drawing.Color.Black;
			this.label4.Location = new System.Drawing.Point(396, 72);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(66, 15);
			this.label4.TabIndex = 44;
			this.label4.Text = "Item Name";
			// 
			// label2
			// 
			this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.label2.ForeColor = System.Drawing.Color.Black;
			this.label2.Location = new System.Drawing.Point(64, 72);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(74, 15);
			this.label2.TabIndex = 43;
			this.label2.Text = "Godown No.";
			// 
			// Godown
			// 
			this.Godown.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.Godown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.Godown.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.Godown.FormattingEnabled = true;
			this.Godown.Location = new System.Drawing.Point(144, 67);
			this.Godown.Name = "Godown";
			this.Godown.Size = new System.Drawing.Size(236, 25);
			this.Godown.TabIndex = 0;
			// 
			// SoftwareName
			// 
			this.SoftwareName.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.SoftwareName.AutoSize = true;
			this.SoftwareName.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
			this.SoftwareName.ForeColor = System.Drawing.Color.Black;
			this.SoftwareName.Location = new System.Drawing.Point(327, 212);
			this.SoftwareName.Name = "SoftwareName";
			this.SoftwareName.Size = new System.Drawing.Size(152, 20);
			this.SoftwareName.TabIndex = 38;
			this.SoftwareName.Text = "Last 20 Transactions";
			// 
			// label8
			// 
			this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.label8.ForeColor = System.Drawing.Color.Black;
			this.label8.Location = new System.Drawing.Point(64, 33);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(319, 15);
			this.label8.TabIndex = 69;
			this.label8.Text = "Please fill out the following information to take out picklist:";
			// 
			// PLOutDate
			// 
			this.PLOutDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.PLOutDate.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
			this.PLOutDate.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
			this.PLOutDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.PLOutDate.Location = new System.Drawing.Point(144, 121);
			this.PLOutDate.Name = "PLOutDate";
			this.PLOutDate.Size = new System.Drawing.Size(236, 23);
			this.PLOutDate.TabIndex = 4;
			// 
			// AddToPicklist
			// 
			this.AddToPicklist.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.AddToPicklist.Location = new System.Drawing.Point(331, 154);
			this.AddToPicklist.Name = "AddToPicklist";
			this.AddToPicklist.Size = new System.Drawing.Size(141, 29);
			this.AddToPicklist.TabIndex = 5;
			this.AddToPicklist.Text = "Add to Picklist";
			this.AddToPicklist.UseVisualStyleBackColor = true;
			// 
			// label9
			// 
			this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
			this.label9.ForeColor = System.Drawing.Color.Black;
			this.label9.Location = new System.Drawing.Point(347, 6);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(94, 20);
			this.label9.TabIndex = 67;
			this.label9.Text = "New Picklist";
			// 
			// panel2
			// 
			this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.panel2.BackColor = System.Drawing.Color.Maroon;
			this.panel2.Location = new System.Drawing.Point(144, 187);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(517, 1);
			this.panel2.TabIndex = 66;
			// 
			// ItemsAddedGrid
			// 
			dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.ItemsAddedGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
			this.ItemsAddedGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.ItemsAddedGrid.BackgroundColor = System.Drawing.Color.Gainsboro;
			this.ItemsAddedGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.ItemsAddedGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle6.BackColor = System.Drawing.Color.Maroon;
			dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F);
			dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.ItemsAddedGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
			this.ItemsAddedGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.ItemsAddedGrid.DoubleBuffered = true;
			this.ItemsAddedGrid.EnableHeadersVisualStyles = false;
			this.ItemsAddedGrid.HeaderBgColor = System.Drawing.Color.Maroon;
			this.ItemsAddedGrid.HeaderForeColor = System.Drawing.Color.White;
			this.ItemsAddedGrid.Location = new System.Drawing.Point(88, 219);
			this.ItemsAddedGrid.Name = "ItemsAddedGrid";
			this.ItemsAddedGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.ItemsAddedGrid.Size = new System.Drawing.Size(648, 210);
			this.ItemsAddedGrid.TabIndex = 6;
			// 
			// label10
			// 
			this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.label10.ForeColor = System.Drawing.Color.Black;
			this.label10.Location = new System.Drawing.Point(107, 125);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(31, 15);
			this.label10.TabIndex = 64;
			this.label10.Text = "Date";
			// 
			// label11
			// 
			this.label11.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.label11.ForeColor = System.Drawing.Color.Black;
			this.label11.Location = new System.Drawing.Point(85, 94);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(53, 15);
			this.label11.TabIndex = 63;
			this.label11.Text = "Quantity";
			// 
			// PLQuantity
			// 
			this.PLQuantity.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.PLQuantity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
			this.PLQuantity.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.PLQuantity.Location = new System.Drawing.Point(144, 90);
			this.PLQuantity.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
			this.PLQuantity.Name = "PLQuantity";
			this.PLQuantity.Size = new System.Drawing.Size(236, 25);
			this.PLQuantity.TabIndex = 2;
			// 
			// PLRemarks
			// 
			this.PLRemarks.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.PLRemarks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
			this.PLRemarks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.PLRemarks.Location = new System.Drawing.Point(468, 90);
			this.PLRemarks.Name = "PLRemarks";
			this.PLRemarks.Size = new System.Drawing.Size(247, 52);
			this.PLRemarks.TabIndex = 3;
			this.PLRemarks.Text = "";
			// 
			// PLItemName
			// 
			this.PLItemName.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.PLItemName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
			this.PLItemName.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.PLItemName.Location = new System.Drawing.Point(468, 59);
			this.PLItemName.Name = "PLItemName";
			this.PLItemName.Size = new System.Drawing.Size(247, 25);
			this.PLItemName.TabIndex = 1;
			// 
			// label12
			// 
			this.label12.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.label12.ForeColor = System.Drawing.Color.Black;
			this.label12.Location = new System.Drawing.Point(409, 94);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(52, 15);
			this.label12.TabIndex = 62;
			this.label12.Text = "Remarks";
			// 
			// label13
			// 
			this.label13.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label13.AutoSize = true;
			this.label13.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.label13.ForeColor = System.Drawing.Color.Black;
			this.label13.Location = new System.Drawing.Point(396, 64);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(66, 15);
			this.label13.TabIndex = 61;
			this.label13.Text = "Item Name";
			// 
			// label14
			// 
			this.label14.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label14.AutoSize = true;
			this.label14.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.label14.ForeColor = System.Drawing.Color.Black;
			this.label14.Location = new System.Drawing.Point(64, 64);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(74, 15);
			this.label14.TabIndex = 60;
			this.label14.Text = "Godown No.";
			// 
			// PLGodown
			// 
			this.PLGodown.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.PLGodown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.PLGodown.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.PLGodown.FormattingEnabled = true;
			this.PLGodown.Location = new System.Drawing.Point(144, 59);
			this.PLGodown.Name = "PLGodown";
			this.PLGodown.Size = new System.Drawing.Size(236, 25);
			this.PLGodown.TabIndex = 0;
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
			this.label15.ForeColor = System.Drawing.Color.Black;
			this.label15.Location = new System.Drawing.Point(92, 193);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(103, 20);
			this.label15.TabIndex = 55;
			this.label15.Text = "Items Added:";
			// 
			// Checkout
			// 
			this.Checkout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.Checkout.Location = new System.Drawing.Point(581, 435);
			this.Checkout.Name = "Checkout";
			this.Checkout.Size = new System.Drawing.Size(155, 29);
			this.Checkout.TabIndex = 7;
			this.Checkout.Text = "Checkout && Print";
			this.Checkout.UseVisualStyleBackColor = true;
			// 
			// Export
			// 
			this.Export.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.Export.BackColor = System.Drawing.Color.White;
			this.Export.Cursor = System.Windows.Forms.Cursors.Hand;
			this.Export.Image = global::UPC_Shipment_Manager_UI.Properties.Resources.excel_24px_dark;
			this.Export.Location = new System.Drawing.Point(698, 206);
			this.Export.Name = "Export";
			this.Export.Size = new System.Drawing.Size(30, 30);
			this.Export.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.Export.TabIndex = 51;
			this.Export.TabStop = false;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox1.BackColor = System.Drawing.Color.White;
			this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pictureBox1.Image = global::UPC_Shipment_Manager_UI.Properties.Resources.excel_24px_dark;
			this.pictureBox1.Location = new System.Drawing.Point(705, 183);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(30, 30);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pictureBox1.TabIndex = 68;
			this.pictureBox1.TabStop = false;
			// 
			// UC_InventoryOut
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.Controls.Add(this.tabControl1);
			this.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.Name = "UC_InventoryOut";
			this.Size = new System.Drawing.Size(801, 498);
			this.tabControl1.ResumeLayout(false);
			this.SingleItem.ResumeLayout(false);
			this.SingleItem.PerformLayout();
			this.CreatePicklist.ResumeLayout(false);
			this.CreatePicklist.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Quantity)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemsAddedGrid)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PLQuantity)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Export)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage SingleItem;
		private System.Windows.Forms.TabPage CreatePicklist;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.DateTimePicker OutDate;
		private System.Windows.Forms.PictureBox Export;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Panel panel1;
		private Bunifu.Framework.UI.BunifuCustomDataGrid bunifuCustomDataGrid1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.NumericUpDown Quantity;
		private System.Windows.Forms.RichTextBox Remarks;
		private System.Windows.Forms.TextBox ItemName;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox Godown;
		private System.Windows.Forms.Label SoftwareName;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.DateTimePicker PLOutDate;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button AddToPicklist;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Panel panel2;
		private Bunifu.Framework.UI.BunifuCustomDataGrid ItemsAddedGrid;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.NumericUpDown PLQuantity;
		private System.Windows.Forms.RichTextBox PLRemarks;
		private System.Windows.Forms.TextBox PLItemName;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.ComboBox PLGodown;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Button Checkout;
	}
}
