namespace EFT.ObstacleCollision;

public class ObstacleCollisionFacade : IObstacleCollisionFacade
{
	private readonly Transform _playerTransform; //Field offset: 0x10
	private readonly Func _actualLinearVelicityGetter; //Field offset: 0x18
	private readonly Func _directionGetter; //Field offset: 0x20
	private readonly Func _handsToBodyAngleGetter; //Field offset: 0x28
	private readonly ObstacleCollisionController _controller; //Field offset: 0x30

	public ObstacleCollisionFacade(Transform playerTransform, Func actualLinearVelicityGetter, Func directionGetter, Func handsToBodyAngleGetter) { }

	public override bool CanMove() { }

	public override void Dispose() { }

	public override void RecalculateCollision(float velocityThreshold) { }

	public override void Reset() { }

	public override void Tick() { }

}

