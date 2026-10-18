namespace EFT.ObstacleCollision.Controllers;

public class KinematicController
{
	private readonly IKinematicModel _kinematicModel; //Field offset: 0x10

	public Vector3 Acceleration
	{
		 get { } //Length: 113
	}

	public Vector3 Velocity
	{
		 get { } //Length: 110
	}

	public KinematicController(IKinematicModel kinematicModel) { }

	public Vector3 get_Acceleration() { }

	public Vector3 get_Velocity() { }

	public void Tick() { }

}

