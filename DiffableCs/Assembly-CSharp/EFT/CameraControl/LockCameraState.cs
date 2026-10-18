namespace EFT.CameraControl;

public class LockCameraState : ThirdPersonCameraState
{

	public LockCameraState(PlayerCameraController playerCameraController) { }

	public virtual void ManualFixedUpdate(float deltaTime) { }

	public virtual void ManualLateUpdate(float deltaTime) { }

	public virtual void SetPointOfView(EPointOfView pointOfView) { }

}

