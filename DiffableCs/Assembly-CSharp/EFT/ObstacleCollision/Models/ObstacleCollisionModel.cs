namespace EFT.ObstacleCollision.Models;

public class ObstacleCollisionModel : IObstacleCollisionModel
{
	private readonly Transform _playerTransform; //Field offset: 0x10
	private readonly Func _directionGetter; //Field offset: 0x18
	private readonly Func _handsToBodyAngleGetter; //Field offset: 0x20
	private readonly Func _actualLinearVelicityGetter; //Field offset: 0x28
	private readonly IKinematicModel _kinematicModel; //Field offset: 0x30
	private readonly ICollisionCalculatorModel _collisionCalculatorModel; //Field offset: 0x38

	public override ICollisionCalculatorModel CollisionCalculatorModel
	{
		 get { } //Length: 5
	}

	public override IKinematicModel KinematicModel
	{
		 get { } //Length: 76
	}

	public ObstacleCollisionModel(Transform playerTransform, Func directionGetter, Func handsToBodyAngleGetter, Func actualLinearVelocity) { }

	[CompilerGenerated]
	private Vector3 <.ctor>b__10_0() { }

	public override ICollisionCalculatorModel get_CollisionCalculatorModel() { }

	public override IKinematicModel get_KinematicModel() { }

}

