using System.Drawing;

namespace FormTyeplovoz
{
	class Train
	{
		private float _startPosX;
		private float _startPosY;
		private int _pictureWidth;
		private int _pictureHeight;
		private readonly int trainWidth = 120;
		private readonly int trainHeight = 80;
		public int MaxSpeed { private set; get; }
		public float Weight { private set; get; }
		public Color MainColor { private set; get; }
		public Color DopColor { private set; get; }
		public bool FrontBamper { private set; get; }
		public bool Chimney { private set; get; }
		public bool SportLine { private set; get; }
		public Train(int maxSpeed, float weight, Color mainColor, Color dopColor,
	   bool frontBamper, bool chimney, bool line)
		{
			MaxSpeed = maxSpeed;
			Weight = weight;
			MainColor = mainColor;
			DopColor = dopColor;
			FrontBamper = frontBamper;
			Chimney = chimney;
			SportLine = line;
		}

		public void SetPosition(int x, int y, int width, int height)
		{
			_startPosX = x;
			_startPosY = y;
			_pictureWidth = width;
			_pictureHeight = height;
		}
		public void MoveTransport(Direction direction)
		{
			float step = MaxSpeed * 100 / Weight;
			switch (direction)
			{
				case Direction.Right:
					if (_startPosX + step < _pictureWidth - trainWidth)
					{
						_startPosX += step;
					}
					break;
				case Direction.Left:
					if (_startPosX - step > trainWidth)
					{
						_startPosX -= step;
					}
					break;
				case Direction.Up:
					if (_startPosY - step > trainHeight)
					{
						_startPosY -= step;
					}
					break;
				case Direction.Down:
					if (_startPosY + step < _pictureHeight - trainHeight)
					{
						_startPosY += step;
					}
					break;
			}
		}

		public void DrawTransport(Graphics g)
		{
			Pen pen = new Pen(Color.Black, 4);
			Brush wheell = new SolidBrush(Color.Black);
			g.FillEllipse(wheell, _startPosX + 60, _startPosY + 50, 20, 20);
			g.FillEllipse(wheell, _startPosX + 40, _startPosY + 50, 20, 20);
			g.FillEllipse(wheell, _startPosX, _startPosY + 50, 20, 20);
			g.FillEllipse(wheell, _startPosX - 20, _startPosY + 50, 20, 20);
			if (FrontBamper)
			{
				g.DrawLine(pen, _startPosX + 80, _startPosY + 40, _startPosX + 80, _startPosY + 60);
				g.DrawLine(pen, _startPosX + 80, _startPosY + 40, _startPosX + 100, _startPosY + 60);
				g.DrawLine(pen, _startPosX + 80, _startPosY + 60, _startPosX + 100, _startPosY + 60);
			}
			pen = new Pen(Color.DarkSeaGreen);
			Brush mainBrush = new SolidBrush(MainColor);
			g.FillRectangle(mainBrush, _startPosX-20, _startPosY+10, 20, 50);
			g.FillRectangle(mainBrush, _startPosX, _startPosY + 20, 80, 40);
			g.FillRectangle(new SolidBrush(Color.DeepSkyBlue), _startPosX + 60, _startPosY + 25, 15, 10);
			g.FillRectangle(new SolidBrush(Color.DeepSkyBlue), _startPosX + 40, _startPosY + 25, 15, 10);
			g.FillRectangle(new SolidBrush(Color.DeepSkyBlue), _startPosX + 20, _startPosY + 25, 15, 10);
			g.FillRectangle(new SolidBrush(Color.DeepSkyBlue), _startPosX, _startPosY + 25, 15, 10);
			pen = new Pen(Color.Green, 10);
			if (SportLine)
			{
				pen = new Pen(Color.Red, 10);
			}
			g.DrawLine(pen, _startPosX, _startPosY + 45, _startPosX + 80, _startPosY + 45);
			if (Chimney)
			{
				Brush bamper = new SolidBrush(DopColor);
				g.FillRectangle(bamper, _startPosX + 60, _startPosY, 10, 20);
			}
		}
	}
}

