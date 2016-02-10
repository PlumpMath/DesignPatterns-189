using System;

namespace Patterns.Bridge
{
	public class OSXImp : IPicture
	{
		public void Paint (string format)
		{
			Console.WriteLine ("Printing on a Mac Book Pro running OSX Yosemite and the format is: " + format);
		}
	}
}

