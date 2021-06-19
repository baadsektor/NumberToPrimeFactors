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
		private int number;

		public List<int> Parse(int number)
		{
			this.number = number;
			List<int> results = new();

			ParseTwos(results);
			ParseOddFactors(results);
			ParseRemainingPrimeFactor(results);

			return results;
		}

		private void ParseTwos(List<int> results)
		{
			int factor = 2;
			while (this.number.IsDivisibleBy(factor))
			{
				results.Add(factor);
				this.number /= factor;
			}
		}

		private void ParseOddFactors(List<int> results)
		{
			int oddFactor = 3;
			while (this.number.MayHaveFactorsEqualOrGreaterThan(oddFactor))
			{
				if (this.number.IsDivisibleBy(oddFactor))
				{
					results.Add(oddFactor);
					this.number /= oddFactor;
				}
				else
				{
					oddFactor = GetNextOddFactor(oddFactor);
				}
			}
		}

		private void ParseRemainingPrimeFactor(List<int> results)
		{
			if (this.number > 1)
			{
				results.Add(this.number);
			}
		}

		private int GetNextOddFactor(int oddFactor)
		{
			return oddFactor + 2;
		}
	}
}
