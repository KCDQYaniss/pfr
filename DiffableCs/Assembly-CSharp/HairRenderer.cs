//Type is in global namespace

public class HairRenderer : MonoBehaviour
{
	internal enum DebugMode
	{
		DBG_NONE = 0,
		DBG_OCCLUSION = 1,
		DBG_GRAYMASK = 2,
		DBG_MASKEDALBEDO = 3,
		DBG_SPECULAR = 4,
		DBG_LIGHTING = 5,
		DBG_FLOW = 6,
	}

	private class MeshSorter
	{
		private class Patch
		{
			public MeshSorter owner; //Field offset: 0x10
			public HashSet indices; //Field offset: 0x18
			public HashSet triangles; //Field offset: 0x20

			public Patch(MeshSorter owner, Triangle t) { }

			public bool AddTriangle(Triangle t) { }

			public bool Merge(Patch p) { }

		}

		private struct SortablePatch
		{
			public Vector3 centroid; //Field offset: 0x0
			public float layer; //Field offset: 0xC
			public int[] indices; //Field offset: 0x10

			public SortablePatch(int[] i, Vector3 c, float l) { }

		}

		private class Triangle
		{
			public int i0; //Field offset: 0x10
			public int i1; //Field offset: 0x14
			public int i2; //Field offset: 0x18

			public Triangle(int i0, int i1, int i2) { }

		}

		private Vector3[] vertices; //Field offset: 0x10
		private Vector2[] uvs; //Field offset: 0x18
		private Color[] colors; //Field offset: 0x20
		private SortablePatch[] sortablePatches; //Field offset: 0x28
		private uint[] sortingList; //Field offset: 0x30
		public Color[] staticPatchColors; //Field offset: 0x38
		public int[] staticPatchIndices; //Field offset: 0x40

		public MeshSorter(Vector3[] vertices, Vector2[] uvs, Color[] colors, int[] indices, Transform space, Transform[] spheres) { }

		public void BuildNormalizedPatches() { }

		private void SetDebugColor(int patchCount, int patchIdx, int offset, int[] indices) { }

		public void SortIndices(Vector3 eye, int[] indices, float distScale) { }

	}

	internal enum Mode
	{
		Original = 0,
		StaticHeightBased = 1,
		DynamicRadialDistance = 2,
	}

	private static readonly int _srcBlend; //Field offset: 0x0
	private static readonly int _dstBlend; //Field offset: 0x4
	private static readonly int _zWrite; //Field offset: 0x8
	private static readonly int _zTest; //Field offset: 0xC
	private static readonly int _cull; //Field offset: 0x10
	private static readonly int _cutoff; //Field offset: 0x14
	public Renderer sourceRenderer; //Field offset: 0x20
	public Mode mode; //Field offset: 0x28
	public bool useOpaquePass; //Field offset: 0x2C
	public float opaqueAlphaRef; //Field offset: 0x30
	public bool frontWriteDepth; //Field offset: 0x34
	public float frontBackAlphaRef; //Field offset: 0x38
	public DebugMode debugMode; //Field offset: 0x3C
	[HideInInspector]
	public Transform[] headSpheres; //Field offset: 0x40
	[HideInInspector]
	public Transform headShell; //Field offset: 0x48
	[HideInInspector]
	public float sortDistanceScale; //Field offset: 0x50
	private Mesh m_sourceMesh; //Field offset: 0x58
	private Mesh m_sortedMesh; //Field offset: 0x60
	private int[] m_sortedIndices; //Field offset: 0x68
	private MeshFilter m_meshFilter; //Field offset: 0x70
	private MeshSorter m_meshSorter; //Field offset: 0x78
	private Material m_materialOpaque; //Field offset: 0x80
	private Material m_materialBack; //Field offset: 0x88
	private Material m_materialFront; //Field offset: 0x90

	private static HairRenderer() { }

	public HairRenderer() { }

	private Material AddChild(Material m) { }

	private void Awake() { }

	private void CreateMaterials() { }

	private void CreateMeshData() { }

	private void LateUpdate() { }

	private void OnValidate() { }

	private void SelectMesh() { }

	private void UpdateKeywords() { }

	private void UpdateMaterials() { }

}

