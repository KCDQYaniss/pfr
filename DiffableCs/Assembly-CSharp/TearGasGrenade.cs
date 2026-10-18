//Type is in global namespace

public class TearGasGrenade : Grenade, IPlatformTransportee
{
	private const float _maxRigidbodyLifeTime = 30; //Field offset: 0x0
	private VolumetricThrowWeap _volumetricWeapon; //Field offset: 0xF0
	private float _emissionStart; //Field offset: 0xF8
	private bool _exploded; //Field offset: 0xFC
	private bool _stopped; //Field offset: 0xFD
	private bool _isAuthoritative; //Field offset: 0xFE
	private bool _propagationStarted; //Field offset: 0xFF
	private int _sourceId; //Field offset: 0x100
	private Vector3 _propagationStartPosition; //Field offset: 0x104
	private bool _platformWasMoving; //Field offset: 0x110
	private float _emitTime; //Field offset: 0x114
	private readonly HashSet _prevTickRaidIds; //Field offset: 0x118
	private readonly HashSet _currentTickRaidIds; //Field offset: 0x120
	[CompilerGenerated]
	private MovingPlatform <Platform>k__BackingField; //Field offset: 0x128
	public Action EmissionEnd; //Field offset: 0x130

	public TearGasGrenadeNetworkData NetworkData
	{
		 get { } //Length: 1921
	}

	public MovingPlatform Platform
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 82
	}

	private TearGasGrenadeSettings TearGasGrenadeSettings
	{
		private get { } //Length: 122
	}

	public TearGasGrenade() { }

	public override void Board(MovingPlatform platform) { }

	private void FreezeAndStop(IVolumePropagationSystem system) { }

	public TearGasGrenadeNetworkData get_NetworkData() { }

	[CompilerGenerated]
	public MovingPlatform get_Platform() { }

	private TearGasGrenadeSettings get_TearGasGrenadeSettings() { }

	public override void GetOff(MovingPlatform platform) { }

	private void HandleCollisionTick(int sourceId, IReadOnlyList players) { }

	private void HandlePlatformMoving() { }

	public virtual void Init(GrenadeSettings settings, int playerRaidId, ThrowWeap throwWeap, float timeSpent, IBallisticsCalculator calculator, bool isBeingPlanted) { }

	public void InvokeEmissionEndEvent() { }

	public virtual void LateUpdate() { }

	protected virtual void OnDestroy() { }

	public virtual void OnExplosion() { }

	public void OnLifetimeEnded() { }

	private void OnStopped(Throwable throwable) { }

	public void RemoveRigidbody() { }

	protected override void RemoveRigidBodyOnVelocityDrop() { }

	[CompilerGenerated]
	public void set_Platform(MovingPlatform value) { }

	public virtual void SetThrowForce(Vector3 force) { }

	public void StartEmissionBehaviour() { }

	private void TryStartPropagation() { }

}

