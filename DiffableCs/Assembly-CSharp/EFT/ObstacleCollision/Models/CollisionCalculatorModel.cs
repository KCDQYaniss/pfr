namespace EFT.ObstacleCollision.Models;

public class CollisionCalculatorModel : ICollisionCalculatorModel
{
	private readonly Func _directionGetter; //Field offset: 0x10
	private readonly Func _velocityGetter; //Field offset: 0x18
	private readonly Func _handsToBodyAngleGetter; //Field offset: 0x20
	private readonly Func _actualLinearVelicityGetter; //Field offset: 0x28
	private bool _canMove; //Field offset: 0x30
	private float _directThreshold; //Field offset: 0x34
	private float _angleDirectionThreshold; //Field offset: 0x38
	private float _handsToBodyAngleThreshold; //Field offset: 0x3C
	private Vector2 _cachedDirection; //Field offset: 0x40
	private float _velocityConditionTimer; //Field offset: 0x48
	private float _velocityConditionTimeThreshold; //Field offset: 0x4C

	public override bool CanMove
	{
		 get { } //Length: 5
	}

	public CollisionCalculatorModel(Func directionGetter, Func velocityGetter, Func handsToBodyAngleGetter, Func actualLinearVelicityGetter) { }

	private bool CanLockMove(float velocityThreshold) { }

	private bool CanUnlockMove() { }

	public override bool get_CanMove() { }

	public override void Recalculate(float velocityThreshold) { }

	public override void Reset() { }

	private void ResetTimer() { }

	public override void TryUnlock() { }

}

