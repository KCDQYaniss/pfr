//Type is in global namespace

public class MetaXRAcousticGeometry : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__93_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal void <.cctor>b__104_0() { }

		internal string <GatherGeometryInternal>b__93_0(Transform t) { }

	}

	[CompilerGenerated]
	private sealed class <LoadGeometryAsync>d__99 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public MetaXRAcousticGeometry <>4__this; //Field offset: 0x20
		public string relativePath; //Field offset: 0x28
		private string <path>5__2; //Field offset: 0x30
		private float <startTime>5__3; //Field offset: 0x38
		private byte[] <bytes>5__4; //Field offset: 0x40
		private Task <readTask>5__5; //Field offset: 0x48
		private Exception <error>5__6; //Field offset: 0x50

		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
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
		public <LoadGeometryAsync>d__99(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	private struct <ReadFileAsync>d__100 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public string path; //Field offset: 0x20
		public CancellationToken token; //Field offset: 0x28
		private FileStream <fs>5__2; //Field offset: 0x30
		private long <length>5__3; //Field offset: 0x38
		private byte[] <buffer>5__4; //Field offset: 0x40
		private int <offset>5__5; //Field offset: 0x48
		private TaskAwaiter <>u__1; //Field offset: 0x50

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private class ColliderGatherer : IGatherer, ITransformVisitor
	{
		[CompilerGenerated]
		private sealed class <>c
		{
			public static readonly <>c <>9; //Field offset: 0x0
			public static Func <>9__0_0; //Field offset: 0x8
			public static Converter <>9__0_1; //Field offset: 0x10

			private static <>c() { }

			public <>c() { }

			internal bool <visit>b__0_0(MetaXRAcousticMaterial x) { }

			internal MetaXRAcousticMaterial <visit>b__0_1(MetaXRAcousticMaterial x) { }

		}

		private List meshes; //Field offset: 0x10
		private List terrains; //Field offset: 0x18

		public override List Meshes
		{
			 get { } //Length: 5
		}

		public override List Terrains
		{
			 get { } //Length: 5
		}

		public ColliderGatherer() { }

		public override List get_Meshes() { }

		public override List get_Terrains() { }

		public override object visit(Transform transform, object parentData) { }

	}

	private interface IGatherer : ITransformVisitor
	{

		public List Meshes
		{
			 get { } //Length: 0
		}

		public List Terrains
		{
			 get { } //Length: 0
		}

		public List get_Meshes() { }

		public List get_Terrains() { }

	}

	public interface ITransformVisitor
	{

		public object visit(Transform transform, object userData) { }

	}

	private class MeshGatherer : IGatherer, ITransformVisitor
	{
		[CompilerGenerated]
		private sealed class <>c
		{
			public static readonly <>c <>9; //Field offset: 0x0
			public static Func <>9__1_0; //Field offset: 0x8
			public static Converter <>9__1_1; //Field offset: 0x10

			private static <>c() { }

			public <>c() { }

			internal bool <visit>b__1_0(MetaXRAcousticMaterial x) { }

			internal MetaXRAcousticMaterial <visit>b__1_1(MetaXRAcousticMaterial x) { }

		}

		private List meshes; //Field offset: 0x10
		private List terrains; //Field offset: 0x18
		internal int ignoredMeshCount; //Field offset: 0x20
		internal bool ignoreStatic; //Field offset: 0x24

		public override List Meshes
		{
			 get { } //Length: 5
		}

		public override List Terrains
		{
			 get { } //Length: 5
		}

		internal MeshGatherer(bool ignoreStatic) { }

		public override List get_Meshes() { }

		public override List get_Terrains() { }

		public override object visit(Transform transform, object parentData) { }

	}

	private struct MeshMaterial
	{
		internal Mesh mesh; //Field offset: 0x0
		internal Transform meshTransform; //Field offset: 0x8
		internal IMaterialDataProvider[] meshMaterials; //Field offset: 0x10

	}

	private struct TerrainMaterial
	{
		internal Terrain terrain; //Field offset: 0x0
		internal IMaterialDataProvider[] terrainMaterials; //Field offset: 0x8
		internal Mesh[] treePrototypeMeshes; //Field offset: 0x10

	}

	private const long MAX_FILE_SIZE = 104857600; //Field offset: 0x0
	internal const string FILE_EXTENSION = "xrageo"; //Field offset: 0x0
	internal static bool AUTO_VALIDATE; //Field offset: 0x0
	internal const int Success = 0; //Field offset: 0x0
	internal static int EnabledGeometryCount; //Field offset: 0x4
	private static readonly object CounterLock; //Field offset: 0x8
	[CompilerGenerated]
	private static Action OnAnyGeometryEnabled; //Field offset: 0x10
	private static int terrainDecimation; //Field offset: 0x18
	public bool enabledGeometryStaleCheck; //Field offset: 0x20
	public bool enabledDrawGizmos; //Field offset: 0x21
	internal bool LoadGeometryProcessCompleted; //Field offset: 0x22
	[FormerlySerializedAs("relativeFilePath_")]
	[SerializeField]
	private string relativeFilePath; //Field offset: 0x28
	private string _cachedGoName; //Field offset: 0x30
	protected string _cachedFilePath; //Field offset: 0x38
	private bool _hasIncrementedCount; //Field offset: 0x40
	[SerializeField]
	internal bool FileEnabled; //Field offset: 0x41
	[SerializeField]
	internal bool IncludeChildMeshes; //Field offset: 0x42
	[SerializeField]
	internal MeshFlags Flags; //Field offset: 0x44
	[SerializeField]
	private float maxSimplifyError; //Field offset: 0x48
	[SerializeField]
	private float minDiffractionEdgeAngle; //Field offset: 0x4C
	[SerializeField]
	private float minDiffractionEdgeLength; //Field offset: 0x50
	[SerializeField]
	private float flagLength; //Field offset: 0x54
	[SerializeField]
	private int lodSelection; //Field offset: 0x58
	[SerializeField]
	private bool useColliders; //Field offset: 0x5C
	[SerializeField]
	private bool overrideExcludeTagsEnabled; //Field offset: 0x5D
	[SerializeField]
	private string[] overrideExcludeTags; //Field offset: 0x60
	internal IntPtr geometryHandle; //Field offset: 0x68
	private bool isLoaded; //Field offset: 0x70
	private int vertexCount; //Field offset: 0x74
	[SerializeField]
	private Color[] materialColors; //Field offset: 0x78
	private CancellationTokenSource _loadTokenSource; //Field offset: 0x80

	internal static event Action OnAnyGeometryEnabled
	{
		[CompilerGenerated]
		internal add { } //Length: 335
		[CompilerGenerated]
		internal remove { } //Length: 335
	}

	internal string AbsoluteFilePath
	{
		internal get { } //Length: 268
		internal set { } //Length: 706
	}

	private string CachedGoName
	{
		private get { } //Length: 66
	}

	internal bool EnableDiffraction
	{
		internal get { } //Length: 8
		internal set { } //Length: 25
	}

	internal bool EnableSimplification
	{
		internal get { } //Length: 7
		internal set { } //Length: 25
	}

	internal string[] ExcludeTags
	{
		internal get { } //Length: 45
	}

	internal float FlagLength
	{
		internal get { } //Length: 6
		internal set { } //Length: 6
	}

	internal bool IsLoaded
	{
		internal get { } //Length: 5
	}

	internal int LodSelection
	{
		internal get { } //Length: 4
		internal set { } //Length: 4
	}

	internal float MaxSimplifyError
	{
		internal get { } //Length: 6
		internal set { } //Length: 126
	}

	internal float MinDiffractionEdgeAngle
	{
		internal get { } //Length: 6
		internal set { } //Length: 106
	}

	internal float MinDiffractionEdgeLength
	{
		internal get { } //Length: 6
		internal set { } //Length: 126
	}

	internal string[] OverrideExcludeTags
	{
		internal get { } //Length: 5
		internal set { } //Length: 82
	}

	internal bool OverrideExcludeTagsEnabled
	{
		internal get { } //Length: 5
		internal set { } //Length: 4
	}

	internal string RelativeFilePath
	{
		internal get { } //Length: 5
	}

	internal bool UseColliders
	{
		internal get { } //Length: 5
		internal set { } //Length: 4
	}

	internal int VertexCount
	{
		internal get { } //Length: 4
	}

	private static MetaXRAcousticGeometry() { }

	public MetaXRAcousticGeometry() { }

	[CompilerGenerated]
	internal static void add_OnAnyGeometryEnabled(Action value) { }

	private void Awake() { }

	public void CancelLoad() { }

	internal bool CreatePropagationGeometry() { }

	private void DecrementEnabledGeometryCount() { }

	internal bool DestroyInternal() { }

	private bool DestroyPropagationGeometry() { }

	private bool GatherGeometryInternal(IntPtr geometryHandle, GameObject meshObject, Matrix4x4 worldToLocal, bool ignoreStatic, out int ignoredMeshCount) { }

	internal bool GatherGeometryRuntime() { }

	internal string get_AbsoluteFilePath() { }

	private string get_CachedGoName() { }

	internal bool get_EnableDiffraction() { }

	internal bool get_EnableSimplification() { }

	internal string[] get_ExcludeTags() { }

	internal float get_FlagLength() { }

	internal bool get_IsLoaded() { }

	internal int get_LodSelection() { }

	internal float get_MaxSimplifyError() { }

	internal float get_MinDiffractionEdgeAngle() { }

	internal float get_MinDiffractionEdgeLength() { }

	internal string[] get_OverrideExcludeTags() { }

	internal bool get_OverrideExcludeTagsEnabled() { }

	internal string get_RelativeFilePath() { }

	internal bool get_UseColliders() { }

	internal int get_VertexCount() { }

	private void IncrementEnabledGeometryCount() { }

	private void LateUpdate() { }

	[IteratorStateMachine(typeof(<LoadGeometryAsync>d__99))]
	public IEnumerator LoadGeometryAsync(string relativePath) { }

	internal bool LoadGeometryFromBytes(byte[] bytes, string sourcePath) { }

	private void OnDestroy() { }

	private void OnDisable() { }

	private void OnEnable() { }

	internal bool ReadFile() { }

	[AsyncStateMachine(typeof(<ReadFileAsync>d__100))]
	private Task ReadFileAsync(string path, CancellationToken token) { }

	[CompilerGenerated]
	internal static void remove_OnAnyGeometryEnabled(Action value) { }

	internal void set_AbsoluteFilePath(string value) { }

	internal void set_EnableDiffraction(bool value) { }

	internal void set_EnableSimplification(bool value) { }

	internal void set_FlagLength(float value) { }

	internal void set_LodSelection(int value) { }

	internal void set_MaxSimplifyError(float value) { }

	internal void set_MinDiffractionEdgeAngle(float value) { }

	internal void set_MinDiffractionEdgeLength(float value) { }

	internal void set_OverrideExcludeTags(string[] value) { }

	internal void set_OverrideExcludeTagsEnabled(bool value) { }

	internal void set_UseColliders(bool value) { }

	internal bool StartInternal() { }

	private static void traverseMeshHierarchy(GameObject obj, bool includeChildren, string[] excludeTags, bool parentWasExcluded, int lodSelection, ITransformVisitor visitor, object parentData = null) { }

	private static void updateCountsForMesh(ref int totalVertexCount, ref uint totalIndexCount, ref int totalFaceCount, ref int totalMaterialCount, Mesh mesh) { }

	private static bool uploadMeshFilter(List tempVertices, List tempIndices, MeshGroup[] groups, float[] vertices, int[] indices, ref int vertexOffset, ref int indexOffset, ref int groupOffset, Mesh mesh, IMaterialDataProvider[] materials, Matrix4x4 matrix) { }

}

