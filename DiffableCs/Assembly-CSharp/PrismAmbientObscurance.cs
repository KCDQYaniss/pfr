//Type is in global namespace

[ExecuteInEditMode]
[RequireComponent(typeof(Camera))]
public class PrismAmbientObscurance : MonoBehaviour
{
	private static readonly int _aoIntensity; //Field offset: 0x0
	private static readonly int _aoLuminanceWeighting; //Field offset: 0x4
	private static readonly int _aoSampleCount; //Field offset: 0x8
	private static readonly int _aoSpiralTurns; //Field offset: 0xC
	private static readonly int _aoRadius; //Field offset: 0x10
	private static readonly int _aoBias; //Field offset: 0x14
	private static readonly int _aoTargetScale; //Field offset: 0x18
	private static readonly int _aoCutoff; //Field offset: 0x1C
	private static readonly int _aoCutoffRange; //Field offset: 0x20
	private static readonly int _aoCameraModelView; //Field offset: 0x24
	private static readonly int _aoProjInfo; //Field offset: 0x28
	private static readonly int _aoTexPrismAo; //Field offset: 0x2C
	private static readonly int _aoBlurVector; //Field offset: 0x30
	private static readonly int _aoTex; //Field offset: 0x34
	public Material m_Material; //Field offset: 0x20
	public Shader m_Shader; //Field offset: 0x28
	public Material m_AOMaterial; //Field offset: 0x30
	public Shader m_AOShader; //Field offset: 0x38
	private Camera m_Camera; //Field offset: 0x40
	private SSAA m_SSAA; //Field offset: 0x48
	public bool useAmbientObscurance; //Field offset: 0x50
	public SampleCount aoSampleCount; //Field offset: 0x54
	public bool useAODistanceCutoff; //Field offset: 0x58
	public float aoDistanceCutoffLength; //Field offset: 0x5C
	public float aoDistanceCutoffStart; //Field offset: 0x60
	public float aoIntensity; //Field offset: 0x64
	public float aoMinIntensity; //Field offset: 0x68
	public float aoRadius; //Field offset: 0x6C
	public bool aoDownsample; //Field offset: 0x70
	public AOBlurType aoBlurType; //Field offset: 0x74
	[Range(0, 3)]
	public int aoBlurIterations; //Field offset: 0x78
	public float aoBias; //Field offset: 0x7C
	public float aoBlurFilterDistance; //Field offset: 0x80
	public float aoLightingContribution; //Field offset: 0x84
	public bool aoShowDebug; //Field offset: 0x88
	public bool advancedAO; //Field offset: 0x89

	public int aoSampleCountValue
	{
		 get { } //Length: 60
		 set { } //Length: 4
	}

	private RenderTextureFormat aoTextureFormat
	{
		private get { } //Length: 28
	}

	public bool IsGBufferAvailable
	{
		 get { } //Length: 96
	}

	public bool UsingTerrain
	{
		 get { } //Length: 274
	}

	private static PrismAmbientObscurance() { }

	public PrismAmbientObscurance() { }

	private Material CreateMaterial(Shader shader) { }

	private bool CreateMaterials() { }

	public int get_aoSampleCountValue() { }

	private RenderTextureFormat get_aoTextureFormat() { }

	public bool get_IsGBufferAvailable() { }

	public bool get_UsingTerrain() { }

	public Camera GetPrismCamera() { }

	private void OnDisable() { }

	private void OnEnable() { }

	[ImageEffectOpaque]
	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	public void Reset() { }

	public void set_aoSampleCountValue(int value) { }

	private void SetAOShaderValues(Material aoMaterial) { }

	public void UpdateShaderValues() { }

}

