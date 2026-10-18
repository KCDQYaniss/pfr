namespace System.Collections.Generic;

[DebuggerDisplay("Count = {Count}")]
[DebuggerTypeProxy(typeof(ICollectionDebugView`1))]
public class SortedSet`1 : ISet, ICollection, IEnumerable, IEnumerable, ICollection, IReadOnlyCollection, ISerializable, IDeserializationCallback
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass52_0
	{
		public int index; //Field offset: 0x0
		public int count; //Field offset: 0x0
		public T[] array; //Field offset: 0x0

		public <>c__DisplayClass52_0() { }

		internal bool <CopyTo>b__0(Node node) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass53_0
	{
		public int index; //Field offset: 0x0
		public object[] objects; //Field offset: 0x0

		public <>c__DisplayClass53_0() { }

		internal bool <System.Collections.ICollection.CopyTo>b__0(Node node) { }

	}

	internal struct Enumerator : IEnumerator, IDisposable, IEnumerator, ISerializable, IDeserializationCallback
	{
		private static readonly Node s_dummyNode; //Field offset: 0x0
		private SortedSet _tree; //Field offset: 0x0
		private int _version; //Field offset: 0x0
		private Stack _stack; //Field offset: 0x0
		private Node _current; //Field offset: 0x0
		private bool _reverse; //Field offset: 0x0

		public override T Current
		{
			 get { } //Length: 89
		}

		internal bool NotStartedOrEnded
		{
			internal get { } //Length: 9
		}

		private override object System.Collections.IEnumerator.Current
		{
			private get { } //Length: 164
		}

		private static Enumerator() { }

		internal Enumerator(SortedSet set) { }

		internal Enumerator(SortedSet set, bool reverse) { }

		public override void Dispose() { }

		public override T get_Current() { }

		internal bool get_NotStartedOrEnded() { }

		private void Initialize() { }

		public override bool MoveNext() { }

		internal void Reset() { }

		private override object System.Collections.IEnumerator.get_Current() { }

		private override void System.Collections.IEnumerator.Reset() { }

		private override void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }

		private override void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	}

	public sealed class Node
	{
		[CompilerGenerated]
		private T <Item>k__BackingField; //Field offset: 0x0
		[CompilerGenerated]
		private Node <Left>k__BackingField; //Field offset: 0x0
		[CompilerGenerated]
		private Node <Right>k__BackingField; //Field offset: 0x0
		[CompilerGenerated]
		private NodeColor <Color>k__BackingField; //Field offset: 0x0

		public NodeColor Color
		{
			[CompilerGenerated]
			 get { } //Length: 5
			[CompilerGenerated]
			 set { } //Length: 4
		}

		public bool Is2Node
		{
			 get { } //Length: 180
		}

		public bool Is4Node
		{
			 get { } //Length: 152
		}

		public bool IsBlack
		{
			 get { } //Length: 8
		}

		public bool IsRed
		{
			 get { } //Length: 8
		}

		public T Item
		{
			[CompilerGenerated]
			 get { } //Length: 11
			[CompilerGenerated]
			 set { } //Length: 82
		}

		public Node Left
		{
			[CompilerGenerated]
			 get { } //Length: 5
			[CompilerGenerated]
			 set { } //Length: 82
		}

		public Node Right
		{
			[CompilerGenerated]
			 get { } //Length: 5
			[CompilerGenerated]
			 set { } //Length: 82
		}

		public Node(T item, NodeColor color) { }

		public void ColorBlack() { }

		public void ColorRed() { }

		[CompilerGenerated]
		public NodeColor get_Color() { }

		public bool get_Is2Node() { }

		public bool get_Is4Node() { }

		public bool get_IsBlack() { }

		public bool get_IsRed() { }

		[CompilerGenerated]
		public T get_Item() { }

		[CompilerGenerated]
		public Node get_Left() { }

		[CompilerGenerated]
		public Node get_Right() { }

		public TreeRotation GetRotation(Node current, Node sibling) { }

		public Node GetSibling(Node node) { }

		public static bool IsNonNullRed(Node node) { }

		public static bool IsNullOrBlack(Node node) { }

		public void Merge2Nodes() { }

		public void ReplaceChild(Node child, Node newChild) { }

		public Node Rotate(TreeRotation rotation) { }

		public Node RotateLeft() { }

		public Node RotateLeftRight() { }

		public Node RotateRight() { }

		public Node RotateRightLeft() { }

		[CompilerGenerated]
		public void set_Color(NodeColor value) { }

		[CompilerGenerated]
		public void set_Item(T value) { }

		[CompilerGenerated]
		public void set_Left(Node value) { }

		[CompilerGenerated]
		public void set_Right(Node value) { }

		public void Split4Node() { }

	}

	private const string VersionName = "Version"; //Field offset: 0x0
	private const string LowerBoundActiveName = "lBoundActive"; //Field offset: 0x0
	private const string MaxName = "Max"; //Field offset: 0x0
	private const string MinName = "Min"; //Field offset: 0x0
	private const string EnumVersionName = "EnumVersion"; //Field offset: 0x0
	private const string ReverseName = "Reverse"; //Field offset: 0x0
	private const string EnumStartName = "EnumStarted"; //Field offset: 0x0
	private const string NodeValueName = "Item"; //Field offset: 0x0
	private const string TreeName = "Tree"; //Field offset: 0x0
	internal const int StackAllocThreshold = 100; //Field offset: 0x0
	private const string ItemsName = "Items"; //Field offset: 0x0
	private const string CountName = "Count"; //Field offset: 0x0
	private const string ComparerName = "Comparer"; //Field offset: 0x0
	private const string UpperBoundActiveName = "uBoundActive"; //Field offset: 0x0
	private SerializationInfo siInfo; //Field offset: 0x0
	private object _syncRoot; //Field offset: 0x0
	private int version; //Field offset: 0x0
	private int count; //Field offset: 0x0
	private IComparer comparer; //Field offset: 0x0
	private Node root; //Field offset: 0x0

	public override int Count
	{
		 get { } //Length: 37
	}

	public T Min
	{
		 get { } //Length: 48
	}

	internal override T MinInternal
	{
		internal get { } //Length: 50
	}

	private override bool System.Collections.Generic.ICollection<T>.IsReadOnly
	{
		private get { } //Length: 3
	}

	private override bool System.Collections.ICollection.IsSynchronized
	{
		private get { } //Length: 3
	}

	private override object System.Collections.ICollection.SyncRoot
	{
		private get { } //Length: 170
	}

	public SortedSet`1() { }

	public SortedSet`1(IComparer comparer) { }

	protected SortedSet`1(SerializationInfo info, StreamingContext context) { }

	public override bool Add(T item) { }

	internal override bool AddIfNotPresent(T item) { }

	public override void Clear() { }

	public override bool Contains(T item) { }

	public void CopyTo(T[] array, int index, int count) { }

	public override void CopyTo(T[] array, int index) { }

	public void CopyTo(T[] array) { }

	internal override bool DoRemove(T item) { }

	internal override Node FindNode(T item) { }

	public override int get_Count() { }

	public T get_Min() { }

	internal override T get_MinInternal() { }

	public Enumerator GetEnumerator() { }

	protected override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	internal override bool InOrderTreeWalk(TreeWalkPredicate action) { }

	private void InsertionBalance(Node current, ref Node parent, Node grandParent, Node greatGrandParent) { }

	internal override bool IsWithinRange(T item) { }

	private static int Log2(int value) { }

	protected override void OnDeserialization(object sender) { }

	public override bool Remove(T item) { }

	private void ReplaceChildOrRoot(Node parent, Node child, Node newChild) { }

	private void ReplaceNode(Node match, Node parentOfMatch, Node successor, Node parentOfSuccessor) { }

	private override void System.Collections.Generic.ICollection<T>.Add(T item) { }

	private override bool System.Collections.Generic.ICollection<T>.get_IsReadOnly() { }

	private override IEnumerator System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }

	private override void System.Collections.ICollection.CopyTo(Array array, int index) { }

	private override bool System.Collections.ICollection.get_IsSynchronized() { }

	private override object System.Collections.ICollection.get_SyncRoot() { }

	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	private override void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }

	private override void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	internal void UpdateVersion() { }

	internal override void VersionCheck() { }

}

