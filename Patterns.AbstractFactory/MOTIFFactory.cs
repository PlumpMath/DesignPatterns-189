using System;

namespace Patterns.AbstractFactory
{
	public class MOTIFFactory : IFactory
	{
		public IScrollbar BuildScrollbar ()
		{
			return new MOTIFScrollbar ();
		}
		public IWindow BuildWindow ()
		{
			return new MOTIFWindow ();
		}
	}
}

