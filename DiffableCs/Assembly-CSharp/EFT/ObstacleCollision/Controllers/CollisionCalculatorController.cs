namespace EFT.ObstacleCollision.Controllers;

public class CollisionCalculatorController
{
	private readonly ICollisionCalculatorModel _obstacleCalculatorModel; //Field offset: 0x10

	public CollisionCalculatorController(ICollisionCalculatorModel obstacleCalculatorModel) { }

	public bool CanMove() { }

	public void Recalculate(float velocityThreshold) { }

	public void Reset() { }

	public void Tick() { }

}

