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
					int numberToParse;

					while (!string.IsNullOrEmpty(currentLine = reader.ReadLine()) && !(Console.KeyAvailable))
					{
						Int32.TryParse(currentLine, out numberToParse);

						string parsedFactorsString = this.numberToPrimeFactorsParser.Parse(numberToParse);

						writer.WriteLine(parsedFactorsString);
						writer.Flush();

						Console.WriteLine($"{currentLine}: {parsedFactorsString}");
					}
				}
			}
		}
	}
}
