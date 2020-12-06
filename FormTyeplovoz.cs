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
	public partial class FormTyeplovoz : Form
	{
		private Train tyeplovoz;
		public FormTyeplovoz()
		{
			InitializeComponent();
		}
		private void Draw()
		{
			Bitmap bmp = new Bitmap(pictureBoxTrain.Width, pictureBoxTrain.Height);
			Graphics gr = Graphics.FromImage(bmp);
			tyeplovoz.DrawTransport(gr);
			pictureBoxTrain.Image = bmp;
		}

		private void buttonCreate_Click(object sender, EventArgs e)
		{
			Random rnd = new Random();
			tyeplovoz = new Train(rnd.Next(100, 300), rnd.Next(1000, 2000), Color.DarkSeaGreen,
		   Color.Gray, true, true, true);
			tyeplovoz.SetPosition(rnd.Next(200, 200), rnd.Next(200, 200), pictureBoxTrain.Width,
		   pictureBoxTrain.Height);
			Draw();
		}

		private void buttonMove_Click(object sender, EventArgs e)
		{
			
			string name = (sender as Button).Name;
			switch (name)
			{
				case "buttonUp":
					tyeplovoz.MoveTransport(Direction.Up);
					break;
				case "buttonDown":
					tyeplovoz.MoveTransport(Direction.Down);
					break;
				case "buttonLeft":
					tyeplovoz.MoveTransport(Direction.Left);
					break;
				case "buttonRight":
					tyeplovoz.MoveTransport(Direction.Right);
					break;
			}
			Draw();
		}
	}
}

