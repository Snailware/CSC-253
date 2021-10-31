using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringExtensionMethodsLib
{
	public static class Extensions
	{
		public static char[] StringToCharArray(this string input)
		{
			return input.ToCharArray();
		}

		public static string[] DateToStringArray(this string input)
		{
			return input.Split('/');
		}

		public static string StringToPhoneNumber(this string input)
		{
			string output;
			output = input.Insert(0, "(");
			output = output.Insert(4, ") ");
			output = output.Insert(9, "-");
			return output;
		}

		public static string ReverseString(this string input)
		{
			char[] inputArray = input.ToCharArray();
			Array.Reverse(inputArray);
			return new string(inputArray);
		}

		public static int CountWords(this string input)
		{
			string[] inputArray = input.Split(null);
			return inputArray.Length;
		}
	}
}
