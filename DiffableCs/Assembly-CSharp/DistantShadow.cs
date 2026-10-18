//Type is in global namespace

[ExecuteInEditMode]
public class DistantShadow : MonoBehaviour
{
	private class CachedParameters
	{
		public Vector3 _cachedLightDirection; //Field offset: 0x10
		public Vector3 _cachedShadowCameraPosition; //Field offset: 0x1C
		public Vector3 _cachedShadowCameraForward; //Field offset: 0x28
		public Vector3 _cachedShadowCameraRight; //Field offset: 0x34
		public Vector3 _cachedShadowCameraUp; //Field offset: 0x40
		public Matrix4x4 _cachedGlobalShadowWorldToScreen; //Field offset: 0x4C
		public Matrix4x4 _cachedGlobalShadowWorldToView; //Field offset: 0x8C
		public Matrix4x4 _cachedGlobalShadowProjGPU; //Field offset: 0xCC
		public Matrix4x4 _cachedGlobalShadowProj; //Field offset: 0x10C
		public float _cachedNearPlane; //Field offset: 0x14C
		public float _cachedFarPlane; //Field offset: 0x150
		public bool _buffersDataIsPropagated; //Field offset: 0x154
		public Matrix4x4[] _cachedGlobalShadowWorldToScreenData; //Field offset: 0x158
		public Matrix4x4[] _cachedGlobalShadowWorldToViewData; //Field offset: 0x160
		public Matrix4x4[] _cachedGlobalShadowProjData; //Field offset: 0x168
		public Vector4[] _cachedOffsetScaleData; //Field offset: 0x170
		public ComputeBuffer _cachedGlobalShadowWorldToScreenBuffer; //Field offset: 0x178
		public ComputeBuffer _cachedGlobalShadowWorldToViewBuffer; //Field offset: 0x180
		public ComputeBuffer _cachedGlobalShadowProjBuffer; //Field offset: 0x188
		public ComputeBuffer _cachedOffsetScaleBuffer; //Field offset: 0x190

		public CachedParameters() { }

	}

	private class DrawRecord
	{
		public Mesh mesh; //Field offset: 0x10
		public Material material; //Field offset: 0x18
		public int submeshIdx; //Field offset: 0x20
		public Matrix4x4 drawTransform; //Field offset: 0x24

		public DrawRecord() { }

	}

	internal enum ResolutionState
	{
		QUARTER = 0,
		HALF = 1,
		FULL = 2,
	}

	private static readonly int GLOBAL_SHADOW_SAMPLED_TEXTURE_ID; //Field offset: 0x0
	private const GraphicsFormat ShadowMaskFormat = 5; //Field offset: 0x0
	private const int HaltonOffsetsCount = 25; //Field offset: 0x0
	private const GraphicsFormat LowResDepthFormat = 49; //Field offset: 0x0
	private const float ParallaxSearchMulFadeInTime = 10; //Field offset: 0x0
	private static readonly int GLOBAL_SHADOW_WORLD_TO_SCREEN_MTRX_ID; //Field offset: 0x4
	private static readonly int GLOBAL_SHADOW_WORLD_TO_VIEW_MTRX_ID; //Field offset: 0x8
	private static readonly int GLOBAL_SHADOW_PROJECTION_MTRX_ID; //Field offset: 0xC
	private static readonly int GLOBAL_SHADOW_SETTINGS_VEC_ID; //Field offset: 0x10
	private static readonly int GLOBAL_SHADOW_SAMPLED_2_TEXTURE_ID; //Field offset: 0x14
	private static readonly int GLOBAL_SHADOW_WORLD_TO_SCREEN_2_MTRX_ID; //Field offset: 0x18
	private static readonly int GLOBAL_SHADOW_WORLD_TO_VIEW_2_MTRX_ID; //Field offset: 0x1C
	private static readonly int GLOBAL_SHADOW_PROJECTION_2_MTRX_ID; //Field offset: 0x20
	private static readonly int GLOBAL_SHADOW_PROJ_VEC_ID; //Field offset: 0x24
	private static readonly int GLOBALSHADOWTEXELSIZE_VEC_ID; //Field offset: 0x28
	private static readonly int DEBUGPARAMS_VEC_ID; //Field offset: 0x2C
	private static readonly int GLOBALSHADOWL0_VEC_ID; //Field offset: 0x30
	private static readonly int GLOBALSHADOWL1_VEC_ID; //Field offset: 0x34
	private static readonly int PARALLAXSEARCHMUL_FLOAT_ID; //Field offset: 0x38
	private static readonly int DEPTHTEXTURE_TEXELSIZE_VEC_ID; //Field offset: 0x3C
	private static readonly int GLOBALSHADOWL0_OLD_VEC_ID; //Field offset: 0x40
	private static readonly int HALTONOFFSETS_BUFF_ID; //Field offset: 0x44
	private static readonly int SHADOWMASKLOWRES_TEXTURE_ID; //Field offset: 0x48
	private static readonly int BLURMASK_TEXTURE_ID; //Field offset: 0x4C
	private static readonly int MAINTEX_TEXTURE_ID; //Field offset: 0x50
	private static readonly int PRECOMPUTEDGLOBALSHADOW_TEXTURE_ID; //Field offset: 0x54
	private static readonly int _lowresdepth_TEXTURE_ID; //Field offset: 0x58
	private static readonly int DSBlurThreshold_FLOAT_ID; //Field offset: 0x5C
	public static int ObjectsToRenderInfo; //Field offset: 0x60
	public static int ObjectsToRenderPerFrameInfo; //Field offset: 0x64
	public static float LastTimeToUpdateInfo; //Field offset: 0x68
	public Camera MasterCamera; //Field offset: 0x20
	private SSAA m_ssaa; //Field offset: 0x28
	public bool EnableShadowsBlend; //Field offset: 0x30
	public bool EnableAdaptiveBias; //Field offset: 0x31
	public float AdaptiveBiasK; //Field offset: 0x34
	public float ConstantBias; //Field offset: 0x38
	public float PCFShift; //Field offset: 0x3C
	public int ShadowPixelsSize; //Field offset: 0x40
	public bool DisableWind; //Field offset: 0x44
	public bool ShouldApplySettings; //Field offset: 0x45
	public float GlobalShadowHalfSize; //Field offset: 0x48
	public float OffsetTowardsLight; //Field offset: 0x4C
	public float BlendTime; //Field offset: 0x50
	public float LightDirectionExtrapolateFactor; //Field offset: 0x54
	public float ObjectSizeFilter; //Field offset: 0x58
	public bool FixGlowEffect; //Field offset: 0x5C
	public bool EnableDistantShadowKeyword; //Field offset: 0x5D
	public bool EnableDistantShadowPCF; //Field offset: 0x5E
	public bool EnableMultiviewTiles; //Field offset: 0x5F
	public bool EnablePCFShift; //Field offset: 0x60
	public bool ReduceBlurSamples; //Field offset: 0x61
	public float BlurDepthThreshold; //Field offset: 0x64
	public bool InvalidateRenderersOnNextUpdate; //Field offset: 0x68
	private float SunAltSpeed; //Field offset: 0x6C
	private float SunAltCosine; //Field offset: 0x70
	private float SunDeltaTime; //Field offset: 0x74
	private bool IsSunAltSpeedInitialized; //Field offset: 0x78
	public bool PreComputeMask; //Field offset: 0x79
	public bool EnableShadowmaskBlur; //Field offset: 0x7A
	public bool EnableBlurMask; //Field offset: 0x7B
	public bool EnableParallax; //Field offset: 0x7C
	private float ParallaxSearchMul; //Field offset: 0x80
	private bool AutoParallaxSearchMul; //Field offset: 0x84
	[Range(0.01, 1)]
	private float AutoMulChangeSpeed; //Field offset: 0x88
	public float LastTimeToUpdate; //Field offset: 0x8C
	private float _weatherUpdateTime; //Field offset: 0x90
	public float NearPlane; //Field offset: 0x94
	public float FarPlane; //Field offset: 0x98
	public int ObjectsPerFrame; //Field offset: 0x9C
	private int WarmupFramesCount; //Field offset: 0xA0
	private int PostWarmupFramesCount; //Field offset: 0xA4
	private float ParallaxSearchMulFadeInTimeCur; //Field offset: 0xA8
	public bool UseGaussDistribution; //Field offset: 0xAC
	public float SamplingRotation; //Field offset: 0xB0
	private uint ImpostorsPerFrame; //Field offset: 0xB4
	private CommandBuffer _renderObjectsCmdBuf; //Field offset: 0xB8
	private CommandBuffer _afterShadowCmdBuf; //Field offset: 0xC0
	private CommandBuffer _disableKeywordsCmdBuf; //Field offset: 0xC8
	private CommandBuffer _enableKeywordsCmdBuf; //Field offset: 0xD0
	private CommandBuffer _disableOpticKeywordsCmdBuf; //Field offset: 0xD8
	private CommandBuffer _enableOpticKeywordsCmdBuf; //Field offset: 0xE0
	private CommandBuffer _computeMaskCmdBuf; //Field offset: 0xE8
	private CommandBuffer _computeMaskOpticCmdBuf; //Field offset: 0xF0
	private RenderTexture _lowResDepth; //Field offset: 0xF8
	private RenderTexture _lowResDepthOptic; //Field offset: 0x100
	private RenderTexture _shadowMaskQuarter; //Field offset: 0x108
	private RenderTexture _shadowMaskQuarterOptic; //Field offset: 0x110
	private RenderTexture _blurMask; //Field offset: 0x118
	private RenderTexture _blurMaskOptic; //Field offset: 0x120
	private RenderTexture _shadowMaskFull; //Field offset: 0x128
	private RenderTexture _shadowMaskFullBuf; //Field offset: 0x130
	private RenderTexture _shadowMaskFullOptic; //Field offset: 0x138
	private RenderTexture _shadowMaskFullOpticBuf; //Field offset: 0x140
	private ComputeBuffer _haltonOffsetsBuffer; //Field offset: 0x148
	private int _activeShadowDepthTextureOld; //Field offset: 0x150
	private int _activeShadowDepthTexture; //Field offset: 0x154
	private int _activeRenderDepthTexture; //Field offset: 0x158
	private float _currentBlendTime; //Field offset: 0x15C
	private int _objectsToRenderCount; //Field offset: 0x160
	private int _impostorsToRenderCount; //Field offset: 0x164
	private string BlendKeyword; //Field offset: 0x168
	private string AdaptiveDepthBiasKeyword; //Field offset: 0x170
	private string DistantShadowKeyword; //Field offset: 0x178
	private string DistantShadowPCFKeyword; //Field offset: 0x180
	private string MultiprojectionKeyword; //Field offset: 0x188
	private string PCFShiftKeyword; //Field offset: 0x190
	private string DisableWindKeyword; //Field offset: 0x198
	private string RenderForScopeKeyword; //Field offset: 0x1A0
	private string UseGaussianKeyword; //Field offset: 0x1A8
	private string PreComputeMaskKeyword; //Field offset: 0x1B0
	private string EnableParallaxKeyword; //Field offset: 0x1B8
	private string ReduceSamplesKeyword; //Field offset: 0x1C0
	private string BlurMaskKeyword; //Field offset: 0x1C8
	private string DistantShadowFixGlow; //Field offset: 0x1D0
	private int id; //Field offset: 0x1D8
	private Camera _opticCamera; //Field offset: 0x1E0
	public ResolutionState CurrentMaskResolution; //Field offset: 0x1E8
	private int _lowResDepthScale; //Field offset: 0x1EC
	private List CameraParametersCache; //Field offset: 0x1F0
	private float _startShadowmapRenderTime; //Field offset: 0x1F8
	private float _fullShadowmapRenderTime; //Field offset: 0x1FC
	private Vector3 _lightDirection; //Field offset: 0x200
	private RenderTexture[] _depthRTs; //Field offset: 0x210
	private int _depthRTsCount; //Field offset: 0x218
	private RenderTexture _currentTargetTexture; //Field offset: 0x220
	private List _renderList; //Field offset: 0x228
	private MaterialPropertyBlock _mpb0; //Field offset: 0x230
	private MaterialPropertyBlock _mpb1; //Field offset: 0x238
	public Material DownscaleDepthMaterial; //Field offset: 0x240
	public Material ComputeShadowMaskMaterial; //Field offset: 0x248
	public Material UpscaleShadowMaskMaterial; //Field offset: 0x250
	public Material ShadowMaskBlurMaterial; //Field offset: 0x258
	private Mesh mesh; //Field offset: 0x260

	private float GetFarPlane
	{
		private get { } //Length: 250
	}

	private float GetOffsetTowardsLight
	{
		private get { } //Length: 247
	}

	public RenderTexture LowResDepth
	{
		 get { } //Length: 8
	}

	private static DistantShadow() { }

	public DistantShadow() { }

	private void ApplySettings() { }

	private void Awake() { }

	private void CacheParameters(int idx) { }

	private bool CheckCommandBuffers() { }

	private void CheckDepthRenderTextures() { }

	private float ComputeParallaxSearchMul(double angleCosSpeed, double angleCos) { }

	private RenderTexture CreateRenderTexture(RenderTexture initialRenderTexture, int width, int height, string name, GraphicsFormat format, bool UAV = false, int depth = 0) { }

	private RenderTexture CreateRenderTexture(RenderTexture initialRenderTexture, int width, int height, string name, RenderTextureFormat format, bool UAV = false, int depth = 0) { }

	private void DestroyRenderTexture(RenderTexture renderTexture) { }

	public void DisableFeature() { }

	private void DisableKeywords(CommandBuffer cmdBuf) { }

	public void EnableFeature() { }

	public static List FindObjectsOfTypeAll() { }

	private int FullResHeight() { }

	private int FullResWidth() { }

	private float get_GetFarPlane() { }

	private float get_GetOffsetTowardsLight() { }

	public RenderTexture get_LowResDepth() { }

	private Matrix4x4 GetOrthoMatrix() { }

	private int InvalidateRenderers() { }

	private void OnDestroy() { }

	private void SetupComputeShadowMaskCommandBuffer(CommandBuffer cmdBuf, int targetIdx, int targetIdxOld, Vector4 GlobalShadowProj, Vector4 TextureParams, Rect lowResViewport, Rect fullResViewport, ResolutionState resState, RenderTexture lowResDepth, RenderTexture lowResShadowMask, RenderTexture blurMask, RenderTexture hiResShadowMask, RenderTexture hiResShadowMaskBuf) { }

	private void SetupKeywords(CommandBuffer cmdBuf, bool opticCamera) { }

	private void Update() { }

	private void UpdateTransformations() { }

	public void WarmupForFrames(int frames) { }

}

