//Type is in global namespace

[Extension]
public static class LoggerUtils
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__2_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal string <ToFormat>b__2_0(string current, KeyValuePair prop) { }

	}

	internal sealed class EnumIntStringConverter`1 : JsonConverter
	{

		public EnumIntStringConverter`1() { }

		public virtual T ReadJson(JsonReader reader, Type objectType, T existingValue, bool hasExistingValue, JsonSerializer serializer) { }

		public virtual void WriteJson(JsonWriter writer, T value, JsonSerializer serializer) { }

	}

	private static StringBuilder _stringBuilder; //Field offset: 0x0

	private static LoggerUtils() { }

	private static string Extract(object[] args) { }

	public static string FormatFields(object[] args) { }

	public static string SafeFormat(string format, object[] args) { }

	[Extension]
	public static string ToFormat(LogEventInfo logEvent) { }

	[Extension]
	public static LogLevel ToLogLevel(LogType logType) { }

	[Extension]
	public static LogType ToLogType(LogLevel logType) { }

}

