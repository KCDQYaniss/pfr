namespace EFT.ObstacleCollision;

public interface IKinematicModel
{

	public Vector3 Acceleration
	{
		 get { } //Length: 0
	}

	public Vector3 NormalizedDirection
	{
		 get { } //Length: 0
	}

	public Vector3 Velocity
	{
		 get { } //Length: 0
	}

	public Vector3 get_Acceleration() { }

	public Vector3 get_NormalizedDirection() { }

	public Vector3 get_Velocity() { }

	public void Tick() { }

}

