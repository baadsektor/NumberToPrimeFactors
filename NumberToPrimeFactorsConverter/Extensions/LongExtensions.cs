using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberToPrimeFactors.ConsoleApp.Extensions
{
	public static class LongExtensions
	{
		public static bool IsDivisibleBy(this long dividend, long divisor)
		{
			return dividend % divisor == 0;
		}

		public static bool MayHaveFactorsEqualOrGreaterThan(this long number, long oddFactor)
		{
			return oddFactor * oddFactor <= number;
		}

	}
}
