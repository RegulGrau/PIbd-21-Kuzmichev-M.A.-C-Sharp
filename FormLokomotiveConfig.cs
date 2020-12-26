using System;
using System.Drawing;
using System.Windows.Forms;
using static FormTyeplovoz.Program;

namespace FormTyeplovoz
{
	public partial class FormLokomotiveConfig : Form
	{
		Locomotive train = null;
		public event Func<Locomotive, Locomotive> EventAddTrain;

		public FormLokomotiveConfig()
		{
			InitializeComponent();
			foreach (var color in groupBoxColors.Controls)
			{
				if (color is Panel)
				{
					((Panel)color).MouseDown += panelColor_MouseDown;
				}
			}

			buttonClose.Click += (object sender, EventArgs e) => { Close(); };
		}

		private void DrawTrain()
		{
			if (train != null)
			{
				Bitmap bmp = new Bitmap(pictureBoxTrain.Width, pictureBoxTrain.Height);
				Graphics gr = Graphics.FromImage(bmp);
				train.SetPosition(5, 5, pictureBoxTrain.Width, pictureBoxTrain.Height);
				train.DrawTransport(gr);
				pictureBoxTrain.Image = bmp;
			}
		}
		public void AddEvent(Func<Locomotive, Locomotive> ev)
		{
			if (ev == null)
			{
				EventAddTrain = new Func<Locomotive, Locomotive>(ev);
			}
			else
			{
				EventAddTrain += ev;
			}
		}

		private void labelTrain_MouseDown(object sender, MouseEventArgs e)
		{
			labelTrain.DoDragDrop(labelTrain.Text, DragDropEffects.Move | DragDropEffects.Copy);
		}
		private void labelTyeplovoz_MouseDown(object sender, MouseEventArgs e)
		{
			labelTyeplovoz.DoDragDrop(labelTyeplovoz.Text, DragDropEffects.Move | DragDropEffects.Copy);
		}
		private void panelTrain_DragEnter(object sender, DragEventArgs e)
		{
			if (e.Data.GetDataPresent(DataFormats.Text))
			{
				e.Effect = DragDropEffects.Copy;
			}
			else
			{
				e.Effect = DragDropEffects.None;
			}
		}

		private void panelTrain_DragDrop(object sender, DragEventArgs e)
		{
			switch (e.Data.GetData(DataFormats.Text).ToString())
			{
				case "Train":
					train = new Locomotive(100, 500, Color.White);
					break;
				case "Tyeplovoz":
					train = new Tyeplovoz(100, 500, Color.White, Color.Black, checkBoxFrontBamper.Checked, checkBoxChimney.Checked, checkBoxSportLine.Checked);
					break;
			}
			DrawTrain();
		}

		private void panelColor_MouseDown(object sender, MouseEventArgs e)
		{
			((Panel)sender).DoDragDrop(((Panel)sender).BackColor, DragDropEffects.Move | DragDropEffects.Copy);
		}
		private void labelBaseColor_DragEnter(object sender, DragEventArgs e)
		{
			if (e.Data.GetDataPresent(typeof(Color)))
			{
				e.Effect = DragDropEffects.Copy;
			}
			else
			{
				e.Effect = DragDropEffects.None;
			}
		}
		private void labelBaseColor_DragDrop(object sender, DragEventArgs e)
		{
			if (train!=null)
				train.SetMainColor((Color)(e.Data.GetData(typeof(Color))));
			DrawTrain();
		}



		private void labelDopColor_DragDrop(object sender, DragEventArgs e)
		{
			if (train is Tyeplovoz)
			{
				(train as Tyeplovoz).SetDopColor((Color)e.Data.GetData(typeof(Color)));
				DrawTrain();
			}
		}

		private void buttonAdd_Click(object sender, EventArgs e)
		{
			EventAddTrain?.Invoke(train);
			Close();
		}


	}
}
