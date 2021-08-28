using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KineticEnergyClassLibrary
{
	/// <summary>
	/// class for performing calculations.
	/// </summary>
	public static class Calculator
	{
		/// <summary>
		/// calculate kinetic energy based on input params.
		/// </summary>
		/// <param name="mass">obj mass.</param>
		/// <param name="velocity">obj velocity.</param>
		/// <returns>kinetic energy of object.</returns>
		public static double KineticEnergy(double mass, double velocity)
		{
			return 1D / 2D * (mass * Math.Pow(velocity, 2D));
		}
	}
}
