
namespace UPC_Shipment_Manager_UI.Forms
{
	partial class Notification
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

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.lblMessage = new System.Windows.Forms.Label();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.pb = new System.Windows.Forms.PictureBox();
			this.btnClose = new System.Windows.Forms.PictureBox();
			this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
			((System.ComponentModel.ISupportInitialize)(this.pb)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
			this.SuspendLayout();
			// 
			// lblMessage
			// 
			this.lblMessage.AutoSize = true;
			this.lblMessage.Font = new System.Drawing.Font("Sitka Small", 10F);
			this.lblMessage.ForeColor = System.Drawing.Color.White;
			this.lblMessage.Location = new System.Drawing.Point(50, 25);
			this.lblMessage.Name = "lblMessage";
			this.lblMessage.Size = new System.Drawing.Size(103, 20);
			this.lblMessage.TabIndex = 8;
			this.lblMessage.Text = "Message Text";
			// 
			// timer1
			// 
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// pb
			// 
			this.pb.Image = global::UPC_Shipment_Manager_UI.Properties.Resources.Info;
			this.pb.Location = new System.Drawing.Point(3, 17);
			this.pb.Name = "pb";
			this.pb.Size = new System.Drawing.Size(41, 36);
			this.pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pb.TabIndex = 7;
			this.pb.TabStop = false;
			// 
			// btnClose
			// 
			this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnClose.Image = global::UPC_Shipment_Manager_UI.Properties.Resources.cancel;
			this.btnClose.Location = new System.Drawing.Point(271, 24);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(29, 26);
			this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.btnClose.TabIndex = 6;
			this.btnClose.TabStop = false;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// bunifuElipse1
			// 
			this.bunifuElipse1.ElipseRadius = 5;
			this.bunifuElipse1.TargetControl = this;
			// 
			// Notification
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(222)))));
			this.ClientSize = new System.Drawing.Size(303, 71);
			this.ControlBox = false;
			this.Controls.Add(this.lblMessage);
			this.Controls.Add(this.pb);
			this.Controls.Add(this.btnClose);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Notification";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.Text = "Notification";
			((System.ComponentModel.ISupportInitialize)(this.pb)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblMessage;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.PictureBox pb;
		private System.Windows.Forms.PictureBox btnClose;
		private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
	}
}