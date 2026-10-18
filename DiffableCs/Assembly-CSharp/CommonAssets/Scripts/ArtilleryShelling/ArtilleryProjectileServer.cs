namespace CommonAssets.Scripts.ArtilleryShelling;

public class ArtilleryProjectileServer
{
	public int id; //Field offset: 0x10
	public Vector3 finalPosition; //Field offset: 0x14
	public Vector3 startPosition; //Field offset: 0x20
	public Vector3 currentPosition; //Field offset: 0x2C
	public bool explosion; //Field offset: 0x38
	public bool firstInShellingForZone; //Field offset: 0x39
	public bool lastInShellingForZone; //Field offset: 0x3A
	public bool firstInRoundForZone; //Field offset: 0x3B
	public bool lastInRoundForZone; //Field offset: 0x3C
	public float speed; //Field offset: 0x40
	public float arcHeight; //Field offset: 0x44
	public Vector2 explosionDistnaceRange; //Field offset: 0x48
	public string zoneID; //Field offset: 0x50
	[CompilerGenerated]
	private Action ExplosionEvent; //Field offset: 0x58
	private bool _flyOn; //Field offset: 0x60
	private Vector3 _forward; //Field offset: 0x64
	private ArtilleryProjectileExplosiveItem _explosiveItem; //Field offset: 0x70

	public event Action ExplosionEvent
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	private static IBallisticsCalculator Calculator
	{
		private get { } //Length: 93
	}

	public ArtilleryProjectileServer() { }

	[CompilerGenerated]
	public void add_ExplosionEvent(Action value) { }

	public void Deactivate() { }

	private void Explosion() { }

	private void Explosion(ArtilleryProjectileExplosiveItem mineData, Vector3 explosionPosition, IBallisticsCalculator ballisticsCalculator) { }

	private void FlyProcess() { }

	private static IBallisticsCalculator get_Calculator() { }

	private DamageInfo GetDamageInfo() { }

	public ArtilleryProjectileSyncPacket GetNetPacket() { }

	public void InitFly(Vector3 startPos, Vector3 finalPos, Vector2 ExplosionDistnace, string idZone, bool firstInShellingZone, bool lastInShellingZone, bool firstInRound, bool lastInRound) { }

	public void OnUpdate() { }

	[CompilerGenerated]
	public void remove_ExplosionEvent(Action value) { }

	public void SetExplosiveItemParams(ArtilleryProjectileExplosionParams explosiveParams) { }

}

