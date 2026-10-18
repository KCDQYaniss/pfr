namespace System.Text.Json.Serialization.Converters;

internal sealed class IDictionaryConverter`1 : JsonDictionaryConverter
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__5_0; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal object <ConfigureJsonTypeInfo>b__5_0() { }

	}


	internal virtual bool CanPopulate
	{
		internal get { } //Length: 3
	}

	public IDictionaryConverter`1() { }

	internal virtual void ConfigureJsonTypeInfo(JsonTypeInfo jsonTypeInfo, JsonSerializerOptions options) { }

	internal virtual bool get_CanPopulate() { }

	protected private virtual bool OnWriteResume(Utf8JsonWriter writer, TDictionary value, JsonSerializerOptions options, ref WriteStack state) { }

}

