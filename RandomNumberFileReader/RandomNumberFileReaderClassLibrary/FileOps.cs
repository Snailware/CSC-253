﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomNumberFileReaderClassLibrary
{
	/// <summary>
	/// class for performing file operations.
	/// </summary>
	public static class FileOps
	{
		/// <summary>
		/// read numbers from a file.
		/// </summary>
		/// <param name="fileName">name of file to be read.</param>
		/// <returns>list of numbers.</returns>
		public static List<int> ReadNumbers(string fileName)
		{
			List<int> numbers = new List<int>();
			StreamReader inputFile;

			inputFile = File.OpenText(fileName);
			// open file.

			do
			{
				numbers.Add(int.Parse(inputFile.ReadLine()));
				// read number from line and add to list.
				// Parse used instead of TryParse because file contains values
				// generated by code and can therefore be trusted.	

			} while (!inputFile.EndOfStream);
			// iter until reaching end of file. 

			inputFile.Close();
			// close file.

			return numbers;
			// return list of numbers.
		}
	}
}