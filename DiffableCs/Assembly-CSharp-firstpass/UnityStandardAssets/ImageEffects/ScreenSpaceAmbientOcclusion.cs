namespace UnityStandardAssets.ImageEffects;

[AddComponentMenu("Image Effects/Rendering/Screen Space Ambient Occlusion")]
[ExecuteInEditMode]
[RequireComponent(typeof(Camera))]
public class ScreenSpaceAmbientOcclusion : MonoBehaviour
{
	internal enum SSAOSamples
	{
		Low = 0,
		Medium = 1,
		High = 2,
	}

	public float m_Radius; //Field offset: 0x20
	public SSAOSamples m_SampleCount; //Field offset: 0x24
	public float m_OcclusionIntensity; //Field offset: 0x28
	public int m_Blur; //Field offset: 0x2C
	public int m_Downsampling; //Field offset: 0x30
	public float m_OcclusionAttenuation; //Field offset: 0x34
	public float m_MinZ; //Field offset: 0x38
	public Shader m_SSAOShader; //Field offset: 0x40
	private Material m_SSAOMaterial; //Field offset: 0x48
	public Texture2D m_RandomTexture; //Field offset: 0x50
	private bool m_Supported; //Field offset: 0x58

	public ScreenSpaceAmbientOcclusion() { }

	private static Material CreateMaterial(Shader shader) { }

	private void CreateMaterials() { }

	private static void DestroyMaterial(Material mat) { }

	private void OnDisable() { }

	private void OnEnable() { }

	[ImageEffectOpaque]
	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	private void Start() { }

}

