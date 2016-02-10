using System;

namespace Patterns.Observer
{
	public class Grocer : Observer
	{
		public void Update() {
			Console.WriteLine ("From the grocer: Updated!!!!");
		}
	}
}

