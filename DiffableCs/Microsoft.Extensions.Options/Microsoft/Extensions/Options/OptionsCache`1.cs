namespace Microsoft.Extensions.Options;

[Nullable(0)]
[NullableContext(1)]
public class OptionsCache`1 : IOptionsMonitorCache
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__2_0; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal Lazy <GetOrAdd>b__2_0(string name, Func createOptions) { }

	}

	[CompilerGenerated]
	private sealed class <>c__3`1
	{
		public static readonly <>c__3 <>9; //Field offset: 0x0
		[TupleElementNames(new IL2CPP_TYPE_STRING[] {"createOptions", "factoryArgument"})]
		public static Func <>9__3_0; //Field offset: 0x0

		private static <>c__3`1() { }

		public <>c__3`1() { }

		internal Lazy <GetOrAdd>b__3_0(string name, ValueTuple arg) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass3_0`1
	{
		public Func localCreateOptions; //Field offset: 0x0
		public string localName; //Field offset: 0x0
		public TArg localFactoryArgument; //Field offset: 0x0

		public <>c__DisplayClass3_0`1() { }

		internal TOptions <GetOrAdd>b__1() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass3_1`1
	{
		[TupleElementNames(new IL2CPP_TYPE_STRING[] {"createOptions", "factoryArgument"})]
		public ValueTuple arg; //Field offset: 0x0
		public string name; //Field offset: 0x0

		public <>c__DisplayClass3_1`1() { }

		internal TOptions <GetOrAdd>b__2() { }

	}

	private readonly ConcurrentDictionary _cache; //Field offset: 0x0

	public OptionsCache`1() { }

	public override TOptions GetOrAdd(string name, Func createOptions) { }

	internal TOptions GetOrAdd(string name, Func createOptions, TArg factoryArgument) { }

	internal bool TryGetValue(string name, out TOptions options) { }

	[NullableContext(2)]
	public override bool TryRemove(string name) { }

}

