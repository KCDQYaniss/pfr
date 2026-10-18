namespace ZLogger;

internal static class CustomFormatParser
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		[Nullable(new IL2CPP_TYPE_U1[] {0, 1, 0, 1, 2})]
		[TupleElementNames(new IL2CPP_TYPE_STRING[] {"name", "format"})]
		public static Func <>9__1_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		[NullableContext(1)]
		internal ValueTuple <GetOrAdd>b__1_0(string format) { }

	}

	[Nullable(new IL2CPP_TYPE_U1[] {1, 1, 0, 1, 2})]
	[TupleElementNames(new IL2CPP_TYPE_STRING[] {"name", "format"})]
	private static readonly ConcurrentDictionary alternateNameCache; //Field offset: 0x0

	private static CustomFormatParser() { }

	[NullableContext(1)]
	public static ValueTuple GetOrAdd(string format) { }

}

