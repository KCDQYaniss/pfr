//Type is in global namespace

[Extension]
public static class JsonExtensions
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__17_0; //Field offset: 0x8
		public static Func <>9__17_1; //Field offset: 0x10
		public static Func <>9__17_2; //Field offset: 0x18
		public static Func <>9__17_3; //Field offset: 0x20
		public static Func <>9__17_4; //Field offset: 0x28

		private static <>c() { }

		public <>c() { }

		internal bool <AnalyzeCommonJsonErrors>b__17_0(char c) { }

		internal bool <AnalyzeCommonJsonErrors>b__17_1(char c) { }

		internal bool <AnalyzeCommonJsonErrors>b__17_2(char c) { }

		internal bool <AnalyzeCommonJsonErrors>b__17_3(char c) { }

		internal bool <AnalyzeCommonJsonErrors>b__17_4(char c) { }

	}

	[ThreadStatic]
	private static JsonSerializer _cachedDefaultSerializer; //Field offset: 0x80000000

	private static void AnalyzeCommonJsonErrors(string jsonData, StringBuilder errorLog) { }

	public static string BeautifyJson(string json) { }

	private static string FormatJson(string json, Formatting formatting) { }

	private static JsonConverter[] GetConvertersOrDefault(JsonConverter[] converters) { }

	public static JsonSerializer GetSerializer(JsonConverter[] converters) { }

	public static void LogJsonDeserializationError(JsonSerializationException jsonEx, string jsonData = null, string prefix = "JSON") { }

	public static void LogJsonDeserializationError(string jsonData) { }

	private static void LogJsonReaderError(JsonReaderException jsonEx, string jsonData) { }

	public static string MinifyJson(string json) { }

	[Extension]
	public static T ParseJsonTo(UnparsedData unparsedData, JsonConverter[] converters) { }

	[Extension]
	public static object ParseJsonTo(UnparsedData unparsedData, Type type, object existingObject, JsonConverter[] converters) { }

	[Extension]
	public static T ParseJsonTo(string json, JsonConverter[] converters) { }

	[Extension]
	public static T ParseJsonTo(Stream stream, JsonConverter[] converters) { }

	[Extension]
	public static void PopulateJson(string json, T target) { }

	[Extension]
	public static string ToJson(T obj, JsonConverter[] converters) { }

	[Extension]
	public static string ToPrettyJson(T obj, JsonConverter[] converters) { }

	[Extension]
	public static UnparsedData ToUnparsedData(T obj, JsonConverter[] converters) { }

}

