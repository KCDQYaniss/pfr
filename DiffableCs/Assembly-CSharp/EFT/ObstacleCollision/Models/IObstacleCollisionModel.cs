namespace EFT.ObstacleCollision.Models;

public interface IObstacleCollisionModel
{

	public ICollisionCalculatorModel CollisionCalculatorModel
	{
		 get { } //Length: 0
	}

	public IKinematicModel KinematicModel
	{
		 get { } //Length: 0
	}

	public ICollisionCalculatorModel get_CollisionCalculatorModel() { }

	public IKinematicModel get_KinematicModel() { }

}

