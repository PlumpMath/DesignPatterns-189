using System;

namespace Patterns.FactoryMethod
{
	public class Document : IDocument
	{
		public Document ()
		{
		}
		public void Open ()
		{
			Console.WriteLine ("Document Opened");
		}
		public void Save ()
		{
			Console.WriteLine ("Document Saved");
		}
		public void Close ()
		{
			Console.WriteLine ("Document Closed");
		}
	}
}

