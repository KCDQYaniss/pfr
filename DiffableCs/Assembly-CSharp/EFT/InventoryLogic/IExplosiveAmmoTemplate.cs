namespace EFT.InventoryLogic;

public interface IExplosiveAmmoTemplate : IItemTemplate
{

	public Vector3 ArmorDistanceDistanceDamage
	{
		 get { } //Length: 0
	}

	public Vector3 Blindness
	{
		 get { } //Length: 0
	}

	public Vector3 Contusion
	{
		 get { } //Length: 0
	}

	public float ExplosionStrength
	{
		 get { } //Length: 0
	}

	public string ExplosionType
	{
		 get { } //Length: 0
	}

	public int FragmentsCount
	{
		 get { } //Length: 0
	}

	public string FragmentType
	{
		 get { } //Length: 0
	}

	public float FuzeArmTimeSec
	{
		 get { } //Length: 0
	}

	public bool GrenadeComponentIsDummy
	{
		 get { } //Length: 0
	}

	public float MaxExplosionDistance
	{
		 get { } //Length: 0
	}

	public float MinExplosionDistance
	{
		 get { } //Length: 0
	}

	public bool ShowHitEffectOnExplode
	{
		 get { } //Length: 0
	}

	public Vector3 get_ArmorDistanceDistanceDamage() { }

	public Vector3 get_Blindness() { }

	public Vector3 get_Contusion() { }

	public float get_ExplosionStrength() { }

	public string get_ExplosionType() { }

	public int get_FragmentsCount() { }

	public string get_FragmentType() { }

	public float get_FuzeArmTimeSec() { }

	public bool get_GrenadeComponentIsDummy() { }

	public float get_MaxExplosionDistance() { }

	public float get_MinExplosionDistance() { }

	public bool get_ShowHitEffectOnExplode() { }

}

