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
		private PrimeFactorsStringBuilder primeFactorsStringBuilder;

		public NumbersToPrimeFactorsConverter(
			NumberToPrimeFactorsParser numberToPrimeFactorsParser, 
			PrimeFactorsStringBuilder primeFactorsStringBuilder)
		{
			this.numberToPrimeFactorsParser = numberToPrimeFactorsParser;
			this.primeFactorsStringBuilder = primeFactorsStringBuilder;
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

						List<int> parsedFactors = this.numberToPrimeFactorsParser.Parse(numberToParse);
						string factorsString = this.primeFactorsStringBuilder.BuildPrimeFactorsString(parsedFactors);

						Console.WriteLine($"{numberToParse}: {factorsString}");

						writer.WriteLine(factorsString);
					}
				}
			}
		}
	}
}
