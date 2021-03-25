
namespace UPC_Shipment_Manager_UI.UserControls.Inventory
{
	partial class UC_InventoryIn
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
			this.SoftwareName = new System.Windows.Forms.Label();
			this.Remarks = new System.Windows.Forms.RichTextBox();
			this.ItemName = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.Godown = new System.Windows.Forms.ComboBox();
			this.Quantity = new System.Windows.Forms.NumericUpDown();
			this.label1 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.dg = new Bunifu.Framework.UI.BunifuCustomDataGrid();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label7 = new System.Windows.Forms.Label();
			this.Register = new System.Windows.Forms.Button();
			this.TransactionDate = new System.Windows.Forms.DateTimePicker();
			this.label5 = new System.Windows.Forms.Label();
			this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.NewGodown = new System.Windows.Forms.PictureBox();
			this.Export = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.Quantity)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dg)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.NewGodown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Export)).BeginInit();
			this.SuspendLayout();
			// 
			// SoftwareName
			// 
			this.SoftwareName.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.SoftwareName.AutoSize = true;
			this.SoftwareName.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
			this.SoftwareName.ForeColor = System.Drawing.Color.Black;
			this.SoftwareName.Location = new System.Drawing.Point(332, 229);
			this.SoftwareName.Name = "SoftwareName";
			this.SoftwareName.Size = new System.Drawing.Size(130, 20);
			this.SoftwareName.TabIndex = 2;
			this.SoftwareName.Text = "Inventory Details";
			// 
			// Remarks
			// 
			this.Remarks.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.Remarks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
			this.Remarks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Remarks.Location = new System.Drawing.Point(460, 112);
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
			this.ItemName.Location = new System.Drawing.Point(136, 81);
			this.ItemName.Name = "ItemName";
			this.ItemName.Size = new System.Drawing.Size(236, 25);
			this.ItemName.TabIndex = 0;
			// 
			// label6
			// 
			this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.label6.ForeColor = System.Drawing.Color.Black;
			this.label6.Location = new System.Drawing.Point(401, 116);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(52, 15);
			this.label6.TabIndex = 25;
			this.label6.Text = "Remarks";
			// 
			// label4
			// 
			this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.label4.ForeColor = System.Drawing.Color.Black;
			this.label4.Location = new System.Drawing.Point(64, 86);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(66, 15);
			this.label4.TabIndex = 24;
			this.label4.Text = "Item Name";
			// 
			// label2
			// 
			this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.label2.ForeColor = System.Drawing.Color.Black;
			this.label2.Location = new System.Drawing.Point(380, 86);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(74, 15);
			this.label2.TabIndex = 23;
			this.label2.Text = "Godown No.";
			// 
			// Godown
			// 
			this.Godown.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.Godown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.Godown.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.Godown.FormattingEnabled = true;
			this.Godown.Location = new System.Drawing.Point(460, 81);
			this.Godown.Name = "Godown";
			this.Godown.Size = new System.Drawing.Size(247, 25);
			this.Godown.TabIndex = 1;
			this.Godown.SelectedIndexChanged += new System.EventHandler(this.Godown_SelectedIndexChanged);
			// 
			// Quantity
			// 
			this.Quantity.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.Quantity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
			this.Quantity.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.Quantity.Location = new System.Drawing.Point(136, 112);
			this.Quantity.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
			this.Quantity.Name = "Quantity";
			this.Quantity.Size = new System.Drawing.Size(236, 25);
			this.Quantity.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.label1.ForeColor = System.Drawing.Color.Black;
			this.label1.Location = new System.Drawing.Point(77, 116);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(53, 15);
			this.label1.TabIndex = 27;
			this.label1.Text = "Quantity";
			// 
			// label3
			// 
			this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.label3.ForeColor = System.Drawing.Color.Black;
			this.label3.Location = new System.Drawing.Point(99, 145);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(31, 15);
			this.label3.TabIndex = 28;
			this.label3.Text = "Date";
			// 
			// dg
			// 
			this.dg.AllowUserToAddRows = false;
			this.dg.AllowUserToDeleteRows = false;
			dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.dg.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
			this.dg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dg.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dg.BackgroundColor = System.Drawing.Color.Gainsboro;
			this.dg.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dg.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.dg.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle6.BackColor = System.Drawing.Color.Maroon;
			dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 8.25F);
			dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dg.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
			this.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
			dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 8.25F);
			dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Transparent;
			dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dg.DefaultCellStyle = dataGridViewCellStyle7;
			this.dg.DoubleBuffered = true;
			this.dg.EnableHeadersVisualStyles = false;
			this.dg.HeaderBgColor = System.Drawing.Color.Maroon;
			this.dg.HeaderForeColor = System.Drawing.Color.White;
			this.dg.Location = new System.Drawing.Point(59, 259);
			this.dg.MultiSelect = false;
			this.dg.Name = "dg";
			this.dg.ReadOnly = true;
			this.dg.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.dg.RowHeadersVisible = false;
			dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Transparent;
			dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
			this.dg.RowsDefaultCellStyle = dataGridViewCellStyle8;
			this.dg.Size = new System.Drawing.Size(675, 224);
			this.dg.TabIndex = 30;
			this.dg.TabStop = false;
			// 
			// Column1
			// 
			this.Column1.DataPropertyName = "Id";
			this.Column1.HeaderText = "Id";
			this.Column1.Name = "Column1";
			this.Column1.ReadOnly = true;
			this.Column1.Visible = false;
			// 
			// Column2
			// 
			this.Column2.DataPropertyName = "ItemName";
			this.Column2.HeaderText = "Item Name";
			this.Column2.Name = "Column2";
			this.Column2.ReadOnly = true;
			// 
			// Column3
			// 
			this.Column3.DataPropertyName = "Godown";
			this.Column3.HeaderText = "Godown No.";
			this.Column3.Name = "Column3";
			this.Column3.ReadOnly = true;
			// 
			// Column4
			// 
			this.Column4.DataPropertyName = "Quantity";
			this.Column4.HeaderText = "Quantity";
			this.Column4.Name = "Column4";
			this.Column4.ReadOnly = true;
			// 
			// Column5
			// 
			this.Column5.DataPropertyName = "Remarks";
			this.Column5.HeaderText = "Remarks";
			this.Column5.Name = "Column5";
			this.Column5.ReadOnly = true;
			// 
			// Column6
			// 
			this.Column6.DataPropertyName = "TransactionDate";
			this.Column6.HeaderText = "Date";
			this.Column6.Name = "Column6";
			this.Column6.ReadOnly = true;
			// 
			// panel1
			// 
			this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.panel1.BackColor = System.Drawing.Color.Maroon;
			this.panel1.Location = new System.Drawing.Point(140, 223);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(517, 1);
			this.panel1.TabIndex = 31;
			// 
			// label7
			// 
			this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
			this.label7.ForeColor = System.Drawing.Color.Black;
			this.label7.Location = new System.Drawing.Point(321, 21);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(132, 20);
			this.label7.TabIndex = 32;
			this.label7.Text = "New Inventory In";
			// 
			// Register
			// 
			this.Register.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.Register.Location = new System.Drawing.Point(323, 178);
			this.Register.Name = "Register";
			this.Register.Size = new System.Drawing.Size(141, 29);
			this.Register.TabIndex = 5;
			this.Register.Text = "Register";
			this.Register.UseVisualStyleBackColor = true;
			this.Register.Click += new System.EventHandler(this.Register_Click);
			// 
			// TransactionDate
			// 
			this.TransactionDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.TransactionDate.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
			this.TransactionDate.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
			this.TransactionDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.TransactionDate.Location = new System.Drawing.Point(136, 142);
			this.TransactionDate.Name = "TransactionDate";
			this.TransactionDate.Size = new System.Drawing.Size(236, 22);
			this.TransactionDate.TabIndex = 4;
			// 
			// label5
			// 
			this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.label5.ForeColor = System.Drawing.Color.Black;
			this.label5.Location = new System.Drawing.Point(56, 53);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(396, 15);
			this.label5.TabIndex = 35;
			this.label5.Text = "Please fill out the following information to register new inventory in entry.";
			// 
			// bunifuElipse1
			// 
			this.bunifuElipse1.ElipseRadius = 7;
			this.bunifuElipse1.TargetControl = this.dg;
			// 
			// NewGodown
			// 
			this.NewGodown.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.NewGodown.BackColor = System.Drawing.Color.White;
			this.NewGodown.Cursor = System.Windows.Forms.Cursors.Hand;
			this.NewGodown.Image = global::UPC_Shipment_Manager_UI.Properties.Resources.icons8_add_24px;
			this.NewGodown.Location = new System.Drawing.Point(710, 82);
			this.NewGodown.Name = "NewGodown";
			this.NewGodown.Size = new System.Drawing.Size(24, 24);
			this.NewGodown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.NewGodown.TabIndex = 36;
			this.NewGodown.TabStop = false;
			this.toolTip1.SetToolTip(this.NewGodown, "Add new Godown number");
			this.NewGodown.Click += new System.EventHandler(this.NewGodown_Click);
			// 
			// Export
			// 
			this.Export.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.Export.BackColor = System.Drawing.Color.White;
			this.Export.Cursor = System.Windows.Forms.Cursors.Hand;
			this.Export.Image = global::UPC_Shipment_Manager_UI.Properties.Resources.icons8_file_excel_24px_1;
			this.Export.Location = new System.Drawing.Point(710, 229);
			this.Export.Name = "Export";
			this.Export.Size = new System.Drawing.Size(24, 24);
			this.Export.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.Export.TabIndex = 34;
			this.Export.TabStop = false;
			this.toolTip1.SetToolTip(this.Export, "Export last 30 transactions");
			// 
			// UC_InventoryIn
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.Controls.Add(this.NewGodown);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.TransactionDate);
			this.Controls.Add(this.Export);
			this.Controls.Add(this.Register);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.dg);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.Quantity);
			this.Controls.Add(this.Remarks);
			this.Controls.Add(this.ItemName);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.Godown);
			this.Controls.Add(this.SoftwareName);
			this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
			this.ForeColor = System.Drawing.Color.Black;
			this.Name = "UC_InventoryIn";
			this.Size = new System.Drawing.Size(801, 498);
			this.Load += new System.EventHandler(this.UC_InventoryIn_Load);
			((System.ComponentModel.ISupportInitialize)(this.Quantity)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dg)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.NewGodown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Export)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label SoftwareName;
		private System.Windows.Forms.RichTextBox Remarks;
		private System.Windows.Forms.TextBox ItemName;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox Godown;
		private System.Windows.Forms.NumericUpDown Quantity;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label3;
		private Bunifu.Framework.UI.BunifuCustomDataGrid dg;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Button Register;
		private System.Windows.Forms.PictureBox Export;
		private System.Windows.Forms.DateTimePicker TransactionDate;
		private System.Windows.Forms.Label label5;
		private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
		private System.Windows.Forms.PictureBox NewGodown;
		private System.Windows.Forms.ToolTip toolTip1;
	}
}
