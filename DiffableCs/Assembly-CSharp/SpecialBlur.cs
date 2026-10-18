//Type is in global namespace

public class SpecialBlur : MonoBehaviour
{
	private static readonly int _offsets; //Field offset: 0x0
	public Shader Shader; //Field offset: 0x20
	public RenderTexture From; //Field offset: 0x28
	public RenderTexture To; //Field offset: 0x30
	public RectTransform Target; //Field offset: 0x38
	public int BlurIterations; //Field offset: 0x40
	public float Snrength; //Field offset: 0x44
	public float Aspect; //Field offset: 0x48
	private Material _material; //Field offset: 0x50

	private static SpecialBlur() { }

	public SpecialBlur() { }

	private void CheckResizeForTarget(RenderTexture from, RenderTexture to) { }

	private Material GetMaterial() { }

	private void MakeBlurTexture(RenderTexture from, RenderTexture to) { }

	public void OnPostRender() { }

	private void OnValidate() { }

	private void Start() { }

}

