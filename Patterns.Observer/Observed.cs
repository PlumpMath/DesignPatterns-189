using System;
using System.Collections;
using System.Collections.Generic;

namespace Patterns.Observer
{
	public abstract class Observed
	{
		public List<Observer> obs_list { get; set; }
		public Observed ()
		{
			obs_list = new List<Observer> ();
		}

		public void addObserver(Observer obs) {
			obs_list.Add (obs);
		}

		public void Notify () {
			foreach (var item in obs_list) {
				item.Update ();
			}
		}
	}
}
