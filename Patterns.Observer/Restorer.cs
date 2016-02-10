using System;

namespace Patterns.Observer
{
	public class Restorer : Observer
	{
		public void Update() {
			Console.WriteLine ("From the restorer: Updated!!!");
		}
	}
}

