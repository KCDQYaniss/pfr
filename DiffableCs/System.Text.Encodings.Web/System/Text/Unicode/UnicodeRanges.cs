namespace System.Text.Unicode;

[Nullable(0)]
[NullableContext(1)]
public static class UnicodeRanges
{
	private static UnicodeRange _all; //Field offset: 0x0
	private static UnicodeRange _u0000; //Field offset: 0x8

	public static UnicodeRange All
	{
		 get { } //Length: 91
	}

	public static UnicodeRange BasicLatin
	{
		 get { } //Length: 96
	}

	private static UnicodeRange CreateRange(ref UnicodeRange range, char first, char last) { }

	public static UnicodeRange get_All() { }

	public static UnicodeRange get_BasicLatin() { }

}

