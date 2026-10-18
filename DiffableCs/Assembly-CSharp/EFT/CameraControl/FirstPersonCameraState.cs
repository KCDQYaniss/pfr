namespace EFT.CameraControl;

public class FirstPersonCameraState : CameraState
{
	private readonly Transform _playerCameraTransform; //Field offset: 0x28
	private readonly ColliderExtrusion _playerCameraCollider; //Field offset: 0x30
	private readonly Transform _cameraTransform; //Field offset: 0x38
	private PlayerCameraController _playerCameraController; //Field offset: 0x40

	public FirstPersonCameraState(PlayerCameraController playerCameraController) { }

	public virtual void ManualFixedUpdate(float deltaTime) { }

	public virtual void ManualLateUpdate(float deltaTime) { }

	public virtual void SetPointOfView(EPointOfView pointOfView) { }

}

