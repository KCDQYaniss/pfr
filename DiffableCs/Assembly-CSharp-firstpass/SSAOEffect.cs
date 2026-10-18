//Type is in global namespace

[AddComponentMenu("Image Effects/Screen Space Ambient Occlusion")]
[ExecuteInEditMode]
[RequireComponent(typeof(Camera))]
public class SSAOEffect : MonoBehaviour
{
	internal enum SSAOSamples
	{
		Low = 0,
		Medium = 1,
		High = 2,
	}

	private static readonly int _farCorner; //Field offset: 0x0
	private static readonly int _params; //Field offset: 0x4
	private static readonly int _bias; //Field offset: 0x8
	private static readonly int _texelOffsetScale; //Field offset: 0xC
	private static readonly int _ssao; //Field offset: 0x10
	private static readonly int _aofog; //Field offset: 0x14
	public float m_Radius; //Field offset: 0x20
	public SSAOSamples m_SampleCount; //Field offset: 0x24
	public float m_OcclusionIntensity; //Field offset: 0x28
	public int m_Blur; //Field offset: 0x2C
	public int m_Downsampling; //Field offset: 0x30
	public float m_OcclusionAttenuation; //Field offset: 0x34
	public float m_MinZ; //Field offset: 0x38
	public float FogDensity; //Field offset: 0x3C
	public float Bias; //Field offset: 0x40
	public Shader m_SSAOShader; //Field offset: 0x48
	private Material m_SSAOMaterial; //Field offset: 0x50
	private bool m_Supported; //Field offset: 0x58

	private static SSAOEffect() { }

	public SSAOEffect() { }

	private static Material CreateMaterial(Shader shader) { }

	private void CreateMaterials() { }

	private static void DestroyMaterial(Material mat) { }

	private void OnDisable() { }

	private void OnEnable() { }

	[ImageEffectOpaque]
	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	private void Start() { }

}

