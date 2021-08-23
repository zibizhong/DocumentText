using System;
using System.Windows.Forms;

namespace Prana.Notepad
{
	
	public class AppStart
	{
		public AppStart()
		{
			
		}

		
		[STAThread]
		static void Main() 
		{
			Application.Run(new FrmMain());
		}
	}
}
