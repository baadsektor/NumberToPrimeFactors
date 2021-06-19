using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberToPrimeFactors.ConsoleApp
{
	public class UserInputValidator
	{
		public static bool ValidateInputFileName(string inputFileName)
		{
			if (string.IsNullOrWhiteSpace(inputFileName) || !System.IO.File.Exists(inputFileName))
			{
				Console.WriteLine("Please enter valid input file path.");
				return false;
			}
			return true;
		}

		public static bool ValidateOutputFileName(string outputFileName)
		{
			if (string.IsNullOrWhiteSpace(outputFileName))
			{
				Console.WriteLine("Please enter valid output file path.");
				return false;
			}

			return true;
		}
	}
}
