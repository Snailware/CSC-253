using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarClassClassLibrary
{
	public class Car
	{
		private int _year;
		private int _speed;
		private string _make;
		// fields. 

		/// <summary>
		/// simple car object.
		/// </summary>
		/// <param name="year">model year of car.</param>
		/// <param name="make">make of car.</param>
		public Car(int year, string make)
		{
			_year = year;
			_speed = 0;
			_make = make;
		}
		// constructor.

		/// <summary>
		/// model year of car. 
		/// </summary>
		public int Year
		{
			get { return _year; }
		}

		/// <summary>
		/// current speed of car.
		/// </summary>
		public int Speed
		{
			get { return _speed; }
		}

		/// <summary>
		/// make of car. 
		/// </summary>
		public string Make
		{
			get { return _make; }
		}
		// props.

		/// <summary>
		/// increase car speed by 5 mph. 
		/// </summary>
		public void Accelerate()
		{
			_speed += 5;
		}

		/// <summary>
		/// decrease car speed by 5 mph, going no lower than 0.
		/// </summary>
		public void Brake()
		{
			if (_speed > 0)
			{
				_speed -= 5;
			}
		}
		// methods.
	}
}
