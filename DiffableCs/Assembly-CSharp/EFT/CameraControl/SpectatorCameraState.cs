namespace EFT.CameraControl;

public class SpectatorCameraState : CameraState
{
	private readonly Transform _cameraTransform; //Field offset: 0x28
	private Transform _playerCameraTransform; //Field offset: 0x30
	private ColliderExtrusion _playerCameraCollider; //Field offset: 0x38
	private ObservedPlayerView _target; //Field offset: 0x40

	public ObservedPlayerView Target
	{
		 get { } //Length: 5
	}

	public SpectatorCameraState(PlayerCameraController playerCameraController) { }

	public ObservedPlayerView get_Target() { }

	public virtual void ManualFixedUpdate(float deltaTime) { }

	public virtual void ManualLateUpdate(float deltaTime) { }

	public virtual void OnEnter() { }

	public virtual void OnExit() { }

	private void ResetCameraFovToSettings() { }

	public virtual void SetPointOfView(EPointOfView pointOfView) { }

	public void SetTarget(ObservedPlayerView target) { }

	private void SyncCameraFovFromTarget(ObservedPlayerView target) { }

}

