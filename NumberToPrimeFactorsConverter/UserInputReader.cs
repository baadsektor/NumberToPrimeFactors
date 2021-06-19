using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberToPrimeFactors.ConsoleApp
{
	public class UserInputReader
	{
		public static string ReadOutputFileName()
		{
			string outputFileName;
			do
			{
				outputFileName = GetFileName("Please enter the destination file path:");
			}
			while (!UserInputValidator.ValidateOutputFileName(outputFileName));

			return outputFileName;
		}

		public static string ReadInputFileName()
		{
			string inputFileName;
			do
			{
				inputFileName = GetFileName("Please enter the file path to convert:");
			}
			while (!UserInputValidator.ValidateInputFileName(inputFileName));
			return inputFileName;
		}

		private static string GetFileName(string message)
		{
			Console.WriteLine(message);
			string input = Console.ReadLine();
			if (input.Equals("exit", StringComparison.InvariantCultureIgnoreCase))
			{
				Environment.Exit(0);
			}

			return input;
		}
	}
}
