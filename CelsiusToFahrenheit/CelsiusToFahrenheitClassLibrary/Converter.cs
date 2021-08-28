using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CelsiusToFahrenheitClassLibrary
{
	/// <summary>
	/// class for converting temperatures.
	/// </summary>
	public static class Converter
	{
		/// <summary>
		/// convert celsius temp to fahrenheit. 
		/// </summary>
		/// <param name="cTemp">celsius temp to convert.</param>
		/// <returns>fahrenheit temp equivalent of input.</returns>
		public static float CelsToFahr(float cTemp)
		{
			return 9.0F / 5.0F * cTemp + 32;
		}
	}
}
