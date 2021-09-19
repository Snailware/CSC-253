using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomNumberFileWriterClassLibrary
{
	/// <summary>
	/// data model for program.
	/// </summary>
	public static class DataModel
	{
		/// <summary>
		/// number of numbers to write to file.
		/// </summary>
		public static int NumberCount { get; set; } = 1;

		/// <summary>
		/// path to write file.
		/// </summary>
		public static string FilePath { get; set; } = "";
		// autoprops.
	}
}
