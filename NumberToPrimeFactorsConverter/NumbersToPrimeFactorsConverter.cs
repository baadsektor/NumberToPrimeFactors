using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NumberToPrimeFactors.ConsoleApp
{
	public class NumbersToPrimeFactorsConverter
	{
		private NumberToPrimeFactorsParser numberToPrimeFactorsParser;

		public NumbersToPrimeFactorsConverter(NumberToPrimeFactorsParser numberToPrimeFactorsParser)
		{
			this.numberToPrimeFactorsParser = numberToPrimeFactorsParser;
		}

		public void Convert(string inputFile, string outputFile)
		{
			using (StreamReader reader = new(inputFile))
			{
				string currentLine;

				using (StreamWriter writer = new(outputFile))
				{
					while (!string.IsNullOrEmpty(currentLine = reader.ReadLine()) && !(Console.KeyAvailable))
					{
						Int32.TryParse(currentLine, out int numberToParse);

						string parsedFactorsString = this.numberToPrimeFactorsParser.Parse(numberToParse);

						Console.WriteLine($"{numberToParse}: {parsedFactorsString}");

						writer.WriteLine(parsedFactorsString);
					}
				}
			}
		}
	}
}
