using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuitionIncreaseLib
{
	/// <summary>
	/// controller for Tuition Increase Calculator.
	/// </summary>
	public static class Controller
	{
		/// <summary>
		/// store values in data model. 
		/// </summary>
		/// <param name="startingAmount">Amount to start calculations from.</param>
		/// <param name="rateOfIncrease">percentage of tuition increase per year.</param>
		/// <param name="numberOfYears">number of years to calculate tuition for.</param>
		public static void StoreValues(double startingAmount, double rateOfIncrease, int numberOfYears)
		{
			DataModel.StartingAmount = startingAmount;
			DataModel.RateOfIncrease = rateOfIncrease;
			DataModel.NumberOfYears = numberOfYears;
		}

		/// <summary>
		/// calculate future tuition rates based on data model.
		/// </summary>
		public static void CalculateTuitionRate()
		{
			if (DataModel.StartingAmount <= 0 || DataModel.RateOfIncrease <= 0 || DataModel.NumberOfYears <= 0)
			{
				throw new ArgumentException("args must be greater than 0.");
			}
			else
			{
				double runningTotal = DataModel.StartingAmount;
				for (int index = 1; index <= DataModel.NumberOfYears; index++)
				{
					runningTotal += (runningTotal / 100 * DataModel.RateOfIncrease);

					string entry = $"Year {index} : {runningTotal.ToString("c")}";
					
					DataModel.Results.Add(entry);
				}
			}
		}

		/// <summary>
		/// get results from data model. 
		/// </summary>
		/// <returns></returns>
		public static List<string> GetResults()
		{
			return DataModel.Results;
		}

		/// <summary>
		/// clear all info from data model. 
		/// </summary>
		public static void ClearModel()
		{
			DataModel.StartingAmount = 0;
			DataModel.RateOfIncrease = 0;
			DataModel.NumberOfYears = 0;
			DataModel.Results.Clear();
		}
	}
}
