
namespace UPC_Shipment_Manager_UI.UserControls.CRM
{
	partial class UC_NewCustomerEntry
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
			this.Canva = new System.Windows.Forms.Panel();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.NewCustomer = new System.Windows.Forms.ToolStripButton();
			this.ExistingCustomer = new System.Windows.Forms.ToolStripButton();
			this.toolStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// Canva
			// 
			this.Canva.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Canva.Location = new System.Drawing.Point(0, 25);
			this.Canva.Name = "Canva";
			this.Canva.Size = new System.Drawing.Size(801, 473);
			this.Canva.TabIndex = 5;
			// 
			// toolStrip1
			// 
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewCustomer,
            this.toolStripSeparator1,
            this.ExistingCustomer,
            this.toolStripSeparator2});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(801, 25);
			this.toolStrip1.TabIndex = 4;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
			// 
			// NewCustomer
			// 
			this.NewCustomer.Image = global::UPC_Shipment_Manager_UI.Properties.Resources.icons8_add_user_male_26px;
			this.NewCustomer.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.NewCustomer.Name = "NewCustomer";
			this.NewCustomer.Size = new System.Drawing.Size(106, 22);
			this.NewCustomer.Text = "New Customer";
			this.NewCustomer.Click += new System.EventHandler(this.NewCustomer_Click);
			// 
			// ExistingCustomer
			// 
			this.ExistingCustomer.Image = global::UPC_Shipment_Manager_UI.Properties.Resources.icons8_user_24px;
			this.ExistingCustomer.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.ExistingCustomer.Name = "ExistingCustomer";
			this.ExistingCustomer.Size = new System.Drawing.Size(123, 22);
			this.ExistingCustomer.Text = "Existing Customer";
			this.ExistingCustomer.Click += new System.EventHandler(this.ExistingCustomer_Click);
			// 
			// UC_NewCustomerEntry
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.Controls.Add(this.Canva);
			this.Controls.Add(this.toolStrip1);
			this.Name = "UC_NewCustomerEntry";
			this.Size = new System.Drawing.Size(801, 498);
			this.Load += new System.EventHandler(this.UC_NewCustomerEntry_Load);
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel Canva;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton NewCustomer;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripButton ExistingCustomer;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
	}
}
