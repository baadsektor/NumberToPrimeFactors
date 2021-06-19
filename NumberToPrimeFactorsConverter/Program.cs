using NumberToPrimeFactors.ConsoleApp;
using System;

namespace NumberToPrimeFactorsConverter
{
	public class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine($"Welcome to the Number-To-Prime Factors converter.{Environment.NewLine}");

			bool shouldContinue = true;
			while (shouldContinue)
			{

				Console.WriteLine("Please enter the file path to convert or type 'exit' to leave the application:");

				string input = Console.ReadLine();

				if (input.Equals("exit", StringComparison.InvariantCultureIgnoreCase))
				{
					shouldContinue = false;
					break;
				}

				while (!InputValidator.ValidateInput(input))
				{
					input = Console.ReadLine();
				}

				Console.WriteLine("Please enter the destination file path:");
				string output = Console.ReadLine();


				NumbersToPrimeFactorsConverter converter = new(new NumberToPrimeFactorsParser(), new PrimeFactorsStringBuilder());
				try
				{
					converter.Convert(input, output);
					Console.WriteLine($"Done!{Environment.NewLine}");
				}
				catch (Exception ex)
				{
					Console.WriteLine($"ERROR: {ex.Message}");
				}
			}
		}
	}
}
