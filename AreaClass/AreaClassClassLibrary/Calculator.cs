using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaClassClassLibrary
{
	/// <summary>
	/// class for performing math calculations.
	/// </summary>
	public static class Calculator
	{
		/// <summary>
		/// calculate area of a circle.
		/// </summary>
		/// <param name="radius">radius of circle.</param>
		/// <returns>area of circle.</returns>
		public static double CalculateArea(double radius)
		{
			return Math.PI * Math.Pow(radius, 2);
		}

		/// <summary>
		/// calculate area of rectangle.
		/// </summary>
		/// <param name="width">width of rectangle.</param>
		/// <param name="length">length of rectangle.</param>
		/// <returns>area of rectangle.</returns>
		public static double CalculateArea(float width, float length)
		{
			return width * length;
		}

		/// <summary>
		/// calculate area of cylinder.
		/// </summary>
		/// <param name="radius">radius of cylinder.</param>
		/// <param name="height">height of cylinder.</param>
		/// <returns>area of cylinder.</returns>
		public static double CalculateArea(double radius, double height)
		{
			return Math.PI * Math.Pow(radius, 2) * height;
		}
	}
}
