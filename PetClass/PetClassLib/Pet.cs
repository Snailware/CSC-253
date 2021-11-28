using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetClassLib
{
	public class Pet
	{
		public Pet(string name, string type, string age)
		{
			Name = name;
			Type = type;
			Age = age;
		}

		public string Name { get; set; }
		public string Type { get; set; }
		public string Age { get; set; }
	}
}
