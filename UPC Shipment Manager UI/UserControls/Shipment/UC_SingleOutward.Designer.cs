
namespace UPC_Shipment_Manager_UI.UserControls.Shipment
{
	partial class UC_SingleOutward
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
			this.ShipmentDate = new System.Windows.Forms.DateTimePicker();
			this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
			this.dg = new Bunifu.Framework.UI.BunifuCustomDataGrid();
			this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.trackingIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.courierNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.itemNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CustomerNamedgclm = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.remarksDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.shipmentTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.inwardSingleShipmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.NewGodown = new System.Windows.Forms.PictureBox();
			this.label8 = new System.Windows.Forms.Label();
			this.Register = new System.Windows.Forms.Button();
			this.label7 = new System.Windows.Forms.Label();
			this.Remarks = new System.Windows.Forms.RichTextBox();
			this.ItemName = new System.Windows.Forms.TextBox();
			this.TrackingId = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.CourierName = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.CustomerName = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.dg)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.inwardSingleShipmentBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.NewGodown)).BeginInit();
			this.SuspendLayout();
			// 
			// ShipmentDate
			// 
			this.ShipmentDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.ShipmentDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.ShipmentDate.Location = new System.Drawing.Point(126, 70);
			this.ShipmentDate.Name = "ShipmentDate";
			this.ShipmentDate.Size = new System.Drawing.Size(236, 20);
			this.ShipmentDate.TabIndex = 0;
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
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(11)))), ((int)(((byte)(11)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8.25F);
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dg.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dateDataGridViewTextBoxColumn,
            this.trackingIdDataGridViewTextBoxColumn,
            this.courierNameDataGridViewTextBoxColumn,
            this.itemNameDataGridViewTextBoxColumn,
            this.CustomerNamedgclm,
            this.remarksDataGridViewTextBoxColumn,
            this.shipmentTypeDataGridViewTextBoxColumn});
			this.dg.DataSource = this.inwardSingleShipmentBindingSource;
			this.dg.DoubleBuffered = true;
			this.dg.EnableHeadersVisualStyles = false;
			this.dg.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(11)))), ((int)(((byte)(11)))));
			this.dg.HeaderForeColor = System.Drawing.Color.White;
			this.dg.Location = new System.Drawing.Point(44, 253);
			this.dg.Name = "dg";
			this.dg.ReadOnly = true;
			this.dg.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.dg.RowHeadersVisible = false;
			this.dg.Size = new System.Drawing.Size(715, 209);
			this.dg.TabIndex = 44;
			this.toolTip1.SetToolTip(this.dg, "All Single Inward Shipments");
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
			// CustomerNamedgclm
			// 
			this.CustomerNamedgclm.DataPropertyName = "CustomerName";
			this.CustomerNamedgclm.HeaderText = "Customer Name";
			this.CustomerNamedgclm.Name = "CustomerNamedgclm";
			this.CustomerNamedgclm.ReadOnly = true;
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
			// inwardSingleShipmentBindingSource
			// 
			this.inwardSingleShipmentBindingSource.DataSource = typeof(UPC.Library.Models.InwardSingleShipment);
			// 
			// pictureBox2
			// 
			this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox2.BackColor = System.Drawing.Color.White;
			this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pictureBox2.Image = global::UPC_Shipment_Manager_UI.Properties.Resources.icons8_file_excel_24px_1;
			this.pictureBox2.Location = new System.Drawing.Point(729, 217);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(30, 30);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pictureBox2.TabIndex = 53;
			this.pictureBox2.TabStop = false;
			this.toolTip1.SetToolTip(this.pictureBox2, "Export all Inward Single Shipments");
			this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
			// 
			// NewGodown
			// 
			this.NewGodown.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.NewGodown.BackColor = System.Drawing.Color.White;
			this.NewGodown.Cursor = System.Windows.Forms.Cursors.Hand;
			this.NewGodown.Image = global::UPC_Shipment_Manager_UI.Properties.Resources.icons8_add_24px;
			this.NewGodown.Location = new System.Drawing.Point(365, 96);
			this.NewGodown.Name = "NewGodown";
			this.NewGodown.Size = new System.Drawing.Size(24, 24);
			this.NewGodown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.NewGodown.TabIndex = 55;
			this.NewGodown.TabStop = false;
			this.toolTip1.SetToolTip(this.NewGodown, "Add new Godown number");
			this.NewGodown.Click += new System.EventHandler(this.NewGodown_Click);
			// 
			// label8
			// 
			this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
			this.label8.ForeColor = System.Drawing.Color.Black;
			this.label8.Location = new System.Drawing.Point(285, 10);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(220, 20);
			this.label8.TabIndex = 52;
			this.label8.Text = "Register New Single Shipment";
			// 
			// Register
			// 
			this.Register.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.Register.Enabled = false;
			this.Register.Font = new System.Drawing.Font("Segoe UI", 8.25F);
			this.Register.Location = new System.Drawing.Point(289, 214);
			this.Register.Name = "Register";
			this.Register.Size = new System.Drawing.Size(236, 33);
			this.Register.TabIndex = 6;
			this.Register.Text = "Register";
			this.Register.UseVisualStyleBackColor = true;
			this.Register.Click += new System.EventHandler(this.Register_Click);
			// 
			// label7
			// 
			this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.label7.ForeColor = System.Drawing.Color.Black;
			this.label7.Location = new System.Drawing.Point(86, 76);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(31, 15);
			this.label7.TabIndex = 51;
			this.label7.Text = "Date";
			// 
			// Remarks
			// 
			this.Remarks.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.Remarks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Remarks.Location = new System.Drawing.Point(126, 158);
			this.Remarks.Name = "Remarks";
			this.Remarks.Size = new System.Drawing.Size(590, 48);
			this.Remarks.TabIndex = 5;
			this.Remarks.Text = "";
			// 
			// ItemName
			// 
			this.ItemName.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.ItemName.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.ItemName.Location = new System.Drawing.Point(126, 127);
			this.ItemName.Name = "ItemName";
			this.ItemName.Size = new System.Drawing.Size(236, 25);
			this.ItemName.TabIndex = 3;
			this.ItemName.TextChanged += new System.EventHandler(this.Tb_TextChanged);
			// 
			// TrackingId
			// 
			this.TrackingId.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.TrackingId.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.TrackingId.Location = new System.Drawing.Point(480, 96);
			this.TrackingId.Name = "TrackingId";
			this.TrackingId.Size = new System.Drawing.Size(236, 25);
			this.TrackingId.TabIndex = 2;
			this.TrackingId.TextChanged += new System.EventHandler(this.Tb_TextChanged);
			// 
			// label6
			// 
			this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.label6.ForeColor = System.Drawing.Color.Black;
			this.label6.Location = new System.Drawing.Point(68, 163);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(52, 15);
			this.label6.TabIndex = 50;
			this.label6.Text = "Remarks";
			// 
			// label5
			// 
			this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.label5.ForeColor = System.Drawing.Color.Black;
			this.label5.Location = new System.Drawing.Point(380, 132);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(94, 15);
			this.label5.TabIndex = 49;
			this.label5.Text = "Customer Name";
			// 
			// label4
			// 
			this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.label4.ForeColor = System.Drawing.Color.Black;
			this.label4.Location = new System.Drawing.Point(54, 132);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(66, 15);
			this.label4.TabIndex = 48;
			this.label4.Text = "Item Name";
			// 
			// label3
			// 
			this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.label3.ForeColor = System.Drawing.Color.Black;
			this.label3.Location = new System.Drawing.Point(409, 101);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(65, 15);
			this.label3.TabIndex = 47;
			this.label3.Text = "Tracking ID";
			// 
			// label2
			// 
			this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.label2.ForeColor = System.Drawing.Color.Black;
			this.label2.Location = new System.Drawing.Point(41, 101);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(79, 15);
			this.label2.TabIndex = 46;
			this.label2.Text = "Courier name";
			// 
			// CourierName
			// 
			this.CourierName.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.CourierName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.CourierName.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.CourierName.FormattingEnabled = true;
			this.CourierName.Items.AddRange(new object[] {
            "courier"});
			this.CourierName.Location = new System.Drawing.Point(126, 96);
			this.CourierName.Name = "CourierName";
			this.CourierName.Size = new System.Drawing.Size(236, 25);
			this.CourierName.TabIndex = 1;
			this.CourierName.SelectedIndexChanged += new System.EventHandler(this.Tb_TextChanged);
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.label1.ForeColor = System.Drawing.Color.Black;
			this.label1.Location = new System.Drawing.Point(276, 40);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(239, 15);
			this.label1.TabIndex = 45;
			this.label1.Text = "Please fill out the following form to proceed";
			// 
			// CustomerName
			// 
			this.CustomerName.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.CustomerName.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.CustomerName.Location = new System.Drawing.Point(480, 127);
			this.CustomerName.Name = "CustomerName";
			this.CustomerName.Size = new System.Drawing.Size(236, 25);
			this.CustomerName.TabIndex = 4;
			// 
			// UC_SingleOutward
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.Controls.Add(this.CustomerName);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.NewGodown);
			this.Controls.Add(this.ShipmentDate);
			this.Controls.Add(this.dg);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.Register);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.Remarks);
			this.Controls.Add(this.ItemName);
			this.Controls.Add(this.TrackingId);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.CourierName);
			this.Controls.Add(this.label1);
			this.Name = "UC_SingleOutward";
			this.Size = new System.Drawing.Size(801, 473);
			this.Load += new System.EventHandler(this.UC_SingleOutward_Load);
			((System.ComponentModel.ISupportInitialize)(this.dg)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.inwardSingleShipmentBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.NewGodown)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.PictureBox NewGodown;
		private System.Windows.Forms.DateTimePicker ShipmentDate;
		private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
		private Bunifu.Framework.UI.BunifuCustomDataGrid dg;
		private System.Windows.Forms.BindingSource inwardSingleShipmentBindingSource;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Button Register;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.RichTextBox Remarks;
		private System.Windows.Forms.TextBox ItemName;
		private System.Windows.Forms.TextBox TrackingId;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox CourierName;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox CustomerName;
		private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn trackingIdDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn courierNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn itemNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn CustomerNamedgclm;
		private System.Windows.Forms.DataGridViewTextBoxColumn remarksDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn shipmentTypeDataGridViewTextBoxColumn;
	}
}
