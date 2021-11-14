using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuitionIncreaseLib
{
	/// <summary>
	/// data model for Tuition Increase Calculator. 
	/// </summary>
	public static class DataModel
	{
		/// <summary>
		/// Amount to start calculations from.
		/// </summary>
		public static double StartingAmount { get; set; }

		/// <summary>
		/// percentage of tuition increase per year.
		/// </summary>
		public static double RateOfIncrease { get; set; }

		/// <summary>
		/// number of years to calculate tuition for. 
		/// </summary>
		public static int NumberOfYears { get; set; }

		/// <summary>
		/// list to store results. 
		/// </summary>
		public static List<string> Results { get; } = new List<string>();
	}
}
