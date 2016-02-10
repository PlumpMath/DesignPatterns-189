using System;

namespace Patterns.Adapter
{
	public class OldCar
	{
		public string Brand {
			get;
			set;
		}
		public string Model {
			get;
			set;
		}
		public DateTime FabDate {
			get;
			set;
		}
		public OldCar (string Brand, string Model, DateTime FabDate)
		{
			this.Brand = Brand;
			this.Model = Model;
			this.FabDate = FabDate;
		}
	}
}

