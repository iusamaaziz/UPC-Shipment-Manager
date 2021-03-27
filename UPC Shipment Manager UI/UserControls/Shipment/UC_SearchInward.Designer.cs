
namespace UPC_Shipment_Manager_UI.UserControls
{
	partial class UC_SearchInward
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
			this.dg = new Bunifu.Framework.UI.BunifuCustomDataGrid();
			this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
			this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.trackingIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.courierNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.itemNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.itemConditionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.remarksDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.inwardShipmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.Export = new System.Windows.Forms.PictureBox();
			this.Fetch = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dg)).BeginInit();
			this.bunifuCards1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.inwardShipmentBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Export)).BeginInit();
			this.SuspendLayout();
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
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.dg.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
			this.dg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dg.AutoGenerateColumns = false;
			this.dg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dg.BackgroundColor = System.Drawing.Color.Gainsboro;
			this.dg.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dg.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 8.25F);
			dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dg.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
			this.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dateDataGridViewTextBoxColumn,
            this.trackingIdDataGridViewTextBoxColumn,
            this.courierNameDataGridViewTextBoxColumn,
            this.itemNameDataGridViewTextBoxColumn,
            this.itemConditionDataGridViewTextBoxColumn,
            this.remarksDataGridViewTextBoxColumn});
			this.dg.DataSource = this.inwardShipmentBindingSource;
			this.dg.DoubleBuffered = true;
			this.dg.EnableHeadersVisualStyles = false;
			this.dg.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
			this.dg.HeaderForeColor = System.Drawing.Color.White;
			this.dg.Location = new System.Drawing.Point(30, 92);
			this.dg.Name = "dg";
			this.dg.ReadOnly = true;
			this.dg.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.dg.RowHeadersVisible = false;
			this.dg.Size = new System.Drawing.Size(898, 385);
			this.dg.TabIndex = 2;
			// 
			// bunifuCards1
			// 
			this.bunifuCards1.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.bunifuCards1.BackColor = System.Drawing.Color.Gainsboro;
			this.bunifuCards1.BorderRadius = 7;
			this.bunifuCards1.BottomSahddow = true;
			this.bunifuCards1.color = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
			this.bunifuCards1.Controls.Add(this.label8);
			this.bunifuCards1.Controls.Add(this.label2);
			this.bunifuCards1.Controls.Add(this.label1);
			this.bunifuCards1.Controls.Add(this.dateTimePicker2);
			this.bunifuCards1.Controls.Add(this.dateTimePicker1);
			this.bunifuCards1.LeftSahddow = false;
			this.bunifuCards1.Location = new System.Drawing.Point(163, 10);
			this.bunifuCards1.Name = "bunifuCards1";
			this.bunifuCards1.RightSahddow = true;
			this.bunifuCards1.ShadowDepth = 20;
			this.bunifuCards1.Size = new System.Drawing.Size(605, 76);
			this.bunifuCards1.TabIndex = 0;
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
			// inwardShipmentBindingSource
			// 
			this.inwardShipmentBindingSource.DataSource = typeof(UPC.Library.Models.InwardSingleShipment);
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.dateTimePicker1.Location = new System.Drawing.Point(97, 42);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(200, 21);
			this.dateTimePicker1.TabIndex = 0;
			// 
			// dateTimePicker2
			// 
			this.dateTimePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.dateTimePicker2.Location = new System.Drawing.Point(330, 42);
			this.dateTimePicker2.Name = "dateTimePicker2";
			this.dateTimePicker2.Size = new System.Drawing.Size(200, 21);
			this.dateTimePicker2.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.label1.ForeColor = System.Drawing.Color.Black;
			this.label1.Location = new System.Drawing.Point(56, 45);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(35, 15);
			this.label1.TabIndex = 14;
			this.label1.Text = "From";
			// 
			// label2
			// 
			this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.label2.ForeColor = System.Drawing.Color.Black;
			this.label2.Location = new System.Drawing.Point(305, 45);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(19, 15);
			this.label2.TabIndex = 15;
			this.label2.Text = "To";
			// 
			// label8
			// 
			this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
			this.label8.ForeColor = System.Drawing.Color.Black;
			this.label8.Location = new System.Drawing.Point(230, 10);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(135, 20);
			this.label8.TabIndex = 28;
			this.label8.Text = "Search and Export";
			// 
			// Export
			// 
			this.Export.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.Export.BackColor = System.Drawing.SystemColors.Control;
			this.Export.Cursor = System.Windows.Forms.Cursors.Hand;
			this.Export.Image = global::UPC_Shipment_Manager_UI.Properties.Resources.excel_24px_dark;
			this.Export.Location = new System.Drawing.Point(898, 56);
			this.Export.Name = "Export";
			this.Export.Size = new System.Drawing.Size(30, 30);
			this.Export.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.Export.TabIndex = 29;
			this.Export.TabStop = false;
			// 
			// Fetch
			// 
			this.Fetch.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.Fetch.Font = new System.Drawing.Font("Segoe UI", 8.25F);
			this.Fetch.Location = new System.Drawing.Point(699, 52);
			this.Fetch.Name = "Fetch";
			this.Fetch.Size = new System.Drawing.Size(51, 21);
			this.Fetch.TabIndex = 1;
			this.Fetch.Text = "Fetch";
			this.Fetch.UseVisualStyleBackColor = true;
			// 
			// UC_SearchInward
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.Fetch);
			this.Controls.Add(this.Export);
			this.Controls.Add(this.bunifuCards1);
			this.Controls.Add(this.dg);
			this.Name = "UC_SearchInward";
			this.Size = new System.Drawing.Size(958, 498);
			((System.ComponentModel.ISupportInitialize)(this.dg)).EndInit();
			this.bunifuCards1.ResumeLayout(false);
			this.bunifuCards1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.inwardShipmentBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Export)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
		private Bunifu.Framework.UI.BunifuCustomDataGrid dg;
		private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn trackingIdDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn courierNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn itemNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn itemConditionDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn remarksDataGridViewTextBoxColumn;
		private System.Windows.Forms.BindingSource inwardShipmentBindingSource;
		private Bunifu.Framework.UI.BunifuCards bunifuCards1;
		private System.Windows.Forms.DateTimePicker dateTimePicker2;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.PictureBox Export;
		private System.Windows.Forms.Button Fetch;
	}
}
