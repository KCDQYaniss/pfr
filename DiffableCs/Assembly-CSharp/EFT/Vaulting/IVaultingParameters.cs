namespace EFT.Vaulting;

public interface IVaultingParameters
{

	public float AbsoluteForwardVelocity
	{
		 get { } //Length: 0
	}

	public float BehindObstacleRatio
	{
		 get { } //Length: 0
	}

	public Vector3 MaxWeightPointPosition
	{
		 get { } //Length: 0
	}

	public float VaultingHeight
	{
		 get { } //Length: 0
	}

	public float VaultingLength
	{
		 get { } //Length: 0
	}

	public float get_AbsoluteForwardVelocity() { }

	public float get_BehindObstacleRatio() { }

	public Vector3 get_MaxWeightPointPosition() { }

	public float get_VaultingHeight() { }

	public float get_VaultingLength() { }

	public EVaultingStrategy GetAutoVaultingStrategy() { }

	public EVaultingStrategy GetVaultingStrategy() { }

}

