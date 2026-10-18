//Type is in global namespace

[DefaultMember("Item")]
internal class CircularArray`1 : IEnumerable, IEnumerable
{
	[CompilerGenerated]
	private sealed class <GetEnumerator>d__18 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x0
		private T <>2__current; //Field offset: 0x0
		public CircularArray <>4__this; //Field offset: 0x0
		private int <i>5__2; //Field offset: 0x0

		private override T System.Collections.Generic.IEnumerator<T>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 172
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 171
		}

		[DebuggerHidden]
		public <GetEnumerator>d__18(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override T System.Collections.Generic.IEnumerator<T>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	private T[] _data; //Field offset: 0x0
	private int _zeroIndex; //Field offset: 0x0
	[CompilerGenerated]
	private int <Length>k__BackingField; //Field offset: 0x0

	public T Item
	{
		 get { } //Length: 304
		 set { } //Length: 466
	}

	public private int Length
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public CircularArray`1(int length) { }

	public void Add(T value) { }

	public void Clear() { }

	public T get_Item(int i) { }

	[CompilerGenerated]
	public int get_Length() { }

	[IteratorStateMachine(typeof(<GetEnumerator>d__18))]
	public override IEnumerator GetEnumerator() { }

	public T GetFromNewest(int i) { }

	public T GetFromOldest(int i) { }

	private int GetIndex(int i) { }

	private int GetReverseIndex(int i) { }

	public void set_Item(int i, T value) { }

	[CompilerGenerated]
	private void set_Length(int value) { }

	public void SetFromNewest(int i, T value) { }

	public void SetFromOldest(int i, T value) { }

	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

