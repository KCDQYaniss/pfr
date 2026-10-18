namespace EFT.Hideout;

public sealed class HideoutCameraController : UIElement
{
	public const float TRANSITION_TIME = 0.8; //Field offset: 0x0
	private const int LOW_PRIORITY = 5; //Field offset: 0x0
	private const int HIGH_PRIORITY = 15; //Field offset: 0x0
	private const int DEFAULT_RAIL_CAMERA_POSITION = 68; //Field offset: 0x0
	private readonly Vector3 DEFAULT_FREE_SPACE_CAMERA_POSITION; //Field offset: 0x70
	[SerializeField]
	private HideoutCamera[] _camerasWithPath; //Field offset: 0x80
	[SerializeField]
	private CinemachineVirtualCamera _playerCamera; //Field offset: 0x88
	[SerializeField]
	private ECameraMoveType _cameraMoveType; //Field offset: 0x90
	private int _currentCameraIndex; //Field offset: 0x94
	private bool _isActive; //Field offset: 0x98
	private bool _nightVisionState; //Field offset: 0x99
	private bool _enableFlashLightForce; //Field offset: 0x9A
	private bool _interactionEnabled; //Field offset: 0x9B
	private bool _selectionState; //Field offset: 0x9C
	private bool _surroundingIllumination; //Field offset: 0x9D

	public bool AreaSelected
	{
		 get { } //Length: 8
		 set { } //Length: 152
	}

	public bool CameraIsInThirdPerson
	{
		 get { } //Length: 579
	}

	private HideoutCamera CurrentCamera
	{
		private get { } //Length: 49
	}

	public bool EnableFlashLightForce
	{
		 get { } //Length: 8
		 set { } //Length: 13
	}

	public bool NightVisionState
	{
		 get { } //Length: 8
		 set { } //Length: 13
	}

	public bool SurroundingIllumination
	{
		 get { } //Length: 8
		 set { } //Length: 13
	}

	public HideoutCameraController() { }

	private void ChangeCameraMover() { }

	public bool get_AreaSelected() { }

	public bool get_CameraIsInThirdPerson() { }

	private HideoutCamera get_CurrentCamera() { }

	public bool get_EnableFlashLightForce() { }

	public bool get_NightVisionState() { }

	public bool get_SurroundingIllumination() { }

	private void LateUpdate() { }

	public void MoveCamera(Vector3 direction) { }

	private void OnDestroy() { }

	public void OnEnterHideoutMode() { }

	private void OnFovChangedHandler(float fov) { }

	public void ResetPlayerPosition(Player player) { }

	public void set_AreaSelected(bool value) { }

	public void set_EnableFlashLightForce(bool value) { }

	public void set_NightVisionState(bool value) { }

	public void set_SurroundingIllumination(bool value) { }

	public void SetActiveState(bool state) { }

	public void SetCameraPosition(object position) { }

	private void SetCurrentCamera(int index) { }

	public void SetInteractable(bool canInteract) { }

	public void SetPositionAndRotation(Vector3 position, Quaternion rotation) { }

	public void Show() { }

	private void Subscribe() { }

	private void SuppressEdgePan() { }

	public void SwitchCamera() { }

	private void Unsubscribe() { }

	private void UpdateFlashlight() { }

	public void Zoom(Nullable value) { }

}

