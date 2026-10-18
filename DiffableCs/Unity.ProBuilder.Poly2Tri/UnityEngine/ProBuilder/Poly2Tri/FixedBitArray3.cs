namespace UnityEngine.ProBuilder.Poly2Tri;

[DefaultMember("Item")]
internal struct FixedBitArray3 : IEnumerable, IEnumerable
{
	[CompilerGenerated]
	private sealed class <Enumerate>d__10 : IEnumerable, IEnumerable, IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private bool <>2__current; //Field offset: 0x14
		private int <>l__initialThreadId; //Field offset: 0x18
		public FixedBitArray3 <>4__this; //Field offset: 0x1C
		public FixedBitArray3 <>3__<>4__this; //Field offset: 0x1F
		private int <i>5__2; //Field offset: 0x24

		private override bool System.Collections.Generic.IEnumerator<System.Boolean>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 73
		}

		[DebuggerHidden]
		public <Enumerate>d__10(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.Generic.IEnumerable<System.Boolean>.GetEnumerator() { }

		[DebuggerHidden]
		private override bool System.Collections.Generic.IEnumerator<System.Boolean>.get_Current() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	public bool _0; //Field offset: 0x0
	public bool _1; //Field offset: 0x1
	public bool _2; //Field offset: 0x2

	public bool Item
	{
		 get { } //Length: 110
		 set { } //Length: 110
	}

	public void Clear() { }

	public void Clear(bool value) { }

	public bool Contains(bool value) { }

	[IteratorStateMachine(typeof(<Enumerate>d__10))]
	private IEnumerable Enumerate() { }

	public bool get_Item(int index) { }

	public override IEnumerator GetEnumerator() { }

	public int IndexOf(bool value) { }

	public void set_Item(int index, bool value) { }

	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

