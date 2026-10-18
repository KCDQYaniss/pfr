//Type is in global namespace

public class QuadTree`2
{
	[CompilerGenerated]
	private sealed class <GetNodesInside>d__12 : IEnumerable, IEnumerable, IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x0
		private TNodeData <>2__current; //Field offset: 0x0
		private int <>l__initialThreadId; //Field offset: 0x0
		public QuadTree <>4__this; //Field offset: 0x0
		private Rect bounds; //Field offset: 0x0
		public Rect <>3__bounds; //Field offset: 0x0
		private IEnumerator <>7__wrap1; //Field offset: 0x0

		private override TNodeData System.Collections.Generic.IEnumerator<TNodeData>.Current
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
		public <GetNodesInside>d__12(int <>1__state) { }

		private void <>m__Finally1() { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.Generic.IEnumerable<TNodeData>.GetEnumerator() { }

		[DebuggerHidden]
		private override TNodeData System.Collections.Generic.IEnumerator<TNodeData>.get_Current() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	private Rect bounds; //Field offset: 0x0
	private float sizeLimit; //Field offset: 0x0
	protected Quadrant root; //Field offset: 0x0
	protected IDictionary table; //Field offset: 0x0

	public Rect Bounds
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	public float SizeLimit
	{
		 get { } //Length: 6
		 set { } //Length: 25
	}

	public QuadTree`2() { }

	protected override Quadrant CreateQuadrant(Quadrant parent, Rect bounds) { }

	public Rect get_Bounds() { }

	public float get_SizeLimit() { }

	private IEnumerable GetNodes(Rect bounds) { }

	[IteratorStateMachine(typeof(<GetNodesInside>d__12))]
	public IEnumerable GetNodesInside(Rect bounds) { }

	public bool HasNodesInside(Rect bounds) { }

	public void Insert(TNodeData nodeData, Rect bounds) { }

	private void ReIndex() { }

	public bool Remove(TNodeData node) { }

	public void set_Bounds(Rect value) { }

	public void set_SizeLimit(float value) { }

}

