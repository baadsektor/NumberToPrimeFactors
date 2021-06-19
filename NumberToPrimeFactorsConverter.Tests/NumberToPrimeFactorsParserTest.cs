using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace NumberToPrimeFactorsConverter.Tests
{
	[TestClass]
	public class NumberToPrimeFactorsParserTest
	{

		[TestMethod, Owner("jan.scholz")]
		public void Parse_4793_Returns_CorrectResult()
		{
			NumberToPrimeFactorsParser parser = new();

			var actualResults = parser.Parse(19172);
			var expectedResults = new List<int> { 2, 2, 4793 };

			CollectionAssert.AreEqual(expectedResults, actualResults);
		}

		[TestMethod, Owner("jan.scholz")]
		public void Parse_2_Returns_OneFactor()
		{
			NumberToPrimeFactorsParser parser = new();

			var actualResults = parser.Parse(2);
			var expectedResults = new List<int> { 2 };

			CollectionAssert.AreEqual(expectedResults, actualResults);
		}

		[TestMethod, Owner("jan.scholz")]
		public void Parse_One_Returns_EmptyList()
		{
			NumberToPrimeFactorsParser parser = new();

			var results = parser.Parse(1);

			Assert.AreEqual(0, results.Count);
		}

		public void Parse_LargePrimeNumber_Returns_OneFactor()
		{
			NumberToPrimeFactorsParser parser = new();

			var actualResults = parser.Parse(4793);
			var expectedResults = new List<int> { 4793 };

			CollectionAssert.AreEqual(expectedResults, actualResults);
		}
	}
}
