namespace UnityStandardAssets.ImageEffects;

[AddComponentMenu("Image Effects/Other/Antialiasing")]
[ExecuteInEditMode]
[RequireComponent(typeof(Camera))]
public class Antialiasing : PostEffectsBase
{
	private static readonly int _edgeThresholdMin; //Field offset: 0x0
	private static readonly int _edgeThreshold; //Field offset: 0x4
	private static readonly int _edgeSharpness; //Field offset: 0x8
	private static readonly int _offsetScale; //Field offset: 0xC
	private static readonly int _blurRadius; //Field offset: 0x10
	public AAMode mode; //Field offset: 0x30
	public bool showGeneratedNormals; //Field offset: 0x34
	public float offsetScale; //Field offset: 0x38
	public float blurRadius; //Field offset: 0x3C
	public float edgeThresholdMin; //Field offset: 0x40
	public float edgeThreshold; //Field offset: 0x44
	public float edgeSharpness; //Field offset: 0x48
	public bool dlaaSharp; //Field offset: 0x4C
	public Shader ssaaShader; //Field offset: 0x50
	private Material ssaa; //Field offset: 0x58
	public Shader dlaaShader; //Field offset: 0x60
	private Material dlaa; //Field offset: 0x68
	public Shader nfaaShader; //Field offset: 0x70
	private Material nfaa; //Field offset: 0x78
	public Shader shaderFXAAPreset2; //Field offset: 0x80
	private Material materialFXAAPreset2; //Field offset: 0x88
	public Shader shaderFXAAPreset3; //Field offset: 0x90
	private Material materialFXAAPreset3; //Field offset: 0x98
	public Shader shaderFXAAII; //Field offset: 0xA0
	private Material materialFXAAII; //Field offset: 0xA8
	public Shader shaderFXAAIII; //Field offset: 0xB0
	private Material materialFXAAIII; //Field offset: 0xB8

	private static Antialiasing() { }

	public Antialiasing() { }

	public virtual bool CheckResources() { }

	public Material CurrentAAMaterial() { }

	public void OnRenderImage(RenderTexture source, RenderTexture destination) { }

}

