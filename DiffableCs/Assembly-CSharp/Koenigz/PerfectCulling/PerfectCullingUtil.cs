namespace Koenigz.PerfectCulling;

public static class PerfectCullingUtil
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__24_0; //Field offset: 0x8
		public static Predicate <>9__28_1; //Field offset: 0x10
		public static Comparison <>9__43_0; //Field offset: 0x18

		private static <>c() { }

		public <>c() { }

		internal int <CloneLODGroup>b__43_0(LOD x, LOD y) { }

		internal Vector3 <ConvertFromProbuilder>b__24_0(Vertex o) { }

		internal bool <CreateBakeGroupsForRenderersEFT>b__28_1(LODGroup lodGroup) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass24_0
	{
		public List indices; //Field offset: 0x10

		public <>c__DisplayClass24_0() { }

		internal void <ConvertFromProbuilder>b__1(Face o) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass28_0
	{
		public Func filter; //Field offset: 0x10

		public <>c__DisplayClass28_0() { }

		internal bool <CreateBakeGroupsForRenderersEFT>b__0(Renderer rend) { }

	}

	public const string CULLING_DATA_PATH = "Culling_Data"; //Field offset: 0x0
	public static readonly Type[] SHARED_OCCLUDER_IGNORE_TYPES; //Field offset: 0x0
	private const string SHADOW_NAME_MARKER = "SHADOW"; //Field offset: 0x0
	private const string STENCIL_NAME_MARKER = "STENCIL"; //Field offset: 0x0
	public static readonly Type[] IGNORE_TYPES; //Field offset: 0x8
	private static readonly string[] transparentShaderKeywordHints; //Field offset: 0x10

	private static PerfectCullingUtil() { }

	public static void CheckRendererTypes(IEnumerable rends) { }

	internal static List CloneLODGroup(LODGroup original, Material opaque, Material transparent, GameObject root = null) { }

	public static MeshRenderer CloneRenderer(MeshRenderer renderer, Material replacementMaterial) { }

	public static bool ContainsComponentInHierarchy(Transform obj, Type[] types, Transform maxTop = null) { }

	public static T ContainsComponentOnParentInHierarchy(Transform obj) { }

	public static bool ContainsComponentOnParentInHierarchyEx(Transform obj, Transform maxTop = null) { }

	public static bool ContainsTransparentMaterial(Material[] sharedMaterials) { }

	public static MeshFilter ConvertFromProbuilder(GameObject targetObject, ProBuilderMesh pbMesh) { }

	public static HashSet CreateBakeGroupsForRenderersEFT(List inputRenderers, Func filter, Transform sourceGroup) { }

	public static void CreateCullingDataFolder(GameObject cullingVolume) { }

	public static GameObject CreateLightProxy(PerfectCullingBakeGroup light, Material replacementMaterial, Color c, Transform root = null) { }

	public static GameObject CreateLightProxy(Light light, Material replacementMaterial, Color c, Transform root = null) { }

	public static string FormatSeconds(double seconds) { }

	public static uint FromBytes(byte[] data) { }

	public static uint FromBytes(byte[] data, uint seed) { }

	public static ulong FromBytes64(byte[] data) { }

	public static uint FromString(string str) { }

	public static ulong FromString64(string str) { }

	public static void GenerateBakeVisuals(PerfectCullingCrossSceneGroup crossGroup) { }

	public static List GenerateOffsets(int numOffsetsByAxis, Vector3 cellSize) { }

	public static List GetByTypeInActiveScene() { }

	public static string GetEditorCullingDataFolder(Scene scene) { }

	public static Dictionary GetFirstLODs(PerfectCullingCrossSceneGroup group) { }

	public static Vector3 GetTransformWorldScale(Transform tr) { }

	public static long HashString(string str) { }

	public static int HashStringInt32(string str) { }

	public static bool IsDecalRenderer(Renderer renderer) { }

	public static bool IsMaterialTransparent(Material mat) { }

	public static bool IsShadowRenderer(Renderer rend) { }

	public static bool IsSharedOccluderHierarchy(Transform t) { }

	public static bool IsValidRendererType(Renderer r) { }

	public static Material[] MakeReplacementMaterials(int num, Material replacement) { }

	public static NativeMeshRenderers[] PrepareNativeMeshRendererData(List inputRenderers, Dictionary groupMappingDict) { }

	public static void SetActiveScene(GameObject obj) { }

	public static bool ShouldProcessLODGroup(LODGroup lodGroup) { }

	public static bool ShouldProcessRenderer(Renderer rend) { }

	public static Vector3 Snap(Vector3 p, float s) { }

	internal static void TransformMeshRenderer(Renderer rend, Material opaque, Material transparent, GameObject root = null, ICollection outLst = null) { }

	public static LODGroup TryGetParentLODGroup(Transform source) { }

}

