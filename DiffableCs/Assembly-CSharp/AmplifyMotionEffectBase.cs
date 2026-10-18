//Type is in global namespace

[AddComponentMenu(null)]
[RequireComponent(typeof(Camera))]
public class AmplifyMotionEffectBase : MonoBehaviour
{
	private const CameraEvent m_fixedUpdateCBEvent = 12; //Field offset: 0x0
	private const CameraEvent m_updateCBEvent = 12; //Field offset: 0x0
	public static Dictionary m_activeObjects; //Field offset: 0x0
	public static Dictionary m_activeCameras; //Field offset: 0x8
	private static bool m_isD3D; //Field offset: 0x10
	private static bool m_ignoreMotionScaleWarning; //Field offset: 0x11
	private static AmplifyMotionEffectBase m_firstInstance; //Field offset: 0x18
	[Header("Motion Blur")]
	public Quality QualityLevel; //Field offset: 0x20
	public int QualitySteps; //Field offset: 0x24
	public float MotionScale; //Field offset: 0x28
	public float CameraMotionMult; //Field offset: 0x2C
	public float MinVelocity; //Field offset: 0x30
	public float MaxVelocity; //Field offset: 0x34
	public float DepthThreshold; //Field offset: 0x38
	public bool Noise; //Field offset: 0x3C
	[Header("Camera")]
	public Camera[] OverlayCameras; //Field offset: 0x40
	public LayerMask CullingMask; //Field offset: 0x48
	[Header("Objects")]
	public bool AutoRegisterObjs; //Field offset: 0x4C
	public float MinResetDeltaDist; //Field offset: 0x50
	public float MinResetDeltaDistSqr; //Field offset: 0x54
	public int ResetFrameDelay; //Field offset: 0x58
	[FormerlySerializedAs("workerThreads")]
	[Header("Low-Level")]
	public int WorkerThreads; //Field offset: 0x5C
	public bool SystemThreadPool; //Field offset: 0x60
	public bool ForceCPUOnly; //Field offset: 0x61
	public bool DebugMode; //Field offset: 0x62
	private Camera m_camera; //Field offset: 0x68
	private bool m_starting; //Field offset: 0x70
	private int m_width; //Field offset: 0x74
	private int m_height; //Field offset: 0x78
	private RenderTexture m_motionRT; //Field offset: 0x80
	private Material m_blurMaterial; //Field offset: 0x88
	private Material m_solidVectorsMaterial; //Field offset: 0x90
	private Material m_skinnedVectorsMaterial; //Field offset: 0x98
	private Material m_clothVectorsMaterial; //Field offset: 0xA0
	private Material m_reprojectionMaterial; //Field offset: 0xA8
	private Material m_combineMaterial; //Field offset: 0xB0
	private Material m_dilationMaterial; //Field offset: 0xB8
	private Material m_depthMaterial; //Field offset: 0xC0
	private Material m_debugMaterial; //Field offset: 0xC8
	private Dictionary m_linkedCameras; //Field offset: 0xD0
	internal Camera[] m_linkedCameraKeys; //Field offset: 0xD8
	internal AmplifyMotionCamera[] m_linkedCameraValues; //Field offset: 0xE0
	internal bool m_linkedCamerasChanged; //Field offset: 0xE8
	private AmplifyMotionPostProcess m_currentPostProcess; //Field offset: 0xF0
	private int m_globalObjectId; //Field offset: 0xF8
	private float m_deltaTime; //Field offset: 0xFC
	private float m_fixedDeltaTime; //Field offset: 0x100
	private float m_motionScaleNorm; //Field offset: 0x104
	private float m_fixedMotionScaleNorm; //Field offset: 0x108
	private Quality m_qualityLevel; //Field offset: 0x10C
	private AmplifyMotionCamera m_baseCamera; //Field offset: 0x110
	private WorkerThreadPool m_workerThreadPool; //Field offset: 0x118
	private bool m_canUseGPU; //Field offset: 0x120
	private CommandBuffer m_updateCB; //Field offset: 0x128
	private CommandBuffer m_fixedUpdateCB; //Field offset: 0x130

	public AmplifyMotionCamera BaseCamera
	{
		 get { } //Length: 8
	}

	public bool CanUseGPU
	{
		 get { } //Length: 8
	}

	internal Material ClothVectorsMaterial
	{
		internal get { } //Length: 8
	}

	public static AmplifyMotionEffectBase FirstInstance
	{
		 get { } //Length: 84
	}

	internal float FixedMotionScaleNorm
	{
		internal get { } //Length: 9
	}

	public static bool IgnoreMotionScaleWarning
	{
		 get { } //Length: 84
	}

	public static AmplifyMotionEffectBase Instance
	{
		 get { } //Length: 84
	}

	public static bool IsD3D
	{
		 get { } //Length: 84
	}

	public Dictionary LinkedCameras
	{
		 get { } //Length: 8
	}

	internal RenderTexture MotionRenderTexture
	{
		internal get { } //Length: 8
	}

	internal float MotionScaleNorm
	{
		internal get { } //Length: 9
	}

	internal Material ReprojectionMaterial
	{
		internal get { } //Length: 8
	}

	internal Material SkinnedVectorsMaterial
	{
		internal get { } //Length: 8
	}

	internal Material SolidVectorsMaterial
	{
		internal get { } //Length: 8
	}

	internal WorkerThreadPool WorkerPool
	{
		internal get { } //Length: 8
	}

	[Obsolete("workerThreads is deprecated, please use WorkerThreads instead.")]
	public int workerThreads
	{
		 get { } //Length: 4
		 set { } //Length: 4
	}

	private static AmplifyMotionEffectBase() { }

	public AmplifyMotionEffectBase() { }

	private void ApplyMotionBlur(RenderTexture source, RenderTexture destination, Vector4 blurStep) { }

	private void Awake() { }

	internal static bool CanRegister(GameObject gameObj, bool autoReg) { }

	private bool CheckMaterialAndShader(Material material, string name) { }

	public bool CheckSupport() { }

	private bool CreateMaterials() { }

	private RenderTexture CreateRenderTexture(string name, int depth, RenderTextureFormat fmt, RenderTextureReadWrite rw, FilterMode fm) { }

	private void DestroyMaterials() { }

	private void DestroyRenderTextures() { }

	internal static bool FindValidTag(Material[] materials) { }

	private void FixedUpdate() { }

	internal int GenerateObjectId(GameObject obj) { }

	public AmplifyMotionCamera get_BaseCamera() { }

	public bool get_CanUseGPU() { }

	internal Material get_ClothVectorsMaterial() { }

	public static AmplifyMotionEffectBase get_FirstInstance() { }

	internal float get_FixedMotionScaleNorm() { }

	public static bool get_IgnoreMotionScaleWarning() { }

	public static AmplifyMotionEffectBase get_Instance() { }

	public static bool get_IsD3D() { }

	public Dictionary get_LinkedCameras() { }

	internal RenderTexture get_MotionRenderTexture() { }

	internal float get_MotionScaleNorm() { }

	internal Material get_ReprojectionMaterial() { }

	internal Material get_SkinnedVectorsMaterial() { }

	internal Material get_SolidVectorsMaterial() { }

	internal WorkerThreadPool get_WorkerPool() { }

	public int get_workerThreads() { }

	private void InitializeCameras() { }

	private void InitializeCommandBuffers() { }

	private void InitializeThreadPool() { }

	private void LateUpdate() { }

	private void OnDestroy() { }

	private void OnDisable() { }

	private void OnEnable() { }

	private void OnPostRender() { }

	private void OnPreRender() { }

	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	public void PostProcess(RenderTexture source, RenderTexture destination) { }

	private GameObject RecursiveFindCamera(GameObject obj, string auxCameraName) { }

	public void Register(GameObject gameObj) { }

	internal static void RegisterCamera(AmplifyMotionCamera cam) { }

	internal static void RegisterObject(AmplifyMotionObjectBase obj) { }

	public void RegisterRecursively(GameObject gameObj) { }

	public static void RegisterRecursivelyS(GameObject gameObj) { }

	public static void RegisterS(GameObject gameObj) { }

	internal void RemoveCamera(Camera reference) { }

	internal void ResetObjectId() { }

	private void SafeDestroyMaterial(ref Material mat) { }

	private void SafeDestroyRenderTexture(ref RenderTexture rt) { }

	private void SafeDestroyTexture(ref Texture tex) { }

	public void set_workerThreads(int value) { }

	private void ShutdownCommandBuffers() { }

	private void ShutdownThreadPool() { }

	private void Start() { }

	public void StartAutoStep() { }

	public void Step(float delta) { }

	public void StopAutoStep() { }

	internal static void TryRegister(GameObject gameObj, bool autoReg) { }

	internal static void TryUnregister(GameObject gameObj) { }

	public void Unregister(GameObject gameObj) { }

	internal static void UnregisterCamera(AmplifyMotionCamera cam) { }

	internal static void UnregisterObject(AmplifyMotionObjectBase obj) { }

	public void UnregisterRecursively(GameObject gameObj) { }

	public static void UnregisterRecursivelyS(GameObject gameObj) { }

	public static void UnregisterS(GameObject gameObj) { }

	public void UpdateActiveCameras() { }

	public void UpdateActiveObjects() { }

	private void UpdateLinkedCameras() { }

	private void UpdatePostProcess() { }

	private void UpdateRenderTextures(bool qualityChanged) { }

}

