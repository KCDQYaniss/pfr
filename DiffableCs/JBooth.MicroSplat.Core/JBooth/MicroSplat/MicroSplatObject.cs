namespace JBooth.MicroSplat;

[ExecuteAlways]
public class MicroSplatObject : MonoBehaviour
{
	internal enum QUALITY
	{
		HIGH = 0,
		NORMAL = 1,
		LOW = 2,
	}

	internal struct TerrainDescriptor
	{
		public Texture heightMap; //Field offset: 0x0
		public Texture normalMap; //Field offset: 0x8
		public Vector3 heightMapScale; //Field offset: 0x10

	}

	public static QUALITY currentQuality; //Field offset: 0x0
	public static Season currentSeason; //Field offset: 0x4
	public static bool NullifyMaterialsReferencesAfterAwake; //Field offset: 0x8
	private static readonly int _terrainBounds; //Field offset: 0xC
	private static readonly int _terrainHeightmapTexture; //Field offset: 0x10
	private static readonly int _terrainHeightmapScale; //Field offset: 0x14
	private static readonly int _terrainNormalmapTexture; //Field offset: 0x18
	private static readonly int _geoTex; //Field offset: 0x1C
	private static readonly int _geoSlopeTex; //Field offset: 0x20
	private static readonly int _globalSlopeTex; //Field offset: 0x24
	private static readonly int _geoCurve; //Field offset: 0x28
	private static readonly int _alphaHoleTexture; //Field offset: 0x2C
	private static readonly int _perPixelNormal; //Field offset: 0x30
	private static readonly int _globalTintTex; //Field offset: 0x34
	private static readonly int _globalNormalTex; //Field offset: 0x38
	private static readonly int _globalSAOMTex; //Field offset: 0x3C
	private static readonly int _globalEmisTex; //Field offset: 0x40
	private static readonly int _vsGrassMap; //Field offset: 0x44
	private static readonly int _vsShadowMap; //Field offset: 0x48
	private static readonly int _streamControl; //Field offset: 0x4C
	private static readonly int _scatterControl; //Field offset: 0x50
	private static readonly int _perTexProps; //Field offset: 0x54
	private static readonly int _procTexCurves; //Field offset: 0x58
	private static readonly int _procTexParams; //Field offset: 0x5C
	private static readonly int _pclayerCount; //Field offset: 0x60
	private static readonly int _procTexBiomeMask; //Field offset: 0x64
	private static readonly int _procTexBiomeMask2; //Field offset: 0x68
	private static readonly int _cavityMap; //Field offset: 0x6C
	private static readonly int _pcHeightGradients; //Field offset: 0x70
	private static readonly int _pcHeightHSV; //Field offset: 0x74
	private static readonly int _pcSlopeGradients; //Field offset: 0x78
	private static readonly int _pcSlopeHSV; //Field offset: 0x7C
	private static readonly int _snowMask; //Field offset: 0x80
	private static readonly int _control0; //Field offset: 0x84
	private static readonly int _control1; //Field offset: 0x88
	private static readonly int _control2; //Field offset: 0x8C
	private static readonly int _control3; //Field offset: 0x90
	private static readonly int _control4; //Field offset: 0x94
	private static readonly int _control5; //Field offset: 0x98
	private static readonly int _control6; //Field offset: 0x9C
	private static readonly int _control7; //Field offset: 0xA0
	public Material templateMaterial; //Field offset: 0x20
	[HideInInspector]
	public MicroSplatSeasons SeasonsMaterials; //Field offset: 0x28
	[HideInInspector]
	public Material matInstance; //Field offset: 0x30
	[HideInInspector]
	public Material blendMat; //Field offset: 0x38
	[HideInInspector]
	public Material blendMatInstance; //Field offset: 0x40
	public MicroSplatKeywords keywordSO; //Field offset: 0x48
	[HideInInspector]
	public Texture2D perPixelNormal; //Field offset: 0x50
	[HideInInspector]
	public Texture2D streamTexture; //Field offset: 0x58
	[HideInInspector]
	public Texture2D clipMap; //Field offset: 0x60
	public MicroSplatPropData propData; //Field offset: 0x68

	private static MicroSplatObject() { }

	public MicroSplatObject() { }

	public void ApplyBlendMap() { }

	protected void ApplyControlTextures(Texture2D[] controls, Material m) { }

	protected void ApplyMaps(Material m) { }

	protected void ApplySharedData(Material m) { }

	public Material GetBlendMatInstance() { }

	public override Bounds GetBounds() { }

	protected long GetOverrideHash() { }

	public override TerrainDescriptor GetTerrainDescriptor() { }

	public void RevisionFromMat() { }

	protected void SetMap(Material m, string name, Texture tex) { }

	protected void SetMap(Material m, int propertyId, Texture tex) { }

	public static void SyncAll() { }

	protected void SyncBlendMat(Vector3 size) { }

}

