namespace UnityEngine.ProBuilder;

[AddComponentMenu("//ProBuilder MeshFilter")]
[DisallowMultipleComponent]
[ExcludeFromObjectFactory]
[ExcludeFromPreset]
[ExecuteInEditMode]
[RequireComponent(typeof(MeshRenderer))]
public sealed class ProBuilderMesh : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__118_0; //Field offset: 0x8
		public static Func <>9__118_1; //Field offset: 0x10
		public static Func <>9__126_0; //Field offset: 0x18
		public static Func <>9__128_0; //Field offset: 0x20
		public static Func <>9__171_0; //Field offset: 0x28

		private static <>c() { }

		public <>c() { }

		internal Face <CopyFrom>b__171_0(Face x) { }

		internal int <get_indexCount>b__126_0(Face x) { }

		internal int <get_triangleCount>b__128_0(Face x) { }

		internal Vector2 <SetUVs>b__118_0(Vector4 x) { }

		internal Vector2 <SetUVs>b__118_1(Vector4 x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass174_0
	{
		public int i; //Field offset: 0x10

		public <>c__DisplayClass174_0() { }

		internal bool <GetUnusedTextureGroup>b__0(Face element) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass176_0
	{
		public int i; //Field offset: 0x10

		public <>c__DisplayClass176_0() { }

		internal bool <UnusedElementGroup>b__0(Face element) { }

	}

	[Flags]
	private enum CacheValidState
	{
		SharedVertex = 1,
		SharedTexture = 2,
	}

	public struct NonVersionedEditScope : IDisposable
	{
		private readonly ProBuilderMesh m_Mesh; //Field offset: 0x0
		private readonly ushort m_VersionIndex; //Field offset: 0x8
		private readonly ushort m_InstanceVersionIndex; //Field offset: 0xA

		public NonVersionedEditScope(ProBuilderMesh mesh) { }

		public override void Dispose() { }

	}

	internal const HideFlags k_MeshFilterHideFlags = 10; //Field offset: 0x0
	internal const ushort k_UnitializedVersionIndex = 0; //Field offset: 0x0
	public const uint maxVertexCount = 65535; //Field offset: 0x0
	internal const int k_MeshFormatVersionAutoUVScaleOffset = 2; //Field offset: 0x0
	[CompilerGenerated]
	private static Action meshWillBeDestroyed; //Field offset: 0x0
	internal const int k_MeshFormatVersion = 2; //Field offset: 0x0
	private const int k_UVChannelCount = 4; //Field offset: 0x0
	internal const int k_MeshFormatVersionSubmeshMaterialRefactor = 1; //Field offset: 0x0
	[CompilerGenerated]
	private static Action meshWasInitialized; //Field offset: 0x8
	[CompilerGenerated]
	private static Action componentWillBeDestroyed; //Field offset: 0x10
	[CompilerGenerated]
	private static Action componentHasBeenReset; //Field offset: 0x18
	[CompilerGenerated]
	private static Action elementSelectionChanged; //Field offset: 0x20
	private static HashSet s_CachedHashSet; //Field offset: 0x28
	[SerializeField]
	private int m_MeshFormatVersion; //Field offset: 0x20
	[FormerlySerializedAs("_quads")]
	[SerializeField]
	private Face[] m_Faces; //Field offset: 0x28
	[FormerlySerializedAs("_sharedIndices")]
	[FormerlySerializedAs("m_SharedVertexes")]
	[SerializeField]
	private SharedVertex[] m_SharedVertices; //Field offset: 0x30
	private CacheValidState m_CacheValid; //Field offset: 0x38
	private Dictionary m_SharedVertexLookup; //Field offset: 0x40
	[FormerlySerializedAs("_sharedIndicesUV")]
	[SerializeField]
	private SharedVertex[] m_SharedTextures; //Field offset: 0x48
	private Dictionary m_SharedTextureLookup; //Field offset: 0x50
	[FormerlySerializedAs("_vertices")]
	[SerializeField]
	private Vector3[] m_Positions; //Field offset: 0x58
	[FormerlySerializedAs("_uv")]
	[SerializeField]
	private Vector2[] m_Textures0; //Field offset: 0x60
	[FormerlySerializedAs("_uv3")]
	[SerializeField]
	private List m_Textures2; //Field offset: 0x68
	[FormerlySerializedAs("_uv4")]
	[SerializeField]
	private List m_Textures3; //Field offset: 0x70
	[FormerlySerializedAs("_tangents")]
	[SerializeField]
	private Vector4[] m_Tangents; //Field offset: 0x78
	private Vector3[] m_Normals; //Field offset: 0x80
	[FormerlySerializedAs("_colors")]
	[SerializeField]
	private Color[] m_Colors; //Field offset: 0x88
	[CompilerGenerated]
	private bool <userCollisions>k__BackingField; //Field offset: 0x90
	[FormerlySerializedAs("unwrapParameters")]
	[SerializeField]
	private UnwrapParameters m_UnwrapParameters; //Field offset: 0x98
	[FormerlySerializedAs("dontDestroyMeshOnDelete")]
	[SerializeField]
	private bool m_PreserveMeshAssetOnDestroy; //Field offset: 0xA0
	[SerializeField]
	internal string assetGuid; //Field offset: 0xA8
	[SerializeField]
	private Mesh m_Mesh; //Field offset: 0xB0
	private MeshRenderer m_MeshRenderer; //Field offset: 0xB8
	private MeshFilter m_MeshFilter; //Field offset: 0xC0
	[SerializeField]
	private ushort m_VersionIndex; //Field offset: 0xC8
	private ushort m_InstanceVersionIndex; //Field offset: 0xCA
	[SerializeField]
	private bool m_IsSelectable; //Field offset: 0xCC
	[SerializeField]
	private int[] m_SelectedFaces; //Field offset: 0xD0
	[SerializeField]
	private Edge[] m_SelectedEdges; //Field offset: 0xD8
	[SerializeField]
	private int[] m_SelectedVertices; //Field offset: 0xE0
	private bool m_SelectedCacheDirty; //Field offset: 0xE8
	private int m_SelectedSharedVerticesCount; //Field offset: 0xEC
	private int m_SelectedCoincidentVertexCount; //Field offset: 0xF0
	private HashSet m_SelectedSharedVertices; //Field offset: 0xF8
	private List m_SelectedCoincidentVertices; //Field offset: 0x100

	internal static event Action componentHasBeenReset
	{
		[CompilerGenerated]
		internal add { } //Length: 358
		[CompilerGenerated]
		internal remove { } //Length: 358
	}

	internal static event Action componentWillBeDestroyed
	{
		[CompilerGenerated]
		internal add { } //Length: 358
		[CompilerGenerated]
		internal remove { } //Length: 358
	}

	public static event Action elementSelectionChanged
	{
		[CompilerGenerated]
		 add { } //Length: 358
		[CompilerGenerated]
		 remove { } //Length: 358
	}

	internal static event Action meshWasInitialized
	{
		[CompilerGenerated]
		internal add { } //Length: 358
		[CompilerGenerated]
		internal remove { } //Length: 358
	}

	public static event Action meshWillBeDestroyed
	{
		[CompilerGenerated]
		 add { } //Length: 347
		[CompilerGenerated]
		 remove { } //Length: 347
	}

	public IList colors
	{
		 get { } //Length: 178
		 set { } //Length: 358
	}

	internal Color[] colorsInternal
	{
		internal get { } //Length: 8
		internal set { } //Length: 82
	}

	public int edgeCount
	{
		 get { } //Length: 169
	}

	public int faceCount
	{
		 get { } //Length: 18
	}

	public IList faces
	{
		 get { } //Length: 182
		 set { } //Length: 313
	}

	internal Face[] facesInternal
	{
		internal get { } //Length: 5
		internal set { } //Length: 82
	}

	internal MeshFilter filter
	{
		internal get { } //Length: 342
	}

	[Obsolete("InstanceID is not used to track mesh references as of 2023/04/12")]
	internal int id
	{
		internal get { } //Length: 98
	}

	public int indexCount
	{
		 get { } //Length: 363
	}

	internal Mesh mesh
	{
		internal get { } //Length: 559
		internal set { } //Length: 82
	}

	internal int meshFormatVersion
	{
		internal get { } //Length: 4
	}

	public MeshSyncState meshSyncState
	{
		 get { } //Length: 303
	}

	internal ushort nonSerializedVersionIndex
	{
		internal get { } //Length: 8
	}

	public IList normals
	{
		 get { } //Length: 178
	}

	internal Vector3[] normalsInternal
	{
		internal get { } //Length: 8
		internal set { } //Length: 82
	}

	public IList positions
	{
		 get { } //Length: 182
		 set { } //Length: 313
	}

	internal Vector3[] positionsInternal
	{
		internal get { } //Length: 5
		internal set { } //Length: 82
	}

	public bool preserveMeshAssetOnDestroy
	{
		 get { } //Length: 8
		 set { } //Length: 7
	}

	internal MeshRenderer renderer
	{
		internal get { } //Length: 163
	}

	public bool selectable
	{
		 get { } //Length: 8
		 set { } //Length: 7
	}

	internal int selectedCoincidentVertexCount
	{
		internal get { } //Length: 28
	}

	internal IEnumerable selectedCoincidentVertices
	{
		internal get { } //Length: 29
	}

	public int selectedEdgeCount
	{
		 get { } //Length: 29
	}

	public ReadOnlyCollection selectedEdges
	{
		 get { } //Length: 182
	}

	internal Edge[] selectedEdgesInternal
	{
		internal get { } //Length: 8
		internal set { } //Length: 82
	}

	public int selectedFaceCount
	{
		 get { } //Length: 29
	}

	public ReadOnlyCollection selectedFaceIndexes
	{
		 get { } //Length: 182
	}

	internal int[] selectedFaceIndicesInternal
	{
		internal get { } //Length: 8
		internal set { } //Length: 82
	}

	internal Face[] selectedFacesInternal
	{
		internal get { } //Length: 354
		internal set { } //Length: 386
	}

	internal int[] selectedIndexesInternal
	{
		internal get { } //Length: 8
		internal set { } //Length: 82
	}

	internal IEnumerable selectedSharedVertices
	{
		internal get { } //Length: 29
	}

	internal int selectedSharedVerticesCount
	{
		internal get { } //Length: 28
	}

	public int selectedVertexCount
	{
		 get { } //Length: 29
	}

	public ReadOnlyCollection selectedVertices
	{
		 get { } //Length: 182
	}

	internal Dictionary sharedTextureLookup
	{
		internal get { } //Length: 219
	}

	internal SharedVertex[] sharedTextures
	{
		internal get { } //Length: 5
		internal set { } //Length: 91
	}

	internal Dictionary sharedVertexLookup
	{
		internal get { } //Length: 223
	}

	public IList sharedVertices
	{
		 get { } //Length: 182
		 set { } //Length: 712
	}

	internal SharedVertex[] sharedVerticesInternal
	{
		internal get { } //Length: 76
		internal set { } //Length: 91
	}

	public IList tangents
	{
		 get { } //Length: 210
		 set { } //Length: 510
	}

	internal Vector4[] tangentsInternal
	{
		internal get { } //Length: 5
		internal set { } //Length: 82
	}

	public IList textures
	{
		 get { } //Length: 178
		 set { } //Length: 476
	}

	internal List textures2Internal
	{
		internal get { } //Length: 5
		internal set { } //Length: 82
	}

	internal List textures3Internal
	{
		internal get { } //Length: 5
		internal set { } //Length: 82
	}

	internal Vector2[] texturesInternal
	{
		internal get { } //Length: 5
		internal set { } //Length: 82
	}

	public int triangleCount
	{
		 get { } //Length: 380
	}

	public UnwrapParameters unwrapParameters
	{
		 get { } //Length: 8
		 set { } //Length: 82
	}

	public bool userCollisions
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 7
	}

	internal ushort versionIndex
	{
		internal get { } //Length: 8
	}

	public int vertexCount
	{
		 get { } //Length: 18
	}

	private static ProBuilderMesh() { }

	public ProBuilderMesh() { }

	[CompilerGenerated]
	private int <set_selectedFacesInternal>b__231_0(Face x) { }

	[CompilerGenerated]
	private int <SetSelectedFaces>b__245_0(Face x) { }

	[CompilerGenerated]
	private IEnumerable <SetSelectedFaces>b__246_0(int x) { }

	[CompilerGenerated]
	private IEnumerable <SetSelectedFaces>b__246_1(int x) { }

	[CompilerGenerated]
	internal static void add_componentHasBeenReset(Action value) { }

	[CompilerGenerated]
	internal static void add_componentWillBeDestroyed(Action value) { }

	[CompilerGenerated]
	public static void add_elementSelectionChanged(Action value) { }

	[CompilerGenerated]
	internal static void add_meshWasInitialized(Action value) { }

	[CompilerGenerated]
	public static void add_meshWillBeDestroyed(Action value) { }

	internal void AddSharedVertex(SharedVertex vertex) { }

	internal void AddToFaceSelection(int index) { }

	internal void AddToSharedVertex(int sharedVertexHandle, int vertex) { }

	private void Awake() { }

	private void CacheSelection() { }

	public void Clear() { }

	public void ClearSelection() { }

	public void CopyFrom(ProBuilderMesh other) { }

	public static ProBuilderMesh Create() { }

	public static ProBuilderMesh Create(IEnumerable positions, IEnumerable faces) { }

	public static ProBuilderMesh Create(IList vertices, IList faces, IList sharedVertices = null, IList sharedTextures = null, IList materials = null) { }

	internal static ProBuilderMesh CreateInstanceWithPoints(Vector3[] positions) { }

	internal void DestroyUnityMesh() { }

	internal void EnsureMeshColliderIsAssigned() { }

	internal void EnsureMeshFilterIsAssigned() { }

	private void FinalizeToMesh(bool usedInParticleSystem) { }

	internal void GeometryWithPoints(Vector3[] points) { }

	public IList get_colors() { }

	internal Color[] get_colorsInternal() { }

	public int get_edgeCount() { }

	public int get_faceCount() { }

	public IList get_faces() { }

	internal Face[] get_facesInternal() { }

	internal MeshFilter get_filter() { }

	internal int get_id() { }

	public int get_indexCount() { }

	internal Mesh get_mesh() { }

	internal int get_meshFormatVersion() { }

	public MeshSyncState get_meshSyncState() { }

	internal ushort get_nonSerializedVersionIndex() { }

	public IList get_normals() { }

	internal Vector3[] get_normalsInternal() { }

	public IList get_positions() { }

	internal Vector3[] get_positionsInternal() { }

	public bool get_preserveMeshAssetOnDestroy() { }

	internal MeshRenderer get_renderer() { }

	public bool get_selectable() { }

	internal int get_selectedCoincidentVertexCount() { }

	internal IEnumerable get_selectedCoincidentVertices() { }

	public int get_selectedEdgeCount() { }

	public ReadOnlyCollection get_selectedEdges() { }

	internal Edge[] get_selectedEdgesInternal() { }

	public int get_selectedFaceCount() { }

	public ReadOnlyCollection get_selectedFaceIndexes() { }

	internal int[] get_selectedFaceIndicesInternal() { }

	internal Face[] get_selectedFacesInternal() { }

	internal int[] get_selectedIndexesInternal() { }

	internal IEnumerable get_selectedSharedVertices() { }

	internal int get_selectedSharedVerticesCount() { }

	public int get_selectedVertexCount() { }

	public ReadOnlyCollection get_selectedVertices() { }

	internal Dictionary get_sharedTextureLookup() { }

	internal SharedVertex[] get_sharedTextures() { }

	internal Dictionary get_sharedVertexLookup() { }

	public IList get_sharedVertices() { }

	internal SharedVertex[] get_sharedVerticesInternal() { }

	public IList get_tangents() { }

	internal Vector4[] get_tangentsInternal() { }

	public IList get_textures() { }

	internal List get_textures2Internal() { }

	internal List get_textures3Internal() { }

	internal Vector2[] get_texturesInternal() { }

	public int get_triangleCount() { }

	public UnwrapParameters get_unwrapParameters() { }

	[CompilerGenerated]
	public bool get_userCollisions() { }

	internal ushort get_versionIndex() { }

	public int get_vertexCount() { }

	internal Edge GetActiveEdge() { }

	internal Face GetActiveFace() { }

	internal int GetActiveVertex() { }

	public List GetCoincidentVertices(IEnumerable vertices) { }

	public void GetCoincidentVertices(IEnumerable faces, List coincident) { }

	public void GetCoincidentVertices(IEnumerable edges, List coincident) { }

	public void GetCoincidentVertices(IEnumerable vertices, List coincident) { }

	public void GetCoincidentVertices(int vertex, List coincident) { }

	public Color[] GetColors() { }

	public Vector3[] GetNormals() { }

	public Face[] GetSelectedFaces() { }

	internal int GetSharedVertexHandle(int vertex) { }

	internal HashSet GetSharedVertexHandles(IEnumerable vertices) { }

	public Vector4[] GetTangents() { }

	internal int GetUnusedTextureGroup(int i = 1) { }

	internal ReadOnlyCollection GetUVs(int channel) { }

	public void GetUVs(int channel, List uvs) { }

	public Vertex[] GetVertices(IList indexes = null) { }

	internal void GetVerticesInList(IList vertices) { }

	public bool HasArrays(MeshArrays channels) { }

	private void IncrementVersionIndex() { }

	internal void InvalidateCaches() { }

	internal void InvalidateFaces() { }

	internal void InvalidateSharedTextureLookup() { }

	internal void InvalidateSharedVertexLookup() { }

	private static bool IsValidTextureGroup(int group) { }

	public void MakeUnique() { }

	private void OnDestroy() { }

	internal void Rebuild() { }

	public void RebuildWithPositionsAndFaces(IEnumerable vertices, IEnumerable faces) { }

	public void Refresh(RefreshMask mask = 31) { }

	private void RefreshColors() { }

	private void RefreshNormals() { }

	private void RefreshTangents() { }

	public void RefreshUV(IEnumerable facesToRefresh) { }

	[CompilerGenerated]
	internal static void remove_componentHasBeenReset(Action value) { }

	[CompilerGenerated]
	internal static void remove_componentWillBeDestroyed(Action value) { }

	[CompilerGenerated]
	public static void remove_elementSelectionChanged(Action value) { }

	[CompilerGenerated]
	internal static void remove_meshWasInitialized(Action value) { }

	[CompilerGenerated]
	public static void remove_meshWillBeDestroyed(Action value) { }

	internal void RemoveFromFaceSelectionAtIndex(int index) { }

	private void Reset() { }

	public void set_colors(IList value) { }

	internal void set_colorsInternal(Color[] value) { }

	public void set_faces(IList value) { }

	internal void set_facesInternal(Face[] value) { }

	internal void set_mesh(Mesh value) { }

	internal void set_normalsInternal(Vector3[] value) { }

	public void set_positions(IList value) { }

	internal void set_positionsInternal(Vector3[] value) { }

	public void set_preserveMeshAssetOnDestroy(bool value) { }

	public void set_selectable(bool value) { }

	internal void set_selectedEdgesInternal(Edge[] value) { }

	internal void set_selectedFaceIndicesInternal(int[] value) { }

	internal void set_selectedFacesInternal(Face[] value) { }

	internal void set_selectedIndexesInternal(int[] value) { }

	internal void set_sharedTextures(SharedVertex[] value) { }

	public void set_sharedVertices(IList value) { }

	internal void set_sharedVerticesInternal(SharedVertex[] value) { }

	public void set_tangents(IList value) { }

	internal void set_tangentsInternal(Vector4[] value) { }

	public void set_textures(IList value) { }

	internal void set_textures2Internal(List value) { }

	internal void set_textures3Internal(List value) { }

	internal void set_texturesInternal(Vector2[] value) { }

	public void set_unwrapParameters(UnwrapParameters value) { }

	[CompilerGenerated]
	public void set_userCollisions(bool value) { }

	public void SetFaceColor(Face face, Color color) { }

	internal void SetGroupUV(AutoUnwrapSettings settings, int group) { }

	public void SetMaterial(IEnumerable faces, Material material) { }

	public void SetSelectedEdges(IEnumerable edges) { }

	public void SetSelectedFaces(IEnumerable selected) { }

	internal void SetSelectedFaces(IEnumerable selected) { }

	public void SetSelectedVertices(IEnumerable vertices) { }

	internal void SetSharedTextures(IEnumerable indexes) { }

	internal void SetSharedVertices(IEnumerable indexes) { }

	internal void SetTexturesCoincident(IEnumerable vertices) { }

	public void SetUVs(int channel, List uvs) { }

	public void SetVertices(IList vertices, bool applyMesh = false) { }

	public void SetVerticesCoincident(IEnumerable vertices) { }

	public void ToMesh(MeshTopology preferredTopology = 0) { }

	internal int UnusedElementGroup(int i = 1) { }

}

