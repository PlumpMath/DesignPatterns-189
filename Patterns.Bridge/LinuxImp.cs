using System;

namespace Patterns.Bridge
{
	public class LinuxImp : IPicture
	{
		public void Paint (string format)
		{
			Console.WriteLine ("Printing on a Desktop PC running Ubuntu Desktop 14.04 LTS and the format is: " + format);
		}
	}
}

