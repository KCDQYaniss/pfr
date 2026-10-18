//Type is in global namespace

public static class BulletSoundsUtils
{
	[CompilerGenerated]
	private static Action OnShoot; //Field offset: 0x0
	[CompilerGenerated]
	private static Action OnSniperZoneShoot; //Field offset: 0x8
	[CompilerGenerated]
	private static Action OnArmorHit; //Field offset: 0x10

	public static event Action OnArmorHit
	{
		[CompilerGenerated]
		 add { } //Length: 304
		[CompilerGenerated]
		 remove { } //Length: 304
	}

	public static event Action OnShoot
	{
		[CompilerGenerated]
		 add { } //Length: 293
		[CompilerGenerated]
		 remove { } //Length: 293
	}

	public static event Action OnSniperZoneShoot
	{
		[CompilerGenerated]
		 add { } //Length: 304
		[CompilerGenerated]
		 remove { } //Length: 304
	}

	[CompilerGenerated]
	public static void add_OnArmorHit(Action value) { }

	[CompilerGenerated]
	public static void add_OnShoot(Action value) { }

	[CompilerGenerated]
	public static void add_OnSniperZoneShoot(Action value) { }

	public static float CalculateInversePan(Vector3 forward, Vector3 bullet) { }

	public static ValueTuple CalculateNormalFromPoint(Vector3 start, Vector3 end, Vector3 center) { }

	public static float CalculatePan(Vector3 forward, Vector3 bullet) { }

	public static float CalculateRadAngle(Vector3 forward, Vector3 bullet) { }

	public static void HitArmor(IPlayer player, IPlayer enemy, Vector3 direction) { }

	[CompilerGenerated]
	public static void remove_OnArmorHit(Action value) { }

	[CompilerGenerated]
	public static void remove_OnShoot(Action value) { }

	[CompilerGenerated]
	public static void remove_OnSniperZoneShoot(Action value) { }

	public static void Shoot(SonicInfo sonicInfo) { }

	public static void SniperZoneShoot(SonicInfo sonicInfo) { }

	public static bool SphereIntersection(Vector3 start, Vector3 end, Vector3 center, float radius) { }

}

