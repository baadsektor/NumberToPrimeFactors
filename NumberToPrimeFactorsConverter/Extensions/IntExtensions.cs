using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberToPrimeFactorsConverter.Extensions
{
	public static class IntExtensions
	{
		public static bool IsDivisibleBy(this int dividend, int divisor)
		{
			return dividend % divisor == 0;
		}

		public static bool MayHaveFactorsEqualOrGreaterThan(this int number, int oddFactor)
		{
			return oddFactor * oddFactor <= number;
		}

	}
}
