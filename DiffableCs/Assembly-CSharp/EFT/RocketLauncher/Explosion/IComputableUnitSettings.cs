namespace EFT.RocketLauncher.Explosion;

public interface IComputableUnitSettings
{

	public float Size
	{
		 get { } //Length: 0
	}

	public ComputableUnitType Type
	{
		 get { } //Length: 0
	}

	public Vector2 UnitDamage
	{
		 get { } //Length: 0
	}

	public float get_Size() { }

	public ComputableUnitType get_Type() { }

	public Vector2 get_UnitDamage() { }

}

