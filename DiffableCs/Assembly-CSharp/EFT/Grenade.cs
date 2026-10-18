namespace EFT;

public class Grenade : Throwable
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass61_0
	{
		public Item originalWeaponItem; //Field offset: 0x10
		public int playerRaidIDWhoThrew; //Field offset: 0x18
		public Vector3 grenadePosition; //Field offset: 0x1C
		public bool isPlanted; //Field offset: 0x28

		public <>c__DisplayClass61_0() { }

		internal DamageInfo <Explosion>b__0() { }

	}

	public const float SHIFT_DISTANCE = 0.08; //Field offset: 0x0
	private const float MIN_COLLISION_THRESHOLD = 0.2; //Field offset: 0x0
	private const float TRAVEL_THROUGH_GLASS_THRESHOLD = 0.5; //Field offset: 0x0
	private const int PATH_DURATION = 300; //Field offset: 0x0
	private static readonly Vector3 _defaultShift; //Field offset: 0x0
	public static PrecalculatedRandoms GrenadeRandoms; //Field offset: 0x10
	private static int GlobalFragmentNumber; //Field offset: 0x18
	public IBallisticsCalculator Calculator; //Field offset: 0x80
	[CompilerGenerated]
	private IObserverToPlayerBridge <Player>k__BackingField; //Field offset: 0x88
	[CompilerGenerated]
	private int <PlayerRaidId>k__BackingField; //Field offset: 0x90
	[CompilerGenerated]
	private ThrowWeap <WeaponSource>k__BackingField; //Field offset: 0x98
	protected GrenadeSettings _grenadeSettings; //Field offset: 0xA0
	protected IEnumerator _behaviourTimerCoroutine; //Field offset: 0xA8
	private bool _needExplodeByContact; //Field offset: 0xB0
	private float _contactExplodeTimer; //Field offset: 0xB4
	private float _timeSpent; //Field offset: 0xB8
	private Collider _collider; //Field offset: 0xC0
	private Transform _attached; //Field offset: 0xC8
	protected bool _isPlantedItem; //Field offset: 0xD0
	private SoundBank _collisionSoundBank; //Field offset: 0xD8
	private readonly Vector3 _sourceShift; //Field offset: 0xE0

	public GrenadeSettings GrenadeSettings
	{
		 get { } //Length: 8
	}

	public virtual bool HasNetData
	{
		 get { } //Length: 3
	}

	public virtual int Id
	{
		 get { } //Length: 116
	}

	public Vector3 Offset
	{
		 get { } //Length: 44
	}

	protected override float PhysicsQuality
	{
		 get { } //Length: 9
	}

	protected static float PhysicsQualityForObserved
	{
		 get { } //Length: 4
	}

	public private IObserverToPlayerBridge Player
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private int PlayerRaidId
	{
		[CompilerGenerated]
		 get { } //Length: 7
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public private ThrowWeap WeaponSource
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	private static Grenade() { }

	public Grenade() { }

	public void Attach(Transform t) { }

	private void Awake() { }

	public static void Explosion(Grenade grenade, IExplosiveItem grenadeItem, Vector3 grenadePosition, int playerRaidIDWhoThrew, IBallisticsCalculator grenadeBallisticsCalculator, Item originalWeaponItem, Vector3 shift, bool isPlanted = false) { }

	private void Explosion() { }

	public void ExternalInvokeBlowUpEvent() { }

	public void ExternalStartTimer() { }

	public GrenadeSettings get_GrenadeSettings() { }

	public virtual bool get_HasNetData() { }

	public virtual int get_Id() { }

	public Vector3 get_Offset() { }

	protected override float get_PhysicsQuality() { }

	protected static float get_PhysicsQualityForObserved() { }

	[CompilerGenerated]
	public IObserverToPlayerBridge get_Player() { }

	[CompilerGenerated]
	public int get_PlayerRaidId() { }

	[CompilerGenerated]
	public ThrowWeap get_WeaponSource() { }

	private static DamageInfo GetDamageInfo(Item originalItemWeapon, int playerRaidIDWhoThrew, Vector3 explosionPosition, bool isPlanted) { }

	protected override ObjectVisibility GetVisibilityChecker() { }

	protected static ObjectVisibility GetVisibilityCheckerForObserved(Grenade grenade) { }

	public override void Init(GrenadeSettings settings, int playerRaidId, ThrowWeap throwWeap, float timeSpent, IBallisticsCalculator calculator, bool isBeingPlanted) { }

	protected void InvokeBlowUpEvent() { }

	public override void LateUpdate() { }

	private void OnCollisionEnter(Collision collision) { }

	public virtual void OnCollisionHandler() { }

	protected virtual void OnDestroy() { }

	public override void OnExplosion() { }

	private void PlayCollisionSound() { }

	protected override void ProcessContactExplodeCollision(float impulse) { }

	[CompilerGenerated]
	private void set_Player(IObserverToPlayerBridge value) { }

	[CompilerGenerated]
	private void set_PlayerRaidId(int value) { }

	[CompilerGenerated]
	private void set_WeaponSource(ThrowWeap value) { }

	public void SetRigidbodyMass(float mass) { }

	public override void SetThrowForce(Vector3 force) { }

	protected override void StartTimer() { }

	protected void StopTimer() { }

	private bool TryGlassCollision(Collision collision) { }

}

