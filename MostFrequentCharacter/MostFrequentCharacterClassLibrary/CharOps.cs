using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MostFrequentCharacterClassLibrary
{
	public static class CharOps
	{
		public static char MostFrequent(string input)
		{
			string allCharacters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
			List<Letter> Letters = new List<Letter>();
			Letter mostFrequent = new Letter(' ');

			foreach (char rawCharacter in allCharacters)
			{
				Letter currentLetter = new Letter(rawCharacter);
				Letters.Add(currentLetter);
			}
			// fill list with letter objs.

			foreach (char character in input.ToUpper())
			{
				foreach (Letter letter in Letters)
				{
					if (character == letter.Character)
					{
						letter.Increment();
					}
				}
			}
			// iter over input and letters, counting occurences.

			foreach (Letter countedLetter in Letters)
			{
				if (countedLetter.Count > mostFrequent.Count)
				{
					mostFrequent = countedLetter;
				}
			}
			// iter over letters, saving the latter with the most occurences.

			return mostFrequent.Character;
			// return char from most frequent letter obj.
		}
	}
}
