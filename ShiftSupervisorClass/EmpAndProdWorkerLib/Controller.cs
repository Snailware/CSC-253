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
		public static ProductionWorker LoadWorker()
		{
			return DataModel.Worker;
		}

		/// <summary>
		/// load shift supervisor from data model.
		/// </summary>
		/// <returns></returns>
		public static ShiftSupervisor LoadSupervisor()
		{
			return DataModel.Supervisor;
		}

		/// <summary>
		/// save production worker to data model.
		/// </summary>
		/// <param name="name">name of worker.</param>
		/// <param name="number">worker id number.</param>
		/// <param name="shiftNumber">shift number of worker.</param>
		/// <param name="hourlyPayRate">hourly pay rate of worker.</param>
		public static void SaveWorker(string name, int number, int shiftNumber, double hourlyPayRate)
		{
			DataModel.Worker = new ProductionWorker(name, number, shiftNumber, hourlyPayRate);
		}

		/// <summary>
		/// save shift supervisor to data model.
		/// </summary>
		/// <param name="name">name of supervisor.</param>
		/// <param name="number">number of supervisor.</param>
		/// <param name="salary">salary of supervisor.</param>
		/// <param name="bonus">nonus of supervisor.</param>
		public static void SaveSupervisor(string name, int number, double salary, double bonus)
		{
			DataModel.Supervisor = new ShiftSupervisor(name, number, salary, bonus);
		}

		/// <summary>
		/// clear worker data from data model.
		/// </summary>
		public static void ClearWorker()
		{
			DataModel.Worker = null;
		}

		/// <summary>
		/// clear supervisor data from data model.
		/// </summary>
		public static void ClearSupervisor()
		{
			DataModel.Supervisor = null;
		}
	}
}
