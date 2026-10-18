namespace EFT.ObstacleCollision;

public class KinematicModel : IKinematicModel
{
	private readonly Transform _playerTransform; //Field offset: 0x10
	private readonly Func _directionGetter; //Field offset: 0x18
	private Vector3 _prevPosition; //Field offset: 0x20
	private Vector3 _currentPosition; //Field offset: 0x2C
	private Vector3 _currentNormalizedDirection; //Field offset: 0x38
	private Vector3 _prevVelocity; //Field offset: 0x44
	private Vector3 _currentVelocity; //Field offset: 0x50
	private Vector3 _currentAccleration; //Field offset: 0x5C

	public override Vector3 Acceleration
	{
		 get { } //Length: 19
	}

	public override Vector3 NormalizedDirection
	{
		 get { } //Length: 19
	}

	public override Vector3 Velocity
	{
		 get { } //Length: 19
	}

	public KinematicModel(Transform playerTransform, Func directionGetter) { }

	private void CalculateAcceleration() { }

	private void CalculateDirection() { }

	private void CalculateParameters() { }

	private void CalculateVelocity() { }

	public override Vector3 get_Acceleration() { }

	public override Vector3 get_NormalizedDirection() { }

	public override Vector3 get_Velocity() { }

	private void SetPreviousValues() { }

	public override void Tick() { }

}

