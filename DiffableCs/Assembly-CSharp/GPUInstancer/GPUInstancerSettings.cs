namespace GPUInstancer;

public class GPUInstancerSettings : ScriptableObject
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Predicate <>9__33_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal bool <AddExtension>b__33_0(GPUInstancerSettingsExtension ex) { }

	}

	internal class GPUIRenderingSettings
	{
		public GPUIPlatform platform; //Field offset: 0x10
		public GPUIMatrixHandlingType matrixHandlingType; //Field offset: 0x14
		public GPUIComputeThreadCount computeThreadCount; //Field offset: 0x18

		public GPUIRenderingSettings() { }

	}

	public float versionNo; //Field offset: 0x18
	public GPUInstancerShaderBindings shaderBindings; //Field offset: 0x20
	public GPUInstancerBillboardAtlasBindings billboardAtlasBindings; //Field offset: 0x28
	public ShaderVariantCollection shaderVariantCollection; //Field offset: 0x30
	public bool packagesLoaded; //Field offset: 0x38
	public bool isHDRP; //Field offset: 0x39
	public bool isLWRP; //Field offset: 0x3A
	public bool isShaderGraphPresent; //Field offset: 0x3B
	public int instancingBoundsSize; //Field offset: 0x3C
	public float MAX_DETAIL_DISTANCE; //Field offset: 0x40
	public float MAX_TREE_DISTANCE; //Field offset: 0x44
	public float MAX_PREFAB_DISTANCE; //Field offset: 0x48
	public int MAX_PREFAB_EXTRA_BUFFER_SIZE; //Field offset: 0x4C
	public Vector2Int DEFAULT_DETAIL_DISTANCE; //Field offset: 0x50
	public Vector2Int DEFAULT_DETAIL_CELL_SIZE; //Field offset: 0x58
	public Vector2 DEFAULT_DETAIL_DENSITY_FACTOR; //Field offset: 0x60
	public Vector2 DEFAULT_FRUSTUM_OFFSET; //Field offset: 0x68
	public bool DEFAULT_USE_DENSITY_MASK; //Field offset: 0x70
	public float DEFAULT_GRASS_SHADOW_DISTANCE; //Field offset: 0x74
	public bool useCustomPreviewBackgroundColor; //Field offset: 0x78
	public Color previewBackgroundColor; //Field offset: 0x7C
	public bool disableAutoGenerateBillboards; //Field offset: 0x8C
	public bool disableShaderVariantCollection; //Field offset: 0x8D
	public bool disableInstanceCountWarning; //Field offset: 0x8E
	public bool disableAutoShaderConversion; //Field offset: 0x8F
	public bool disableAutoVariantHandling; //Field offset: 0x90
	public bool testBothEyesForVROcclusion; //Field offset: 0x91
	public int vrRenderingMode; //Field offset: 0x94
	public List extensionSettings; //Field offset: 0x98
	public List renderingSettingPresets; //Field offset: 0xA0
	public bool hasCustomRenderingSettings; //Field offset: 0xA8
	public GPUIRenderingSettings customRenderingSettings; //Field offset: 0xB0
	public GPUIOcclusionCullingType occlusionCullingType; //Field offset: 0xB8

	public GPUInstancerSettings() { }

	public void AddExtension(GPUInstancerSettingsExtension extension) { }

	public override void AddShaderVariantToCollection(Material material, string extensionCode = null) { }

	public override void AddShaderVariantToCollection(string shaderName, string extensionCode = null) { }

	public GPUIComputeThreadCount GetComputeThreadCount(GPUIPlatform platform) { }

	public int GetDefaultDetailCellSize(bool isOptic) { }

	public float GetDefaultDetailDensity(Terrain terrain, bool isOptic) { }

	public int GetDefaultDetailDistance(bool isOptic) { }

	public float GetDefaultFrustumOffset(bool isOptic) { }

	public static GPUInstancerBillboardAtlasBindings GetDefaultGPUInstancerBillboardAtlasBindings() { }

	public static GPUInstancerSettings GetDefaultGPUInstancerSettings() { }

	public static GPUInstancerShaderBindings GetDefaultGPUInstancerShaderBindings() { }

	public static ShaderVariantCollection GetDefaultShaderVariantCollection() { }

	public GPUIMatrixHandlingType GetMatrixHandlingType(GPUIPlatform platform) { }

	public override void SetDefaultGPUInstancerBillboardAtlasBindings() { }

	public override void SetDefaultGPUInstancerShaderBindings() { }

	public override void SetDefaultShaderVariantCollection() { }

	public override void SetDefaultShaderVariants() { }

	public override void SetDefultBindings() { }

}

