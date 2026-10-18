namespace EFT.ObstacleCollision.Models;

public interface ICollisionCalculatorModel
{

	public bool CanMove
	{
		 get { } //Length: 0
	}

	public bool get_CanMove() { }

	public void Recalculate(float velocityThreshold) { }

	public void Reset() { }

	public void TryUnlock() { }

}

