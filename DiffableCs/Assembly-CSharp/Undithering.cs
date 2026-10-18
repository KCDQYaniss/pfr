//Type is in global namespace

[AddComponentMenu("Image Effects/Undithering")]
[ExecuteInEditMode]
[RequireComponent(typeof(Camera))]
public class Undithering : MonoBehaviour
{
	private static readonly int _distortionID; //Field offset: 0x0
	private static readonly int _scatterID; //Field offset: 0x4
	public Shader shader; //Field offset: 0x20
	public bool useTriangleBlit; //Field offset: 0x28
	[SerializeField]
	private bool _distortion; //Field offset: 0x29
	private bool _scatter; //Field offset: 0x2A
	private Material _material; //Field offset: 0x30
	private MaterialPropertyBlock _materialProperty; //Field offset: 0x38
	private CommandBuffer _cmdBuf; //Field offset: 0x40

	private CommandBuffer CmdBuf
	{
		private get { } //Length: 356
	}

	private Material Material
	{
		private get { } //Length: 433
	}

	private static Undithering() { }

	public Undithering() { }

	private CommandBuffer get_CmdBuf() { }

	private Material get_Material() { }

	private void OnDestroy() { }

	[ImageEffectOpaque]
	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	private void Start() { }

}

