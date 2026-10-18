namespace EFT.InventoryLogic;

public class Rocket : Ammo
{
	private IExplosionSettings _explosionSettings; //Field offset: 0x88

	public float ArmingTime
	{
		 get { } //Length: 81
	}

	public float BackBlastConeAngle
	{
		 get { } //Length: 81
	}

	public Vector2 BackBlastDamage
	{
		 get { } //Length: 97
	}

	public float BackBlastDistance
	{
		 get { } //Length: 81
	}

	public int Capacity
	{
		 get { } //Length: 79
	}

	public float ComputableUnitSize
	{
		 get { } //Length: 81
	}

	public ComputableUnitType ComputableUnitType
	{
		 get { } //Length: 79
	}

	public float Duration
	{
		 get { } //Length: 81
	}

	public float ExplosionRadius
	{
		 get { } //Length: 81
	}

	public IExplosionSettings ExplosionSettings
	{
		 get { } //Length: 1677
	}

	public float ParticleSize
	{
		 get { } //Length: 81
	}

	public float PropagationSpeed
	{
		 get { } //Length: 81
	}

	public Vector2 UnitDamage
	{
		 get { } //Length: 97
	}

	public WeightMultipliers WeightMultipliers
	{
		 get { } //Length: 80
	}

	public Rocket(string id, RocketTemplate template) { }

	public Rocket Clone(string id) { }

	public float get_ArmingTime() { }

	public float get_BackBlastConeAngle() { }

	public Vector2 get_BackBlastDamage() { }

	public float get_BackBlastDistance() { }

	public int get_Capacity() { }

	public float get_ComputableUnitSize() { }

	public ComputableUnitType get_ComputableUnitType() { }

	public float get_Duration() { }

	public float get_ExplosionRadius() { }

	public IExplosionSettings get_ExplosionSettings() { }

	public float get_ParticleSize() { }

	public float get_PropagationSpeed() { }

	public Vector2 get_UnitDamage() { }

	public WeightMultipliers get_WeightMultipliers() { }

}

