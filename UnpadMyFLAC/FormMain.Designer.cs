namespace UnpadMyFLAC
{
	partial class FormMain
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
			this.label1 = new System.Windows.Forms.Label();
			this.buttonOpen = new System.Windows.Forms.Button();
			this.btnOpenAllFolders = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 17);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(72, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "Choose folder";
			// 
			// buttonOpen
			// 
			this.buttonOpen.Location = new System.Drawing.Point(90, 12);
			this.buttonOpen.Name = "buttonOpen";
			this.buttonOpen.Size = new System.Drawing.Size(93, 23);
			this.buttonOpen.TabIndex = 2;
			this.buttonOpen.Text = "Open Folder";
			this.buttonOpen.UseVisualStyleBackColor = true;
			this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
			// 
			// btnOpenAllFolders
			// 
			this.btnOpenAllFolders.Location = new System.Drawing.Point(12, 41);
			this.btnOpenAllFolders.Name = "btnOpenAllFolders";
			this.btnOpenAllFolders.Size = new System.Drawing.Size(171, 23);
			this.btnOpenAllFolders.TabIndex = 4;
			this.btnOpenAllFolders.Text = "Choose Folder and all Subfolders";
			this.btnOpenAllFolders.UseVisualStyleBackColor = true;
			this.btnOpenAllFolders.Click += new System.EventHandler(this.btnOpenAllFolders_Click);
			// 
			// FormMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(195, 69);
			this.Controls.Add(this.btnOpenAllFolders);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.buttonOpen);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "FormMain";
			this.Text = "UnpadMyFLAC";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button buttonOpen;
		private System.Windows.Forms.Button btnOpenAllFolders;
	}
}

