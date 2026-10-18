namespace Koenigz.PerfectCulling.EFT;

public class BVH`1
{
	[CompilerGenerated]
	private sealed class <EnumerateOverlappingLeafNodes>d__16 : IEnumerable, IEnumerable, IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x0
		private T <>2__current; //Field offset: 0x0
		private int <>l__initialThreadId; //Field offset: 0x0
		public BVH <>4__this; //Field offset: 0x0
		private Bounds bounds; //Field offset: 0x0
		public Bounds <>3__bounds; //Field offset: 0x0

		private override T System.Collections.Generic.IEnumerator<T>.Current
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
		public <EnumerateOverlappingLeafNodes>d__16(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }

		[DebuggerHidden]
		private override T System.Collections.Generic.IEnumerator<T>.get_Current() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	private struct Node
	{
		public int Child1; //Field offset: 0x0
		public int Child2; //Field offset: 0x0
		public int Height; //Field offset: 0x0
		public int Parent; //Field offset: 0x0
		public int Next; //Field offset: 0x0
		public Bounds AABB; //Field offset: 0x0
		public T Object; //Field offset: 0x0

		public bool IsLeaf
		{
			 get { } //Length: 7
		}

		public bool get_IsLeaf() { }

	}

	private const int EMPTY = -1; //Field offset: 0x0
	private const float MARGIN = 0; //Field offset: 0x0
	private int _root; //Field offset: 0x0
	private Node[] _nodes; //Field offset: 0x0
	private int _nodeCount; //Field offset: 0x0
	private int _nodeCapacity; //Field offset: 0x0
	private int _freeList; //Field offset: 0x0
	private int _inCnt; //Field offset: 0x0
	private readonly Stack _growableStack; //Field offset: 0x0

	public int NodeCapacity
	{
		 get { } //Length: 4
	}

	public int NodeCount
	{
		 get { } //Length: 4
	}

	public BVH`1() { }

	public int Add(T obj) { }

	private int AllocateNode() { }

	private int Balance(int iA) { }

	private int ComputeHeight(int nodeId) { }

	[IteratorStateMachine(typeof(<EnumerateOverlappingLeafNodes>d__16))]
	public IEnumerable EnumerateOverlappingLeafNodes(Bounds bounds) { }

	private void FreeNode(int key) { }

	public int get_NodeCapacity() { }

	public int get_NodeCount() { }

	public void Initialize(int capacity) { }

	private void InsertLeaf(int leaf) { }

	public int OverlapNoAlloc(Bounds bounds, T[] outputArray) { }

	public T Query(Vector3 point) { }

	public T QueryNearest(Vector3 point, float radius) { }

	private void ValidateMetrics(int index) { }

	private void ValidateStructure(int index) { }

}

