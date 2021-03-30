
namespace UPC_Shipment_Manager_UI.UserControls.CRM
{
	partial class UC_ExistingCustomerEntry
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
			this.Action = new System.Windows.Forms.RichTextBox();
			this.Query = new System.Windows.Forms.RichTextBox();
			this.Whatsapp = new System.Windows.Forms.Button();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.WhatsappMessage = new System.Windows.Forms.RichTextBox();
			this.OpenEntry = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.Email = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.Phone = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.CustomerName = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.OrderNumber = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.Product = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.OrderDate = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.NewMarketPlace = new System.Windows.Forms.PictureBox();
			this.Marketplace = new System.Windows.Forms.ComboBox();
			((System.ComponentModel.ISupportInitialize)(this.NewMarketPlace)).BeginInit();
			this.SuspendLayout();
			// 
			// Action
			// 
			this.Action.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
			this.Action.Location = new System.Drawing.Point(159, 267);
			this.Action.Name = "Action";
			this.Action.Size = new System.Drawing.Size(531, 65);
			this.Action.TabIndex = 8;
			this.Action.Text = "";
			// 
			// Query
			// 
			this.Query.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
			this.Query.Location = new System.Drawing.Point(159, 196);
			this.Query.Name = "Query";
			this.Query.Size = new System.Drawing.Size(531, 65);
			this.Query.TabIndex = 7;
			this.Query.Text = "";
			// 
			// Whatsapp
			// 
			this.Whatsapp.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.Whatsapp.BackgroundImage = global::UPC_Shipment_Manager_UI.Properties.Resources.icons8_whatsapp_24px;
			this.Whatsapp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.Whatsapp.Cursor = System.Windows.Forms.Cursors.Hand;
			this.Whatsapp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Whatsapp.ForeColor = System.Drawing.Color.White;
			this.Whatsapp.Location = new System.Drawing.Point(694, 378);
			this.Whatsapp.Name = "Whatsapp";
			this.Whatsapp.Size = new System.Drawing.Size(28, 25);
			this.Whatsapp.TabIndex = 10;
			this.toolTip1.SetToolTip(this.Whatsapp, "Send to Whatsapp");
			this.Whatsapp.UseVisualStyleBackColor = true;
			this.Whatsapp.Click += new System.EventHandler(this.Whatsapp_Click);
			// 
			// WhatsappMessage
			// 
			this.WhatsappMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
			this.WhatsappMessage.Location = new System.Drawing.Point(159, 338);
			this.WhatsappMessage.Name = "WhatsappMessage";
			this.WhatsappMessage.Size = new System.Drawing.Size(531, 65);
			this.WhatsappMessage.TabIndex = 9;
			this.WhatsappMessage.Text = "";
			// 
			// OpenEntry
			// 
			this.OpenEntry.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.OpenEntry.Location = new System.Drawing.Point(348, 409);
			this.OpenEntry.Name = "OpenEntry";
			this.OpenEntry.Size = new System.Drawing.Size(152, 29);
			this.OpenEntry.TabIndex = 11;
			this.OpenEntry.Text = "Open Entry";
			this.OpenEntry.UseVisualStyleBackColor = true;
			this.OpenEntry.Click += new System.EventHandler(this.OpenEntry_Click);
			// 
			// label2
			// 
			this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.label2.ForeColor = System.Drawing.Color.Black;
			this.label2.Location = new System.Drawing.Point(100, 340);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(53, 15);
			this.label2.TabIndex = 69;
			this.label2.Text = "Message";
			// 
			// label6
			// 
			this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.label6.ForeColor = System.Drawing.Color.Black;
			this.label6.Location = new System.Drawing.Point(111, 269);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(42, 15);
			this.label6.TabIndex = 68;
			this.label6.Text = "Action";
			// 
			// label9
			// 
			this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.label9.ForeColor = System.Drawing.Color.Black;
			this.label9.Location = new System.Drawing.Point(114, 201);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(39, 15);
			this.label9.TabIndex = 67;
			this.label9.Text = "Query";
			// 
			// Email
			// 
			this.Email.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.Email.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
			this.Email.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.Email.Location = new System.Drawing.Point(454, 104);
			this.Email.Name = "Email";
			this.Email.Size = new System.Drawing.Size(236, 25);
			this.Email.TabIndex = 2;
			// 
			// label3
			// 
			this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.label3.ForeColor = System.Drawing.Color.Black;
			this.label3.Location = new System.Drawing.Point(412, 109);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(36, 15);
			this.label3.TabIndex = 66;
			this.label3.Text = "Email";
			// 
			// Phone
			// 
			this.Phone.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.Phone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
			this.Phone.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.Phone.Location = new System.Drawing.Point(159, 104);
			this.Phone.Name = "Phone";
			this.Phone.Size = new System.Drawing.Size(236, 25);
			this.Phone.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.label1.ForeColor = System.Drawing.Color.Black;
			this.label1.Location = new System.Drawing.Point(112, 110);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(41, 15);
			this.label1.TabIndex = 65;
			this.label1.Text = "Phone";
			// 
			// label5
			// 
			this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.label5.ForeColor = System.Drawing.Color.Black;
			this.label5.Location = new System.Drawing.Point(79, 44);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(376, 15);
			this.label5.TabIndex = 64;
			this.label5.Text = "Please fill out the following information to register customer for entry.";
			// 
			// label7
			// 
			this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
			this.label7.ForeColor = System.Drawing.Color.Black;
			this.label7.Location = new System.Drawing.Point(344, 12);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(136, 20);
			this.label7.TabIndex = 63;
			this.label7.Text = "Existing Customer";
			// 
			// CustomerName
			// 
			this.CustomerName.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.CustomerName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
			this.CustomerName.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.CustomerName.Location = new System.Drawing.Point(159, 72);
			this.CustomerName.Name = "CustomerName";
			this.CustomerName.Size = new System.Drawing.Size(531, 25);
			this.CustomerName.TabIndex = 0;
			// 
			// label4
			// 
			this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.label4.ForeColor = System.Drawing.Color.Black;
			this.label4.Location = new System.Drawing.Point(114, 77);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(39, 15);
			this.label4.TabIndex = 62;
			this.label4.Text = "Name";
			// 
			// label8
			// 
			this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.label8.ForeColor = System.Drawing.Color.Black;
			this.label8.Location = new System.Drawing.Point(81, 139);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(72, 15);
			this.label8.TabIndex = 71;
			this.label8.Text = "Marketplace";
			// 
			// OrderNumber
			// 
			this.OrderNumber.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.OrderNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
			this.OrderNumber.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.OrderNumber.Location = new System.Drawing.Point(454, 134);
			this.OrderNumber.Name = "OrderNumber";
			this.OrderNumber.Size = new System.Drawing.Size(236, 25);
			this.OrderNumber.TabIndex = 4;
			// 
			// label10
			// 
			this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.label10.ForeColor = System.Drawing.Color.Black;
			this.label10.Location = new System.Drawing.Point(401, 139);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(47, 15);
			this.label10.TabIndex = 73;
			this.label10.Text = "Order #";
			// 
			// Product
			// 
			this.Product.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.Product.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
			this.Product.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.Product.Location = new System.Drawing.Point(454, 165);
			this.Product.Name = "Product";
			this.Product.Size = new System.Drawing.Size(236, 25);
			this.Product.TabIndex = 6;
			// 
			// label11
			// 
			this.label11.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.label11.ForeColor = System.Drawing.Color.Black;
			this.label11.Location = new System.Drawing.Point(399, 170);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(49, 15);
			this.label11.TabIndex = 77;
			this.label11.Text = "Product";
			// 
			// OrderDate
			// 
			this.OrderDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.OrderDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
			this.OrderDate.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.OrderDate.Location = new System.Drawing.Point(159, 165);
			this.OrderDate.Name = "OrderDate";
			this.OrderDate.Size = new System.Drawing.Size(236, 25);
			this.OrderDate.TabIndex = 5;
			// 
			// label12
			// 
			this.label12.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.label12.ForeColor = System.Drawing.Color.Black;
			this.label12.Location = new System.Drawing.Point(89, 170);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(64, 15);
			this.label12.TabIndex = 75;
			this.label12.Text = "Order Date";
			// 
			// NewMarketPlace
			// 
			this.NewMarketPlace.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.NewMarketPlace.BackColor = System.Drawing.Color.White;
			this.NewMarketPlace.Cursor = System.Windows.Forms.Cursors.Hand;
			this.NewMarketPlace.Image = global::UPC_Shipment_Manager_UI.Properties.Resources.icons8_add_24px;
			this.NewMarketPlace.Location = new System.Drawing.Point(370, 135);
			this.NewMarketPlace.Name = "NewMarketPlace";
			this.NewMarketPlace.Size = new System.Drawing.Size(24, 24);
			this.NewMarketPlace.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.NewMarketPlace.TabIndex = 79;
			this.NewMarketPlace.TabStop = false;
			this.toolTip1.SetToolTip(this.NewMarketPlace, "New MarketPlace");
			// 
			// Marketplace
			// 
			this.Marketplace.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.Marketplace.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.Marketplace.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.Marketplace.FormattingEnabled = true;
			this.Marketplace.Location = new System.Drawing.Point(159, 134);
			this.Marketplace.Name = "Marketplace";
			this.Marketplace.Size = new System.Drawing.Size(206, 25);
			this.Marketplace.TabIndex = 3;
			// 
			// UC_ExistingCustomerEntry
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.Color.White;
			this.Controls.Add(this.NewMarketPlace);
			this.Controls.Add(this.Marketplace);
			this.Controls.Add(this.Product);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.OrderDate);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.OrderNumber);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.Action);
			this.Controls.Add(this.Query);
			this.Controls.Add(this.Whatsapp);
			this.Controls.Add(this.WhatsappMessage);
			this.Controls.Add(this.OpenEntry);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.Email);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.Phone);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.CustomerName);
			this.Controls.Add(this.label4);
			this.Name = "UC_ExistingCustomerEntry";
			this.Size = new System.Drawing.Size(801, 473);
			((System.ComponentModel.ISupportInitialize)(this.NewMarketPlace)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.RichTextBox Action;
		private System.Windows.Forms.RichTextBox Query;
		private System.Windows.Forms.Button Whatsapp;
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.RichTextBox WhatsappMessage;
		private System.Windows.Forms.Button OpenEntry;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox Email;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox Phone;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox CustomerName;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox OrderNumber;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox Product;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TextBox OrderDate;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.PictureBox NewMarketPlace;
		private System.Windows.Forms.ComboBox Marketplace;
	}
}
