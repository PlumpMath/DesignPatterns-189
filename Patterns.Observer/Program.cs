using System;

namespace Patterns.Observer
{
	public class Program
	{
		public static void main(string[] args) {
			var b = new Book ("The Lord of the Rings");
			b.Notify ();
		}
	}
}

