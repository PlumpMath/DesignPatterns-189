using System;

namespace Patterns.Bridge
{
	public class BMP : AbstractPicture
	{
		public BMP (IPicture img):base(img){}

		public override void Caller() {
			img.Paint ("BMP");
		}
	}
}

