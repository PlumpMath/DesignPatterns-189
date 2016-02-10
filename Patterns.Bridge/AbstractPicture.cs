using System;

namespace Patterns.Bridge
{
	public abstract class AbstractPicture
	{
		public IPicture img { get; set; }

		public AbstractPicture (IPicture img)
		{
			this.img = img;
		}
		public abstract void Caller();
	}
}

