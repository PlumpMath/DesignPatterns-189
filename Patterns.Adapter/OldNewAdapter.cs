using System;

namespace Patterns.Adapter
{
	public class OldNewAdapter : IAuto
	{
		private OldCar oldCar;
		public OldNewAdapter (OldCar oldCar)
		{
			this.oldCar = oldCar;
		}

		#region IAuto implementation
		public string getBrand ()
		{
			return oldCar.Brand + " " + oldCar.Model;
		}
		public void setBrand (string brand)
		{
			var new_brand = brand.Split (' ');
			var parsed_brand = new_brand [0];
			var parsed_model = new_brand [1];
			oldCar.Brand = parsed_brand;
			oldCar.Model = parsed_model;
		}
		public int getYears ()
		{
			return DateTime.Now.Year - oldCar.FabDate.Year;
		}
		public void setYears (int years)
		{
			var d = DateTime.Now.Year - years;
			var nd = new DateTime (d, DateTime.Now.Month, DateTime.Now.Day);
			oldCar.FabDate = nd;
		}
		#endregion
		
	}
}

