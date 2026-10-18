namespace UnityEngine.Rendering.PostProcessing;

[AddComponentMenu("Rendering/Post-process Layer", 1000)]
[DisallowMultipleComponent]
[ExecuteAlways]
[ImageEffectAllowedInSceneView]
[RequireComponent(typeof(Camera))]
public sealed class PostProcessLayer : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__64_1; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal PostProcessBundle <UpdateBundleSortList>b__64_1(KeyValuePair kvp) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass64_0
	{
		public PostProcessEvent evt; //Field offset: 0x10
		public List effects; //Field offset: 0x18

		public <>c__DisplayClass64_0() { }

		internal bool <UpdateBundleSortList>b__0(KeyValuePair kvp) { }

		internal bool <UpdateBundleSortList>b__2(SerializedBundleRef x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass64_1
	{
		public string searchStr; //Field offset: 0x10

		public <>c__DisplayClass64_1() { }

		internal bool <UpdateBundleSortList>b__3(PostProcessBundle b) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass64_2
	{
		public string typeName; //Field offset: 0x10

		public <>c__DisplayClass64_2() { }

		internal bool <UpdateBundleSortList>b__4(SerializedBundleRef b) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass64_3
	{
		public string typeName; //Field offset: 0x10

		public <>c__DisplayClass64_3() { }

		internal bool <UpdateBundleSortList>b__5(PostProcessBundle b) { }

	}

	internal enum Antialiasing
	{
		None = 0,
		FastApproximateAntialiasing = 1,
		SubpixelMorphologicalAntialiasing = 2,
		TemporalAntialiasing = 3,
	}

	internal sealed class SerializedBundleRef
	{
		public string assemblyQualifiedName; //Field offset: 0x10
		public PostProcessBundle bundle; //Field offset: 0x18

		public SerializedBundleRef() { }

	}

	public static bool EnambleMipStreamingShaderOffset; //Field offset: 0x0
	public Transform volumeTrigger; //Field offset: 0x20
	public LayerMask volumeLayer; //Field offset: 0x28
	public bool stopNaNPropagation; //Field offset: 0x2C
	public bool finalBlitToCameraTarget; //Field offset: 0x2D
	public Antialiasing antialiasingMode; //Field offset: 0x30
	public TemporalAntialiasing temporalAntialiasing; //Field offset: 0x38
	public SubpixelMorphologicalAntialiasing subpixelMorphologicalAntialiasing; //Field offset: 0x40
	public FastApproximateAntialiasing fastApproximateAntialiasing; //Field offset: 0x48
	public Fog fog; //Field offset: 0x50
	private Dithering dithering; //Field offset: 0x58
	public PostProcessDebugLayer debugLayer; //Field offset: 0x60
	public PostProcessLayer masterLayerExposure; //Field offset: 0x68
	private List dependendLayerExposure; //Field offset: 0x70
	public RenderTexture lastExposureTexture; //Field offset: 0x78
	public bool storeLastExposureTexture; //Field offset: 0x80
	public bool computeAutoExposure; //Field offset: 0x81
	private SSAAPropagator _ssaaPropagator; //Field offset: 0x88
	[SerializeField]
	private PostProcessResources m_Resources; //Field offset: 0x90
	[Preserve]
	[SerializeField]
	private bool m_ShowToolkit; //Field offset: 0x98
	[Preserve]
	[SerializeField]
	private bool m_ShowCustomSorter; //Field offset: 0x99
	public bool breakBeforeColorGrading; //Field offset: 0x9A
	[SerializeField]
	private List m_BeforeTransparentBundles; //Field offset: 0xA0
	[SerializeField]
	private List m_BeforeStackBundles; //Field offset: 0xA8
	[SerializeField]
	private List m_AfterStackBundles; //Field offset: 0xB0
	[CompilerGenerated]
	private Dictionary <sortedBundles>k__BackingField; //Field offset: 0xB8
	[CompilerGenerated]
	private DepthTextureMode <cameraDepthFlags>k__BackingField; //Field offset: 0xC0
	[CompilerGenerated]
	private bool <haveBundlesBeenInited>k__BackingField; //Field offset: 0xC4
	private Dictionary m_Bundles; //Field offset: 0xC8
	private PropertySheetFactory m_PropertySheetFactory; //Field offset: 0xD0
	private CommandBuffer m_LegacyCmdBufferBeforeReflections; //Field offset: 0xD8
	private CommandBuffer m_LegacyCmdBufferBeforeLighting; //Field offset: 0xE0
	private CommandBuffer m_LegacyCmdBufferOpaque; //Field offset: 0xE8
	private CommandBuffer m_LegacyCmdBuffer; //Field offset: 0xF0
	private Camera m_Camera; //Field offset: 0xF8
	private PostProcessRenderContext m_CurrentContext; //Field offset: 0x100
	private LogHistogram m_LogHistogram; //Field offset: 0x108
	private bool m_SettingsUpdateNeeded; //Field offset: 0x110
	private bool m_IsRenderingInSceneView; //Field offset: 0x111
	private TargetPool m_TargetPool; //Field offset: 0x118
	private bool m_NaNKilled; //Field offset: 0x120
	private bool isBufferSet; //Field offset: 0x121
	private readonly List m_ActiveEffects; //Field offset: 0x128
	private readonly List m_Targets; //Field offset: 0x130
	private bool _isTAAResolveDisabled; //Field offset: 0x138

	public private DepthTextureMode cameraDepthFlags
	{
		[CompilerGenerated]
		 get { } //Length: 7
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public private bool haveBundlesBeenInited
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public private Dictionary sortedBundles
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	private static PostProcessLayer() { }

	public PostProcessLayer() { }

	public void AddDependedPostProcessExposure(PostProcessLayer pp) { }

	private void ApplyDefaultFlip(MaterialPropertyBlock properties) { }

	private void ApplyFlip(PostProcessRenderContext context, MaterialPropertyBlock properties) { }

	private void Awake() { }

	public void BakeMSVOMap(CommandBuffer cmd, Camera camera, RenderTargetIdentifier destination, Nullable depthMap, bool invert, bool isMSAA = false) { }

	private void BuildCommandBuffers() { }

	public void DisableTAAResolvePass(bool disable) { }

	[CompilerGenerated]
	public DepthTextureMode get_cameraDepthFlags() { }

	[CompilerGenerated]
	public bool get_haveBundlesBeenInited() { }

	[CompilerGenerated]
	public Dictionary get_sortedBundles() { }

	public PostProcessBundle GetBundle(Type settingsType) { }

	public PostProcessBundle GetBundle() { }

	public Vector2 GetPixelJitterValues() { }

	public T GetSettings() { }

	public bool HasActiveEffects(PostProcessEvent evt, PostProcessRenderContext context) { }

	public bool HasOpaqueOnlyEffects(PostProcessRenderContext context) { }

	public void Init(PostProcessResources resources) { }

	public void InitBundles() { }

	private void InitLegacy() { }

	private void OnDestroy() { }

	private void OnDisable() { }

	private void OnEnable() { }

	private void OnPostRender() { }

	private void OnPreCull() { }

	private void OnPreRender() { }

	[ImageEffectUsesCommandBuffer]
	private void OnRenderImage(RenderTexture src, RenderTexture dst) { }

	internal void OverrideSettings(List baseSettings, float interpFactor) { }

	private void ReleaseBundles() { }

	private void RemoveBuffers() { }

	public void Render(PostProcessRenderContext context) { }

	private int RenderBuiltins(PostProcessRenderContext context, bool isFinalPass, int releaseTargetAfterUse = -1, int eye = -1) { }

	private int RenderEffect(PostProcessRenderContext context, bool useTempTarget = false) { }

	private void RenderFinalPass(PostProcessRenderContext context, int releaseTargetAfterUse = -1, int eye = -1) { }

	private int RenderInjectionPoint(PostProcessEvent evt, PostProcessRenderContext context, string marker, int releaseTargetAfterUse = -1) { }

	private void RenderList(List list, PostProcessRenderContext context, string marker) { }

	public void RenderOpaqueOnly(PostProcessRenderContext context) { }

	private static bool RequiresInitialBlit(Camera camera, PostProcessRenderContext context) { }

	private void Reset() { }

	public void ResetHistory() { }

	[CompilerGenerated]
	private void set_cameraDepthFlags(DepthTextureMode value) { }

	[CompilerGenerated]
	private void set_haveBundlesBeenInited(bool value) { }

	[CompilerGenerated]
	private void set_sortedBundles(Dictionary value) { }

	public void SetHighQuality() { }

	private void SetLegacyCameraFlags(PostProcessRenderContext context) { }

	public void SetLowQuality() { }

	private void SetupContext(PostProcessRenderContext context) { }

	private bool ShouldGenerateLogHistogram(PostProcessRenderContext context) { }

	private void UpdateBundleSortList(List sortedList, PostProcessEvent evt) { }

	private void UpdateSrcDstForOpaqueOnly(ref int src, ref int dst, PostProcessRenderContext context, RenderTargetIdentifier cameraTarget, int opaqueOnlyEffectsRemaining) { }

	public void UpdateVolumeSystem(Camera cam, CommandBuffer cmd) { }

}

