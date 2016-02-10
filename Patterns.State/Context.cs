using System;

namespace Patterns.State
{
	public class Context
	{
		public State state {
			get;
			set;
		}
		public void Request() {
			state.Handle ();
		}
	}
}

