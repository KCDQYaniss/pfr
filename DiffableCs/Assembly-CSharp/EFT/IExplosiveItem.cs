namespace EFT;

public interface IExplosiveItem
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

	public int FragmentsCount
	{
		 get { } //Length: 0
	}

	public float GetStrength
	{
		 get { } //Length: 0
	}

	public bool IsDummy
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

	public Ammo CreateFragment() { }

	public Vector3 get_ArmorDistanceDistanceDamage() { }

	public Vector3 get_Blindness() { }

	public Vector3 get_Contusion() { }

	public int get_FragmentsCount() { }

	public float get_GetStrength() { }

	public bool get_IsDummy() { }

	public float get_MaxExplosionDistance() { }

	public float get_MinExplosionDistance() { }

}

