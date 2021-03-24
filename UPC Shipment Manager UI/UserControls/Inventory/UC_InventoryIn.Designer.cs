
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
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
			this.bunifuCustomDataGrid1 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label7 = new System.Windows.Forms.Label();
			this.Register = new System.Windows.Forms.Button();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.label5 = new System.Windows.Forms.Label();
			this.Export = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.Quantity)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Export)).BeginInit();
			this.SuspendLayout();
			// 
			// SoftwareName
			// 
			this.SoftwareName.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.SoftwareName.AutoSize = true;
			this.SoftwareName.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
			this.SoftwareName.ForeColor = System.Drawing.Color.Black;
			this.SoftwareName.Location = new System.Drawing.Point(319, 229);
			this.SoftwareName.Name = "SoftwareName";
			this.SoftwareName.Size = new System.Drawing.Size(152, 20);
			this.SoftwareName.TabIndex = 2;
			this.SoftwareName.Text = "Last 20 Transactions";
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
			this.ItemName.Location = new System.Drawing.Point(460, 81);
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
			this.label4.Location = new System.Drawing.Point(388, 86);
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
			this.label2.Location = new System.Drawing.Point(56, 86);
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
			this.Godown.Location = new System.Drawing.Point(136, 81);
			this.Godown.Name = "Godown";
			this.Godown.Size = new System.Drawing.Size(236, 25);
			this.Godown.TabIndex = 0;
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
			// bunifuCustomDataGrid1
			// 
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.bunifuCustomDataGrid1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.bunifuCustomDataGrid1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.bunifuCustomDataGrid1.BackgroundColor = System.Drawing.Color.Gainsboro;
			this.bunifuCustomDataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.bunifuCustomDataGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.Maroon;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8.25F);
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.bunifuCustomDataGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.bunifuCustomDataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.bunifuCustomDataGrid1.DoubleBuffered = true;
			this.bunifuCustomDataGrid1.EnableHeadersVisualStyles = false;
			this.bunifuCustomDataGrid1.HeaderBgColor = System.Drawing.Color.Maroon;
			this.bunifuCustomDataGrid1.HeaderForeColor = System.Drawing.Color.White;
			this.bunifuCustomDataGrid1.Location = new System.Drawing.Point(72, 259);
			this.bunifuCustomDataGrid1.Name = "bunifuCustomDataGrid1";
			this.bunifuCustomDataGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.bunifuCustomDataGrid1.Size = new System.Drawing.Size(648, 224);
			this.bunifuCustomDataGrid1.TabIndex = 30;
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
			// dateTimePicker1
			// 
			this.dateTimePicker1.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.dateTimePicker1.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
			this.dateTimePicker1.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
			this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateTimePicker1.Location = new System.Drawing.Point(136, 143);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(236, 22);
			this.dateTimePicker1.TabIndex = 4;
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
			// Export
			// 
			this.Export.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.Export.BackColor = System.Drawing.Color.White;
			this.Export.Cursor = System.Windows.Forms.Cursors.Hand;
			this.Export.Image = global::UPC_Shipment_Manager_UI.Properties.Resources.excel_24px_dark;
			this.Export.Location = new System.Drawing.Point(690, 223);
			this.Export.Name = "Export";
			this.Export.Size = new System.Drawing.Size(30, 30);
			this.Export.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.Export.TabIndex = 34;
			this.Export.TabStop = false;
			// 
			// UC_InventoryIn
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.Controls.Add(this.label5);
			this.Controls.Add(this.dateTimePicker1);
			this.Controls.Add(this.Export);
			this.Controls.Add(this.Register);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.bunifuCustomDataGrid1);
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
			((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).EndInit();
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
		private Bunifu.Framework.UI.BunifuCustomDataGrid bunifuCustomDataGrid1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Button Register;
		private System.Windows.Forms.PictureBox Export;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.Label label5;
	}
}
