using System;

namespace Patterns.State
{
	public abstract class State
	{
		protected Context ctx;
		public abstract void Handle();
	}
}

