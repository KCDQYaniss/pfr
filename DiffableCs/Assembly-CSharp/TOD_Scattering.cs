//Type is in global namespace

[AddComponentMenu("Time of Day/Camera Scattering")]
[ExecuteInEditMode]
[RequireComponent(typeof(Camera))]
public class TOD_Scattering : TOD_ImageEffect
{
	private static readonly int _frustumCornersWs; //Field offset: 0x0
	private static readonly int _ditheringTexture; //Field offset: 0x4
	private static readonly int _density; //Field offset: 0x8
	private static readonly int _sunrizeGlow; //Field offset: 0xC
	private static readonly int _scatteringTex; //Field offset: 0x10
	public bool Lighten; //Field offset: 0x38
	public bool FromLevelSettings; //Field offset: 0x39
	public Shader ScatteringShader; //Field offset: 0x40
	public Texture2D DitheringTexture; //Field offset: 0x48
	[Range(0.001, 0.2)]
	public float GlobalDensity; //Field offset: 0x50
	[Range(0, 1)]
	public float HeightFalloff; //Field offset: 0x54
	[Range(0.95, 1)]
	public float SunrizeGlow; //Field offset: 0x58
	[SerializeField]
	private bool _mboit; //Field offset: 0x5C
	public float ZeroLevel; //Field offset: 0x60
	private Material scatteringMaterial; //Field offset: 0x68
	private Mesh _mesh; //Field offset: 0x70
	private MBOIT_Scattering _mboitScattering; //Field offset: 0x78
	private bool _isInitialized; //Field offset: 0x80

	public bool MBOIT
	{
		 get { } //Length: 5
		 set { } //Length: 331
	}

	private static TOD_Scattering() { }

	public TOD_Scattering() { }

	private void DestroyMaterial(ref Material mat) { }

	private void EnableMBOITMode(bool enable) { }

	public bool get_MBOIT() { }

	private void Init() { }

	protected void OnDestroy() { }

	[ImageEffectOpaque]
	protected void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	protected void OnRenderImageNormalMode(RenderTexture source, RenderTexture destination) { }

	public void set_MBOIT(bool value) { }

	protected void Start() { }

}

