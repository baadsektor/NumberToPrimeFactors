using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumberToPrimeFactors.ConsoleApp;
using System.Collections.Generic;

namespace NumberToPrimeFactorsConverter.Tests
{
	[TestClass]
	public class NumberToPrimeFactorsParserTest
	{

		[TestMethod,Owner("jan.scholz")]
		public void Parse_4793_Returns_CorrectResult()
		{
			NumberToPrimeFactorsParser parser = new();

			var actualResult = parser.Parse("19172");
			var expectedResult = "2,2,4793";

			Assert.AreEqual(expectedResult, actualResult);
		}

		[TestMethod,Owner("jan.scholz")]
		public void Parse_2_Returns_OneFactor()
		{
			NumberToPrimeFactorsParser parser = new();

			var actualResult = parser.Parse("2");
			var expectedResult = "2";

			Assert.AreEqual(expectedResult, actualResult);
		}

		[TestMethod,Owner("jan.scholz")]
		public void Parse_LargePrimeNumber_Returns_OneFactor()
		{
			NumberToPrimeFactorsParser parser = new();

			var actualResult = parser.Parse("4793");
			var expectedResult = "4793";

			Assert.AreEqual(expectedResult, actualResult);
		}

		[TestMethod,Owner("jan.scholz")]
		public void Parse_One_Returns_EmptyString()
		{
			NumberToPrimeFactorsParser parser = new();

			var result = parser.Parse("1");

			Assert.AreEqual(string.Empty, result);
		}

		[TestMethod,Owner("jan.scholz")]
		public void Parse_Zero_Returns_EmptyString()
		{
			NumberToPrimeFactorsParser parser = new();

			var result = parser.Parse("0");

			Assert.AreEqual(string.Empty, result);
		}

		[TestMethod, Owner("jan.scholz")]
		public void Parse_Empty_String_Returns_EmptyString()
		{
			NumberToPrimeFactorsParser parser = new();
			var result = parser.Parse(string.Empty);

			Assert.AreEqual(string.Empty, result);
		}

		[TestMethod, Owner("jan.scholz")]
		public void Parse_NonNumeral_String_Returns_EmptyString()
		{
			NumberToPrimeFactorsParser parser = new();
			var result = parser.Parse("test");

			Assert.AreEqual(string.Empty, result);
		}

		[TestMethod, Owner("jan.scholz")]
		public void Parse_NumberLargerThanLongMaxValue_Returns_EmptyString()
		{
			NumberToPrimeFactorsParser parser = new();
			var result = parser.Parse("9223372036854775808");

			Assert.AreEqual(string.Empty, result);
		}
	}
}
