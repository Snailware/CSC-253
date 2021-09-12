using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordSeparatorClassLibrary
{
	/// <summary>
	/// class for working with words.
	/// </summary>
	public static class WordOps
	{
		/// <summary>
		/// parse pascal case string to normal human readable string.
		/// </summary>
		/// <param name="input">pascal case string to be parsed.</param>
		/// <return>human readable string.</returns>
		public static string ParsePascalCase(string input)
		{
			string output = "";
			// var to hold output.
			
			for (int index = 0;  index < input.Length; index++)
			{
				if (Char.IsUpper(input[index]) && index != 0)
				{
					output = $"{output} {input[index].ToString().ToLower()}";
				}
				else
				{
					output = $"{output}{input[index]}";
				}
			}
			// iter over characters and construct output string accordingly.

			return output;
			// return parsed output.
		}
	}
}
