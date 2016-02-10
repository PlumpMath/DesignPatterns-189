using System;

namespace Patterns.AbstractFactory
{
	public class PMScrollbar : IScrollbar
	{
		public void Draw ()
		{
			Console.WriteLine ("Drawing a PM Scrollbar");
		}
	}
}

