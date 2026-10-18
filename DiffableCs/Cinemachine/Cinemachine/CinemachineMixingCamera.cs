namespace Cinemachine;

[AddComponentMenu("Cinemachine/CinemachineMixingCamera")]
[DisallowMultipleComponent]
[DocumentationSorting(Level::UserRef (2))]
[ExcludeFromPreset]
[ExecuteAlways]
[HelpURL("https://docs.unity3d.com/Packages/com.unity.cinemachine@2.9/manual/CinemachineMixingCamera.html")]
public class CinemachineMixingCamera : CinemachineVirtualCameraBase
{
	public const int MaxCameras = 8; //Field offset: 0x0
	[Tooltip("The weight of the first tracked camera")]
	public float m_Weight0; //Field offset: 0xA8
	[Tooltip("The weight of the second tracked camera")]
	public float m_Weight1; //Field offset: 0xAC
	[Tooltip("The weight of the third tracked camera")]
	public float m_Weight2; //Field offset: 0xB0
	[Tooltip("The weight of the fourth tracked camera")]
	public float m_Weight3; //Field offset: 0xB4
	[Tooltip("The weight of the fifth tracked camera")]
	public float m_Weight4; //Field offset: 0xB8
	[Tooltip("The weight of the sixth tracked camera")]
	public float m_Weight5; //Field offset: 0xBC
	[Tooltip("The weight of the seventh tracked camera")]
	public float m_Weight6; //Field offset: 0xC0
	[Tooltip("The weight of the eighth tracked camera")]
	public float m_Weight7; //Field offset: 0xC4
	private CameraState m_State; //Field offset: 0xC8
	[CompilerGenerated]
	private ICinemachineCamera <LiveChild>k__BackingField; //Field offset: 0x1B0
	[CompilerGenerated]
	private Transform <LookAt>k__BackingField; //Field offset: 0x1B8
	[CompilerGenerated]
	private Transform <Follow>k__BackingField; //Field offset: 0x1C0
	private CinemachineVirtualCameraBase[] m_ChildCameras; //Field offset: 0x1C8
	private Dictionary m_indexMap; //Field offset: 0x1D0

	public CinemachineVirtualCameraBase[] ChildCameras
	{
		 get { } //Length: 29
	}

	public virtual Transform Follow
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 82
	}

	private ICinemachineCamera LiveChild
	{
		[CompilerGenerated]
		private get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public virtual Transform LookAt
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public virtual CameraState State
	{
		 get { } //Length: 148
	}

	public CinemachineMixingCamera() { }

	public virtual void ForceCameraPosition(Vector3 pos, Quaternion rot) { }

	public CinemachineVirtualCameraBase[] get_ChildCameras() { }

	[CompilerGenerated]
	public virtual Transform get_Follow() { }

	[CompilerGenerated]
	private ICinemachineCamera get_LiveChild() { }

	[CompilerGenerated]
	public virtual Transform get_LookAt() { }

	public virtual CameraState get_State() { }

	public float GetWeight(int index) { }

	public float GetWeight(CinemachineVirtualCameraBase vcam) { }

	public virtual void InternalUpdateCameraState(Vector3 worldUp, float deltaTime) { }

	protected void InvalidateListOfChildren() { }

	public virtual bool IsLiveChild(ICinemachineCamera vcam, bool dominantChildOnly = false) { }

	protected virtual void OnEnable() { }

	public virtual void OnTargetObjectWarped(Transform target, Vector3 positionDelta) { }

	public void OnTransformChildrenChanged() { }

	public virtual void OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime) { }

	protected virtual void OnValidate() { }

	[CompilerGenerated]
	public virtual void set_Follow(Transform value) { }

	[CompilerGenerated]
	private void set_LiveChild(ICinemachineCamera value) { }

	[CompilerGenerated]
	public virtual void set_LookAt(Transform value) { }

	public void SetWeight(CinemachineVirtualCameraBase vcam, float w) { }

	public void SetWeight(int index, float w) { }

	protected void ValidateListOfChildren() { }

}

