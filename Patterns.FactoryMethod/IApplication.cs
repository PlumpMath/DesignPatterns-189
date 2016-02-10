using System;

namespace Patterns.FactoryMethod
{
	public interface IApplication
	{
		IDocument createDocument();
	}
}

