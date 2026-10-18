namespace UnityEngine;

[NativeHeader("Modules/Terrain/Public/TerrainDataScriptingInterface.h")]
[NativeHeader("TerrainScriptingClasses.h")]
[UsedByNativeCode]
public sealed class TerrainData : Object
{
	private enum BoundaryValueType
	{
		MaxHeightmapRes = 0,
		MinDetailResPerPatch = 1,
		MaxDetailResPerPatch = 2,
		MaxDetailPatchCount = 3,
		MaxCoveragePerRes = 4,
		MinAlphamapRes = 5,
		MaxAlphamapRes = 6,
		MinBaseMapRes = 7,
		MaxBaseMapRes = 8,
	}

	private const string k_ScriptingInterfaceName = "TerrainDataScriptingInterface"; //Field offset: 0x0
	private const string k_ScriptingInterfacePrefix = "TerrainDataScriptingInterface::"; //Field offset: 0x0
	private const string k_HeightmapPrefix = "GetHeightmap()."; //Field offset: 0x0
	private const string k_DetailDatabasePrefix = "GetDetailDatabase()."; //Field offset: 0x0
	private const string k_TreeDatabasePrefix = "GetTreeDatabase()."; //Field offset: 0x0
	private const string k_SplatDatabasePrefix = "GetSplatDatabase()."; //Field offset: 0x0
	internal static readonly int k_MaximumResolution; //Field offset: 0x0
	internal static readonly int k_MinimumDetailResolutionPerPatch; //Field offset: 0x4
	internal static readonly int k_MaximumDetailResolutionPerPatch; //Field offset: 0x8
	internal static readonly int k_MaximumDetailPatchCount; //Field offset: 0xC
	internal static readonly int k_MinimumAlphamapResolution; //Field offset: 0x10
	internal static readonly int k_MaximumAlphamapResolution; //Field offset: 0x14
	internal static readonly int k_MinimumBaseMapResolution; //Field offset: 0x18
	internal static readonly int k_MaximumBaseMapResolution; //Field offset: 0x1C

	public int alphamapHeight
	{
		 get { } //Length: 78
	}

	public int alphamapLayers
	{
		[NativeName("GetSplatDatabase().GetSplatCount")]
		 get { } //Length: 78
	}

	public int alphamapResolution
	{
		 get { } //Length: 78
		 set { } //Length: 615
	}

	public int alphamapTextureCount
	{
		[NativeName("GetSplatDatabase().GetAlphaTextureCount")]
		 get { } //Length: 78
	}

	public Texture2D[] alphamapTextures
	{
		 get { } //Length: 388
	}

	public int alphamapWidth
	{
		 get { } //Length: 78
	}

	public int baseMapResolution
	{
		 set { } //Length: 615
	}

	public Bounds bounds
	{
		[NativeName("GetHeightmap().CalculateBounds")]
		 get { } //Length: 108
	}

	public DetailPrototype[] detailPrototypes
	{
		[FreeFunction("TerrainDataScriptingInterface::GetDetailPrototypes", HasExplicitThis = True)]
		 get { } //Length: 78
		[FreeFunction("TerrainDataScriptingInterface::SetDetailPrototypes", HasExplicitThis = True, ThrowsException = True)]
		 set { } //Length: 93
	}

	public int detailResolution
	{
		[NativeName("GetDetailDatabase().GetResolution")]
		 get { } //Length: 78
	}

	public int heightmapResolution
	{
		 get { } //Length: 78
		 set { } //Length: 392
	}

	public Vector3 heightmapScale
	{
		[NativeName("GetHeightmap().GetScale")]
		 get { } //Length: 104
	}

	public RenderTexture heightmapTexture
	{
		[NativeName("GetHeightmap().GetHeightmapTexture")]
		 get { } //Length: 78
	}

	private int Internal_alphamapResolution
	{
		[NativeName("GetSplatDatabase().GetAlphamapResolution")]
		private get { } //Length: 78
		[NativeName("GetSplatDatabase().SetAlphamapResolution")]
		private set { } //Length: 91
	}

	private int Internal_baseMapResolution
	{
		[NativeName("GetSplatDatabase().SetBaseMapResolution")]
		private set { } //Length: 91
	}

	private int internalHeightmapResolution
	{
		[NativeName("GetHeightmap().GetResolution")]
		private get { } //Length: 78
		[NativeName("GetHeightmap().SetResolution")]
		private set { } //Length: 91
	}

	public Vector3 size
	{
		[NativeName("GetHeightmap().GetSize")]
		 get { } //Length: 104
		[NativeName("GetHeightmap().SetSize")]
		 set { } //Length: 93
	}

	public TerrainLayer[] terrainLayers
	{
		[FreeFunction("TerrainDataScriptingInterface::SetTerrainLayers", HasExplicitThis = True)]
		 set { } //Length: 93
	}

	public TreeInstance[] treeInstances
	{
		 get { } //Length: 78
		 set { } //Length: 96
	}

	public TreePrototype[] treePrototypes
	{
		[FreeFunction("TerrainDataScriptingInterface::GetTreePrototypes", HasExplicitThis = True)]
		 get { } //Length: 78
		[FreeFunction("TerrainDataScriptingInterface::SetTreePrototypes", HasExplicitThis = True, ThrowsException = True)]
		 set { } //Length: 93
	}

	internal Terrain[] users
	{
		internal get { } //Length: 78
	}

	private static TerrainData() { }

	public TerrainData() { }

	public int get_alphamapHeight() { }

	[NativeName("GetSplatDatabase().GetSplatCount")]
	public int get_alphamapLayers() { }

	public int get_alphamapResolution() { }

	[NativeName("GetSplatDatabase().GetAlphaTextureCount")]
	public int get_alphamapTextureCount() { }

	public Texture2D[] get_alphamapTextures() { }

	public int get_alphamapWidth() { }

	[NativeName("GetHeightmap().CalculateBounds")]
	public Bounds get_bounds() { }

	private void get_bounds_Injected(out Bounds ret) { }

	[FreeFunction("TerrainDataScriptingInterface::GetDetailPrototypes", HasExplicitThis = True)]
	public DetailPrototype[] get_detailPrototypes() { }

	[NativeName("GetDetailDatabase().GetResolution")]
	public int get_detailResolution() { }

	public int get_heightmapResolution() { }

	[NativeName("GetHeightmap().GetScale")]
	public Vector3 get_heightmapScale() { }

	private void get_heightmapScale_Injected(out Vector3 ret) { }

	[NativeName("GetHeightmap().GetHeightmapTexture")]
	public RenderTexture get_heightmapTexture() { }

	[NativeName("GetSplatDatabase().GetAlphamapResolution")]
	private int get_Internal_alphamapResolution() { }

	[NativeName("GetHeightmap().GetResolution")]
	private int get_internalHeightmapResolution() { }

	[NativeName("GetHeightmap().GetSize")]
	public Vector3 get_size() { }

	private void get_size_Injected(out Vector3 ret) { }

	public TreeInstance[] get_treeInstances() { }

	[FreeFunction("TerrainDataScriptingInterface::GetTreePrototypes", HasExplicitThis = True)]
	public TreePrototype[] get_treePrototypes() { }

	internal Terrain[] get_users() { }

	[NativeName("GetSplatDatabase().GetAlphamapResolution")]
	[RequiredByNativeCode]
	internal float GetAlphamapResolutionInternal() { }

	public float[,,] GetAlphamaps(int x, int y, int width, int height) { }

	[NativeName("GetSplatDatabase().GetAlphaTexture")]
	public Texture2D GetAlphamapTexture(int index) { }

	[StaticAccessor("TerrainDataScriptingInterface", StaticAccessorType::DoubleColon (2))]
	[ThreadSafe]
	private static int GetBoundaryValue(BoundaryValueType type) { }

	[FreeFunction("TerrainDataScriptingInterface::GetDetailLayer", HasExplicitThis = True)]
	public int[,] GetDetailLayer(int xBase, int yBase, int width, int height, int layer) { }

	public float[,] GetHeights(int xBase, int yBase, int width, int height) { }

	[FreeFunction("TerrainDataScriptingInterface::Create")]
	private static void Internal_Create(TerrainData terrainData) { }

	[FreeFunction("TerrainDataScriptingInterface::GetAlphamaps", HasExplicitThis = True)]
	private float[,,] Internal_GetAlphamaps(int x, int y, int width, int height) { }

	[FreeFunction("TerrainDataScriptingInterface::GetHeights", HasExplicitThis = True)]
	private float[,] Internal_GetHeights(int xBase, int yBase, int width, int height) { }

	[NativeName("GetTreeDatabase().GetInstances")]
	private TreeInstance[] Internal_GetTreeInstances() { }

	[FreeFunction("TerrainDataScriptingInterface::SetDetailLayer", HasExplicitThis = True)]
	private void Internal_SetDetailLayer(int xBase, int yBase, int totalWidth, int totalHeight, int detailIndex, int[,] data) { }

	[NativeName("GetDetailDatabase().SetDetailResolution")]
	private void Internal_SetDetailResolution(int patchCount, int resolutionPerPatch) { }

	[FreeFunction("TerrainDataScriptingInterface::RefreshPrototypes", HasExplicitThis = True)]
	public void RefreshPrototypes() { }

	public void set_alphamapResolution(int value) { }

	public void set_baseMapResolution(int value) { }

	[FreeFunction("TerrainDataScriptingInterface::SetDetailPrototypes", HasExplicitThis = True, ThrowsException = True)]
	public void set_detailPrototypes(DetailPrototype[] value) { }

	public void set_heightmapResolution(int value) { }

	[NativeName("GetSplatDatabase().SetAlphamapResolution")]
	private void set_Internal_alphamapResolution(int value) { }

	[NativeName("GetSplatDatabase().SetBaseMapResolution")]
	private void set_Internal_baseMapResolution(int value) { }

	[NativeName("GetHeightmap().SetResolution")]
	private void set_internalHeightmapResolution(int value) { }

	[NativeName("GetHeightmap().SetSize")]
	public void set_size(Vector3 value) { }

	private void set_size_Injected(ref Vector3 value) { }

	[FreeFunction("TerrainDataScriptingInterface::SetTerrainLayers", HasExplicitThis = True)]
	public void set_terrainLayers(TerrainLayer[] value) { }

	public void set_treeInstances(TreeInstance[] value) { }

	[FreeFunction("TerrainDataScriptingInterface::SetTreePrototypes", HasExplicitThis = True, ThrowsException = True)]
	public void set_treePrototypes(TreePrototype[] value) { }

	public void SetDetailLayer(int xBase, int yBase, int layer, int[,] details) { }

	public void SetDetailResolution(int detailResolution, int resolutionPerPatch) { }

	[FreeFunction("TerrainDataScriptingInterface::SetTreeInstances", HasExplicitThis = True)]
	public void SetTreeInstances(TreeInstance[] instances, bool snapToHeightmap) { }

}

