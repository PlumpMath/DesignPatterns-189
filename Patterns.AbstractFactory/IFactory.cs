using System;

namespace Patterns.AbstractFactory
{
	public interface IFactory
	{
		IScrollbar BuildScrollbar();
		IWindow BuildWindow();
	}
}

