namespace UnityStandardAssets.ImageEffects;

[AddComponentMenu("Image Effects/Edge Detection/Edge Detection")]
[ExecuteInEditMode]
[RequireComponent(typeof(Camera))]
public class EdgeDetection : PostEffectsBase
{
	internal enum EdgeDetectMode
	{
		TriangleDepthNormals = 0,
		RobertsCrossDepthNormals = 1,
		SobelDepth = 2,
		SobelDepthThin = 3,
		TriangleLuminance = 4,
	}

	public EdgeDetectMode mode; //Field offset: 0x30
	public float sensitivityDepth; //Field offset: 0x34
	public float sensitivityNormals; //Field offset: 0x38
	public float lumThreshold; //Field offset: 0x3C
	public float edgeExp; //Field offset: 0x40
	public float sampleDist; //Field offset: 0x44
	public float edgesOnly; //Field offset: 0x48
	public Color edgesOnlyBgColor; //Field offset: 0x4C
	public Shader edgeDetectShader; //Field offset: 0x60
	private Material edgeDetectMaterial; //Field offset: 0x68
	private EdgeDetectMode oldMode; //Field offset: 0x70

	public EdgeDetection() { }

	public virtual bool CheckResources() { }

	private void OnEnable() { }

	[ImageEffectOpaque]
	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	private void SetCameraFlag() { }

	private void Start() { }

}

