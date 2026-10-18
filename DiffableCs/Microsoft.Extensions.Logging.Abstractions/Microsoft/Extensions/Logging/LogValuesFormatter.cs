namespace Microsoft.Extensions.Logging;

[Nullable(0)]
[NullableContext(1)]
internal sealed class LogValuesFormatter
{
	private readonly List _valueNames; //Field offset: 0x10
	private readonly string _format; //Field offset: 0x18
	[CompilerGenerated]
	private readonly string <OriginalFormat>k__BackingField; //Field offset: 0x20

	public string OriginalFormat
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public List ValueNames
	{
		 get { } //Length: 5
	}

	public LogValuesFormatter(string format) { }

	private static int FindBraceIndex(string format, char brace, int startIndex, int endIndex) { }

	public string Format(object[] values) { }

	private static object FormatArgument(object value) { }

	[CompilerGenerated]
	public string get_OriginalFormat() { }

	public List get_ValueNames() { }

	public KeyValuePair GetValue(object[] values, int index) { }

	private static bool TryFormatArgumentIfNullOrEnumerable(T value, out object stringValue) { }

}

