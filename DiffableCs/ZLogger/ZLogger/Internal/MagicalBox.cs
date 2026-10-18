namespace ZLogger.Internal;

[Nullable(0)]
[NullableContext(1)]
internal struct MagicalBox
{
	[Nullable(0)]
	[NullableContext(2)]
	private static class ReaderCache
	{
		[NullableContext(0)]
		private sealed class Handlers
		{
			[Nullable(new IL2CPP_TYPE_U1[] {0, 1, 2})]
			public readonly IntPtr Utf8JsonWriter; //Field offset: 0x10
			[Nullable(new IL2CPP_TYPE_U1[] {0, 2})]
			public readonly IntPtr StringHandler; //Field offset: 0x18
			[Nullable(new IL2CPP_TYPE_U1[] {0, 0, 1, 2})]
			public readonly IntPtr Utf8StringWriter; //Field offset: 0x20
			[Nullable(new IL2CPP_TYPE_U1[] {0, 2})]
			public readonly IntPtr ReadBoxed; //Field offset: 0x28

			public Handlers(IntPtr utf8JsonWriter, IntPtr stringHandler, IntPtr utf8StringWriter, IntPtr readBoxed) { }

		}

		[NullableContext(0)]
		private static class IsRegistered`1
		{
			public static bool Value; //Field offset: 0x0

		}

		[Nullable(1)]
		private static readonly ConcurrentDictionary cache; //Field offset: 0x0

		private static ReaderCache() { }

		[NullableContext(1)]
		private static bool DateTimeOffsetJsonWrite(MagicalBox box, int offset, Utf8JsonWriter writer, JsonSerializerOptions options) { }

		private static bool EnumJsonWrite(MagicalBox box, int offset, Utf8JsonWriter writer, JsonSerializerOptions options) { }

		private static bool EnumStringWrite(MagicalBox box, int offset, ref DefaultInterpolatedStringHandler handler, int alignment, string format) { }

		private static bool EnumUtf8Write(MagicalBox box, int offset, ref Utf8StringWriter writer, int alignment, string format) { }

		[NullableContext(1)]
		private static bool GuidJsonWrite(MagicalBox box, int offset, Utf8JsonWriter writer, JsonSerializerOptions options) { }

		private static bool JsonSerialize(MagicalBox box, int offset, Utf8JsonWriter writer, JsonSerializerOptions options) { }

		[NullableContext(1)]
		public static object ReadBoxed(Type type, MagicalBox box, int offset) { }

		private static object ReadBoxed(MagicalBox box, int offset) { }

		public static void Register() { }

		private static bool StringAppendFormatted(MagicalBox box, int offset, ref DefaultInterpolatedStringHandler handler, int alignment, string format) { }

		[NullableContext(1)]
		public static bool TryReadTo(Type type, MagicalBox box, int offset, Utf8JsonWriter jsonWriter, JsonSerializerOptions options) { }

		[NullableContext(1)]
		public static bool TryReadTo(Type type, MagicalBox box, int offset, ref DefaultInterpolatedStringHandler handler, int alignment, string format) { }

		[NullableContext(1)]
		public static bool TryReadTo(Type type, MagicalBox box, int offset, ref Utf8StringWriter writer, int alignment, string format) { }

		private static bool Utf8AppendFormatted(MagicalBox box, int offset, ref Utf8StringWriter writer, int alignment, string format) { }

	}

	private byte[] storage; //Field offset: 0x0
	private int written; //Field offset: 0x8

	public int Written
	{
		 get { } //Length: 4
	}

	public MagicalBox(byte[] storage) { }

	public int get_Written() { }

	[NullableContext(2)]
	private static bool IsSupportedType() { }

	private T Read(int offset) { }

	public object ReadBoxed(Type type, int offset) { }

	private static void ThrowArgumentOutOfRangeException() { }

	public bool TryRead(int offset, out T value) { }

	public bool TryReadTo(Type type, int offset, int alignment, string format, ref Utf8StringWriter handler) { }

	public bool TryReadTo(Type type, int offset, int alignment, string format, ref DefaultInterpolatedStringHandler handler) { }

	public bool TryReadTo(Type type, int offset, Utf8JsonWriter jsonWriter, JsonSerializerOptions options) { }

	public bool TryWrite(T value, out int offset) { }

}

