namespace UnityStandardAssets.ImageEffects;

[AddComponentMenu("Image Effects/Noise/Noise and Scratches")]
[ExecuteInEditMode]
[RequireComponent(typeof(Camera))]
public class NoiseAndScratches : MonoBehaviour
{
	private static readonly int _grainTex; //Field offset: 0x0
	private static readonly int _scratchTex; //Field offset: 0x4
	private static readonly int _grainOffsetScale; //Field offset: 0x8
	private static readonly int _scratchOffsetScale; //Field offset: 0xC
	private static readonly int _intensity; //Field offset: 0x10
	public bool monochrome; //Field offset: 0x20
	private bool rgbFallback; //Field offset: 0x21
	public float grainIntensityMin; //Field offset: 0x24
	public float grainIntensityMax; //Field offset: 0x28
	public float grainSize; //Field offset: 0x2C
	public float scratchIntensityMin; //Field offset: 0x30
	public float scratchIntensityMax; //Field offset: 0x34
	public float scratchFPS; //Field offset: 0x38
	public float scratchJitter; //Field offset: 0x3C
	public Texture grainTexture; //Field offset: 0x40
	public Texture scratchTexture; //Field offset: 0x48
	public Shader shaderRGB; //Field offset: 0x50
	public Shader shaderYUV; //Field offset: 0x58
	private Material m_MaterialRGB; //Field offset: 0x60
	private Material m_MaterialYUV; //Field offset: 0x68
	private float scratchTimeLeft; //Field offset: 0x70
	private float scratchX; //Field offset: 0x74
	private float scratchY; //Field offset: 0x78

	protected Material material
	{
		 get { } //Length: 776
	}

	private static NoiseAndScratches() { }

	public NoiseAndScratches() { }

	protected Material get_material() { }

	protected void OnDisable() { }

	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	private void SanitizeParameters() { }

	protected void Start() { }

}

