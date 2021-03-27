
namespace UPC_Shipment_Manager_UI.UserControls
{
	partial class UC_BulkInward
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
			this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
			this.dg = new Bunifu.Framework.UI.BunifuCustomDataGrid();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.label8 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.Date = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.Remarks = new System.Windows.Forms.RichTextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.CourierName = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.pictureBox4 = new System.Windows.Forms.PictureBox();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.courierNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.trackingIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.remarksDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.inwardBulkShipmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.dg)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.inwardBulkShipmentBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
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
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.dg.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dg.AutoGenerateColumns = false;
			this.dg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dg.BackgroundColor = System.Drawing.Color.Gainsboro;
			this.dg.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dg.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8.25F);
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dg.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dateDataGridViewTextBoxColumn,
            this.courierNameDataGridViewTextBoxColumn,
            this.trackingIdDataGridViewTextBoxColumn,
            this.remarksDataGridViewTextBoxColumn});
			this.dg.DataSource = this.inwardBulkShipmentBindingSource;
			this.dg.DoubleBuffered = true;
			this.dg.EnableHeadersVisualStyles = false;
			this.dg.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
			this.dg.HeaderForeColor = System.Drawing.Color.White;
			this.dg.Location = new System.Drawing.Point(158, 221);
			this.dg.Name = "dg";
			this.dg.ReadOnly = true;
			this.dg.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.dg.RowHeadersVisible = false;
			this.dg.Size = new System.Drawing.Size(659, 267);
			this.dg.TabIndex = 48;
			this.toolTip1.SetToolTip(this.dg, "All Single Inward Shipments");
			// 
			// label8
			// 
			this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
			this.label8.ForeColor = System.Drawing.Color.Black;
			this.label8.Location = new System.Drawing.Point(386, 11);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(209, 20);
			this.label8.TabIndex = 45;
			this.label8.Text = "Register New Bulk Shipment";
			// 
			// button1
			// 
			this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.button1.Font = new System.Drawing.Font("Segoe UI", 8.25F);
			this.button1.Location = new System.Drawing.Point(387, 182);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(236, 33);
			this.button1.TabIndex = 44;
			this.button1.Text = "Register";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// Date
			// 
			this.Date.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.Date.AutoSize = true;
			this.Date.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.Date.ForeColor = System.Drawing.Color.Black;
			this.Date.Location = new System.Drawing.Point(224, 77);
			this.Date.Name = "Date";
			this.Date.Size = new System.Drawing.Size(140, 15);
			this.Date.TabIndex = 43;
			this.Date.Text = "DD:MM:YYYY HH:MM:SS";
			// 
			// label7
			// 
			this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.label7.ForeColor = System.Drawing.Color.Black;
			this.label7.Location = new System.Drawing.Point(187, 77);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(31, 15);
			this.label7.TabIndex = 42;
			this.label7.Text = "Date";
			// 
			// Remarks
			// 
			this.Remarks.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.Remarks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Remarks.Location = new System.Drawing.Point(227, 128);
			this.Remarks.Name = "Remarks";
			this.Remarks.Size = new System.Drawing.Size(590, 48);
			this.Remarks.TabIndex = 41;
			this.Remarks.Text = "";
			// 
			// label6
			// 
			this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.label6.ForeColor = System.Drawing.Color.Black;
			this.label6.Location = new System.Drawing.Point(169, 133);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(52, 15);
			this.label6.TabIndex = 37;
			this.label6.Text = "Remarks";
			// 
			// label3
			// 
			this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.label3.ForeColor = System.Drawing.Color.Black;
			this.label3.Location = new System.Drawing.Point(685, 102);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(65, 15);
			this.label3.TabIndex = 34;
			this.label3.Text = "Tracking ID";
			// 
			// label2
			// 
			this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.label2.ForeColor = System.Drawing.Color.Black;
			this.label2.Location = new System.Drawing.Point(142, 102);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(79, 15);
			this.label2.TabIndex = 33;
			this.label2.Text = "Courier name";
			// 
			// CourierName
			// 
			this.CourierName.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.CourierName.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.CourierName.FormattingEnabled = true;
			this.CourierName.Location = new System.Drawing.Point(227, 97);
			this.CourierName.Name = "CourierName";
			this.CourierName.Size = new System.Drawing.Size(452, 25);
			this.CourierName.TabIndex = 32;
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.label1.ForeColor = System.Drawing.Color.Black;
			this.label1.Location = new System.Drawing.Point(380, 41);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(239, 15);
			this.label1.TabIndex = 31;
			this.label1.Text = "Please fill out the following form to proceed";
			// 
			// pictureBox4
			// 
			this.pictureBox4.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.pictureBox4.BackColor = System.Drawing.Color.White;
			this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pictureBox4.Image = global::UPC_Shipment_Manager_UI.Properties.Resources.icons8_show_property_24px;
			this.pictureBox4.Location = new System.Drawing.Point(786, 97);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new System.Drawing.Size(30, 25);
			this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pictureBox4.TabIndex = 50;
			this.pictureBox4.TabStop = false;
			this.toolTip1.SetToolTip(this.pictureBox4, "View Imported Tracking IDs");
			// 
			// pictureBox3
			// 
			this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.pictureBox3.BackColor = System.Drawing.Color.White;
			this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pictureBox3.Image = global::UPC_Shipment_Manager_UI.Properties.Resources.icons8_import_file_24px;
			this.pictureBox3.Location = new System.Drawing.Point(756, 97);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(30, 25);
			this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pictureBox3.TabIndex = 49;
			this.pictureBox3.TabStop = false;
			this.toolTip1.SetToolTip(this.pictureBox3, "Import Tracking IDs");
			// 
			// dateDataGridViewTextBoxColumn
			// 
			this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
			this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
			this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
			this.dateDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// courierNameDataGridViewTextBoxColumn
			// 
			this.courierNameDataGridViewTextBoxColumn.DataPropertyName = "CourierName";
			this.courierNameDataGridViewTextBoxColumn.HeaderText = "Courier Name";
			this.courierNameDataGridViewTextBoxColumn.Name = "courierNameDataGridViewTextBoxColumn";
			this.courierNameDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// trackingIdDataGridViewTextBoxColumn
			// 
			this.trackingIdDataGridViewTextBoxColumn.DataPropertyName = "TrackingId";
			this.trackingIdDataGridViewTextBoxColumn.HeaderText = "Tracking Id";
			this.trackingIdDataGridViewTextBoxColumn.Name = "trackingIdDataGridViewTextBoxColumn";
			this.trackingIdDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// remarksDataGridViewTextBoxColumn
			// 
			this.remarksDataGridViewTextBoxColumn.DataPropertyName = "Remarks";
			this.remarksDataGridViewTextBoxColumn.HeaderText = "Remarks";
			this.remarksDataGridViewTextBoxColumn.Name = "remarksDataGridViewTextBoxColumn";
			this.remarksDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// inwardBulkShipmentBindingSource
			// 
			this.inwardBulkShipmentBindingSource.DataSource = typeof(UPC.Library.Models.InwardBulkShipment);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.pictureBox1.BackColor = System.Drawing.Color.White;
			this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pictureBox1.Image = global::UPC_Shipment_Manager_UI.Properties.Resources.icons8_eraser_24px;
			this.pictureBox1.Location = new System.Drawing.Point(623, 184);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(30, 30);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pictureBox1.TabIndex = 47;
			this.pictureBox1.TabStop = false;
			this.toolTip1.SetToolTip(this.pictureBox1, "Clear all");
			// 
			// pictureBox2
			// 
			this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.pictureBox2.BackColor = System.Drawing.Color.White;
			this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pictureBox2.Image = global::UPC_Shipment_Manager_UI.Properties.Resources.excel_24px_dark;
			this.pictureBox2.Location = new System.Drawing.Point(653, 184);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(30, 30);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pictureBox2.TabIndex = 46;
			this.pictureBox2.TabStop = false;
			this.toolTip1.SetToolTip(this.pictureBox2, "Export all Inward Bulk Shipments");
			// 
			// UC_BulkInward
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.Controls.Add(this.pictureBox4);
			this.Controls.Add(this.pictureBox3);
			this.Controls.Add(this.dg);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.Date);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.Remarks);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.CourierName);
			this.Controls.Add(this.label1);
			this.Name = "UC_BulkInward";
			this.Size = new System.Drawing.Size(958, 498);
			((System.ComponentModel.ISupportInitialize)(this.dg)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.inwardBulkShipmentBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
		private Bunifu.Framework.UI.BunifuCustomDataGrid dg;
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label Date;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.RichTextBox Remarks;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox CourierName;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.PictureBox pictureBox4;
		private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn courierNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn trackingIdDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn remarksDataGridViewTextBoxColumn;
		private System.Windows.Forms.BindingSource inwardBulkShipmentBindingSource;
	}
}
