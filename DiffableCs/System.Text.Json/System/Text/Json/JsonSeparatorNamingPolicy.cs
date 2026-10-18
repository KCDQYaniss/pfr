namespace System.Text.Json;

internal abstract class JsonSeparatorNamingPolicy : JsonNamingPolicy
{
	[CompilerGenerated]
	private struct <>c__DisplayClass4_0
	{
		public int charsWritten; //Field offset: 0x0
		public char[] rentedBuffer; //Field offset: 0x8

	}

	private enum SeparatorState
	{
		NotStarted = 0,
		UppercaseLetter = 1,
		LowercaseLetterOrDigit = 2,
		SpaceSeparator = 3,
	}

	private readonly bool _lowercase; //Field offset: 0x10
	private readonly char _separator; //Field offset: 0x12

	internal JsonSeparatorNamingPolicy(bool lowercase, char separator) { }

	[CompilerGenerated]
	internal static void <ConvertNameCore>g__ExpandBuffer|4_1(ref Span destination, ref <>c__DisplayClass4_0 unnamed_param_1) { }

	[CompilerGenerated]
	internal static void <ConvertNameCore>g__WriteChar|4_0(char value, ref Span destination, ref <>c__DisplayClass4_0 unnamed_param_2) { }

	public virtual string ConvertName(string name) { }

	private static string ConvertNameCore(char separator, bool lowercase, ReadOnlySpan chars) { }

}

