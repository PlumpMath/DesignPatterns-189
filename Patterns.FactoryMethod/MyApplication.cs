using System;

namespace Patterns.FactoryMethod
{
	public class MyApplication : IApplication
	{
		public MyApplication ()
		{
		}

		public IDocument createDocument ()
		{
			return new Document ();
		}

	}
}

