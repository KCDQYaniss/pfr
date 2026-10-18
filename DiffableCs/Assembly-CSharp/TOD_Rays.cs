//Type is in global namespace

[AddComponentMenu("Time of Day/Camera God Rays")]
[ExecuteInEditMode]
[RequireComponent(typeof(Camera))]
public class TOD_Rays : TOD_ImageEffect
{
	internal enum BlendModeType
	{
		Screen = 0,
		Add = 1,
	}

	internal enum ResolutionType
	{
		Low = 0,
		Normal = 1,
		High = 2,
	}

	private const int PASS_ADD = 4; //Field offset: 0x0
	private const int PASS_RADIAL = 1; //Field offset: 0x0
	private const int PASS_NODEPTH = 3; //Field offset: 0x0
	private const int PASS_DEPTH = 2; //Field offset: 0x0
	private static readonly int _blurRadius4; //Field offset: 0x0
	private const int PASS_SCREEN = 0; //Field offset: 0x0
	private static readonly int _lightPosition; //Field offset: 0x4
	private static readonly int _lightColor; //Field offset: 0x8
	private static readonly int _colorBuffer; //Field offset: 0xC
	public Shader GodRayShader; //Field offset: 0x38
	public Shader ScreenClearShader; //Field offset: 0x40
	public ResolutionType Resolution; //Field offset: 0x48
	public BlendModeType BlendMode; //Field offset: 0x4C
	[TOD_Range(0, 4)]
	public int BlurIterations; //Field offset: 0x50
	[TOD_Min(0)]
	public float BlurRadius; //Field offset: 0x54
	[TOD_Min(0)]
	public float Intensity; //Field offset: 0x58
	[TOD_Min(0)]
	public float MaxRadius; //Field offset: 0x5C
	public bool UseDepthTexture; //Field offset: 0x60
	private Material godRayMaterial; //Field offset: 0x68
	private Material screenClearMaterial; //Field offset: 0x70

	private static TOD_Rays() { }

	public TOD_Rays() { }

	protected void OnDisable() { }

	protected void OnEnable() { }

	protected void OnRenderImage(RenderTexture source, RenderTexture destination) { }

}

