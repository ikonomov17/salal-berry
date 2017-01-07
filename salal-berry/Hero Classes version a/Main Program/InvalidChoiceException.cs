using System;

namespace Main_Program
{
	public class InvalidChoiceException : ApplicationException
	{
		private readonly string fileName;
		private readonly int lineNumber;

		public InvalidChoiceException(string message, string filename, int linenumber, Exception exception) : base(message, exception)
		{
			this.fileName = filename;
			this.lineNumber = linenumber;
		}

		public string FileName { get; }

		public int LineNumber { get; }

		public override string Message
		{
			get
			{
				return string.Format($"{base.Message} (file: {this.fileName})");
			}
		}
	}
}
