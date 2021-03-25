
namespace UPC_Shipment_Manager_UI.UserControls.Inventory
{
	partial class UC_GodownStock
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			this.label7 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.Godown = new System.Windows.Forms.ComboBox();
			this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
			this.dg = new Bunifu.Framework.UI.BunifuCustomDataGrid();
			this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.itemNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.godownDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.remarksDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.transactionDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.transactionTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.inventoryItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.Print = new System.Windows.Forms.PictureBox();
			this.Export = new System.Windows.Forms.PictureBox();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			((System.ComponentModel.ISupportInitialize)(this.dg)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.inventoryItemBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Print)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Export)).BeginInit();
			this.SuspendLayout();
			// 
			// label7
			// 
			this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
			this.label7.ForeColor = System.Drawing.Color.Black;
			this.label7.Location = new System.Drawing.Point(330, 14);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(110, 20);
			this.label7.TabIndex = 51;
			this.label7.Text = "Godown Stock";
			// 
			// label5
			// 
			this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.label5.ForeColor = System.Drawing.Color.Black;
			this.label5.Location = new System.Drawing.Point(183, 44);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(395, 15);
			this.label5.TabIndex = 53;
			this.label5.Text = "Please select a Godown from the following dropdown to get stock details:";
			// 
			// label2
			// 
			this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.label2.ForeColor = System.Drawing.Color.Black;
			this.label2.Location = new System.Drawing.Point(205, 76);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(74, 15);
			this.label2.TabIndex = 55;
			this.label2.Text = "Godown No.";
			// 
			// Godown
			// 
			this.Godown.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.Godown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.Godown.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.Godown.FormattingEnabled = true;
			this.Godown.Location = new System.Drawing.Point(285, 71);
			this.Godown.Name = "Godown";
			this.Godown.Size = new System.Drawing.Size(247, 25);
			this.Godown.Sorted = true;
			this.Godown.TabIndex = 54;
			this.Godown.SelectedIndexChanged += new System.EventHandler(this.Godown_SelectedIndexChanged);
			// 
			// bunifuElipse1
			// 
			this.bunifuElipse1.ElipseRadius = 7;
			this.bunifuElipse1.TargetControl = this.dg;
			// 
			// dg
			// 
			this.dg.AllowUserToAddRows = false;
			this.dg.AllowUserToDeleteRows = false;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.dg.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dg.AutoGenerateColumns = false;
			this.dg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dg.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dg.BackgroundColor = System.Drawing.Color.Gainsboro;
			this.dg.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dg.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.dg.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.Maroon;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dg.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.itemNameDataGridViewTextBoxColumn,
            this.godownDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.remarksDataGridViewTextBoxColumn,
            this.transactionDateDataGridViewTextBoxColumn,
            this.transactionTypeDataGridViewTextBoxColumn});
			this.dg.DataSource = this.inventoryItemBindingSource;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F);
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Transparent;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dg.DefaultCellStyle = dataGridViewCellStyle3;
			this.dg.DoubleBuffered = true;
			this.dg.EnableHeadersVisualStyles = false;
			this.dg.HeaderBgColor = System.Drawing.Color.Maroon;
			this.dg.HeaderForeColor = System.Drawing.Color.White;
			this.dg.Location = new System.Drawing.Point(61, 113);
			this.dg.MultiSelect = false;
			this.dg.Name = "dg";
			this.dg.ReadOnly = true;
			this.dg.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.dg.RowHeadersVisible = false;
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Transparent;
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
			this.dg.RowsDefaultCellStyle = dataGridViewCellStyle4;
			this.dg.Size = new System.Drawing.Size(675, 330);
			this.dg.TabIndex = 56;
			this.dg.TabStop = false;
			// 
			// idDataGridViewTextBoxColumn
			// 
			this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
			this.idDataGridViewTextBoxColumn.HeaderText = "Id";
			this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
			this.idDataGridViewTextBoxColumn.ReadOnly = true;
			this.idDataGridViewTextBoxColumn.Visible = false;
			// 
			// itemNameDataGridViewTextBoxColumn
			// 
			this.itemNameDataGridViewTextBoxColumn.DataPropertyName = "ItemName";
			this.itemNameDataGridViewTextBoxColumn.HeaderText = "Item Name";
			this.itemNameDataGridViewTextBoxColumn.Name = "itemNameDataGridViewTextBoxColumn";
			this.itemNameDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// godownDataGridViewTextBoxColumn
			// 
			this.godownDataGridViewTextBoxColumn.DataPropertyName = "Godown";
			this.godownDataGridViewTextBoxColumn.HeaderText = "Godown";
			this.godownDataGridViewTextBoxColumn.Name = "godownDataGridViewTextBoxColumn";
			this.godownDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// quantityDataGridViewTextBoxColumn
			// 
			this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
			this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
			this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
			this.quantityDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// remarksDataGridViewTextBoxColumn
			// 
			this.remarksDataGridViewTextBoxColumn.DataPropertyName = "Remarks";
			this.remarksDataGridViewTextBoxColumn.HeaderText = "Remarks";
			this.remarksDataGridViewTextBoxColumn.Name = "remarksDataGridViewTextBoxColumn";
			this.remarksDataGridViewTextBoxColumn.ReadOnly = true;
			this.remarksDataGridViewTextBoxColumn.Visible = false;
			// 
			// transactionDateDataGridViewTextBoxColumn
			// 
			this.transactionDateDataGridViewTextBoxColumn.DataPropertyName = "TransactionDate";
			this.transactionDateDataGridViewTextBoxColumn.HeaderText = "Last Modified";
			this.transactionDateDataGridViewTextBoxColumn.Name = "transactionDateDataGridViewTextBoxColumn";
			this.transactionDateDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// transactionTypeDataGridViewTextBoxColumn
			// 
			this.transactionTypeDataGridViewTextBoxColumn.DataPropertyName = "TransactionType";
			this.transactionTypeDataGridViewTextBoxColumn.HeaderText = "TransactionType";
			this.transactionTypeDataGridViewTextBoxColumn.Name = "transactionTypeDataGridViewTextBoxColumn";
			this.transactionTypeDataGridViewTextBoxColumn.ReadOnly = true;
			this.transactionTypeDataGridViewTextBoxColumn.Visible = false;
			// 
			// inventoryItemBindingSource
			// 
			this.inventoryItemBindingSource.DataSource = typeof(UPC.Library.InventoryModels.InventoryItem);
			// 
			// Print
			// 
			this.Print.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.Print.BackColor = System.Drawing.Color.White;
			this.Print.Cursor = System.Windows.Forms.Cursors.Hand;
			this.Print.Image = global::UPC_Shipment_Manager_UI.Properties.Resources.icons8_print_24px;
			this.Print.Location = new System.Drawing.Point(712, 83);
			this.Print.Name = "Print";
			this.Print.Size = new System.Drawing.Size(24, 24);
			this.Print.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.Print.TabIndex = 58;
			this.Print.TabStop = false;
			this.toolTip1.SetToolTip(this.Print, "Print");
			this.Print.Click += new System.EventHandler(this.Print_Click);
			// 
			// Export
			// 
			this.Export.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.Export.BackColor = System.Drawing.Color.White;
			this.Export.Cursor = System.Windows.Forms.Cursors.Hand;
			this.Export.Image = global::UPC_Shipment_Manager_UI.Properties.Resources.icons8_file_excel_24px_1;
			this.Export.Location = new System.Drawing.Point(688, 83);
			this.Export.Name = "Export";
			this.Export.Size = new System.Drawing.Size(24, 24);
			this.Export.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.Export.TabIndex = 57;
			this.Export.TabStop = false;
			this.toolTip1.SetToolTip(this.Export, "Export to Excel");
			this.Export.Click += new System.EventHandler(this.Export_Click);
			// 
			// UC_GodownStock
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.Controls.Add(this.Print);
			this.Controls.Add(this.Export);
			this.Controls.Add(this.dg);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.Godown);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label7);
			this.Name = "UC_GodownStock";
			this.Size = new System.Drawing.Size(801, 473);
			this.Load += new System.EventHandler(this.UC_GodownStock_Load);
			((System.ComponentModel.ISupportInitialize)(this.dg)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.inventoryItemBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Print)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Export)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox Godown;
		private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
		private Bunifu.Framework.UI.BunifuCustomDataGrid dg;
		private System.Windows.Forms.BindingSource inventoryItemBindingSource;
		private System.Windows.Forms.PictureBox Export;
		private System.Windows.Forms.PictureBox Print;
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn itemNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn godownDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn remarksDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn transactionDateDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn transactionTypeDataGridViewTextBoxColumn;
	}
}
