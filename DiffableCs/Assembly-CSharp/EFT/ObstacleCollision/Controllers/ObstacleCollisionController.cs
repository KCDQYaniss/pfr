namespace EFT.ObstacleCollision.Controllers;

public class ObstacleCollisionController
{
	private readonly Transform _playerTransform; //Field offset: 0x10
	private readonly Func _directionGetter; //Field offset: 0x18
	private readonly Func _handsToBodyAngle; //Field offset: 0x20
	private readonly Func _actualLinearVelicityGetter; //Field offset: 0x28
	private readonly IObstacleCollisionModel _model; //Field offset: 0x30
	private readonly KinematicController _kinematicController; //Field offset: 0x38
	private readonly CollisionCalculatorController _collisionCalculatorController; //Field offset: 0x40

	public KinematicController KinematicController
	{
		 get { } //Length: 5
	}

	public ObstacleCollisionController(Transform playerTransform, Func directionGetter, Func handsToBodyAngle, Func actualLinearVelicityGetter) { }

	public bool CanMove() { }

	public KinematicController get_KinematicController() { }

	public void RecalculateCollision(float velocityThreshold) { }

	public void Reset() { }

	public void Tick() { }

}

