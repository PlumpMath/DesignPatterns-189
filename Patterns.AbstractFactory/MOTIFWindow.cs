using System;

namespace Patterns.AbstractFactory
{
	public class MOTIFWindow : IWindow
	{
		public void Draw ()
		{
			Console.WriteLine ("Drawing a MOTIF Window");
		}
	}
}

