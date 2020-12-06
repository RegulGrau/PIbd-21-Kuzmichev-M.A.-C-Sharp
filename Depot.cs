using System.Collections.Generic;
using System.Drawing;
namespace FormTyeplovoz
{
	public class Depot<T> where T : class, ILocomotive
	{
		private readonly List<T> _places;
		private readonly int _maxCount;
		private readonly int pictureWidth;
		private readonly int pictureHeight;
		private readonly int _placeSizeWidth = 500;
		private readonly int _placeSizeHeight = 100;
		public Depot(int picWidth, int picHeight)
		{
			int width = picWidth / _placeSizeWidth;
			int height = picHeight / _placeSizeHeight;
			_maxCount = width * height;
			pictureWidth = picWidth;
			pictureHeight = picHeight;
			_places = new List<T>();
		}
		public static bool operator +(Depot<T> p, T train)
		{
			if (p._places.Count >= p._maxCount)
			{
				return false;
			}
			p._places.Add(train);
			return true;
		}
		public static T operator -(Depot<T> p, int index)
		{
			if (index+1 < -1 || index+1 > p._places.Count)
			{
				return null;
			}
			T train = p._places[index];
			p._places.RemoveAt(index);
			return train;
		}
		public void Draw(Graphics g)
		{
			DrawMarking(g);
			for (int i = 0; i < _places.Count; i++)
			{
				//корректировка положения
				_places[i]?.SetPosition(i / (pictureWidth / _placeSizeWidth*2) * _placeSizeWidth+150, i % (pictureWidth / _placeSizeWidth*2) * _placeSizeHeight+10, pictureWidth, pictureHeight);
				_places[i]?.DrawTransport(g);
			}
		}
		private void DrawMarking(Graphics g)
		{
			Pen pen = new Pen(Color.Black, 3);
			for (int i = 0; i < pictureWidth / _placeSizeWidth; i++)
			{
				for (int j = 0; j < pictureHeight / _placeSizeHeight + 1; ++j)
				{
					g.DrawLine(pen, i * _placeSizeWidth, j * _placeSizeHeight, i * _placeSizeWidth + _placeSizeWidth / 2, j * _placeSizeHeight);
				}
				g.DrawLine(pen, i * _placeSizeWidth, 0, i * _placeSizeWidth, (pictureHeight / _placeSizeHeight) * _placeSizeHeight);
			}
		}
	}
}

