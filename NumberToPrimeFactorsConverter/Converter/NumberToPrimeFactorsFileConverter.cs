using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NumberToPrimeFactors.ConsoleApp
{
	public class NumberToPrimeFactorsFileConverter
	{
		private INumberToPrimeFactorsParser numberToPrimeFactorsParser;

		public NumberToPrimeFactorsFileConverter(INumberToPrimeFactorsParser numberToPrimeFactorsParser)
		{
			this.numberToPrimeFactorsParser = numberToPrimeFactorsParser;
		}

		public void Convert(string inputFile, string outputFile)
		{
			using (StreamReader reader = new(inputFile))
			{
				using (StreamWriter writer = new(outputFile))
				{
					string currentLine;

					while (!string.IsNullOrEmpty(currentLine = reader.ReadLine()) && !(Console.KeyAvailable))
					{
						Console.Write($"{currentLine}:");

						string parsedFactorsString = this.numberToPrimeFactorsParser.Parse(currentLine);

						writer.WriteLine(parsedFactorsString);
						writer.Flush();

						Console.WriteLine(parsedFactorsString);
					}
				}
			}
		}
	}
}
