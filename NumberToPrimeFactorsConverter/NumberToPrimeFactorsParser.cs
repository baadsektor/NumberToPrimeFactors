using NumberToPrimeFactors.ConsoleApp.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberToPrimeFactors.ConsoleApp
{
	public class NumberToPrimeFactorsParser
	{
		private const string factorsSeparator = ", ";

		private int number;

		public string Parse(int number)
		{
			this.number = number;
			StringBuilder result = new();

			ParseTwos(result);
			ParseOddFactors(result);
			ParseRemainingPrimeFactor(result);

			return result.ToString();
		}

		private void ParseTwos(StringBuilder result)
		{
			int factor = 2;
			while (this.number.IsDivisibleBy(factor))
			{
				AppendResult(result, factor);
				this.number /= factor;
			}
		}

		private void ParseOddFactors(StringBuilder result)
		{
			int oddFactor = 3;
			while (this.number.MayHaveFactorsEqualOrGreaterThan(oddFactor))
			{
				if (this.number.IsDivisibleBy(oddFactor))
				{
					AppendResult(result, oddFactor);
					this.number /= oddFactor;
				}
				else
				{
					oddFactor = GetNextOddFactor(oddFactor);
				}
			}
		}

		private void ParseRemainingPrimeFactor(StringBuilder result)
		{
			if (this.number > 1)
			{
				AppendResult(result, this.number);
			}
		}

		private int GetNextOddFactor(int oddFactor)
		{
			return oddFactor + 2;
		}

		private void AppendResult(StringBuilder result, int factor)
		{
			if (result.Length != 0)
			{
				result.Append(factorsSeparator);
			}

			result.Append(factor);
		}
	}
}
