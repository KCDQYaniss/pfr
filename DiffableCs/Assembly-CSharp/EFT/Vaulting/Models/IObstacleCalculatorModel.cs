namespace EFT.Vaulting.Models;

public interface IObstacleCalculatorModel
{

	public float BehindObstacleRatio
	{
		 get { } //Length: 0
	}

	public float DistanceToMainObstacle
	{
		 get { } //Length: 0
	}

	public bool IsTerrain
	{
		 get { } //Length: 0
	}

	public float MainObstacleHeight
	{
		 get { } //Length: 0
	}

	public float MainObstacleLength
	{
		 get { } //Length: 0
	}

	public Nullable MinRoofHeight
	{
		 get { } //Length: 0
	}

	public Collider TargetCollider
	{
		 get { } //Length: 0
	}

	public void CalculateSurface(GridSurfaceCalculatorDataTransferModel data) { }

	public float get_BehindObstacleRatio() { }

	public float get_DistanceToMainObstacle() { }

	public bool get_IsTerrain() { }

	public float get_MainObstacleHeight() { }

	public float get_MainObstacleLength() { }

	public Nullable get_MinRoofHeight() { }

	public Collider get_TargetCollider() { }

}

