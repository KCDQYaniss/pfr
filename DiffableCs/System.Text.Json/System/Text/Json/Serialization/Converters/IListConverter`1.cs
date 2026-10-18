namespace System.Text.Json.Serialization.Converters;

internal sealed class IListConverter`1 : JsonCollectionConverter
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

	public IListConverter`1() { }

	internal virtual void ConfigureJsonTypeInfo(JsonTypeInfo jsonTypeInfo, JsonSerializerOptions options) { }

	internal virtual bool get_CanPopulate() { }

	protected virtual bool OnWriteResume(Utf8JsonWriter writer, TCollection value, JsonSerializerOptions options, ref WriteStack state) { }

}

