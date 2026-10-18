namespace EFT.UI;

public abstract class EnvironmentCameraMotion : MonoBehaviour, IEnvironmentCameraMotion
{

	public override Transform CameraContainer
	{
		 get { } //Length: 156
	}

	protected bool IsCameraContainerActive
	{
		 get { } //Length: 391
	}

	protected EnvironmentCameraMotion() { }

	public override Transform get_CameraContainer() { }

	protected bool get_IsCameraContainerActive() { }

	public abstract void MoveSecondary() { }

	public abstract void ResetMotion() { }

	public abstract void SetMain(bool isMain) { }

}

