using System;

namespace Patterns.AbstractFactory
{
	public class MOTIFScrollbar : IScrollbar
	{
		public void Draw ()
		{
			Console.WriteLine ("Drawing a MOTIF Scrollbar");
		}
	}
}

