using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpAndProdWorkerLib
{
	/// <summary>
	/// class for operating on data model.
	/// </summary>
	public static class Controller
	{
		/// <summary>
		/// load production worker from data model.
		/// </summary>
		/// <returns>production worker obj.</returns>
		public static TeamLeader LoadWorker()
		{
			return DataModel.Worker;
		}

		/// <summary>
		/// save production worker to data model.
		/// </summary>
		/// <param name="name">name of worker.</param>
		/// <param name="number">worker id number.</param>
		/// <param name="shiftNumber">shift number of worker.</param>
		/// <param name="hourlyPayRate">hourly pay rate of worker.</param>
		public static void SaveWorker(string name, 
									  int number, 
									  int shiftNumber, 
									  double hourlyPayRate, 
									  double bonusAmount, 
									  int requiredTrainingHours, 
									  int completedTrainingHours)
		{
			DataModel.Worker = new TeamLeader(name, 
											  number, 
											  shiftNumber, 
											  hourlyPayRate, 
											  bonusAmount, 
											  requiredTrainingHours, 
											  completedTrainingHours);
		}

		/// <summary>
		/// clear worker data from data model.
		/// </summary>
		public static void ClearWorker()
		{
			DataModel.Worker = null;
		}
	}
}
