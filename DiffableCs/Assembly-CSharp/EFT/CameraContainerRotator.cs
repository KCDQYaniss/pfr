namespace EFT;

public sealed class CameraContainerRotator : ICustomRotator
{
	private const float SPEED = 36; //Field offset: 0x0
	private Transform _cameraContainer; //Field offset: 0x10
	private Quaternion _lastRotation; //Field offset: 0x18

	public override bool IsValid
	{
		 get { } //Length: 203
	}

	public CameraContainerRotator() { }

	public override bool get_IsValid() { }

	public override Quaternion GetRotation() { }

	public void Init(Player player, Nullable intermediateRotation = null) { }

	public void Init(Transform cameraContainer, Nullable intermediateRotation = null) { }

}

