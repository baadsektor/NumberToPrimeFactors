using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberToPrimeFactors.ConsoleApp
{
	public class PrimeFactorsStringBuilder
	{
		private const string factorsSeparator = ", ";

		public string BuildPrimeFactorsString(List<int> factors)
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
