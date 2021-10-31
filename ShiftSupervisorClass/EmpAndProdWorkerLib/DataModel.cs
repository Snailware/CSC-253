using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpAndProdWorkerLib
{
	/// <summary>
	/// data model for program.
	/// </summary>
	public static class DataModel
	{
		/// <summary>
		/// stored worker.
		/// </summary>
		public static ProductionWorker Worker { get; set; }

		/// <summary>
		/// stored supervisor.
		/// </summary>
		public static ShiftSupervisor Supervisor { get; set; }
	}
}
