namespace EFT.UI;

public sealed class HorizontalEnvironmentCameraMotion : EnvironmentCameraMotion
{
	[SerializeField]
	private Transform _mainPoint; //Field offset: 0x20
	[SerializeField]
	private Transform[] _secondaryPoints; //Field offset: 0x28
	[SerializeField]
	private float _moveDuration; //Field offset: 0x30
	[SerializeField]
	private Ease _moveEase; //Field offset: 0x34
	private bool _loggedMissingSecondaryPoints; //Field offset: 0x38

	public HorizontalEnvironmentCameraMotion() { }

	private Vector3 GetMainLocalPosition(Transform cameraContainer) { }

	private Vector3 GetSecondaryLocalPosition(Transform cameraContainer) { }

	private void LogMissingSecondaryPoints() { }

	public virtual void MoveSecondary() { }

	private void MoveTo(Vector3 targetPosition) { }

	private void MoveToMain() { }

	public virtual void ResetMotion() { }

	public virtual void SetMain(bool isMain) { }

}

