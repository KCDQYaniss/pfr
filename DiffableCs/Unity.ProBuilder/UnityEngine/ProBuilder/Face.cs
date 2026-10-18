namespace UnityEngine.ProBuilder;

[DefaultMember("Item")]
public sealed class Face
{
	[FormerlySerializedAs("_indices")]
	[SerializeField]
	private int[] m_Indexes; //Field offset: 0x10
	[FormerlySerializedAs("_smoothingGroup")]
	[SerializeField]
	private int m_SmoothingGroup; //Field offset: 0x18
	[FormerlySerializedAs("_uv")]
	[SerializeField]
	private AutoUnwrapSettings m_Uv; //Field offset: 0x1C
	[FormerlySerializedAs("_mat")]
	[SerializeField]
	private Material m_Material; //Field offset: 0x40
	[SerializeField]
	private int m_SubmeshIndex; //Field offset: 0x48
	[FormerlySerializedAs("manualUV")]
	[SerializeField]
	private bool m_ManualUV; //Field offset: 0x4C
	[SerializeField]
	internal int elementGroup; //Field offset: 0x50
	[SerializeField]
	private int m_TextureGroup; //Field offset: 0x54
	private int[] m_DistinctIndexes; //Field offset: 0x58
	private Edge[] m_Edges; //Field offset: 0x60

	public ReadOnlyCollection distinctIndexes
	{
		 get { } //Length: 183
	}

	internal int[] distinctIndexesInternal
	{
		internal get { } //Length: 359
	}

	public ReadOnlyCollection edges
	{
		 get { } //Length: 198
	}

	internal Edge[] edgesInternal
	{
		internal get { } //Length: 19
	}

	public ReadOnlyCollection indexes
	{
		 get { } //Length: 182
	}

	internal int[] indexesInternal
	{
		internal get { } //Length: 5
		internal set { } //Length: 289
	}

	public int Item
	{
		 get { } //Length: 43
	}

	public bool manualUV
	{
		 get { } //Length: 5
		 set { } //Length: 4
	}

	[Obsolete("Face.material is deprecated. Please use submeshIndex instead.")]
	public Material material
	{
		 get { } //Length: 5
		 set { } //Length: 82
	}

	public int smoothingGroup
	{
		 get { } //Length: 4
		 set { } //Length: 4
	}

	public int submeshIndex
	{
		 get { } //Length: 4
		 set { } //Length: 4
	}

	public int textureGroup
	{
		 get { } //Length: 4
		 set { } //Length: 4
	}

	public AutoUnwrapSettings uv
	{
		 get { } //Length: 19
		 set { } //Length: 16
	}

	public Face(Face other) { }

	internal Face(IEnumerable triangles, int submeshIndex, AutoUnwrapSettings u, int smoothing, int texture, int element, bool manualUVs) { }

	[Obsolete("Face.material is deprecated. Please use \"submeshIndex\" instead.")]
	internal Face(int[] triangles, Material m, AutoUnwrapSettings u, int smoothing, int texture, int element, bool manualUVs) { }

	public Face(IEnumerable indices) { }

	public Face() { }

	private int[] CacheDistinctIndexes() { }

	private Edge[] CacheEdges() { }

	public bool Contains(int a, int b, int c) { }

	public void CopyFrom(Face other) { }

	public ReadOnlyCollection get_distinctIndexes() { }

	internal int[] get_distinctIndexesInternal() { }

	public ReadOnlyCollection get_edges() { }

	internal Edge[] get_edgesInternal() { }

	public ReadOnlyCollection get_indexes() { }

	internal int[] get_indexesInternal() { }

	public int get_Item(int i) { }

	public bool get_manualUV() { }

	public Material get_material() { }

	public int get_smoothingGroup() { }

	public int get_submeshIndex() { }

	public int get_textureGroup() { }

	public AutoUnwrapSettings get_uv() { }

	internal static void GetDistinctIndices(IEnumerable faces, List indices) { }

	internal static void GetIndices(IEnumerable faces, List indices) { }

	internal void InvalidateCache() { }

	public bool IsQuad() { }

	public void Reverse() { }

	internal void set_indexesInternal(int[] value) { }

	public void set_manualUV(bool value) { }

	public void set_material(Material value) { }

	public void set_smoothingGroup(int value) { }

	public void set_submeshIndex(int value) { }

	public void set_textureGroup(int value) { }

	public void set_uv(AutoUnwrapSettings value) { }

	public void SetIndexes(IEnumerable indices) { }

	public void ShiftIndexes(int offset) { }

	public void ShiftIndexesToZero() { }

	private int SmallestIndexValue() { }

	public int[] ToQuad() { }

	public virtual string ToString() { }

	internal bool TryGetNextEdge(Edge source, int index, ref Edge nextEdge, ref int nextIndex) { }

}

