using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WriteClassInformationClassLibrary
{
	/// <summary>
	/// class for persons.
	/// </summary>
	public class Person
	{
		/// <summary>
		/// name of person.
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// hair color of person.
		/// </summary>
		public string HairColor { get; set; }

		/// <summary>
		/// age of person.
		/// </summary>
		public int Age { get; set; }
		// autoprops.

		/// <summary>
		/// class for persons.
		/// </summary>
		/// <param name="name">name of person.</param>
		/// <param name="hairColor">hair color of person.</param>
		/// <param name="age">age of person.</param>
		public Person(string name, string hairColor, int age)
		{
			Name = name;
			HairColor = hairColor;
			Age = age;
		}
		// constructor.
	}
}
