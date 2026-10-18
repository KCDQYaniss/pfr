namespace EFT.UI;

public sealed class TubeEnvironmentCameraMotion : EnvironmentCameraMotion
{
	private const float ROTATE_DURATION = 1; //Field offset: 0x0

	public TubeEnvironmentCameraMotion() { }

	private static Vector3 GetRandomOffset() { }

	public virtual void MoveSecondary() { }

	public virtual void ResetMotion() { }

	private void RotateBack() { }

	public virtual void SetMain(bool isMain) { }

}

