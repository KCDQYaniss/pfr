namespace EFT.ObstacleCollision;

public interface IObstacleCollisionFacade
{

	public bool CanMove() { }

	public void Dispose() { }

	public void RecalculateCollision(float velocityThreshold) { }

	public void Reset() { }

	public void Tick() { }

}

