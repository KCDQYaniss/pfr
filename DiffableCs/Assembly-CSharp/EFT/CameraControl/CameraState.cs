namespace EFT.CameraControl;

public abstract class CameraState
{
	private const float MOVE_STEP = 0.01; //Field offset: 0x0
	private const float MAX_MOVE_DELTA = 1; //Field offset: 0x0
	protected readonly PlayerCameraController PlayerCameraController; //Field offset: 0x10
	protected readonly Player _player; //Field offset: 0x18
	protected readonly Camera _camera; //Field offset: 0x20

	protected CameraState(PlayerCameraController playerCameraController) { }

	protected Vector3 CalculateSafePosition(ColliderExtrusion сameraCollider, Vector3 startPosition, Quaternion startRotation, Vector3 targetPosition) { }

	protected void ChangeCameraStateQuickButtons() { }

	public abstract void ManualFixedUpdate(float deltaTime) { }

	public abstract void ManualLateUpdate(float deltaTime) { }

	public override void OnEnter() { }

	public override void OnExit() { }

	public abstract void SetPointOfView(EPointOfView pointOfView) { }

}

