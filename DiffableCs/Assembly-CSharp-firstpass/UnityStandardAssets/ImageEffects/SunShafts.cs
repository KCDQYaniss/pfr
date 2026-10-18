namespace UnityStandardAssets.ImageEffects;

[AddComponentMenu("Image Effects/Rendering/Sun Shafts")]
[ExecuteInEditMode]
[RequireComponent(typeof(Camera))]
public class SunShafts : PostEffectsBase
{
	internal enum ShaftsScreenBlendMode
	{
		Screen = 0,
		Add = 1,
	}

	internal enum SunShaftsResolution
	{
		Low = 0,
		Normal = 1,
		High = 2,
	}

	private static readonly int _blurRadius4; //Field offset: 0x0
	private static readonly int _sunPosition; //Field offset: 0x4
	private static readonly int _sunThreshold; //Field offset: 0x8
	private static readonly int _sunColor; //Field offset: 0xC
	private static readonly int _colorBuffer; //Field offset: 0x10
	public SunShaftsResolution resolution; //Field offset: 0x30
	public ShaftsScreenBlendMode screenBlendMode; //Field offset: 0x34
	public Transform sunTransform; //Field offset: 0x38
	public int radialBlurIterations; //Field offset: 0x40
	public Color sunColor; //Field offset: 0x44
	public Color sunThreshold; //Field offset: 0x54
	public float sunShaftBlurRadius; //Field offset: 0x64
	public float sunShaftIntensity; //Field offset: 0x68
	public float maxRadius; //Field offset: 0x6C
	public bool useDepthTexture; //Field offset: 0x70
	public Shader sunShaftsShader; //Field offset: 0x78
	private Material sunShaftsMaterial; //Field offset: 0x80
	public Shader simpleClearShader; //Field offset: 0x88
	private Material simpleClearMaterial; //Field offset: 0x90
	public Vector3 SunDirection; //Field offset: 0x98

	private static SunShafts() { }

	public SunShafts() { }

	public virtual bool CheckResources() { }

	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

}

