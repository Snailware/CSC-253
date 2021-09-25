using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomNumberFileWriterClassLibrary
{
	public static class FileOps
	{
		/// <summary>
		/// write random numbers to a file according to params.
		/// </summary>
		/// <param name="count">amount of numbers to write.</param>
		/// <param name="filePath">path of file to write to.</param>
		public static string WriteRandomNumbers(int count, string filePath)
		{
			StreamWriter outputFile;

			Random random = new Random();
			// random number generator.

			try
			{
				outputFile = File.CreateText(filePath);
				// create file.

				for (int index = 0; index < count; index++)
				{
					int number = random.Next(0, 101);
					outputFile.WriteLine(number);
				}
				// generate desired amount of random numbers & write to file.

				outputFile.Close();
				// close file.

				return "File Saved Successfully!";
				// return confirmation for success.
			}
			catch (Exception ex)
			{
				return ex.Message;
				// return error message if fails. 
			}

		}
	}
}
