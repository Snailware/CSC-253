using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpAndProdWorkerLib
{
	public class ProductionWorker : Employee
	{
		/// <summary>
		/// class for production workers. inherits from employee. 
		/// </summary>
		/// <param name="name">name of production worker.</param>
		/// <param name="number">production worker id number.</param>
		/// <param name="shiftNumber">shift number of production worker. (1, 2, or 3)</param>
		/// <param name="hourlyPayRate">hourly pay rate for production worker.</param>
		public ProductionWorker(string name, int number, int shiftNumber, double hourlyPayRate)
			: base (name, number)
		{
			ShiftNumber = shiftNumber;
			HourlyPayRate = hourlyPayRate;
		}

		/// <summary>
		/// shift number of production worker. (1, 2, or 3)
		/// </summary>
		public int ShiftNumber { get; set; }

		/// <summary>
		/// hourly pay rate for production worker. 
		/// </summary>
		public double HourlyPayRate { get; set; }
	}
}
