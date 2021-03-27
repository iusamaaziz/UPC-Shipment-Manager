
namespace UPC_Shipment_Manager_UI.UserControls.Shipment
{
	partial class UC_ShipementReportDateRange
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
			this.label4 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.dg = new Bunifu.Framework.UI.BunifuCustomDataGrid();
			this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.trackingIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.courierNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.itemNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.itemConditionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.remarksDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.shipmentTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.customerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.inwardSingleShipmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.label2 = new System.Windows.Forms.Label();
			this.From = new System.Windows.Forms.DateTimePicker();
			this.To = new System.Windows.Forms.DateTimePicker();
			this.Search = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dg)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.inwardSingleShipmentBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.SuspendLayout();
			// 
			// label4
			// 
			this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.label4.ForeColor = System.Drawing.Color.Black;
			this.label4.Location = new System.Drawing.Point(175, 49);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(35, 15);
			this.label4.TabIndex = 77;
			this.label4.Text = "From";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
			this.label1.ForeColor = System.Drawing.Color.Black;
			this.label1.Location = new System.Drawing.Point(55, 104);
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
			this.label7.Location = new System.Drawing.Point(312, 12);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(163, 20);
			this.label7.TabIndex = 74;
			this.label7.Text = "Search between Dates";
			// 
			// dg
			// 
			this.dg.AllowUserToAddRows = false;
			this.dg.AllowUserToDeleteRows = false;
			dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.dg.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
			this.dg.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dg.AutoGenerateColumns = false;
			this.dg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dg.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dg.BackgroundColor = System.Drawing.Color.Gainsboro;
			this.dg.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dg.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.dg.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle6.BackColor = System.Drawing.Color.Maroon;
			dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F);
			dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dg.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
			this.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dateDataGridViewTextBoxColumn,
            this.trackingIdDataGridViewTextBoxColumn,
            this.courierNameDataGridViewTextBoxColumn,
            this.itemNameDataGridViewTextBoxColumn,
            this.itemConditionDataGridViewTextBoxColumn,
            this.remarksDataGridViewTextBoxColumn,
            this.shipmentTypeDataGridViewTextBoxColumn,
            this.customerNameDataGridViewTextBoxColumn});
			this.dg.DataSource = this.inwardSingleShipmentBindingSource;
			dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 9F);
			dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Transparent;
			dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dg.DefaultCellStyle = dataGridViewCellStyle7;
			this.dg.DoubleBuffered = true;
			this.dg.EnableHeadersVisualStyles = false;
			this.dg.HeaderBgColor = System.Drawing.Color.Maroon;
			this.dg.HeaderForeColor = System.Drawing.Color.White;
			this.dg.Location = new System.Drawing.Point(59, 129);
			this.dg.MultiSelect = false;
			this.dg.Name = "dg";
			this.dg.ReadOnly = true;
			this.dg.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.dg.RowHeadersVisible = false;
			dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Transparent;
			dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
			this.dg.RowsDefaultCellStyle = dataGridViewCellStyle8;
			this.dg.Size = new System.Drawing.Size(686, 332);
			this.dg.TabIndex = 73;
			this.dg.TabStop = false;
			// 
			// dateDataGridViewTextBoxColumn
			// 
			this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
			this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
			this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
			this.dateDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// trackingIdDataGridViewTextBoxColumn
			// 
			this.trackingIdDataGridViewTextBoxColumn.DataPropertyName = "TrackingId";
			this.trackingIdDataGridViewTextBoxColumn.HeaderText = "Tracking ID";
			this.trackingIdDataGridViewTextBoxColumn.Name = "trackingIdDataGridViewTextBoxColumn";
			this.trackingIdDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// courierNameDataGridViewTextBoxColumn
			// 
			this.courierNameDataGridViewTextBoxColumn.DataPropertyName = "CourierName";
			this.courierNameDataGridViewTextBoxColumn.HeaderText = "Courier name";
			this.courierNameDataGridViewTextBoxColumn.Name = "courierNameDataGridViewTextBoxColumn";
			this.courierNameDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// itemNameDataGridViewTextBoxColumn
			// 
			this.itemNameDataGridViewTextBoxColumn.DataPropertyName = "ItemName";
			this.itemNameDataGridViewTextBoxColumn.HeaderText = "Item Name";
			this.itemNameDataGridViewTextBoxColumn.Name = "itemNameDataGridViewTextBoxColumn";
			this.itemNameDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// itemConditionDataGridViewTextBoxColumn
			// 
			this.itemConditionDataGridViewTextBoxColumn.DataPropertyName = "ItemCondition";
			this.itemConditionDataGridViewTextBoxColumn.HeaderText = "Item Condition";
			this.itemConditionDataGridViewTextBoxColumn.Name = "itemConditionDataGridViewTextBoxColumn";
			this.itemConditionDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// remarksDataGridViewTextBoxColumn
			// 
			this.remarksDataGridViewTextBoxColumn.DataPropertyName = "Remarks";
			this.remarksDataGridViewTextBoxColumn.HeaderText = "Remarks";
			this.remarksDataGridViewTextBoxColumn.Name = "remarksDataGridViewTextBoxColumn";
			this.remarksDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// shipmentTypeDataGridViewTextBoxColumn
			// 
			this.shipmentTypeDataGridViewTextBoxColumn.DataPropertyName = "ShipmentType";
			this.shipmentTypeDataGridViewTextBoxColumn.HeaderText = "Shipment Type";
			this.shipmentTypeDataGridViewTextBoxColumn.Name = "shipmentTypeDataGridViewTextBoxColumn";
			this.shipmentTypeDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// customerNameDataGridViewTextBoxColumn
			// 
			this.customerNameDataGridViewTextBoxColumn.DataPropertyName = "CustomerName";
			this.customerNameDataGridViewTextBoxColumn.HeaderText = "Customer Name";
			this.customerNameDataGridViewTextBoxColumn.Name = "customerNameDataGridViewTextBoxColumn";
			this.customerNameDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// inwardSingleShipmentBindingSource
			// 
			this.inwardSingleShipmentBindingSource.DataSource = typeof(UPC.Library.Models.InwardSingleShipment);
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
			this.pictureBox2.Location = new System.Drawing.Point(715, 93);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(30, 30);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pictureBox2.TabIndex = 78;
			this.pictureBox2.TabStop = false;
			this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
			// 
			// label2
			// 
			this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.label2.ForeColor = System.Drawing.Color.Black;
			this.label2.Location = new System.Drawing.Point(411, 49);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(19, 15);
			this.label2.TabIndex = 79;
			this.label2.Text = "To";
			// 
			// From
			// 
			this.From.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.From.CalendarFont = new System.Drawing.Font("Segoe UI", 9F);
			this.From.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.From.Location = new System.Drawing.Point(216, 47);
			this.From.Name = "From";
			this.From.Size = new System.Drawing.Size(189, 20);
			this.From.TabIndex = 80;
			// 
			// To
			// 
			this.To.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.To.CalendarFont = new System.Drawing.Font("Segoe UI", 9F);
			this.To.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.To.Location = new System.Drawing.Point(436, 47);
			this.To.Name = "To";
			this.To.Size = new System.Drawing.Size(189, 20);
			this.To.TabIndex = 81;
			// 
			// Search
			// 
			this.Search.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.Search.Font = new System.Drawing.Font("Segoe UI", 8.25F);
			this.Search.Location = new System.Drawing.Point(326, 73);
			this.Search.Name = "Search";
			this.Search.Size = new System.Drawing.Size(145, 27);
			this.Search.TabIndex = 82;
			this.Search.Text = "Search";
			this.Search.UseVisualStyleBackColor = true;
			this.Search.Click += new System.EventHandler(this.Search_Click);
			// 
			// UC_ShipementReportDateRange
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.Controls.Add(this.Search);
			this.Controls.Add(this.To);
			this.Controls.Add(this.From);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.dg);
			this.Controls.Add(this.pictureBox2);
			this.Name = "UC_ShipementReportDateRange";
			this.Size = new System.Drawing.Size(801, 473);
			((System.ComponentModel.ISupportInitialize)(this.dg)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.inwardSingleShipmentBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label7;
		private Bunifu.Framework.UI.BunifuCustomDataGrid dg;
		private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn trackingIdDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn courierNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn itemNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn itemConditionDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn remarksDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn shipmentTypeDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn customerNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.BindingSource inwardSingleShipmentBindingSource;
		private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DateTimePicker From;
		private System.Windows.Forms.DateTimePicker To;
		private System.Windows.Forms.Button Search;
	}
}
