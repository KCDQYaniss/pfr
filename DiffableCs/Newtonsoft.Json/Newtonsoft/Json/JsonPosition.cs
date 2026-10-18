namespace Newtonsoft.Json;

[Nullable(0)]
[NullableContext(1)]
internal struct JsonPosition
{
	private static readonly char[] SpecialCharacters; //Field offset: 0x0
	internal JsonContainerType Type; //Field offset: 0x0
	internal int Position; //Field offset: 0x4
	[Nullable(2)]
	internal string PropertyName; //Field offset: 0x8
	internal bool HasIndex; //Field offset: 0x10

	private static JsonPosition() { }

	public JsonPosition(JsonContainerType type) { }

	internal static string BuildPath(List positions, Nullable currentPosition) { }

	internal int CalculateLength() { }

	internal static string FormatMessage(IJsonLineInfo lineInfo, string path, string message) { }

	internal static bool TypeHasIndex(JsonContainerType type) { }

	[NullableContext(2)]
	internal void WriteTo(StringBuilder sb, ref StringWriter writer, ref char[] buffer) { }

}

