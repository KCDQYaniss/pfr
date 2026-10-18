namespace JBooth.MicroSplat;

[CreateAssetMenu(menuName = "MicroSplat/Texture Array Config", order = 1)]
[ExecuteInEditMode]
public class TextureArrayConfig : ScriptableObject
{
	internal enum AllTextureChannel
	{
		R = 0,
		G = 1,
		B = 2,
		A = 3,
		Custom = 4,
	}

	internal enum ClusterMode
	{
		None = 0,
		TwoVariations = 1,
		ThreeVariations = 2,
	}

	internal enum Compression
	{
		AutomaticCompressed = 0,
		ForceDXT = 1,
		ForceBC7 = 2,
		ForcePVR = 3,
		ForceETC2 = 4,
		ForceASTC = 5,
		ForceCrunch = 6,
		Uncompressed = 7,
	}

	internal enum CompressionQuality
	{
		High = 0,
		Medium = 1,
		Low = 2,
	}

	internal enum PackingMode
	{
		Fastest = 0,
		Quality = 1,
	}

	internal enum PBRWorkflow
	{
		Metallic = 0,
		Specular = 1,
	}

	internal class PlatformTextureOverride
	{
		public TextureArrayGroup settings; //Field offset: 0x10

		public PlatformTextureOverride() { }

	}

	internal enum Season
	{
		Summer = 0,
		Autumn = 1,
		Winter = 2,
		Spring = 3,
		AutumnLate = 4,
		SpringEarly = 5,
	}

	internal enum SourceTextureSize
	{
		Unchanged = 0,
		k32 = 32,
		k256 = 256,
	}

	internal class TextureArrayGroup
	{
		public TextureArraySettings diffuseSettings; //Field offset: 0x10
		public TextureArraySettings normalSettings; //Field offset: 0x18
		public TextureArraySettings smoothSettings; //Field offset: 0x20
		public TextureArraySettings antiTileSettings; //Field offset: 0x28
		public TextureArraySettings emissiveSettings; //Field offset: 0x30
		public TextureArraySettings specularSettings; //Field offset: 0x38
		public TextureArraySettings traxDiffuseSettings; //Field offset: 0x40
		public TextureArraySettings traxNormalSettings; //Field offset: 0x48
		public TextureArraySettings decalSplatSettings; //Field offset: 0x50

		public TextureArrayGroup() { }

	}

	internal class TextureArraySettings
	{
		public TextureSize textureSize; //Field offset: 0x10
		public Compression compression; //Field offset: 0x14
		public CompressionQuality compressionQuality; //Field offset: 0x18
		public FilterMode filterMode; //Field offset: 0x1C
		[Range(0, 16)]
		public int Aniso; //Field offset: 0x20

		public TextureArraySettings(TextureSize s, Compression c, FilterMode f, int a = 1) { }

	}

	internal enum TextureChannel
	{
		R = 0,
		G = 1,
		B = 2,
		A = 3,
	}

	internal class TextureEntry
	{
		public string layerName; //Field offset: 0x10
		public Texture2D diffuse; //Field offset: 0x18
		public Texture2D height; //Field offset: 0x20
		public TextureChannel heightChannel; //Field offset: 0x28
		public Texture2D normal; //Field offset: 0x30
		public Texture2D smoothness; //Field offset: 0x38
		public TextureChannel smoothnessChannel; //Field offset: 0x40
		public bool isRoughness; //Field offset: 0x44
		public Texture2D ao; //Field offset: 0x48
		public TextureChannel aoChannel; //Field offset: 0x50
		public Texture2D emis; //Field offset: 0x58
		public Texture2D metal; //Field offset: 0x60
		public TextureChannel metalChannel; //Field offset: 0x68
		public Texture2D specular; //Field offset: 0x70
		public Texture2D noiseNormal; //Field offset: 0x78
		public Texture2D detailNoise; //Field offset: 0x80
		public TextureChannel detailChannel; //Field offset: 0x88
		public Texture2D distanceNoise; //Field offset: 0x90
		public TextureChannel distanceChannel; //Field offset: 0x98
		public Texture2D traxDiffuse; //Field offset: 0xA0
		public Texture2D traxHeight; //Field offset: 0xA8
		public TextureChannel traxHeightChannel; //Field offset: 0xB0
		public Texture2D traxNormal; //Field offset: 0xB8
		public Texture2D traxSmoothness; //Field offset: 0xC0
		public TextureChannel traxSmoothnessChannel; //Field offset: 0xC8
		public bool traxIsRoughness; //Field offset: 0xCC
		public Texture2D traxAO; //Field offset: 0xD0
		public TextureChannel traxAOChannel; //Field offset: 0xD8
		public Texture2D splat; //Field offset: 0xE0

		public TextureEntry() { }

		public bool HasTextures(PBRWorkflow wf) { }

		public void Reset() { }

	}

	internal enum TextureMode
	{
		Basic = 0,
		PBR = 1,
	}

	internal enum TextureSize
	{
		k4096 = 4096,
		k2048 = 2048,
		k1024 = 1024,
		k512 = 512,
		k256 = 256,
		k128 = 128,
		k64 = 64,
		k32 = 32,
	}

	public bool diffuseIsLinear; //Field offset: 0x18
	[HideInInspector]
	public bool antiTileArray; //Field offset: 0x19
	[HideInInspector]
	public bool emisMetalArray; //Field offset: 0x1A
	public bool traxArray; //Field offset: 0x1B
	[HideInInspector]
	public TextureMode textureMode; //Field offset: 0x1C
	[HideInInspector]
	public ClusterMode clusterMode; //Field offset: 0x20
	[HideInInspector]
	public PackingMode packingMode; //Field offset: 0x24
	[HideInInspector]
	public PBRWorkflow pbrWorkflow; //Field offset: 0x28
	[HideInInspector]
	public int hash; //Field offset: 0x2C
	[HideInInspector]
	public Texture2DArray splatArray; //Field offset: 0x30
	[HideInInspector]
	public Texture2DArray diffuseArray; //Field offset: 0x38
	[HideInInspector]
	public Texture2DArray normalSAOArray; //Field offset: 0x40
	[HideInInspector]
	public Texture2DArray smoothAOArray; //Field offset: 0x48
	[HideInInspector]
	public Texture2DArray specularArray; //Field offset: 0x50
	[HideInInspector]
	public Texture2DArray diffuseArray2; //Field offset: 0x58
	[HideInInspector]
	public Texture2DArray normalSAOArray2; //Field offset: 0x60
	[HideInInspector]
	public Texture2DArray smoothAOArray2; //Field offset: 0x68
	[HideInInspector]
	public Texture2DArray specularArray2; //Field offset: 0x70
	[HideInInspector]
	public Texture2DArray diffuseArray3; //Field offset: 0x78
	[HideInInspector]
	public Texture2DArray normalSAOArray3; //Field offset: 0x80
	[HideInInspector]
	public Texture2DArray smoothAOArray3; //Field offset: 0x88
	[HideInInspector]
	public Texture2DArray specularArray3; //Field offset: 0x90
	[HideInInspector]
	public Texture2DArray emisArray; //Field offset: 0x98
	[HideInInspector]
	public Texture2DArray emisArray2; //Field offset: 0xA0
	[HideInInspector]
	public Texture2DArray emisArray3; //Field offset: 0xA8
	public TextureArrayGroup defaultTextureSettings; //Field offset: 0xB0
	public List platformOverrides; //Field offset: 0xB8
	public SourceTextureSize sourceTextureSize; //Field offset: 0xC0
	[HideInInspector]
	public AllTextureChannel allTextureChannelHeight; //Field offset: 0xC4
	[HideInInspector]
	public AllTextureChannel allTextureChannelSmoothness; //Field offset: 0xC8
	[HideInInspector]
	public AllTextureChannel allTextureChannelAO; //Field offset: 0xCC
	[HideInInspector]
	public List sourceTextures; //Field offset: 0xD0
	[HideInInspector]
	public List sourceTextures2; //Field offset: 0xD8
	[HideInInspector]
	public List sourceTextures3; //Field offset: 0xE0

	public TextureArrayConfig() { }

	public bool IsDecal() { }

	public bool IsDecalSplat() { }

	public bool IsScatter() { }

	public bool IsStarReach() { }

}

