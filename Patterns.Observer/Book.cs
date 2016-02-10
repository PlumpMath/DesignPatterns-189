using System;

namespace Patterns.Observer
{
	public class Book : Observed
	{
		string Title {get;set;}
		public Book (string Title):base()
		{
			this.Title = Title;
		}

	}
}

