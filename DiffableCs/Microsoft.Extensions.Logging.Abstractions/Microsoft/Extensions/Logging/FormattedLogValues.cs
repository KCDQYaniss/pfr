namespace Microsoft.Extensions.Logging;

[DefaultMember("Item")]
[IsReadOnly]
[Nullable(0)]
[NullableContext(2)]
internal struct FormattedLogValues : IReadOnlyList, IEnumerable, IEnumerable, IReadOnlyCollection
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__9_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal LogValuesFormatter <.ctor>b__9_0(string f) { }

	}

	[CompilerGenerated]
	private sealed class <GetEnumerator>d__14 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private KeyValuePair <>2__current; //Field offset: 0x18
		public FormattedLogValues <>4__this; //Field offset: 0x28
		private int <i>5__2; //Field offset: 0x40

		private override KeyValuePair System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 11
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 74
		}

		[DebuggerHidden]
		public <GetEnumerator>d__14(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override KeyValuePair System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<System.String,System.Object>>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	private static int s_count; //Field offset: 0x0
	private static readonly ConcurrentDictionary s_formatters; //Field offset: 0x8
	private readonly LogValuesFormatter _formatter; //Field offset: 0x0
	private readonly object[] _values; //Field offset: 0x8
	private readonly string _originalMessage; //Field offset: 0x10

	public override int Count
	{
		 get { } //Length: 87
	}

	[Nullable(new IL2CPP_TYPE_U1[] {0, 1, 2})]
	public override KeyValuePair Item
	{
		 get { } //Length: 710
	}

	private static FormattedLogValues() { }

	public FormattedLogValues(string format, object[] values) { }

	public override int get_Count() { }

	public override KeyValuePair get_Item(int index) { }

	[IteratorStateMachine(typeof(<GetEnumerator>d__14))]
	public override IEnumerator GetEnumerator() { }

	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	[NullableContext(1)]
	public virtual string ToString() { }

}

