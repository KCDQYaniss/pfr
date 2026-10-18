//Type is in global namespace

public class DLSSWrapper
{
	internal enum DEPTH_COPY_MODE
	{
		NO_MODIFICATION = 0,
		INVERT = 1,
		CONST_ZERO = 2,
		CONST_ONE = 3,
	}

	internal enum InitErrors
	{
		INIT_SUCCESS = 0,
		INIT_INTERNAL_INIT_ERROR = 1,
		INIT_GET_CAPABILITY_FAILED = 2,
		INIT_OLD_DRIVER = 3,
		INIT_NOT_SUPPORTED_HARDWARE_OR_PLATFORM = 4,
		INIT_DENIED_FOR_THIS_APP = 5,
	}

	[IsByRefLike]
	[IsReadOnly]
	[Obsolete("Types with embedded references are not supported in this version of your compiler.", True)]
	internal struct PresetController
	{
		private readonly DLSSWrapper _dlssWrapper; //Field offset: 0x0

		public bool IsCreated
		{
			 get { } //Length: 8
		}

		public PresetController(DLSSWrapper dlssWrapper) { }

		public EDLSSPreset Get() { }

		public bool get_IsCreated() { }

		public bool Set(EDLSSPreset preset) { }

	}

	public static bool DebugPretendDLSSIsSupported; //Field offset: 0x0
	public static bool WantToDebugDLSSViaRenderdoc; //Field offset: 0x1
	private static Nullable _isSupportedCachedValue; //Field offset: 0x2
	private bool _createdDLSSBuffers; //Field offset: 0x10
	public float Sharpness; //Field offset: 0x14
	public bool DebugMode; //Field offset: 0x18
	public bool DebugDisable; //Field offset: 0x19
	public int Quality; //Field offset: 0x1C
	public Vector2 JitterOffsets; //Field offset: 0x20
	public Vector2 MVScale; //Field offset: 0x28
	[CompilerGenerated]
	private Action RenderTexturesAreChanged; //Field offset: 0x30
	private RenderTexture _srcCopyUAV; //Field offset: 0x38
	private RenderTexture _motionVectorsCopy; //Field offset: 0x40
	private RenderTexture _depthCopy; //Field offset: 0x48
	private RenderTexture _textureBuffer; //Field offset: 0x50
	private IntPtr _srcCopyUAVPtr; //Field offset: 0x58
	private IntPtr _motionVectorsCopyPtr; //Field offset: 0x60
	private IntPtr _depthCopyPtr; //Field offset: 0x68
	private IntPtr _textureBufferPtr; //Field offset: 0x70
	private MaterialPropertyBlock _propertiesOut; //Field offset: 0x78
	private MaterialPropertyBlock _copyDepthMotionProperties; //Field offset: 0x80
	private CommandBuffer _cmdBufEvaluate; //Field offset: 0x88
	private CommandBuffer _cmdBufCopy; //Field offset: 0x90
	private RenderTargetIdentifier[] _mrt3; //Field offset: 0x98
	private RenderTargetIdentifier[] _mrt2; //Field offset: 0xA0
	private Material _matCopySources; //Field offset: 0xA8
	private Mesh _mesh; //Field offset: 0xB0
	private int _dlssHandle; //Field offset: 0xB8
	private List _dlssHandlesToRelease; //Field offset: 0xC0
	private int _featureInWidth; //Field offset: 0xC8
	private int _featureInHeight; //Field offset: 0xCC
	private int _featureOutWidth; //Field offset: 0xD0
	private int _featureOutHeight; //Field offset: 0xD4
	private int _featureQuality; //Field offset: 0xD8
	private Material _debugMaterial; //Field offset: 0xE0
	private EDLSSPreset _currentNvGfxPreset; //Field offset: 0xE8

	public event Action RenderTexturesAreChanged
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public RenderTexture DepthBuffer
	{
		 get { } //Length: 5
	}

	public RenderTexture MotionVectorsBuffer
	{
		 get { } //Length: 5
	}

	public DLSSWrapper(Material CopyDLSSSourcesMat, Material DebugMaterial) { }

	private DLSSWrapper() { }

	[CompilerGenerated]
	public void add_RenderTexturesAreChanged(Action value) { }

	public void CopyDepthMotion(RenderTexture source, RenderTexture dst, DEPTH_COPY_MODE depthCopyMode, CommandBuffer commandBuffer) { }

	private void DisableCopyDepthKeyword(CommandBuffer cmd, DEPTH_COPY_MODE mode) { }

	private void EnableCopyDepthKeyword(CommandBuffer cmd, DEPTH_COPY_MODE mode) { }

	public RenderTexture get_DepthBuffer() { }

	public RenderTexture get_MotionVectorsBuffer() { }

	private static uint GetCurrentNvGfxPresetExt() { }

	private static IntPtr GetDLSSEvaluateFuncExtInt() { }

	private static int GetDLSSEvaluateLastResult() { }

	private static int InitDLSSExt() { }

	public InitErrors InitializeDLSS() { }

	private void InitializeResourcesIfNeeded(RenderTexture src, RenderTexture dest) { }

	public bool IsDLSSLibraryLoaded() { }

	private static bool IsDLSSLoaded() { }

	public static bool IsDLSSSupported() { }

	private static bool IsHDR() { }

	public static bool ObtainOptimalResolution(int TargetWidth, int TargetHeight, int PerfQualityValue, out int pRecommendedOptimalRenderWidth, out int pRecommendedOptimalRenderHeight, out int pDynamicMaximumRenderSizeHeight, out int pDynamicMinimumRenderSizeHeight, out int pDynamicMaximumRenderSizeWidth, out int pDynamicMinimumRenderSizeWidth, out float pSharpness) { }

	public void OnDestroy() { }

	public void OnRenderImage(RenderTexture src, RenderTexture dest, bool flipOutputUpDown, Vector2 jitterOffset, CommandBuffer externalCommandBuffer) { }

	private static int PrepareHandle() { }

	public static void ReleaseAllHandles() { }

	private static void ReleaseHandleInt(int dlssHandleIdx, out int releaseFeatureResult) { }

	[CompilerGenerated]
	public void remove_RenderTexturesAreChanged(Action value) { }

	private static void SafeReleaseAndDestroy(ref RenderTexture texture) { }

	private static void SetCreateDLSSFeatureParameters(int width, int height, int targetWidth, int targetHeight, int PerfQualityValue) { }

	private static bool SetCurrentNvGfxPresetExt(uint value) { }

	private static void SetDLSSEvaluateParametersExtInt(IntPtr resourceIn, IntPtr resourceOut, IntPtr depth, IntPtr motionVectors, int reset, int viewportWidth, int viewportHeight, float sharpness, float mvScaleX, float mvScaleY, float jitterX, float jitterY, int dlssHandleIdx) { }

	public static void UnloadDLSS() { }

}

