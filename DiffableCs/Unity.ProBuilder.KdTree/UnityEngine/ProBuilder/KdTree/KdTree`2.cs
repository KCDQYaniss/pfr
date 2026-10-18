namespace UnityEngine.ProBuilder.KdTree;

internal class KdTree`2 : IKdTree, IEnumerable, IEnumerable
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass33_0
	{
		public Stack left; //Field offset: 0x0
		public Stack right; //Field offset: 0x0

		public <>c__DisplayClass33_0() { }

		internal void <GetEnumerator>b__0(KdTreeNode node) { }

		internal void <GetEnumerator>b__1(KdTreeNode node) { }

	}

	[CompilerGenerated]
	private sealed class <GetEnumerator>d__33 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x0
		private KdTreeNode <>2__current; //Field offset: 0x0
		public KdTree <>4__this; //Field offset: 0x0
		private <>c__DisplayClass33_0 <>8__1; //Field offset: 0x0
		private Action <addLeft>5__2; //Field offset: 0x0
		private Action <addRight>5__3; //Field offset: 0x0

		private override KdTreeNode System.Collections.Generic.IEnumerator<UnityEngine.ProBuilder.KdTree.KdTreeNode<TKey,TValue>>.Current
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
		public <GetEnumerator>d__33(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override KdTreeNode System.Collections.Generic.IEnumerator<UnityEngine.ProBuilder.KdTree.KdTreeNode<TKey,TValue>>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	private int dimensions; //Field offset: 0x0
	private ITypeMath typeMath; //Field offset: 0x0
	private KdTreeNode root; //Field offset: 0x0
	[CompilerGenerated]
	private AddDuplicateBehavior <AddDuplicateBehavior>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private int <Count>k__BackingField; //Field offset: 0x0

	public private AddDuplicateBehavior AddDuplicateBehavior
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public private override int Count
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public KdTree`2(int dimensions, ITypeMath typeMath) { }

	public KdTree`2(int dimensions, ITypeMath typeMath, AddDuplicateBehavior addDuplicateBehavior) { }

	public override bool Add(TKey[] point, TValue value) { }

	private void AddNearestNeighbours(KdTreeNode node, TKey[] target, HyperRect rect, int depth, NearestNeighbourList nearestNeighbours, TKey maxSearchRadiusSquared) { }

	private void AddNodesBalanced(KdTreeNode[] nodes, int byDimension, int fromIndex, int toIndex) { }

	private void AddNodesToList(KdTreeNode node, List nodes) { }

	private void AddNodeToStringBuilder(KdTreeNode node, StringBuilder sb, int depth) { }

	public void Balance() { }

	public override void Clear() { }

	public override TKey[] FindValue(TValue value) { }

	public override TValue FindValueAt(TKey[] point) { }

	[CompilerGenerated]
	public AddDuplicateBehavior get_AddDuplicateBehavior() { }

	[CompilerGenerated]
	public override int get_Count() { }

	[IteratorStateMachine(typeof(<GetEnumerator>d__33))]
	public override IEnumerator GetEnumerator() { }

	public override KdTreeNode[] GetNearestNeighbours(TKey[] point, int count) { }

	public static KdTree LoadFromFile(string filename) { }

	public override KdTreeNode[] RadialSearch(TKey[] center, TKey radius, int count) { }

	private void ReadChildNodes(KdTreeNode removedNode) { }

	public override void RemoveAt(TKey[] point) { }

	private void RemoveChildNodes(KdTreeNode node) { }

	public void SaveToFile(string filename) { }

	[CompilerGenerated]
	private void set_AddDuplicateBehavior(AddDuplicateBehavior value) { }

	[CompilerGenerated]
	private void set_Count(int value) { }

	private void SortNodesArray(KdTreeNode[] nodes, int byDimension, int fromIndex, int toIndex) { }

	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	public virtual string ToString() { }

	public override bool TryFindValue(TValue value, out TKey[] point) { }

	public override bool TryFindValueAt(TKey[] point, out TValue value) { }

}

