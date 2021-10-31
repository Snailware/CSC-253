using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpAndProdWorkerLib
{
	/// <summary>
	/// class for employees.
	/// </summary>
	public class Employee
	{
		/// <summary>
		/// class for employees.
		/// </summary>
		/// <param name="name">name of employee.</param>
		/// <param name="number">employee id number.</param>
		public Employee(string name, int number)
		{
			Name = name;
			Number = number;
		}

		/// <summary>
		/// name of employee.
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// employee id number.
		/// </summary>
		public int Number { get; set; }
	}
}
