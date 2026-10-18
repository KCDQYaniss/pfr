namespace UnityStandardAssets.ImageEffects;

[AddComponentMenu("Image Effects/Color Adjustments/Contrast Stretch")]
[ExecuteInEditMode]
public class ContrastStretch : MonoBehaviour
{
	private static readonly int _adaptTex; //Field offset: 0x0
	private static readonly int _curTex; //Field offset: 0x4
	private static readonly int _adaptParams; //Field offset: 0x8
	public float adaptationSpeed; //Field offset: 0x20
	public float limitMinimum; //Field offset: 0x24
	public float limitMaximum; //Field offset: 0x28
	private RenderTexture[] adaptRenderTex; //Field offset: 0x30
	private int curAdaptIndex; //Field offset: 0x38
	public Shader shaderLum; //Field offset: 0x40
	private Material m_materialLum; //Field offset: 0x48
	public Shader shaderReduce; //Field offset: 0x50
	private Material m_materialReduce; //Field offset: 0x58
	public Shader shaderAdapt; //Field offset: 0x60
	private Material m_materialAdapt; //Field offset: 0x68
	public Shader shaderApply; //Field offset: 0x70
	private Material m_materialApply; //Field offset: 0x78

	protected Material materialAdapt
	{
		 get { } //Length: 435
	}

	protected Material materialApply
	{
		 get { } //Length: 435
	}

	protected Material materialLum
	{
		 get { } //Length: 435
	}

	protected Material materialReduce
	{
		 get { } //Length: 435
	}

	private static ContrastStretch() { }

	public ContrastStretch() { }

	private void CalculateAdaptation(Texture curTexture) { }

	protected Material get_materialAdapt() { }

	protected Material get_materialApply() { }

	protected Material get_materialLum() { }

	protected Material get_materialReduce() { }

	private void OnDisable() { }

	private void OnEnable() { }

	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	private void Start() { }

}

