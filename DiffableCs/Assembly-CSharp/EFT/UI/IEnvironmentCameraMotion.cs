namespace EFT.UI;

public interface IEnvironmentCameraMotion
{

	public Transform CameraContainer
	{
		 get { } //Length: 0
	}

	public Transform get_CameraContainer() { }

	public void MoveSecondary() { }

	public void ResetMotion() { }

	public void SetMain(bool isMain) { }

}

