namespace UnityStandardAssets.ImageEffects;

[AddComponentMenu("Image Effects/Color Adjustments/Color Correction (Curves, Saturation)")]
[ExecuteInEditMode]
public class ColorCorrectionCurves : PostEffectsBase
{
	internal enum ColorCorrectionMode
	{
		Simple = 0,
		Advanced = 1,
	}

	public AnimationCurve redChannel; //Field offset: 0x30
	public AnimationCurve greenChannel; //Field offset: 0x38
	public AnimationCurve blueChannel; //Field offset: 0x40
	public bool useDepthCorrection; //Field offset: 0x48
	public AnimationCurve zCurve; //Field offset: 0x50
	public AnimationCurve depthRedChannel; //Field offset: 0x58
	public AnimationCurve depthGreenChannel; //Field offset: 0x60
	public AnimationCurve depthBlueChannel; //Field offset: 0x68
	private Material ccMaterial; //Field offset: 0x70
	private Material ccDepthMaterial; //Field offset: 0x78
	private Material selectiveCcMaterial; //Field offset: 0x80
	private Texture2D rgbChannelTex; //Field offset: 0x88
	private Texture2D rgbDepthChannelTex; //Field offset: 0x90
	private Texture2D zCurveTex; //Field offset: 0x98
	public float saturation; //Field offset: 0xA0
	public bool selectiveCc; //Field offset: 0xA4
	public Color selectiveFromColor; //Field offset: 0xA8
	public Color selectiveToColor; //Field offset: 0xB8
	public ColorCorrectionMode mode; //Field offset: 0xC8
	public bool updateTextures; //Field offset: 0xCC
	public Shader colorCorrectionCurvesShader; //Field offset: 0xD0
	public Shader simpleColorCorrectionCurvesShader; //Field offset: 0xD8
	public Shader colorCorrectionSelectiveShader; //Field offset: 0xE0
	private bool updateTexturesOnStartup; //Field offset: 0xE8
	private SSAAPropagator _ssaaPropagator; //Field offset: 0xF0

	public ColorCorrectionCurves() { }

	private void Awake() { }

	public virtual bool CheckResources() { }

	private void OnDestroy() { }

	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	private void Start() { }

	public void UpdateParameters() { }

	private void UpdateTextures() { }

}

