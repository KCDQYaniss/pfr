namespace GPUInstancer;

public class GPUInstancerHiZOcclusionGenerator : MonoBehaviour
{
	[IsReadOnly]
	internal struct EditorHandler : IDisposable
	{
		private readonly GPUInstancerHiZOcclusionGenerator _generator; //Field offset: 0x0
		public readonly bool IsReady; //Field offset: 0x8

		public EditorHandler(GPUInstancerHiZOcclusionGenerator generator, Camera camera) { }

		public override void Dispose() { }

	}

	public bool debuggerEnabled; //Field offset: 0x20
	public bool debuggerGUIOnTop; //Field offset: 0x21
	[Range(0, 0.1)]
	public float debuggerOverlay; //Field offset: 0x24
	[Range(0, 16)]
	public int debuggerMipLevel; //Field offset: 0x28
	[Header("For info only, don't change:")]
	public RenderTexture hiZDepthTexture; //Field offset: 0x30
	public Texture unityDepthTexture; //Field offset: 0x38
	public Vector2 hiZTextureSize; //Field offset: 0x40
	[HideInInspector]
	public bool isVREnabled; //Field offset: 0x48
	private Camera _mainCamera; //Field offset: 0x50
	private SSAA _ssaa; //Field offset: 0x58
	private int _previousScreenSizeX; //Field offset: 0x60
	private int _previousScreenSizeY; //Field offset: 0x64
	private bool _isInvalid; //Field offset: 0x68
	private GPUIOcclusionCullingType occlusionCullingType; //Field offset: 0x6C
	private Material _depthBlitMaterial; //Field offset: 0x70
	private int _hiZMipLevels; //Field offset: 0x78
	private RenderTexture[] _hiZMipLevelTextures; //Field offset: 0x80
	private RawImage _hiZDebugDepthTextureGUIImage; //Field offset: 0x88
	private GameObject _hiZOcclusionDebuggerGUI; //Field offset: 0x90
	private bool _debuggerGUIOnTopCached; //Field offset: 0x98
	private float _debuggerOverlayCached; //Field offset: 0x9C

	public int MipCount
	{
		 get { } //Length: 4
	}

	public GPUInstancerHiZOcclusionGenerator() { }

	private void Awake() { }

	private void CreateHiZDebuggerCanvas() { }

	private void CreateHiZDepthTexture() { }

	public int get_MipCount() { }

	private int GetPixelHeight() { }

	private int GetPixelWidth() { }

	private void HandleHiZDebugger() { }

	private void HandleScreenSizeChange() { }

	public void Initialize(Camera occlusionCamera = null) { }

	private void OnDestroy() { }

	private void OnDisable() { }

	private void OnEnable() { }

	private void OnEndCameraRendering(Camera camera) { }

	private void OnEndCameraRenderingBlit(Camera camera) { }

	private void OnEndCameraRenderingSRP(ScriptableRenderContext context, Camera camera) { }

	private void UpdateTextureWithComputeShader(int offset) { }

}

