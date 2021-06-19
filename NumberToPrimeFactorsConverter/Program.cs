using System;

namespace NumberToPrimeFactors.ConsoleApp
{
	public class Program
	{
		static void Main(string[] args)
		{
			DisplayIntroduction();

			NumberToPrimeFactorsFileConverter converter = new(new NumberToPrimeFactorsParser());

			bool shouldContinue = true;
			while (shouldContinue)
			{
				try
				{
					string inputFileName = UserInputReader.ReadInputFileName();
					string outputFileName = UserInputReader.ReadOutputFileName();
					DirectoryHelper.CreateDirectoryIfDoesNotExist(outputFileName);

					converter.Convert(inputFileName, outputFileName);
					Console.WriteLine($"Done!{Environment.NewLine}");
				}
				catch (Exception ex)
				{
					Console.WriteLine($"ERROR: {ex.Message}");
				}
			}
		}

		private static void DisplayIntroduction()
		{
			Console.WriteLine($"Welcome to the Prime Factors converter.{Environment.NewLine}");
			Console.WriteLine($"This application will read a list of integers and convert them into their prime factors.{Environment.NewLine}");
			Console.WriteLine($"Type 'exit' to exit the application. While the converter is processing the data, you can always stop it by pressing any key.{Environment.NewLine}");
		}
	}
}
