//Type is in global namespace

[Extension]
public static class StringBuilderExtension
{
	private const int DIGITS_RANGE = 1000; //Field offset: 0x0
	private static readonly string MINUS; //Field offset: 0x0
	private static readonly string[] _preallocatedStrings; //Field offset: 0x8

	private static StringBuilderExtension() { }

	[Extension]
	public static void AppendDigitalValue(StringBuilder stringBuilder, float f) { }

	[Extension]
	public static void AppendDigitalValue(StringBuilder stringBuilder, double f) { }

	[Extension]
	public static void AppendDigitalValue(StringBuilder stringBuilder, int int, int charsCount = -1) { }

}

