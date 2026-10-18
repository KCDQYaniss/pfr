namespace EFT.Vehicle;

public sealed class TransformInterpolator
{
	private readonly Transform _transform; //Field offset: 0x10
	private Vector3 _targetPosition; //Field offset: 0x18
	private Quaternion _targetRotation; //Field offset: 0x24
	private Vector3 _velocity; //Field offset: 0x34
	private float _lastUpdateTime; //Field offset: 0x40
	private readonly float _interpolationBufferSec; //Field offset: 0x44
	private readonly float _extrapolationLimitSec; //Field offset: 0x48
	private readonly float _snapThresholdSqr; //Field offset: 0x4C

	public TransformInterpolator(Transform transform, float interpolationBufferSec = 0.1, float extrapolationLimitSec = 0.5, float snapThresholdMeters = 5) { }

	public void Initialize(Vector3 position, Quaternion rotation) { }

	public bool Interpolate(bool isMoving) { }

	private Quaternion InterpolateRotation(Quaternion current, Quaternion target, float t) { }

	public void UpdateTarget(Vector3 position, Quaternion rotation, float speed, float maxSpeed) { }

}

