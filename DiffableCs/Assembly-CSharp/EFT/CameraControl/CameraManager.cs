namespace EFT.CameraControl;

public sealed class CameraManager : IDisposable
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__126_0; //Field offset: 0x8
		public static Func <>9__142_0; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal bool <RegisterAudioSources>b__142_0(AudioSource t) { }

		internal bool <UpdateUseOcclusionCulling>b__126_0(OcclusionCullingSwitcher switcher) { }

	}

	[CompilerGenerated]
	private sealed class <SetFovCoroutine>d__139 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public float x; //Field offset: 0x20
		public CameraManager <>4__this; //Field offset: 0x28
		public float time; //Field offset: 0x30
		private float <targetFov>5__2; //Field offset: 0x34
		private float <normalTime>5__3; //Field offset: 0x38

		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		[DebuggerHidden]
		public <SetFovCoroutine>d__139(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	internal interface ISettings
	{

		[CanBeNull]
		public Camera CameraPrefab
		{
			 get { } //Length: 0
		}

		[CanBeNull]
		public PostProcessProfile PostProcessProfilePrefab
		{
			 get { } //Length: 0
		}

		[CanBeNull]
		public PrismPreset PrismPresetPrefab
		{
			 get { } //Length: 0
		}

		public Camera get_CameraPrefab() { }

		public PostProcessProfile get_PostProcessProfilePrefab() { }

		public PrismPreset get_PrismPresetPrefab() { }

	}

	private static CameraManager instance; //Field offset: 0x0
	public const float OpticsFov = 35; //Field offset: 0x0
	public const float AimDeltaFov = 15; //Field offset: 0x0
	public const string CAMERA_NAME = "FPS Camera"; //Field offset: 0x0
	private static readonly int _dlssParamsId; //Field offset: 0x8
	[CompilerGenerated]
	private readonly OpticCameraManager <OpticCameraManager>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private EffectsController <EffectsController>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private HideoutCameraFlashlight <Flashlight>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private HighLightMesh <MeshHighlighter>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private VisorEffect <VisorEffect>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	private HysteresisFilter <VisorSwitcher>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	private NightVision <NightVision>k__BackingField; //Field offset: 0x40
	[CompilerGenerated]
	private NightVisionZBlur <NightVisionZBlur>k__BackingField; //Field offset: 0x48
	[CompilerGenerated]
	private ThermalVision <ThermalVision>k__BackingField; //Field offset: 0x50
	[CompilerGenerated]
	private GradingPostFX <PostFX>k__BackingField; //Field offset: 0x58
	[CompilerGenerated]
	private FaceCoverMaskEffect <FaceCoverMask>k__BackingField; //Field offset: 0x60
	[CompilerGenerated]
	private Action OnFovChanged; //Field offset: 0x68
	[CompilerGenerated]
	private Camera <Camera>k__BackingField; //Field offset: 0x70
	[CompilerGenerated]
	private Action OnCameraChanged; //Field offset: 0x78
	[CompilerGenerated]
	private Action OnSuperSamplingChanged; //Field offset: 0x80
	[CompilerGenerated]
	private Action OnAntiAliasingChanged; //Field offset: 0x88
	[CompilerGenerated]
	private Action FoVUpdateAction; //Field offset: 0x90
	[CompilerGenerated]
	private Action ChangeFovCoroutineStarted; //Field offset: 0x98
	[CompilerGenerated]
	private bool <ApplyDovFovOnCamera>k__BackingField; //Field offset: 0xA0
	[CompilerGenerated]
	private float <LaserBeamFovFactor>k__BackingField; //Field offset: 0xA4
	public readonly ReflexController ReflexController; //Field offset: 0xA8
	private CameraLodBiasController _cameraLodBiasController; //Field offset: 0xB0
	private PostProcessVolume _postProcessVolume; //Field offset: 0xB8
	private DepthOfField _depthOfField; //Field offset: 0xC0
	private PostProcessLayer _postProcessLayer; //Field offset: 0xC8
	private CC_Sharpen _ccSharpen; //Field offset: 0xD0
	private HBAO _hbao; //Field offset: 0xD8
	private AmbientOcclusion _ambientOcclusion; //Field offset: 0xE0
	private PrismEffects _prismEffects; //Field offset: 0xE8
	private ChromaticAberration _chromaticAberration; //Field offset: 0xF0
	private float _fov; //Field offset: 0xF8
	private Coroutine _fovCoroutine; //Field offset: 0x100
	private InventoryBlur _blur; //Field offset: 0x108
	private SSAA _ssaa; //Field offset: 0x110
	private SSAAImpl _ssaaImpl; //Field offset: 0x118
	private Nullable _occlusionCullingEnabled; //Field offset: 0x120
	private VolumetricLightRenderer _volumetricLightRenderer; //Field offset: 0x128
	private StreamingController _streamingController; //Field offset: 0x130
	private VRamUsageWrapper _vramWrapper; //Field offset: 0x138
	private Player _player; //Field offset: 0x140
	private ObservedPlayerView _spectatingTarget; //Field offset: 0x148
	private ProceduralWeaponAnimation _opticSightSource; //Field offset: 0x150
	private readonly List _actionsToDispose; //Field offset: 0x158
	private Renderer[] nonLensRenderer; //Field offset: 0x160
	private Renderer[] sightRenderers; //Field offset: 0x168
	private Renderer[] handsRenderers; //Field offset: 0x170

	public event Action ChangeFovCoroutineStarted
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public event Action FoVUpdateAction
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public event Action OnAntiAliasingChanged
	{
		[CompilerGenerated]
		 add { } //Length: 251
		[CompilerGenerated]
		 remove { } //Length: 251
	}

	public event Action OnCameraChanged
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public event Action OnFovChanged
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public event Action OnSuperSamplingChanged
	{
		[CompilerGenerated]
		 add { } //Length: 251
		[CompilerGenerated]
		 remove { } //Length: 251
	}

	public private bool ApplyDovFovOnCamera
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public private Camera Camera
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public DepthOfField DepthOfField
	{
		 get { } //Length: 8
	}

	public private EffectsController EffectsController
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public static bool Exist
	{
		 get { } //Length: 87
	}

	public private FaceCoverMaskEffect FaceCoverMask
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private HideoutCameraFlashlight Flashlight
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public float Fov
	{
		 get { } //Length: 9
		 set { } //Length: 173
	}

	public static CameraManager Instance
	{
		 get { } //Length: 701
	}

	public bool IsActive
	{
		 get { } //Length: 162
		 set { } //Length: 178
	}

	public bool IsOcclusionCullingAllowed
	{
		 get { } //Length: 83
	}

	public float LaserBeamFovFactor
	{
		[CompilerGenerated]
		 get { } //Length: 9
		[CompilerGenerated]
		 set { } //Length: 9
	}

	public private HighLightMesh MeshHighlighter
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private NightVision NightVision
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private NightVisionZBlur NightVisionZBlur
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public OpticCameraManager OpticCameraManager
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public private GradingPostFX PostFX
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public SSAA SSAA
	{
		 get { } //Length: 8
	}

	public private ThermalVision ThermalVision
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private VisorEffect VisorEffect
	{
		[CompilerGenerated]
		 get { } //Length: 76
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private HysteresisFilter VisorSwitcher
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public VolumetricLightRenderer VolumetricLightRenderer
	{
		 get { } //Length: 8
	}

	private static CameraManager() { }

	public CameraManager() { }

	[CompilerGenerated]
	private void <InitCamera>b__134_0() { }

	[CompilerGenerated]
	private void <InitCamera>b__134_1(float x) { }

	[CompilerGenerated]
	private void <InitCamera>b__134_2(int x) { }

	[CompilerGenerated]
	public void add_ChangeFovCoroutineStarted(Action value) { }

	[CompilerGenerated]
	public void add_FoVUpdateAction(Action value) { }

	[CompilerGenerated]
	public void add_OnAntiAliasingChanged(Action value) { }

	[CompilerGenerated]
	public void add_OnCameraChanged(Action value) { }

	[CompilerGenerated]
	public void add_OnFovChanged(Action value) { }

	[CompilerGenerated]
	public void add_OnSuperSamplingChanged(Action value) { }

	private void ApplyFoV(int fov, int minFov, int maxFov) { }

	public void Blur(bool isActive, float time = 0.5) { }

	private void CollectOpticSightRenderers() { }

	private void DestroyCameraComponent() { }

	public override void Dispose() { }

	private void DisposeAfterPostFxDestroy() { }

	public float Distance(Vector3 position) { }

	public void EnableAutoExposure(bool flag) { }

	public void ForceSetPosition(Vector3 position) { }

	[CompilerGenerated]
	public bool get_ApplyDovFovOnCamera() { }

	[CompilerGenerated]
	public Camera get_Camera() { }

	public DepthOfField get_DepthOfField() { }

	[CompilerGenerated]
	public EffectsController get_EffectsController() { }

	public static bool get_Exist() { }

	[CompilerGenerated]
	public FaceCoverMaskEffect get_FaceCoverMask() { }

	[CompilerGenerated]
	public HideoutCameraFlashlight get_Flashlight() { }

	public float get_Fov() { }

	public static CameraManager get_Instance() { }

	public bool get_IsActive() { }

	public bool get_IsOcclusionCullingAllowed() { }

	[CompilerGenerated]
	public float get_LaserBeamFovFactor() { }

	[CompilerGenerated]
	public HighLightMesh get_MeshHighlighter() { }

	[CompilerGenerated]
	public NightVision get_NightVision() { }

	[CompilerGenerated]
	public NightVisionZBlur get_NightVisionZBlur() { }

	[CompilerGenerated]
	public OpticCameraManager get_OpticCameraManager() { }

	[CompilerGenerated]
	public GradingPostFX get_PostFX() { }

	public SSAA get_SSAA() { }

	[CompilerGenerated]
	public ThermalVision get_ThermalVision() { }

	[CompilerGenerated]
	public VisorEffect get_VisorEffect() { }

	[CompilerGenerated]
	public HysteresisFilter get_VisorSwitcher() { }

	public VolumetricLightRenderer get_VolumetricLightRenderer() { }

	private OpticSight GetCurrentOpticSight() { }

	public bool GetSSREnabled() { }

	public void GetVRamUsage(out ulong totalVRam, out ulong localBudget, out ulong localCurrentUsage) { }

	public float IncreaseStreamingMipMapBias(float bias) { }

	private void InitCamera() { }

	private bool IsSightRenderer(int instanceId) { }

	private void OnCurrentOpticUpdate(bool isAiming) { }

	private void OpticCameraManagerOnCollimatorDisabled(CollimatorSight sight) { }

	private void OpticCameraManagerOnCollimatorUpdated(CollimatorSight sight) { }

	private void OpticCameraManagerOnOpticDisabled() { }

	private void OpticCameraManagerOnOpticEnabled() { }

	private void OpticCameraManagerOnOpticTexturesAreChanged(Texture depthBuffer, Texture mvBuffer) { }

	private void RefreshCurrentOpticSight() { }

	private void RegisterAudioSources() { }

	[CompilerGenerated]
	public void remove_ChangeFovCoroutineStarted(Action value) { }

	[CompilerGenerated]
	public void remove_FoVUpdateAction(Action value) { }

	[CompilerGenerated]
	public void remove_OnAntiAliasingChanged(Action value) { }

	[CompilerGenerated]
	public void remove_OnCameraChanged(Action value) { }

	[CompilerGenerated]
	public void remove_OnFovChanged(Action value) { }

	[CompilerGenerated]
	public void remove_OnSuperSamplingChanged(Action value) { }

	private void Reset() { }

	[CompilerGenerated]
	private void set_ApplyDovFovOnCamera(bool value) { }

	[CompilerGenerated]
	private void set_Camera(Camera value) { }

	[CompilerGenerated]
	private void set_EffectsController(EffectsController value) { }

	[CompilerGenerated]
	private void set_FaceCoverMask(FaceCoverMaskEffect value) { }

	[CompilerGenerated]
	private void set_Flashlight(HideoutCameraFlashlight value) { }

	public void set_Fov(float value) { }

	public void set_IsActive(bool value) { }

	[CompilerGenerated]
	public void set_LaserBeamFovFactor(float value) { }

	[CompilerGenerated]
	private void set_MeshHighlighter(HighLightMesh value) { }

	[CompilerGenerated]
	private void set_NightVision(NightVision value) { }

	[CompilerGenerated]
	private void set_NightVisionZBlur(NightVisionZBlur value) { }

	[CompilerGenerated]
	private void set_PostFX(GradingPostFX value) { }

	[CompilerGenerated]
	private void set_ThermalVision(ThermalVision value) { }

	[CompilerGenerated]
	private void set_VisorEffect(VisorEffect value) { }

	[CompilerGenerated]
	private void set_VisorSwitcher(HysteresisFilter value) { }

	public void SetAntiAliasing(EAntialiasingMode quality, EDLSSMode dlssMode, EFSR2Mode fsr2Mode, EFSR3Mode fsr3Mode) { }

	public void SetAspectRatio(float division) { }

	public void SetCamera(Camera camera) { }

	public void SetCameraFromPrefab(GameObject cameraPrefab = null, PrismPreset prismPreset = null, PostProcessProfile postProcessProfile = null) { }

	public void SetCameraFromSettings(ISettings settings) { }

	public void SetChromaticAberration(bool enabled) { }

	public void SetDLSSPreset(EDLSSPreset preset) { }

	private void SetDoFFocalDistance(int fov, float minFov = 55, float maxFov = 75) { }

	public void SetFov(float x, float time, bool applyFovOnCamera = true) { }

	public void SetFov(float targetFov) { }

	[IteratorStateMachine(typeof(<SetFovCoroutine>d__139))]
	private IEnumerator SetFovCoroutine(float x, float time) { }

	public void SetFSR(EFSRMode fsrMode) { }

	public void SetFSR2(EFSR2Mode fsr2Mode) { }

	public void SetFSR3(EFSR3Mode fsr3Mode) { }

	public void SetMipStreamingBufferSize(int size) { }

	public void SetMipStreamingIOCount(int count) { }

	public void SetNoise(bool useNoise) { }

	public void SetOcclusionCullingEnabled(Nullable value) { }

	public void SetOverallVisibility(float range) { }

	public void SetPlayer(Player player) { }

	private void SetPostProcessProfile(Camera camera, PostProcessProfile postProcessProfile) { }

	private static void SetPrismPreset(Camera camera, PrismPreset prismPreset) { }

	public void SetSharpen(float strength) { }

	public void SetSpectatingTarget(ObservedPlayerView target) { }

	public void SetSSAO(ESSAOMode ssaoMode) { }

	public void SetSSR(ESSRMode ssrMode) { }

	public void SetSuperSampling(float sampling) { }

	public void SetZBlur(bool enable) { }

	public float SqrDistance(Vector3 position) { }

	public float SqrDistanceWithZero(Vector3 position) { }

	private void UpdateOpticSightSource() { }

	private void UpdateStreamingMipmapBias() { }

	public void UpdateUseOcclusionCulling() { }

}

