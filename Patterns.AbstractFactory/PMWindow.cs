using System;

namespace Patterns.AbstractFactory
{
	public class PMWindow : IWindow
	{
		public void Draw ()
		{
			Console.WriteLine ("Drawing a PM Window.");
		}
	}
}

