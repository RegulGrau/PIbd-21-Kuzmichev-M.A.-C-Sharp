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
		private ILocomotive tyeplovoz;

		public FormTyeplovoz()
		{
			InitializeComponent();
		}

		public void SetLocomotive(ILocomotive tyeplovoz)
		{
			this.tyeplovoz = tyeplovoz;
			Draw();
		}

		private void Draw()
		{
			Bitmap bmp = new Bitmap(pictureBoxTrain.Width, pictureBoxTrain.Height);
			Graphics gr = Graphics.FromImage(bmp);
			tyeplovoz.DrawTransport(gr);
			pictureBoxTrain.Image = bmp;
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

