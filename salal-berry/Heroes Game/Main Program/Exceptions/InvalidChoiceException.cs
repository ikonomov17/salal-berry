using System;

namespace Main_Program
{
	public class InvalidChoiceException : ApplicationException
	{
		public InvalidChoiceException()
		{
		}

		public InvalidChoiceException(string message) : base(message)
		{
		}
	}
}
