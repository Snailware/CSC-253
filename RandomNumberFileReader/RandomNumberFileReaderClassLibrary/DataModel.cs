using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomNumberFileReaderClassLibrary
{
	public static class DataModel
	{
		/// <summary>
		/// name of to be read.
		/// </summary>
		public static string FileName { get; set; } = "";

		/// <summary>
		/// sum of numbers read from file.
		/// </summary>
		public static int Sum { get; set; } = 0;

		/// <summary>
		/// amount of numbers read from file.
		/// </summary>
		public static int Count { get; set; } = 0;

		/// <summary>
		/// list of numbers read from file.
		/// </summary>
		public static List<int> Numbers { get; set; } = new List<int>();
		// autoprops.
	}
}
