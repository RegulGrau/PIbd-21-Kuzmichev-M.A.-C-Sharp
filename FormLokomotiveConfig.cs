using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormTyeplovoz
{
	public partial class FormLokomotiveConfig : Form
	{
		ILocomotive train = null;
		public FormLokomotiveConfig()
		{
			InitializeComponent();
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
					train = new Tyeplovoz(100, 500, Color.White, Color.Black, true, true, true);
					break;
			}
			DrawTrain();
		}

		
	}
}
