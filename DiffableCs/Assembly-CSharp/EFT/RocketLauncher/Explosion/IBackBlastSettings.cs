namespace EFT.RocketLauncher.Explosion;

public interface IBackBlastSettings
{

	public float BackBlastConeAngle
	{
		 get { } //Length: 0
	}

	public Vector2 BackBlastDamage
	{
		 get { } //Length: 0
	}

	public float BackBlastDistance
	{
		 get { } //Length: 0
	}

	public float get_BackBlastConeAngle() { }

	public Vector2 get_BackBlastDamage() { }

	public float get_BackBlastDistance() { }

}

