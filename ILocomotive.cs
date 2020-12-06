using System.Drawing;
namespace FormTyeplovoz
{
	public interface ILocomotive
	{
		void SetPosition(int x, int y, int width, int height);
		void MoveTransport(Direction dir);
		void DrawTransport(Graphics gr);
		void SetMainColor(Color color);
	}
}
