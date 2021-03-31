
namespace UPC_Shipment_Manager_UI.UserControls.Inventory
{
	partial class UC_ItemReports
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
			this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
			this.Current = new Bunifu.Framework.UI.BunifuCustomDataGrid();
			this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.itemNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.godownDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.remarksDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.transactionDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.transactionTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.inventoryItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.label7 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.InventoryIn = new Bunifu.Framework.UI.BunifuCustomDataGrid();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
			this.label3 = new System.Windows.Forms.Label();
			this.InventoryOut = new Bunifu.Framework.UI.BunifuCustomDataGrid();
			this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
			this.bunifuElipse3 = new Bunifu.Framework.UI.BunifuElipse(this.components);
			this.ItemName = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.Current)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.inventoryItemBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.InventoryIn)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.InventoryOut)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
			this.SuspendLayout();
			// 
			// bunifuElipse1
			// 
			this.bunifuElipse1.ElipseRadius = 7;
			this.bunifuElipse1.TargetControl = this.Current;
			// 
			// Current
			// 
			this.Current.AllowUserToAddRows = false;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.Current.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.Current.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.Current.AutoGenerateColumns = false;
			this.Current.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.Current.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.Current.BackgroundColor = System.Drawing.Color.Gainsboro;
			this.Current.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.Current.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.Current.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.Maroon;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.Current.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.Current.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.Current.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.itemNameDataGridViewTextBoxColumn,
            this.godownDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.remarksDataGridViewTextBoxColumn,
            this.transactionDateDataGridViewTextBoxColumn,
            this.transactionTypeDataGridViewTextBoxColumn});
			this.Current.DataSource = this.inventoryItemBindingSource;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F);
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.Current.DefaultCellStyle = dataGridViewCellStyle3;
			this.Current.DoubleBuffered = true;
			this.Current.EnableHeadersVisualStyles = false;
			this.Current.HeaderBgColor = System.Drawing.Color.Maroon;
			this.Current.HeaderForeColor = System.Drawing.Color.White;
			this.Current.Location = new System.Drawing.Point(53, 84);
			this.Current.MultiSelect = false;
			this.Current.Name = "Current";
			this.Current.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
			this.Current.RowsDefaultCellStyle = dataGridViewCellStyle4;
			this.Current.Size = new System.Drawing.Size(686, 109);
			this.Current.TabIndex = 57;
			this.Current.TabStop = false;
			this.Current.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.Current_CellValueChanged);
			this.Current.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Current_KeyDown);
			// 
			// idDataGridViewTextBoxColumn
			// 
			this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
			this.idDataGridViewTextBoxColumn.HeaderText = "Id";
			this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
			this.idDataGridViewTextBoxColumn.Visible = false;
			// 
			// itemNameDataGridViewTextBoxColumn
			// 
			this.itemNameDataGridViewTextBoxColumn.DataPropertyName = "ItemName";
			this.itemNameDataGridViewTextBoxColumn.HeaderText = "Item Name";
			this.itemNameDataGridViewTextBoxColumn.Name = "itemNameDataGridViewTextBoxColumn";
			// 
			// godownDataGridViewTextBoxColumn
			// 
			this.godownDataGridViewTextBoxColumn.DataPropertyName = "Godown";
			this.godownDataGridViewTextBoxColumn.HeaderText = "Godown";
			this.godownDataGridViewTextBoxColumn.Name = "godownDataGridViewTextBoxColumn";
			// 
			// quantityDataGridViewTextBoxColumn
			// 
			this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
			this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
			this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
			// 
			// remarksDataGridViewTextBoxColumn
			// 
			this.remarksDataGridViewTextBoxColumn.DataPropertyName = "Remarks";
			this.remarksDataGridViewTextBoxColumn.HeaderText = "Remarks";
			this.remarksDataGridViewTextBoxColumn.Name = "remarksDataGridViewTextBoxColumn";
			this.remarksDataGridViewTextBoxColumn.Visible = false;
			// 
			// transactionDateDataGridViewTextBoxColumn
			// 
			this.transactionDateDataGridViewTextBoxColumn.DataPropertyName = "TransactionDate";
			this.transactionDateDataGridViewTextBoxColumn.HeaderText = "Last Modified";
			this.transactionDateDataGridViewTextBoxColumn.Name = "transactionDateDataGridViewTextBoxColumn";
			// 
			// transactionTypeDataGridViewTextBoxColumn
			// 
			this.transactionTypeDataGridViewTextBoxColumn.DataPropertyName = "TransactionType";
			this.transactionTypeDataGridViewTextBoxColumn.HeaderText = "TransactionType";
			this.transactionTypeDataGridViewTextBoxColumn.Name = "transactionTypeDataGridViewTextBoxColumn";
			this.transactionTypeDataGridViewTextBoxColumn.Visible = false;
			// 
			// inventoryItemBindingSource
			// 
			this.inventoryItemBindingSource.AllowNew = true;
			this.inventoryItemBindingSource.DataSource = typeof(UPC.Library.InventoryModels.InventoryItem);
			// 
			// label7
			// 
			this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
			this.label7.ForeColor = System.Drawing.Color.Black;
			this.label7.Location = new System.Drawing.Point(329, 5);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(101, 20);
			this.label7.TabIndex = 58;
			this.label7.Text = "Item Reports";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
			this.label1.ForeColor = System.Drawing.Color.Black;
			this.label1.Location = new System.Drawing.Point(49, 61);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(97, 19);
			this.label1.TabIndex = 60;
			this.label1.Text = "Current State";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
			this.label2.ForeColor = System.Drawing.Color.Black;
			this.label2.Location = new System.Drawing.Point(49, 198);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(144, 19);
			this.label2.TabIndex = 62;
			this.label2.Text = "Inventory In History";
			// 
			// InventoryIn
			// 
			this.InventoryIn.AllowUserToAddRows = false;
			this.InventoryIn.AllowUserToDeleteRows = false;
			dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.InventoryIn.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
			this.InventoryIn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.InventoryIn.AutoGenerateColumns = false;
			this.InventoryIn.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.InventoryIn.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.InventoryIn.BackgroundColor = System.Drawing.Color.Gainsboro;
			this.InventoryIn.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.InventoryIn.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.InventoryIn.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle6.BackColor = System.Drawing.Color.Maroon;
			dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F);
			dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.InventoryIn.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
			this.InventoryIn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.InventoryIn.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
			this.InventoryIn.DataSource = this.bindingSource1;
			dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 9F);
			dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Transparent;
			dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.InventoryIn.DefaultCellStyle = dataGridViewCellStyle7;
			this.InventoryIn.DoubleBuffered = true;
			this.InventoryIn.EnableHeadersVisualStyles = false;
			this.InventoryIn.HeaderBgColor = System.Drawing.Color.Maroon;
			this.InventoryIn.HeaderForeColor = System.Drawing.Color.White;
			this.InventoryIn.Location = new System.Drawing.Point(53, 221);
			this.InventoryIn.MultiSelect = false;
			this.InventoryIn.Name = "InventoryIn";
			this.InventoryIn.ReadOnly = true;
			this.InventoryIn.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.InventoryIn.RowHeadersVisible = false;
			dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Transparent;
			dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
			this.InventoryIn.RowsDefaultCellStyle = dataGridViewCellStyle8;
			this.InventoryIn.Size = new System.Drawing.Size(686, 109);
			this.InventoryIn.TabIndex = 61;
			this.InventoryIn.TabStop = false;
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
			this.dataGridViewTextBoxColumn1.HeaderText = "Id";
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn1.ReadOnly = true;
			this.dataGridViewTextBoxColumn1.Visible = false;
			// 
			// dataGridViewTextBoxColumn2
			// 
			this.dataGridViewTextBoxColumn2.DataPropertyName = "ItemName";
			this.dataGridViewTextBoxColumn2.HeaderText = "Item Name";
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			this.dataGridViewTextBoxColumn2.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn3
			// 
			this.dataGridViewTextBoxColumn3.DataPropertyName = "Godown";
			this.dataGridViewTextBoxColumn3.HeaderText = "Godown";
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			this.dataGridViewTextBoxColumn3.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn4
			// 
			this.dataGridViewTextBoxColumn4.DataPropertyName = "Quantity";
			this.dataGridViewTextBoxColumn4.HeaderText = "Quantity";
			this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
			this.dataGridViewTextBoxColumn4.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn5
			// 
			this.dataGridViewTextBoxColumn5.DataPropertyName = "Remarks";
			this.dataGridViewTextBoxColumn5.HeaderText = "Remarks";
			this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
			this.dataGridViewTextBoxColumn5.ReadOnly = true;
			this.dataGridViewTextBoxColumn5.Visible = false;
			// 
			// dataGridViewTextBoxColumn6
			// 
			this.dataGridViewTextBoxColumn6.DataPropertyName = "TransactionDate";
			this.dataGridViewTextBoxColumn6.HeaderText = "Checkin Date";
			this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
			this.dataGridViewTextBoxColumn6.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn7
			// 
			this.dataGridViewTextBoxColumn7.DataPropertyName = "TransactionType";
			this.dataGridViewTextBoxColumn7.HeaderText = "TransactionType";
			this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
			this.dataGridViewTextBoxColumn7.ReadOnly = true;
			this.dataGridViewTextBoxColumn7.Visible = false;
			// 
			// bindingSource1
			// 
			this.bindingSource1.DataSource = typeof(UPC.Library.InventoryModels.InventoryItem);
			// 
			// bunifuElipse2
			// 
			this.bunifuElipse2.ElipseRadius = 7;
			this.bunifuElipse2.TargetControl = this.InventoryIn;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
			this.label3.ForeColor = System.Drawing.Color.Black;
			this.label3.Location = new System.Drawing.Point(49, 338);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(156, 19);
			this.label3.TabIndex = 64;
			this.label3.Text = "Inventory Out History";
			// 
			// InventoryOut
			// 
			this.InventoryOut.AllowUserToAddRows = false;
			this.InventoryOut.AllowUserToDeleteRows = false;
			dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.InventoryOut.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
			this.InventoryOut.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.InventoryOut.AutoGenerateColumns = false;
			this.InventoryOut.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.InventoryOut.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.InventoryOut.BackgroundColor = System.Drawing.Color.Gainsboro;
			this.InventoryOut.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.InventoryOut.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.InventoryOut.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle10.BackColor = System.Drawing.Color.Maroon;
			dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 9F);
			dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.InventoryOut.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
			this.InventoryOut.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.InventoryOut.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14});
			this.InventoryOut.DataSource = this.bindingSource2;
			dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 9F);
			dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.Transparent;
			dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.InventoryOut.DefaultCellStyle = dataGridViewCellStyle11;
			this.InventoryOut.DoubleBuffered = true;
			this.InventoryOut.EnableHeadersVisualStyles = false;
			this.InventoryOut.HeaderBgColor = System.Drawing.Color.Maroon;
			this.InventoryOut.HeaderForeColor = System.Drawing.Color.White;
			this.InventoryOut.Location = new System.Drawing.Point(53, 361);
			this.InventoryOut.MultiSelect = false;
			this.InventoryOut.Name = "InventoryOut";
			this.InventoryOut.ReadOnly = true;
			this.InventoryOut.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.InventoryOut.RowHeadersVisible = false;
			dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.Transparent;
			dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black;
			this.InventoryOut.RowsDefaultCellStyle = dataGridViewCellStyle12;
			this.InventoryOut.Size = new System.Drawing.Size(686, 109);
			this.InventoryOut.TabIndex = 63;
			this.InventoryOut.TabStop = false;
			// 
			// dataGridViewTextBoxColumn8
			// 
			this.dataGridViewTextBoxColumn8.DataPropertyName = "Id";
			this.dataGridViewTextBoxColumn8.HeaderText = "Id";
			this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
			this.dataGridViewTextBoxColumn8.ReadOnly = true;
			this.dataGridViewTextBoxColumn8.Visible = false;
			// 
			// dataGridViewTextBoxColumn9
			// 
			this.dataGridViewTextBoxColumn9.DataPropertyName = "ItemName";
			this.dataGridViewTextBoxColumn9.HeaderText = "Item Name";
			this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
			this.dataGridViewTextBoxColumn9.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn10
			// 
			this.dataGridViewTextBoxColumn10.DataPropertyName = "Godown";
			this.dataGridViewTextBoxColumn10.HeaderText = "Godown";
			this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
			this.dataGridViewTextBoxColumn10.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn11
			// 
			this.dataGridViewTextBoxColumn11.DataPropertyName = "Quantity";
			this.dataGridViewTextBoxColumn11.HeaderText = "Quantity";
			this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
			this.dataGridViewTextBoxColumn11.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn12
			// 
			this.dataGridViewTextBoxColumn12.DataPropertyName = "Remarks";
			this.dataGridViewTextBoxColumn12.HeaderText = "Remarks";
			this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
			this.dataGridViewTextBoxColumn12.ReadOnly = true;
			this.dataGridViewTextBoxColumn12.Visible = false;
			// 
			// dataGridViewTextBoxColumn13
			// 
			this.dataGridViewTextBoxColumn13.DataPropertyName = "TransactionDate";
			this.dataGridViewTextBoxColumn13.HeaderText = "Checkout Date";
			this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
			this.dataGridViewTextBoxColumn13.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn14
			// 
			this.dataGridViewTextBoxColumn14.DataPropertyName = "TransactionType";
			this.dataGridViewTextBoxColumn14.HeaderText = "TransactionType";
			this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
			this.dataGridViewTextBoxColumn14.ReadOnly = true;
			this.dataGridViewTextBoxColumn14.Visible = false;
			// 
			// bindingSource2
			// 
			this.bindingSource2.DataSource = typeof(UPC.Library.InventoryModels.InventoryItem);
			// 
			// bunifuElipse3
			// 
			this.bunifuElipse3.ElipseRadius = 7;
			this.bunifuElipse3.TargetControl = this.InventoryOut;
			// 
			// ItemName
			// 
			this.ItemName.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.ItemName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.ItemName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
			this.ItemName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
			this.ItemName.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.ItemName.Location = new System.Drawing.Point(259, 28);
			this.ItemName.Name = "ItemName";
			this.ItemName.Size = new System.Drawing.Size(236, 25);
			this.ItemName.TabIndex = 65;
			this.ItemName.Click += new System.EventHandler(this.ItemName_Click);
			this.ItemName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ItemName_KeyDown);
			// 
			// label4
			// 
			this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.label4.ForeColor = System.Drawing.Color.Black;
			this.label4.Location = new System.Drawing.Point(187, 33);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(66, 15);
			this.label4.TabIndex = 66;
			this.label4.Text = "Item Name";
			// 
			// UC_ItemReports
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.Controls.Add(this.ItemName);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.InventoryOut);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.InventoryIn);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.Current);
			this.Name = "UC_ItemReports";
			this.Size = new System.Drawing.Size(801, 473);
			this.Load += new System.EventHandler(this.UC_ItemReports_Load);
			((System.ComponentModel.ISupportInitialize)(this.Current)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.inventoryItemBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.InventoryIn)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.InventoryOut)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
		private Bunifu.Framework.UI.BunifuCustomDataGrid Current;
		private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn itemNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn godownDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn remarksDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn transactionDateDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn transactionTypeDataGridViewTextBoxColumn;
		private System.Windows.Forms.BindingSource inventoryItemBindingSource;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private Bunifu.Framework.UI.BunifuCustomDataGrid InventoryIn;
		private System.Windows.Forms.BindingSource bindingSource1;
		private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
		private System.Windows.Forms.Label label3;
		private Bunifu.Framework.UI.BunifuCustomDataGrid InventoryOut;
		private System.Windows.Forms.BindingSource bindingSource2;
		private Bunifu.Framework.UI.BunifuElipse bunifuElipse3;
		private System.Windows.Forms.TextBox ItemName;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
	}
}
