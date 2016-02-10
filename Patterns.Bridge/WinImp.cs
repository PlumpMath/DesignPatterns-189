using System;

namespace Patterns.Bridge
{
	public class WinImp : IPicture
	{
		public void Paint (string format)
		{
			Console.WriteLine ("Printed on an ASUS Republic of Gamers running Windows 10 and the format is: " + format);
		}
	}
}

