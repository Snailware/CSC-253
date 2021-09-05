using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AverageNumberOfLettersClassLibrary
{
	/// <summary>
	/// class for performing string operations.
	/// </summary>
	public static class StringOps
	{
		static string[] _words;

		/// <summary>
		/// count number of words in input string.
		/// </summary>
		/// <param name="input">string of words to be counted.</param>
		/// <returns>number of words in input.</returns>
		public static int CountWords(string input)
		{
			char[] delimiters = { ' ' };

			if (input != "")
			{
				_words = input.Split(delimiters);
			}
			else
			{
				_words = new string[] { };
			}
			return _words.Length;
		}

		/// <summary>
		/// calc average number of letters per word in internal array.
		/// </summary>
		/// <returns>avg number of letters per word.</returns>
		public static int AverageLetters()
		{
			int wordCount = 0,
				letterCount = 0;

			if (_words.Length != 0)
			{
				foreach (string word in _words)
				{
					wordCount++;
					letterCount += word.Length;
				}

				return letterCount / wordCount;
			}
			else
			{
				return 0;
			}
		}
	}
}
