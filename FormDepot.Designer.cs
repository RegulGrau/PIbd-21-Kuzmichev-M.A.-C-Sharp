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
			this.buttonAddTyeplovoz = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.buttonTake = new System.Windows.Forms.Button();
			this.pictureBoxDepot = new System.Windows.Forms.PictureBox();
			this.maskedTextBox = new System.Windows.Forms.MaskedTextBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxDepot)).BeginInit();
			this.SuspendLayout();
			// 
			// buttonAdd
			// 
			this.buttonAdd.Location = new System.Drawing.Point(1075, 3);
			this.buttonAdd.Name = "buttonAdd";
			this.buttonAdd.Size = new System.Drawing.Size(101, 66);
			this.buttonAdd.TabIndex = 0;
			this.buttonAdd.Text = "Add To Depot";
			this.buttonAdd.UseVisualStyleBackColor = true;
			this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
			// 
			// buttonAddTyeplovoz
			// 
			this.buttonAddTyeplovoz.Location = new System.Drawing.Point(1075, 75);
			this.buttonAddTyeplovoz.Name = "buttonAddTyeplovoz";
			this.buttonAddTyeplovoz.Size = new System.Drawing.Size(101, 66);
			this.buttonAddTyeplovoz.TabIndex = 1;
			this.buttonAddTyeplovoz.Text = "Add Tyeplovoz To Depot";
			this.buttonAddTyeplovoz.UseVisualStyleBackColor = true;
			this.buttonAddTyeplovoz.Click += new System.EventHandler(this.buttonAddTyeplovoz_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(1072, 144);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(108, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Take the Locomotive";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(1081, 163);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(37, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Place:";
			// 
			// buttonTake
			// 
			this.buttonTake.Location = new System.Drawing.Point(1075, 186);
			this.buttonTake.Name = "buttonTake";
			this.buttonTake.Size = new System.Drawing.Size(55, 22);
			this.buttonTake.TabIndex = 5;
			this.buttonTake.Text = "Take";
			this.buttonTake.UseVisualStyleBackColor = true;
			this.buttonTake.Click += new System.EventHandler(this.buttonTake_Click);
			// 
			// pictureBoxDepot
			// 
			this.pictureBoxDepot.Location = new System.Drawing.Point(2, 3);
			this.pictureBoxDepot.Name = "pictureBoxDepot";
			this.pictureBoxDepot.Size = new System.Drawing.Size(1064, 441);
			this.pictureBoxDepot.TabIndex = 6;
			this.pictureBoxDepot.TabStop = false;
			// 
			// maskedTextBox
			// 
			this.maskedTextBox.Location = new System.Drawing.Point(1124, 160);
			this.maskedTextBox.Mask = "00";
			this.maskedTextBox.Name = "maskedTextBox";
			this.maskedTextBox.Size = new System.Drawing.Size(52, 20);
			this.maskedTextBox.TabIndex = 7;
			this.maskedTextBox.ValidatingType = typeof(int);
			// 
			// FormDepot
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1178, 450);
			this.Controls.Add(this.maskedTextBox);
			this.Controls.Add(this.pictureBoxDepot);
			this.Controls.Add(this.buttonTake);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.buttonAddTyeplovoz);
			this.Controls.Add(this.buttonAdd);
			this.Name = "FormDepot";
			this.Text = "FormDepot";
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxDepot)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button buttonAdd;
		private System.Windows.Forms.Button buttonAddTyeplovoz;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button buttonTake;
		private System.Windows.Forms.PictureBox pictureBoxDepot;
		private System.Windows.Forms.MaskedTextBox maskedTextBox;
	}
}