namespace Cinemachine;

[AddComponentMenu("Cinemachine/CinemachineBlendListCamera")]
[DisallowMultipleComponent]
[DocumentationSorting(Level::UserRef (2))]
[ExcludeFromPreset]
[ExecuteAlways]
[HelpURL("https://docs.unity3d.com/Packages/com.unity.cinemachine@2.9/manual/CinemachineBlendListCamera.html")]
public class CinemachineBlendListCamera : CinemachineVirtualCameraBase
{
	internal struct Instruction
	{
		[Tooltip("The virtual camera to activate when this instruction becomes active")]
		public CinemachineVirtualCameraBase m_VirtualCamera; //Field offset: 0x0
		[Tooltip("How long to wait (in seconds) before activating the next virtual camera in the list (if any)")]
		public float m_Hold; //Field offset: 0x8
		[CinemachineBlendDefinitionProperty]
		[Tooltip("How to blend to the next virtual camera in the list (if any)")]
		public CinemachineBlendDefinition m_Blend; //Field offset: 0x10

	}

	[NoSaveDuringPlay]
	[Tooltip("Default object for the camera children to look at (the aim target), if not specified in a child camera.  May be empty if all of the children define targets of their own.")]
	[VcamTargetProperty]
	public Transform m_LookAt; //Field offset: 0xA8
	[NoSaveDuringPlay]
	[Tooltip("Default object for the camera children wants to move with (the body target), if not specified in a child camera.  May be empty if all of the children define targets of their own.")]
	[VcamTargetProperty]
	public Transform m_Follow; //Field offset: 0xB0
	[Tooltip("When enabled, the current child camera and blend will be indicated in the game window, for debugging")]
	public bool m_ShowDebugText; //Field offset: 0xB8
	[Tooltip("When enabled, the child vcams will cycle indefinitely instead of just stopping at the last one")]
	public bool m_Loop; //Field offset: 0xB9
	[HideInInspector]
	[NoSaveDuringPlay]
	[SerializeField]
	internal CinemachineVirtualCameraBase[] m_ChildCameras; //Field offset: 0xC0
	[Tooltip("The set of instructions for enabling child cameras.")]
	public Instruction[] m_Instructions; //Field offset: 0xC8
	[CompilerGenerated]
	private ICinemachineCamera <LiveChild>k__BackingField; //Field offset: 0xD0
	private ICinemachineCamera m_TransitioningFrom; //Field offset: 0xD8
	private CameraState m_State; //Field offset: 0xE0
	private float mActivationTime; //Field offset: 0x1C8
	private int mCurrentInstruction; //Field offset: 0x1CC
	private CinemachineBlend mActiveBlend; //Field offset: 0x1D0

	public CinemachineVirtualCameraBase[] ChildCameras
	{
		 get { } //Length: 29
	}

	public virtual string Description
	{
		 get { } //Length: 315
	}

	public virtual Transform Follow
	{
		 get { } //Length: 15
		 set { } //Length: 82
	}

	public bool IsBlending
	{
		 get { } //Length: 12
	}

	public ICinemachineCamera LiveChild
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public virtual Transform LookAt
	{
		 get { } //Length: 15
		 set { } //Length: 82
	}

	public virtual CameraState State
	{
		 get { } //Length: 148
	}

	public CinemachineBlendListCamera() { }

	private void AdvanceCurrentInstruction(float deltaTime) { }

	public virtual void ForceCameraPosition(Vector3 pos, Quaternion rot) { }

	public CinemachineVirtualCameraBase[] get_ChildCameras() { }

	public virtual string get_Description() { }

	public virtual Transform get_Follow() { }

	public bool get_IsBlending() { }

	[CompilerGenerated]
	public ICinemachineCamera get_LiveChild() { }

	public virtual Transform get_LookAt() { }

	public virtual CameraState get_State() { }

	public virtual void InternalUpdateCameraState(Vector3 worldUp, float deltaTime) { }

	private void InvalidateListOfChildren() { }

	public virtual bool IsLiveChild(ICinemachineCamera vcam, bool dominantChildOnly = false) { }

	protected virtual void OnDisable() { }

	protected virtual void OnEnable() { }

	private void OnGuiHandler() { }

	public virtual void OnTargetObjectWarped(Transform target, Vector3 positionDelta) { }

	private void OnTransformChildrenChanged() { }

	public virtual void OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime) { }

	private void Reset() { }

	public virtual void set_Follow(Transform value) { }

	[CompilerGenerated]
	public void set_LiveChild(ICinemachineCamera value) { }

	public virtual void set_LookAt(Transform value) { }

	private void UpdateListOfChildren() { }

	internal void ValidateInstructions() { }

}

