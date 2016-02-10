using System;

namespace Patterns.Bridge
{
	public class GIF : AbstractPicture
	{
		public GIF (IPicture img) : base(img) {}

		public override void Caller ()
		{
			img.Paint ("GIF");
		}
	}
}

