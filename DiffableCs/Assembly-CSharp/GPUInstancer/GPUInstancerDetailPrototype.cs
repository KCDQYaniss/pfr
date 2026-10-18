namespace GPUInstancer;

public class GPUInstancerDetailPrototype : GPUInstancerPrototype
{
	public int prototypeIndex; //Field offset: 0x88
	public DetailRenderMode detailRenderMode; //Field offset: 0x8C
	public bool usePrototypeMesh; //Field offset: 0x90
	public Texture2D prototypeTexture; //Field offset: 0x98
	public Texture2D bumpMap; //Field offset: 0xA0
	public bool useCustomMaterialForTextureDetail; //Field offset: 0xA8
	public Material textureDetailCustomMaterial; //Field offset: 0xB0
	public int detailResolution; //Field offset: 0xB8
	[Range(0, 1)]
	public float detailDensity; //Field offset: 0xBC
	[Range(0, 1)]
	public float detailGrowDirection; //Field offset: 0xC0
	public bool useCrossQuads; //Field offset: 0xC4
	[Range(1, 4)]
	public int quadCount; //Field offset: 0xC8
	public bool isBillboard; //Field offset: 0xCC
	[Range(0.5, 1)]
	public float billboardDistance; //Field offset: 0xD0
	public bool billboardDistanceDebug; //Field offset: 0xD4
	public Color billboardDistanceDebugColor; //Field offset: 0xD8
	public bool billboardFaceCamPos; //Field offset: 0xE8
	public Color detailHealthyColor; //Field offset: 0xEC
	public Color detailDryColor; //Field offset: 0xFC
	public float noiseSpread; //Field offset: 0x10C
	[Range(0, 1)]
	public float ambientOcclusion; //Field offset: 0x110
	[Range(0, 1)]
	public float gradientPower; //Field offset: 0x114
	public Color windWaveTintColor; //Field offset: 0x118
	[Range(0, 1)]
	public float windIdleSway; //Field offset: 0x128
	public bool windWavesOn; //Field offset: 0x12C
	[Range(0, 1)]
	public float windWaveTint; //Field offset: 0x130
	[Range(0, 1)]
	public float windWaveSway; //Field offset: 0x134
	public Vector4 detailScale; //Field offset: 0x138
	public int[] cachedDensityMapForInstance; //Field offset: 0x148
	public float densityFadeFactor; //Field offset: 0x150
	public int densityMapIndex; //Field offset: 0x154
	public Vector4 densityChanelMask; //Field offset: 0x158
	public Vector2 densityMinMax; //Field offset: 0x168
	public bool useDensityMask; //Field offset: 0x170
	public bool useCustomHealthyDryNoiseTexture; //Field offset: 0x171
	public Texture2D healthyDryNoiseTexture; //Field offset: 0x178
	public List alphaChannelMask; //Field offset: 0x180
	public bool useAlphaMask; //Field offset: 0x188
	public bool useVertexFit; //Field offset: 0x189
	public bool useTerrainNormal; //Field offset: 0x18A
	[Range(0, 5)]
	public float gradientNormalHeight; //Field offset: 0x18C

	public GPUInstancerDetailPrototype() { }

	public float[] CreateAlphaMaskArray() { }

	public Texture2DArray CreateTextureArray(Texture2D[] textureList) { }

	public virtual string ToString() { }

}

