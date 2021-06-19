using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberToPrimeFactorsConverter
{
	public class NumbersToPrimeFactorsConverter
	{
		private const string factorsSeparator = ", ";

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
						List<int> parsedFactors = this.numberToPrimeFactorsParser.Parse(numberToParse);
						string factorsString = BuildFactorsString(parsedFactors);

						Console.WriteLine($"{numberToParse}: {factorsString}");

						writer.WriteLine(factorsString);
					}
				}
			}
		}

		private string BuildFactorsString(List<int> factors)
		{
			StringBuilder stringBuilder = new();

			for (int index = 0; index < factors.Count; index++)
			{
				if (index > 0)
				{
					stringBuilder.Append(factorsSeparator);
				}

				stringBuilder.Append(factors[index]);
			}

			return stringBuilder.ToString();
		}
	}
}
