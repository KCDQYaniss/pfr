namespace UnityStandardAssets.ImageEffects;

[AddComponentMenu("Image Effects/Color Adjustments/Tonemapping")]
[ExecuteInEditMode]
[RequireComponent(typeof(Camera))]
public class Tonemapping : PostEffectsBase
{
	internal enum AdaptiveTexSize
	{
		Square16 = 16,
		Square32 = 32,
		Square64 = 64,
		Square128 = 128,
		Square256 = 256,
		Square512 = 512,
		Square1024 = 1024,
	}

	internal enum TonemapperType
	{
		SimpleReinhard = 0,
		UserCurve = 1,
		Hable = 2,
		Photographic = 3,
		OptimizedHejiDawson = 4,
		AdaptiveReinhard = 5,
		AdaptiveReinhardAutoWhite = 6,
	}

	private static readonly int _rangeScale; //Field offset: 0x0
	private static readonly int _curve; //Field offset: 0x4
	private static readonly int _exposureAdjustment; //Field offset: 0x8
	private static readonly int _adaptionSpeed; //Field offset: 0xC
	private static readonly int _hdrParams; //Field offset: 0x10
	private static readonly int _smallTex; //Field offset: 0x14
	public TonemapperType type; //Field offset: 0x30
	public AdaptiveTexSize adaptiveTextureSize; //Field offset: 0x34
	public AnimationCurve remapCurve; //Field offset: 0x38
	private Texture2D curveTex; //Field offset: 0x40
	public float exposureAdjustment; //Field offset: 0x48
	public float middleGrey; //Field offset: 0x4C
	public float white; //Field offset: 0x50
	public float adaptionSpeed; //Field offset: 0x54
	public Shader tonemapper; //Field offset: 0x58
	public bool validRenderTextureFormat; //Field offset: 0x60
	private Material tonemapMaterial; //Field offset: 0x68
	private RenderTexture rt; //Field offset: 0x70
	private RenderTextureFormat rtFormat; //Field offset: 0x78

	private static Tonemapping() { }

	public Tonemapping() { }

	public virtual bool CheckResources() { }

	private bool CreateInternalRenderTexture() { }

	private void OnDisable() { }

	[ImageEffectTransformsToLDR]
	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	public float UpdateCurve() { }

}

