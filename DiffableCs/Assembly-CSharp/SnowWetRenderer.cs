//Type is in global namespace

[ExecuteInEditMode]
public sealed class SnowWetRenderer : MonoBehaviour
{
	[CompilerGenerated]
	private static class <>O
	{
		public static Action <0>__OnScreenChanged; //Field offset: 0x0

	}

	private const float MAP_DOWNSCALE_FACTOR = 4; //Field offset: 0x0
	private static readonly int _biasId; //Field offset: 0x0
	private const string WINTER_SNOW = "WINTER_SNOW"; //Field offset: 0x0
	private const string SNOW_GLITTERS = "SNOW_GLITTERS"; //Field offset: 0x0
	private static readonly int _intensityId; //Field offset: 0x4
	private static readonly int _springSnowFactor; //Field offset: 0x8
	private static readonly int _diffuseColorId; //Field offset: 0xC
	private static readonly int _specColorId; //Field offset: 0x10
	private static readonly int _noiseTilingId; //Field offset: 0x14
	private static readonly int _specularMap; //Field offset: 0x18
	private static readonly int _bumpMap; //Field offset: 0x1C
	private static readonly int _glossness; //Field offset: 0x20
	public static readonly int _wetOffMask; //Field offset: 0x24
	private static readonly int _snowGlitterMask; //Field offset: 0x28
	private static readonly int _snowNormalMap; //Field offset: 0x2C
	private static readonly int _opaquenessId; //Field offset: 0x30
	private static readonly int _wetFactorId; //Field offset: 0x34
	private static readonly int _wetAngleMin; //Field offset: 0x38
	private static readonly int _wetAngleMax; //Field offset: 0x3C
	private static readonly int _snowTransition; //Field offset: 0x40
	private static readonly int _screenSpaceNormalAndAlphaMask; //Field offset: 0x44
	private static readonly int _mapBoundsMinId; //Field offset: 0x48
	private static readonly int _mapBoundsMaxId; //Field offset: 0x4C
	private static readonly int _mapDownscaleId; //Field offset: 0x50
	private static readonly int _textureTilingId; //Field offset: 0x54
	private static readonly int _albedoTex; //Field offset: 0x58
	private static readonly int _noiseMap; //Field offset: 0x5C
	private static readonly int _screenNoiseTiling; //Field offset: 0x60
	private static readonly int _snowSpecularFactor; //Field offset: 0x64
	private static readonly int _glitterThreshold; //Field offset: 0x68
	private static readonly int _glitterIntensity; //Field offset: 0x6C
	private static readonly int _disableSnowMaskID; //Field offset: 0x70
	private static readonly int _stormEnabledId; //Field offset: 0x74
	private static readonly int _dampingDistance; //Field offset: 0x78
	private static readonly int _swampSnowIgnoreMaskId; //Field offset: 0x7C
	public Shader WetShader; //Field offset: 0x20
	[Range(0, 1)]
	public float Wetting; //Field offset: 0x28
	public Vector3 SpringSnowFactor; //Field offset: 0x2C
	public Color DiffuseColor; //Field offset: 0x38
	public Color SpecColor; //Field offset: 0x48
	public float WetFactor; //Field offset: 0x58
	public float WetBias; //Field offset: 0x5C
	public float Opaqueness; //Field offset: 0x60
	public Material _wetMaterial; //Field offset: 0x68
	public Material _snowCopyMaterial; //Field offset: 0x70
	public Mesh _wetMesh; //Field offset: 0x78
	public Material _snowSparkling; //Field offset: 0x80
	public int SparklingsCount; //Field offset: 0x88
	private bool _winterShow; //Field offset: 0x8C
	private bool _winterShowUpdated; //Field offset: 0x8D
	private readonly CommandBufferManager _cbSwampManager; //Field offset: 0x90
	private readonly CommandBufferManager _cbSnowManager; //Field offset: 0x98
	public bool StormEnabled; //Field offset: 0xA0
	public float WetAngleMin; //Field offset: 0xA4
	public float WetAngleMax; //Field offset: 0xA8
	public float SnowTransition; //Field offset: 0xAC
	[HideInInspector]
	[SerializeField]
	private Vector2 _textureTilingFactor; //Field offset: 0xB0
	[HideInInspector]
	[SerializeField]
	private Vector2 _noiseTilingFactor; //Field offset: 0xB8
	private Vector2 _textureTiling; //Field offset: 0xC0
	private Vector2 _noiseTiling; //Field offset: 0xC8
	private Vector3 _mapBoundsMin; //Field offset: 0xD0
	private Vector3 _mapBoundsMax; //Field offset: 0xDC
	private float _mapDownscale; //Field offset: 0xE8
	private LevelSettings _levelSettings; //Field offset: 0xF0
	public float _DampingDistance; //Field offset: 0xF8
	public Texture2D AlbedoTex; //Field offset: 0x100
	public Texture2D SpecularMap; //Field offset: 0x108
	public Texture2D BumpMap; //Field offset: 0x110
	public Texture2D NoiseMap; //Field offset: 0x118
	public Vector2 ScreenNoiseTiling; //Field offset: 0x120
	public float Glossness; //Field offset: 0x128
	public Vector4 SnowSpecularFactor; //Field offset: 0x12C
	[Range(0, 1)]
	public float GlitterThreshold; //Field offset: 0x13C
	[Range(0, 10)]
	public float GlitterIntensity; //Field offset: 0x140

	public bool WinterShow
	{
		 get { } //Length: 8
		 set { } //Length: 112
	}

	private static SnowWetRenderer() { }

	public SnowWetRenderer() { }

	private static Mesh CreateQuad() { }

	private static Mesh CreateSparklingMesh(int count) { }

	public bool get_WinterShow() { }

	private Material GetMaterial() { }

	private void Init() { }

	private void OnDestroy() { }

	private void OnDisable() { }

	private void OnEnable() { }

	private void OnPreCullCallback(Camera currentCamera) { }

	private static void OnScreenChanged() { }

	private static void OnScreenChanged(EEftScreenType screenType) { }

	private void OnValidate() { }

	private void RenderSnowy(in SnowRendererData data) { }

	private void RenderSwamp(in SnowRendererData data) { }

	public void set_WinterShow(bool value) { }

	public void SetDebugRain(bool debug) { }

	private bool SetMapParams() { }

	private static void SetSnowKeyword(bool enable) { }

	private void Start() { }

	private void Update() { }

	private void UpdateMaterial() { }

}

