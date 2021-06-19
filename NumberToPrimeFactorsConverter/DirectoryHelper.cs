using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberToPrimeFactors.ConsoleApp
{
	public class DirectoryHelper
	{
		public static void CreateDirectoryIfDoesNotExist(string outputFileName)
		{
			FileInfo outputFileInfo = new(outputFileName);
			string directoryName = outputFileInfo.DirectoryName;
			if (!System.IO.Directory.Exists(directoryName))
			{
				System.IO.Directory.CreateDirectory(directoryName);
			}
		}
	}
}
