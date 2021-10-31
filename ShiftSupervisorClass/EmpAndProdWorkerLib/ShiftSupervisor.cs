using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpAndProdWorkerLib
{
	/// <summary>
	/// shift supervisor class.
	/// </summary>
	public class ShiftSupervisor : Employee
	{
		/// <summary>
		/// shift supervisor class.
		/// </summary>
		/// <param name="name">name of supervisor.</param>
		/// <param name="number">supervisor id number.</param>
		/// <param name="salary">salary of supervisor.</param>
		/// <param name="bonus">bonus of supervisor.</param>
		public ShiftSupervisor(string name, int number, double salary, double bonus)
			: base(name, number)
		{
			Salary = salary;
			Bonus = bonus;
		}

		/// <summary>
		/// salary of supervisor.
		/// </summary>
		public double Salary { get; set; }

		/// <summary>
		/// bonus of supervisor.
		/// </summary>
		public double Bonus { get; set; }
	}
}
