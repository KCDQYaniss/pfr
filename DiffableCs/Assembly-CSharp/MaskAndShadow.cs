//Type is in global namespace

public class MaskAndShadow : MonoBehaviour
{
	private static readonly int _mnSMaskTexture; //Field offset: 0x0
	public Shader Shader; //Field offset: 0x20
	public Texture2D Mask; //Field offset: 0x28
	[Header("Shadow")]
	public Vector2 ShadowShift; //Field offset: 0x30
	public int ShadowBlurIterations; //Field offset: 0x38
	public float ShadowBlurStrength; //Field offset: 0x3C
	[Range(0, 1)]
	public float ShadowStrength; //Field offset: 0x40
	private Camera _camera; //Field offset: 0x48
	private Material _material; //Field offset: 0x50
	private CommandBuffer _grabAlphaBuffer; //Field offset: 0x58

	private static MaskAndShadow() { }

	public MaskAndShadow() { }

	private void Awake() { }

	private int BlurTex(CommandBuffer buffer, Material mat, int blurTex) { }

	private Material GetMaterial() { }

	private void OnValidate() { }

	private void SetGrabAlphaBuffer() { }

}

