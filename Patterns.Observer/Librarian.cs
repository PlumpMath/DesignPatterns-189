using System;

namespace Patterns.Observer
{
	public class Librarian : Observer
	{
		public void Update() {
			Console.WriteLine ("From the Librarian: Updated!!!!");
		}
	}
}

