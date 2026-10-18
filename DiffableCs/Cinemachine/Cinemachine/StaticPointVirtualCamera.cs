namespace Cinemachine;

internal class StaticPointVirtualCamera : ICinemachineCamera
{
	[CompilerGenerated]
	private string <Name>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private int <Priority>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private Transform <LookAt>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private Transform <Follow>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private CameraState <State>k__BackingField; //Field offset: 0x30

	public override string Description
	{
		 get { } //Length: 49
	}

	public override Transform Follow
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public override bool IsValid
	{
		 get { } //Length: 3
	}

	public override Transform LookAt
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public private override string Name
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public override ICinemachineCamera ParentCamera
	{
		 get { } //Length: 3
	}

	public override int Priority
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public private override CameraState State
	{
		[CompilerGenerated]
		 get { } //Length: 151
		[CompilerGenerated]
		private set { } //Length: 212
	}

	public override GameObject VirtualCameraGameObject
	{
		 get { } //Length: 3
	}

	public StaticPointVirtualCamera(CameraState state, string name) { }

	public override string get_Description() { }

	[CompilerGenerated]
	public override Transform get_Follow() { }

	public override bool get_IsValid() { }

	[CompilerGenerated]
	public override Transform get_LookAt() { }

	[CompilerGenerated]
	public override string get_Name() { }

	public override ICinemachineCamera get_ParentCamera() { }

	[CompilerGenerated]
	public override int get_Priority() { }

	[CompilerGenerated]
	public override CameraState get_State() { }

	public override GameObject get_VirtualCameraGameObject() { }

	public override void InternalUpdateCameraState(Vector3 worldUp, float deltaTime) { }

	public override bool IsLiveChild(ICinemachineCamera vcam, bool dominantChildOnly = false) { }

	public override void OnTargetObjectWarped(Transform target, Vector3 positionDelta) { }

	public override void OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime) { }

	[CompilerGenerated]
	public override void set_Follow(Transform value) { }

	[CompilerGenerated]
	public override void set_LookAt(Transform value) { }

	[CompilerGenerated]
	private void set_Name(string value) { }

	[CompilerGenerated]
	public override void set_Priority(int value) { }

	[CompilerGenerated]
	private void set_State(CameraState value) { }

	public void SetState(CameraState state) { }

	public override void UpdateCameraState(Vector3 worldUp, float deltaTime) { }

}

