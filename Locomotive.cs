using System;
using System.Drawing;

namespace FormTyeplovoz
{
	public class Locomotive : Train
	{
		protected readonly int trainWidth = 120;
		protected readonly int trainHeight = 80;
		protected readonly char separator = ';';
		public Locomotive(int maxSpeed, float weight, Color mainColor)
		{
			MaxSpeed = maxSpeed;
			Weight = weight;
			MainColor = mainColor;
		}
		public Locomotive(string info)
		{
			string[] strs = info.Split(separator);
			if (strs.Length == 3)
			{
				MaxSpeed = Convert.ToInt32(strs[0]);
				Weight = Convert.ToInt32(strs[1]);
				MainColor = Color.FromName(strs[2]);
			}
		}
		public override void MoveTransport(Direction direction)
		{
			float step = MaxSpeed * 100 / Weight;
			switch (direction)
			{
				// вправо
				case Direction.Right:
					if (_startPosX + step < _pictureWidth - trainWidth)
					{
						_startPosX += step;
					}
					break;
				//влево
				case Direction.Left:
					if (_startPosX - step > 150)
					{
						_startPosX -= step;
					}
					break;
				//вверх
				case Direction.Up:
					if (_startPosY - step > 0)
					{
						_startPosY -= step;
					}
					break;
				//вниз
				case Direction.Down:
					if (_startPosY + step < _pictureHeight)
					{
						_startPosY += step;
					}
					break;
			}
		}
		public override void DrawTransport(Graphics g)
		{
			Pen pen = new Pen(Color.Black, 4);
			Brush wheell = new SolidBrush(Color.Black);
			g.FillEllipse(wheell, _startPosX + 60, _startPosY + 50, 20, 20);
			g.FillEllipse(wheell, _startPosX + 40, _startPosY + 50, 20, 20);
			g.FillEllipse(wheell, _startPosX, _startPosY + 50, 20, 20);
			g.FillEllipse(wheell, _startPosX - 20, _startPosY + 50, 20, 20);
			g.FillEllipse(wheell, _startPosX - 60, _startPosY + 50, 20, 20);
			g.FillEllipse(wheell, _startPosX - 80, _startPosY + 50, 20, 20);
			g.FillEllipse(wheell, _startPosX - 120, _startPosY + 50, 20, 20);
			g.FillEllipse(wheell, _startPosX - 140, _startPosY + 50, 20, 20);
			g.FillRectangle(wheell, _startPosX - 40, _startPosY + 50, 20, 5);
			pen = new Pen(Color.DarkSeaGreen);
			Brush mainBrush = new SolidBrush(MainColor);
			g.FillRectangle(mainBrush, _startPosX-20, _startPosY+10, 20, 50);
			g.FillRectangle(mainBrush, _startPosX, _startPosY + 20, 80, 40);
			g.FillRectangle(new SolidBrush(Color.DeepSkyBlue), _startPosX + 60, _startPosY + 25, 15, 10);
			g.FillRectangle(new SolidBrush(Color.DeepSkyBlue), _startPosX + 40, _startPosY + 25, 15, 10);
			g.FillRectangle(new SolidBrush(Color.DeepSkyBlue), _startPosX + 20, _startPosY + 25, 15, 10);
			g.FillRectangle(new SolidBrush(Color.DeepSkyBlue), _startPosX, _startPosY + 25, 15, 10);
			g.FillRectangle(mainBrush, _startPosX - 140, _startPosY + 20, 100, 40);
			g.FillRectangle(new SolidBrush(Color.DeepSkyBlue), _startPosX - 60, _startPosY + 25, 15, 10);
			g.FillRectangle(new SolidBrush(Color.DeepSkyBlue), _startPosX - 80, _startPosY + 25, 15, 10);
			g.FillRectangle(new SolidBrush(Color.DeepSkyBlue), _startPosX - 100, _startPosY + 25, 15, 10);
			g.FillRectangle(new SolidBrush(Color.DeepSkyBlue), _startPosX - 120, _startPosY + 25, 15, 10);
			g.FillRectangle(new SolidBrush(Color.DeepSkyBlue), _startPosX - 140, _startPosY + 25, 15, 10);
			pen = new Pen(Color.Green, 10);
			g.DrawLine(pen, _startPosX, _startPosY + 45, _startPosX + 80, _startPosY + 45);
		}
		public override string ToString()
		{
			return $"{MaxSpeed}{separator}{Weight}{separator}{MainColor.Name}";
		}
	}
}

