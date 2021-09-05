using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordCounterClassLibrary
{
	/// <summary>
	/// class for performing counting operations. 
	/// </summary>
	public static class Counter
	{
		/// <summary>
		/// count words in string.
		/// </summary>
		/// <param name="input">string of words to count.</param>
		/// <returns>number of words in string.</returns>
		public static int CountWords(string input)
		{
			char[] delimiters = { ' ' };
			if (input == "")
			{
				return 0;
			}
			else
			{
				return input.Split(delimiters).Length;
			}
		}
	}
}
