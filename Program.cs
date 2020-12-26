using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormTyeplovoz
{
	public static class Program
	{
		public delegate void Func(Locomotive train, Locomotive train2);
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new FormDepot());
		}
	}
}
