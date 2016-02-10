using System;

namespace Patterns.Bridge
{
	public class JPG : AbstractPicture
	{
		public JPG (IPicture img) : base(img) {}
		public override void Caller() {
			img.Paint ("JPG");
		}
	}
}

