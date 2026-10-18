namespace EFT.RocketLauncher.Explosion;

public interface IPhysicalSettings
{

	public float ArmingTime
	{
		 get { } //Length: 0
	}

	public float ExplosionRadius
	{
		 get { } //Length: 0
	}

	public float PropagationSpeed
	{
		 get { } //Length: 0
	}

	public WeightMultipliers WeightMultipliers
	{
		 get { } //Length: 0
	}

	public float get_ArmingTime() { }

	public float get_ExplosionRadius() { }

	public float get_PropagationSpeed() { }

	public WeightMultipliers get_WeightMultipliers() { }

}

