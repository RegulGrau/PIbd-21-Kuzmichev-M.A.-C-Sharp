using System;
using System.Drawing;
using System.Windows.Forms;
namespace FormTyeplovoz
{
	partial class FormDepot : Form
	{
		private readonly Depot<Locomotive> depot;
		public FormDepot()
		{
			InitializeComponent();
			depot = new Depot<Locomotive>(pictureBoxDepot.Width, pictureBoxDepot.Height);
			Draw();
		}

		private void Draw()
		{
			Bitmap bmp = new Bitmap(pictureBoxDepot.Width, pictureBoxDepot.Height);
			Graphics gr = Graphics.FromImage(bmp);
			depot.Draw(gr);
			pictureBoxDepot.Image = bmp;
		}


		private void buttonAdd_Click(object sender, EventArgs e)
		{
			ColorDialog dialog = new ColorDialog();
			if (dialog.ShowDialog() == DialogResult.OK)
			{
				var train = new Locomotive(100, 1000, dialog.Color);

				if (depot + train)
				{
					Draw();
				}
				else
				{
					MessageBox.Show("Депо переполнено");
				}
			}
		}
		private void buttonAddTyeplovoz_Click(object sender, EventArgs e)
		{
			ColorDialog dialog = new ColorDialog();
			if (dialog.ShowDialog() == DialogResult.OK)
			{
				ColorDialog dialogDop = new ColorDialog();
				if (dialogDop.ShowDialog() == DialogResult.OK)
				{
					var train = new Tyeplovoz(100, 1000, dialog.Color, dialogDop.Color, true, true, true);
					if (depot + train)
					{
						Draw();
					}
					else
					{
						MessageBox.Show("Депо переполнено");
					}
				}
			}
		}

		private void buttonTake_Click(object sender, EventArgs e)
		{
			if (maskedTextBox.Text != "")
			{
				var train = depot - Convert.ToInt32(maskedTextBox.Text);
				if (train != null)
				{
					FormTyeplovoz form = new FormTyeplovoz();
					form.SetLocomotive(train);
					form.ShowDialog();
				}
				Draw();
			}
		}
	}
}