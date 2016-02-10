using System;

namespace Patterns.Adapter
{
	public interface IAuto
	{
		string getBrand();
		void setBrand(string brand);
		int getYears();
		void setYears(int years);
	}
}

