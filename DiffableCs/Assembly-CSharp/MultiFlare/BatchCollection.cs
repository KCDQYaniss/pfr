namespace MultiFlare;

[DefaultMember("Item")]
public class BatchCollection : IEnumerable, IEnumerable
{
	[CompilerGenerated]
	private sealed class <GetEnumerator>d__10 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private FlareBatch <>2__current; //Field offset: 0x18
		public BatchCollection <>4__this; //Field offset: 0x20
		private Enumerator <>7__wrap1; //Field offset: 0x28

		private override FlareBatch System.Collections.Generic.IEnumerator<MultiFlare.FlareBatch>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		[DebuggerHidden]
		public <GetEnumerator>d__10(int <>1__state) { }

		private void <>m__Finally1() { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override FlareBatch System.Collections.Generic.IEnumerator<MultiFlare.FlareBatch>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	private readonly Dictionary _batches; //Field offset: 0x10
	private readonly List _defaultBatches; //Field offset: 0x18
	private readonly List _instantBatches; //Field offset: 0x20

	public IReadOnlyList DefaultBatches
	{
		 get { } //Length: 5
	}

	public IReadOnlyList InstantBatches
	{
		 get { } //Length: 5
	}

	public FlareBatch Item
	{
		 get { } //Length: 86
	}

	public BatchCollection() { }

	public void Clear() { }

	public IReadOnlyList get_DefaultBatches() { }

	public IReadOnlyList get_InstantBatches() { }

	public FlareBatch get_Item(FlareType flareType) { }

	[IteratorStateMachine(typeof(<GetEnumerator>d__10))]
	public override IEnumerator GetEnumerator() { }

	public void Register(FlareType flareType, FlareBatch batch) { }

	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

