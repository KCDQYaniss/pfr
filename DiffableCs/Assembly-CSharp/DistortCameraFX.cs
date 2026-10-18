//Type is in global namespace

public class DistortCameraFX : MonoBehaviour
{
	private static readonly List DistortNBlurRenderers; //Field offset: 0x0
	private static readonly int _distortionID; //Field offset: 0x8
	private static readonly int _distortValuesTex; //Field offset: 0xC
	private static readonly int _blurTextureID; //Field offset: 0x10
	private static readonly int _blurOffsets; //Field offset: 0x14
	public Shader Shader; //Field offset: 0x20
	public float Distortion; //Field offset: 0x28
	[Range(1, 4)]
	public int BlurIterations; //Field offset: 0x2C
	private Material _material; //Field offset: 0x30
	private Camera _camera; //Field offset: 0x38
	private SSAA _ssaa; //Field offset: 0x40
	private SSAAPropagator _ssaaPropagator; //Field offset: 0x48
	private CommandBuffer _renderersBuffer; //Field offset: 0x50
	private RenderTexture _distortTexture; //Field offset: 0x58
	private RenderTexture _blurTexture; //Field offset: 0x60
	private bool _doNotRender; //Field offset: 0x68
	private Vector2 _distortion; //Field offset: 0x6C
	private int _prevPixelHeight; //Field offset: 0x74
	private int _prevPixelWidth; //Field offset: 0x78

	private Material Material
	{
		private get { } //Length: 356
	}

	private static DistortCameraFX() { }

	public DistortCameraFX() { }

	public static void AddRenderer(DistortRenderer renderer) { }

	private void Awake() { }

	private void CreateBlurTexture() { }

	private void CreateDistortTexture() { }

	private bool DrawRenderers(CommandBuffer buffer, Camera currentCamera) { }

	private Material get_Material() { }

	private int GetPixelHeight() { }

	private int GetPixelWidth() { }

	private void Init() { }

	private void MakeBlurTexture(RenderTexture src) { }

	private void OnDestroy() { }

	private void OnDisable() { }

	private void OnEnable() { }

	private void OnPreCull() { }

	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	private void OnRenderImageInternal(RenderTexture src, RenderTexture dest) { }

	private void OnValidate() { }

	public static void RemoveRenderer(DistortRenderer renderer) { }

	private void SetDistortion() { }

	private void Update() { }

}

