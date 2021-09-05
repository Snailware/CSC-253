using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MostFrequentCharacterClassLibrary
{
	/// <summary>
	/// class for letters.
	/// </summary>
	public class Letter
	{
		private char _character;
		private int _count;
		// fields.

		/// <summary>
		/// class for letters.
		/// </summary>
		/// <param name="letter">letter of object.</param>
		public Letter(char letter)
		{
			_character = letter;
			_count = 0;
		}
		// constructors.

		/// <summary>
		/// letter as character.
		/// </summary>
		public char Character
		{
			get { return _character; }
		}

		/// <summary>
		/// number of occurences of letter. 
		/// </summary>
		public int Count
		{
			get { return _count; }
		}
		// props.

		/// <summary>
		/// increase letter count by 1.
		/// </summary>
		public void Increment()
		{
			_count++;
		}
		// methods.
	}
}
