using System;

namespace Patterns.FactoryMethod
{
	public interface IDocument
	{
		void Open();
		void Save();
		void Close();
	}
}

