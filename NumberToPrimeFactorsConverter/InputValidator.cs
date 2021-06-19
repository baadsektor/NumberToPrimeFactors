using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberToPrimeFactors.ConsoleApp
{
	public class InputValidator
	{
		public static bool ValidateInput(string input)
		{
			if (!System.IO.File.Exists(input))
			{
				Console.WriteLine("File under the given path not found.");
				return false;
			}
			return true;
		}
	}
}
