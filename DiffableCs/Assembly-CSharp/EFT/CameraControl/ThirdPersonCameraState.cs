namespace EFT.CameraControl;

public abstract class ThirdPersonCameraState : CameraState
{
	protected readonly PlayerSpring Spring; //Field offset: 0x28
	protected Vector3 _followPosition; //Field offset: 0x30
	protected Vector3 followOffset; //Field offset: 0x3C
	protected float _followCameraSpeedCoeff; //Field offset: 0x48
	protected float _framesSinceButtonHeld; //Field offset: 0x4C

	protected ThirdPersonCameraState(PlayerCameraController playerCameraController) { }

	public virtual void SetPointOfView(EPointOfView pointOfView) { }

}

