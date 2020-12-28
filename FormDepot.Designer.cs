using System;

namespace FormTyeplovoz
{
	partial class FormDepot
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
            this.buttonAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonTake = new System.Windows.Forms.Button();
            this.pictureBoxDepot = new System.Windows.Forms.PictureBox();
            this.maskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.listBoxDepot = new System.Windows.Forms.ListBox();
            this.buttonDeleteDepot = new System.Windows.Forms.Button();
            this.textBoxDepotName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonAddDepot = new System.Windows.Forms.Button();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDepot)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(1429, 239);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(135, 81);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.Text = "Add To Depot";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1424, 423);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Take the Locomotive";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1429, 447);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Place:";
            // 
            // buttonTake
            // 
            this.buttonTake.Location = new System.Drawing.Point(1481, 492);
            this.buttonTake.Margin = new System.Windows.Forms.Padding(4);
            this.buttonTake.Name = "buttonTake";
            this.buttonTake.Size = new System.Drawing.Size(73, 27);
            this.buttonTake.TabIndex = 5;
            this.buttonTake.Text = "Take";
            this.buttonTake.UseVisualStyleBackColor = true;
            this.buttonTake.Click += new System.EventHandler(this.buttonTake_Click);
            // 
            // pictureBoxDepot
            // 
            this.pictureBoxDepot.Location = new System.Drawing.Point(0, 28);
            this.pictureBoxDepot.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxDepot.Name = "pictureBoxDepot";
            this.pictureBoxDepot.Size = new System.Drawing.Size(1419, 543);
            this.pictureBoxDepot.TabIndex = 6;
            this.pictureBoxDepot.TabStop = false;
            // 
            // maskedTextBox
            // 
            this.maskedTextBox.Location = new System.Drawing.Point(1499, 443);
            this.maskedTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.maskedTextBox.Mask = "00";
            this.maskedTextBox.Name = "maskedTextBox";
            this.maskedTextBox.Size = new System.Drawing.Size(68, 22);
            this.maskedTextBox.TabIndex = 7;
            this.maskedTextBox.ValidatingType = typeof(int);
            // 
            // listBoxDepot
            // 
            this.listBoxDepot.FormattingEnabled = true;
            this.listBoxDepot.ItemHeight = 16;
            this.listBoxDepot.Location = new System.Drawing.Point(1439, 113);
            this.listBoxDepot.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxDepot.Name = "listBoxDepot";
            this.listBoxDepot.Size = new System.Drawing.Size(115, 84);
            this.listBoxDepot.TabIndex = 8;
            this.listBoxDepot.SelectedIndexChanged += new System.EventHandler(this.listBoxDepot_SelectedIndexChanged);
            // 
            // buttonDeleteDepot
            // 
            this.buttonDeleteDepot.Location = new System.Drawing.Point(1449, 206);
            this.buttonDeleteDepot.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDeleteDepot.Name = "buttonDeleteDepot";
            this.buttonDeleteDepot.Size = new System.Drawing.Size(104, 26);
            this.buttonDeleteDepot.TabIndex = 9;
            this.buttonDeleteDepot.Text = "Delete Depot";
            this.buttonDeleteDepot.UseVisualStyleBackColor = true;
            this.buttonDeleteDepot.Click += new System.EventHandler(this.buttonDeleteDepot_Click);
            // 
            // textBoxDepotName
            // 
            this.textBoxDepotName.Location = new System.Drawing.Point(1447, 49);
            this.textBoxDepotName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxDepotName.Name = "textBoxDepotName";
            this.textBoxDepotName.Size = new System.Drawing.Size(104, 22);
            this.textBoxDepotName.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1459, 22);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Depots";
            // 
            // buttonAddDepot
            // 
            this.buttonAddDepot.Location = new System.Drawing.Point(1439, 78);
            this.buttonAddDepot.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAddDepot.Name = "buttonAddDepot";
            this.buttonAddDepot.Size = new System.Drawing.Size(100, 28);
            this.buttonAddDepot.TabIndex = 12;
            this.buttonAddDepot.Text = "Add Depot";
            this.buttonAddDepot.UseVisualStyleBackColor = true;
            this.buttonAddDepot.Click += new System.EventHandler(this.buttonAddDepot_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1590, 28);
            this.menuStrip.TabIndex = 13;
            this.menuStrip.Text = "menuStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.loadToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            this.openFileDialog.Filter = "txt file | *.txt";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "txt file | *.txt";
            // 
            // FormDepot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1590, 554);
            this.Controls.Add(this.buttonAddDepot);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxDepotName);
            this.Controls.Add(this.buttonDeleteDepot);
            this.Controls.Add(this.listBoxDepot);
            this.Controls.Add(this.maskedTextBox);
            this.Controls.Add(this.pictureBoxDepot);
            this.Controls.Add(this.buttonTake);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormDepot";
            this.Text = "FormDepot";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDepot)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}


        #endregion

        private System.Windows.Forms.Button buttonAdd;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button buttonTake;
		private System.Windows.Forms.PictureBox pictureBoxDepot;
		private System.Windows.Forms.MaskedTextBox maskedTextBox;
		private System.Windows.Forms.ListBox listBoxDepot;
        private System.Windows.Forms.Button buttonDeleteDepot;
        private System.Windows.Forms.TextBox textBoxDepotName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonAddDepot;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}