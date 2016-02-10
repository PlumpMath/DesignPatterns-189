using System;

namespace Patterns.AbstractFactory
{
	public class PMFactory : IFactory
	{
		public IScrollbar BuildScrollbar ()
		{
			return new PMScrollbar ();
		}
		public IWindow BuildWindow ()
		{
			return new PMWindow ();
		}
	}
}

