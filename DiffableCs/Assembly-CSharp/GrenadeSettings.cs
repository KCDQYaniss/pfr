//Type is in global namespace

public class GrenadeSettings : ThrowableSettings
{
	internal enum CollisionSounds
	{
		frag = 0,
		smoke = 1,
		stun = 2,
		smokeM18 = 3,
		stunM7920 = 4,
	}

	public CollisionSounds CollisionSound; //Field offset: 0x30
	public Transform Skoba; //Field offset: 0x38

	public string EmmisionEffect
	{
		 get { } //Length: 109
	}

	public GrenadeSettings() { }

	public string get_EmmisionEffect() { }

}

