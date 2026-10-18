namespace UnityEngine.ProBuilder;

[DefaultMember("Item")]
public sealed class SharedVertex : ICollection, IEnumerable, IEnumerable
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__26_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal bool <SortedRemoveAndShift>b__26_0(KeyValuePair x) { }

	}

	[FormerlySerializedAs("array")]
	[FormerlySerializedAs("m_Vertexes")]
	[SerializeField]
	private int[] m_Vertices; //Field offset: 0x10

	internal int[] arrayInternal
	{
		internal get { } //Length: 5
	}

	public override int Count
	{
		 get { } //Length: 26
	}

	public override bool IsReadOnly
	{
		 get { } //Length: 23
	}

	public int Item
	{
		 get { } //Length: 43
		 set { } //Length: 43
	}

	public SharedVertex(IEnumerable indexes) { }

	public SharedVertex(SharedVertex sharedVertex) { }

	public override void Add(int item) { }

	public override void Clear() { }

	public override bool Contains(int item) { }

	public override void CopyTo(int[] array, int arrayIndex) { }

	internal int[] get_arrayInternal() { }

	public override int get_Count() { }

	public override bool get_IsReadOnly() { }

	public int get_Item(int i) { }

	public override IEnumerator GetEnumerator() { }

	public static void GetSharedVertexLookup(IList sharedVertices, Dictionary lookup) { }

	public static SharedVertex[] GetSharedVerticesWithPositions(IList positions) { }

	public override bool Remove(int item) { }

	internal static SharedVertex[] RemoveAndShift(Dictionary lookup, IEnumerable remove) { }

	public void set_Item(int i, int value) { }

	internal static void SetCoincident(ref Dictionary lookup, IEnumerable vertices) { }

	internal void ShiftIndexes(int offset) { }

	internal static SharedVertex[] SortedRemoveAndShift(Dictionary lookup, List remove) { }

	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	internal static SharedVertex[] ToSharedVertices(IEnumerable lookup) { }

	private static SharedVertex[] ToSharedVertices(List list) { }

	public virtual string ToString() { }

}

