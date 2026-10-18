//Type is in global namespace

[AddComponentMenu(null)]
[RequireComponent(typeof(Camera))]
public class AmplifyMotionCamera : MonoBehaviour
{
	private const CameraEvent m_renderCBEvent = 18; //Field offset: 0x0
	internal AmplifyMotionEffectBase Instance; //Field offset: 0x20
	internal Matrix4x4 PrevViewProjMatrix; //Field offset: 0x28
	internal Matrix4x4 ViewProjMatrix; //Field offset: 0x68
	internal Matrix4x4 InvViewProjMatrix; //Field offset: 0xA8
	internal Matrix4x4 PrevViewProjMatrixRT; //Field offset: 0xE8
	internal Matrix4x4 ViewProjMatrixRT; //Field offset: 0x128
	internal Transform Transform; //Field offset: 0x168
	private bool m_linked; //Field offset: 0x170
	private bool m_initialized; //Field offset: 0x171
	private bool m_starting; //Field offset: 0x172
	private bool m_autoStep; //Field offset: 0x173
	private bool m_step; //Field offset: 0x174
	private bool m_overlay; //Field offset: 0x175
	private Camera m_camera; //Field offset: 0x178
	private int m_prevFrameCount; //Field offset: 0x180
	private HashSet m_affectedObjectsTable; //Field offset: 0x188
	private AmplifyMotionObjectBase[] m_affectedObjects; //Field offset: 0x190
	private bool m_affectedObjectsChanged; //Field offset: 0x198
	private CommandBuffer m_renderCB; //Field offset: 0x1A0

	public bool AutoStep
	{
		 get { } //Length: 8
	}

	public Camera Camera
	{
		 get { } //Length: 8
	}

	public bool Initialized
	{
		 get { } //Length: 8
	}

	public bool Overlay
	{
		 get { } //Length: 8
	}

	public AmplifyMotionCamera() { }

	private void Awake() { }

	public void FixedUpdateTransform(AmplifyMotionEffectBase inst, CommandBuffer updateCB) { }

	public bool get_AutoStep() { }

	public Camera get_Camera() { }

	public bool get_Initialized() { }

	public bool get_Overlay() { }

	public void Initialize() { }

	private void InitializeCommandBuffers() { }

	public void LinkTo(AmplifyMotionEffectBase instance, bool overlay) { }

	private void OnDestroy() { }

	private void OnDisable() { }

	private void OnEnable() { }

	public void PreRenderVectors(RenderTexture motionRT, bool clearColor, float rcpDepthThreshold) { }

	public void RegisterObject(AmplifyMotionObjectBase obj) { }

	public void RenderReprojectionVectors(RenderTexture destination, float scale) { }

	public void RenderVectors(float scale, float fixedScale, Quality quality) { }

	private void ShutdownCommandBuffers() { }

	public void StartAutoStep() { }

	public void Step() { }

	public void StopAutoStep() { }

	public void UnregisterObject(AmplifyMotionObjectBase obj) { }

	private void Update() { }

	private void UpdateAffectedObjects() { }

	private void UpdateMatrices() { }

	public void UpdateTransform(AmplifyMotionEffectBase inst, CommandBuffer updateCB) { }

}

