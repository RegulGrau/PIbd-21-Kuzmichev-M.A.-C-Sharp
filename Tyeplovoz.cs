using System;
using System.Drawing;
namespace FormTyeplovoz
{
	public class Tyeplovoz : Locomotive
	{ 
		public Color DopColor { private set; get; }
		public bool FrontBamper { private set; get; }
		public bool Chimney { private set; get; }
		public bool SportLine { private set; get; }
		public Tyeplovoz(int maxSpeed, float weight, Color mainColor, Color dopColor,
	   bool frontBamper, bool chimney, bool line) : base(maxSpeed, weight, mainColor)
		{
			DopColor = dopColor;
			FrontBamper = frontBamper;
			Chimney = chimney;
			SportLine = line;
		}
		public Tyeplovoz(string info) : base(info)
		{
			string[] strs = info.Split(separator);
			if (strs.Length == 7)
			{
				MaxSpeed = Convert.ToInt32(strs[0]);
				Weight = Convert.ToInt32(strs[1]);
				MainColor = Color.FromName(strs[2]);
				DopColor = Color.FromName(strs[3]);
				FrontBamper = Convert.ToBoolean(strs[4]);
				Chimney = Convert.ToBoolean(strs[5]);
				SportLine = Convert.ToBoolean(strs[6]);
			}
		}
		public override void DrawTransport(Graphics g)
		{
			base.DrawTransport(g);
			Pen pen = new Pen(Color.Black, 4); Brush wheell = new SolidBrush(Color.Black);

			if (FrontBamper)
			{
				g.DrawLine(pen, _startPosX + 80, _startPosY + 40, _startPosX + 80, _startPosY + 60);
				g.DrawLine(pen, _startPosX + 80, _startPosY + 40, _startPosX + 100, _startPosY + 60);
				g.DrawLine(pen, _startPosX + 80, _startPosY + 60, _startPosX + 100, _startPosY + 60);

			}
			pen = new Pen(Color.DarkSeaGreen);
			Brush mainBrush = new SolidBrush(MainColor);
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
		public void SetDopColor(Color color)
		{
			DopColor = color;
		}
		public override string ToString()
		{
			return
		   $"{base.ToString()}{separator}{DopColor.Name}{separator}{FrontBamper}{separator}{Chimney}{separator}{SportLine}";
		}
	}
}
