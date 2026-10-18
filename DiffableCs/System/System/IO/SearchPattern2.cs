namespace System.IO;

internal class SearchPattern2
{
	private class Op
	{
		public OpCode Code; //Field offset: 0x10
		public string Argument; //Field offset: 0x18
		public Op Next; //Field offset: 0x20

		public Op(OpCode code) { }

	}

	private enum OpCode
	{
		ExactString = 0,
		AnyChar = 1,
		AnyString = 2,
		End = 3,
		True = 4,
	}

	internal static readonly char[] WildcardChars; //Field offset: 0x0
	internal static readonly char[] InvalidChars; //Field offset: 0x8
	private Op ops; //Field offset: 0x10
	private bool ignore; //Field offset: 0x18
	private bool hasWildcard; //Field offset: 0x19
	private string pattern; //Field offset: 0x20

	public bool HasWildcard
	{
		 get { } //Length: 5
	}

	private static SearchPattern2() { }

	public SearchPattern2(string pattern) { }

	public SearchPattern2(string pattern, bool ignore) { }

	private void Compile(string pattern) { }

	public bool get_HasWildcard() { }

}

