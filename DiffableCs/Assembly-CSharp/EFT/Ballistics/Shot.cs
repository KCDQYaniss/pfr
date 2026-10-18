namespace EFT.Ballistics;

public class Shot
{
	internal enum EBulletState
	{
		Flying = 0,
		DeviationHit = 1,
		RicochetHit = 2,
		FragmentationHit = 3,
		StopHit = 4,
	}

	public const float AIR_DENSITY = 1.2; //Field offset: 0x0
	public const float MIN_PENETRATION_POWER = 0; //Field offset: 0x0
	public const float MAX_PENETRATION_POWER = 100; //Field offset: 0x0
	private const float DRAG_CONSTANT = 0.00033; //Field offset: 0x0
	private const float FRAGMENT_EXTENSION = 0.002; //Field offset: 0x0
	public const float AERODYNAMIC_COEFFICIENT = 0.0014223; //Field offset: 0x0
	public const float TRAJECTORY_STEP = 0.01; //Field offset: 0x0
	public const int MAX_RICOCHET_COUNT = 2; //Field offset: 0x0
	public const float MIN_RICOCHET_ANGLE = 85; //Field offset: 0x0
	public const float MAX_RICOCHET_ANGLE = 160; //Field offset: 0x0
	private static Stack _poolOfShots; //Field offset: 0x0
	private const int POOL_SIZE = 200; //Field offset: 0x0
	private static readonly List G1; //Field offset: 0x8
	private static RaycastHit[] _hits; //Field offset: 0x10
	[CompilerGenerated]
	private EBulletState <BulletState>k__BackingField; //Field offset: 0x10
	public Item Ammo; //Field offset: 0x18
	public float AmmoLifeTime; //Field offset: 0x20
	public int FragmentIndex; //Field offset: 0x24
	public int RandomSeed; //Field offset: 0x28
	public float ArmorDamage; //Field offset: 0x2C
	public readonly List PositionHistory; //Field offset: 0x30
	public Vector3 MasterOrigin; //Field offset: 0x38
	public Vector3 Direction; //Field offset: 0x44
	public float InitialSpeed; //Field offset: 0x50
	public float Speed; //Field offset: 0x54
	public float DamageDegradationCoefficient; //Field offset: 0x58
	public float Damage; //Field offset: 0x5C
	public float PenetrationPower; //Field offset: 0x60
	public float BulletMassGram; //Field offset: 0x64
	public float BulletDiameterMilimeters; //Field offset: 0x68
	public float PenetrationChance; //Field offset: 0x6C
	public float RicochetChance; //Field offset: 0x70
	public float FragmentationChance; //Field offset: 0x74
	public float DeviationChance; //Field offset: 0x78
	public Nullable BlockedBy; //Field offset: 0x80
	public bool DelayedDamage; //Field offset: 0xA0
	public Nullable DeflectedBy; //Field offset: 0xA8
	public Nullable HitArmorItemID; //Field offset: 0xC8
	public int MinFragmentsCount; //Field offset: 0xE8
	public int MaxFragmentsCount; //Field offset: 0xEC
	public float TimeSinceShot; //Field offset: 0xF0
	public Vector3 StartPosition; //Field offset: 0xF4
	public Vector3 StartVelocity; //Field offset: 0x100
	public TrajectoryCalculator TrajectoryInfo; //Field offset: 0x110
	private Vector3 _currentPosition; //Field offset: 0x118
	private Vector3 _velocity; //Field offset: 0x124
	[CompilerGenerated]
	private float <BallisticCoefficient>k__BackingField; //Field offset: 0x130
	public BallisticCollider HittedBallisticCollider; //Field offset: 0x138
	[CanBeNull]
	private BallisticCollider _defaultHitBody; //Field offset: 0x140
	public IRandom Randoms; //Field offset: 0x148
	private RaycastHit _hit; //Field offset: 0x150
	public bool IsForwardHit; //Field offset: 0x17C
	public bool AvoidAdditionalDamage; //Field offset: 0x17D
	private float _hitCosDirectionToNormal; //Field offset: 0x180
	public readonly List Fragments; //Field offset: 0x188
	public IObserverToPlayerBridge Player; //Field offset: 0x190
	public int PlayerRaidId; //Field offset: 0x198
	public Item Weapon; //Field offset: 0x1A0
	public int FireIndex; //Field offset: 0x1A8
	public Shot Parent; //Field offset: 0x1B0
	private IPlayer _playerHitWhereCollidersIntersect; //Field offset: 0x1B8
	private Func _isHitIgnoredTest; //Field offset: 0x1C0
	private readonly Collider[] _hitColliders; //Field offset: 0x1C8
	public bool ShotProcessed; //Field offset: 0x1D0
	public float A; //Field offset: 0x1D4
	public float B; //Field offset: 0x1D8
	public float C; //Field offset: 0x1DC
	private Vector3 _lastDeltaPositionVector3; //Field offset: 0x1E0
	public float TimeLeftSinceFrameStart; //Field offset: 0x1EC

	public bool AreAllFragmentsFinished
	{
		 get { } //Length: 261
	}

	public private float BallisticCoefficient
	{
		[CompilerGenerated]
		 get { } //Length: 9
		[CompilerGenerated]
		private set { } //Length: 9
	}

	public private EBulletState BulletState
	{
		[CompilerGenerated]
		 get { } //Length: 164
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public Vector3 CurrentDirection
	{
		 get { } //Length: 253
	}

	public Vector3 CurrentPosition
	{
		 get { } //Length: 25
	}

	public Vector3 CurrentVelocity
	{
		 get { } //Length: 25
	}

	public float GetTimeSinceShot
	{
		 get { } //Length: 9
	}

	public bool HasAchievedTarget
	{
		 get { } //Length: 206
	}

	public override Collider HitCollider
	{
		 get { } //Length: 14
	}

	public float HitCosDirectionToNormal
	{
		 get { } //Length: 9
	}

	public override Vector3 HitNormal
	{
		 get { } //Length: 27
	}

	public override Vector3 HitPoint
	{
		 get { } //Length: 27
	}

	public bool IsFirstFragment
	{
		 get { } //Length: 12
	}

	public bool IsFirstHit
	{
		 get { } //Length: 42
	}

	public bool IsFlyingOutOfTime
	{
		 get { } //Length: 16
	}

	public bool IsShotAndParentFinished
	{
		 get { } //Length: 63
	}

	public bool IsShotFinished
	{
		 get { } //Length: 49
	}

	public float VelocityMagnitude
	{
		 get { } //Length: 12
	}

	public float VelocitySqrMagnitude
	{
		 get { } //Length: 47
	}

	private static Shot() { }

	protected Shot() { }

	public void AddClientHitPosition(PlayerHitInfo playerHitInfo) { }

	private static void ApplyPenetratedDegradation(BallisticCollider parentBallisticCollider, bool isForwardHit, Shot shot) { }

	private void AvoidAdditionalDamageWhereCollidersIntersect() { }

	public static float CalculateG1DragCoefficient(float velocity) { }

	public static void CalculateStartVelocity(float currentPosition, float startPosition, out float startVelocity, float time) { }

	private bool CheckCollision(Vector3 prevPosition, Vector3 nextPosition, LayerMask forwardLayerMask, LayerMask backwardLayerMask, Func isHitIgnoredTest) { }

	private bool CheckCollision(Vector3 prevPosition, Vector3 nextPosition) { }

	private bool CheckCollisionForSpirit(Vector3 prevPosition, Vector3 nextPosition) { }

	private PlayerSpirit CheckCollisionWithSpirit(Vector3 prevPosition, Vector3 nextPosition, LayerMask layerMask) { }

	private bool CheckTrajectoryDeviationChance() { }

	public static Shot Create(Item ammo, int fragmentIndex, int seed, Vector3 origin, Vector3 direction, float initialSpeed, float speed, float bulletMassGram, float bulletDiameterMilimeters, float damage, float penetrationPower, float penetrationChance, float ricochetChance, float fragmentationChance, float deviationChance, int minFragmentsCount, int maxFragmentsCount, BallisticCollider defaultBallisticCollider, IRandom randoms, float ballisticCoefficient, Vector3 abc, int player, Item weapon, int fireIndex, Shot parent, bool delayedDamage = false) { }

	private void CreateBulletFragments() { }

	private void CreateDeviatedFragment() { }

	private void CreateFragments() { }

	private void CreateRicochetedFragment(bool isHeavyArmorRicochet = false) { }

	public void DrawGizmos() { }

	public static void FillPool() { }

	public static void FormTrajectory(Vector3 zeroPosition, Vector3 zeroVelocity, float bulletMassGram, float bulletDiameterMilimeters, float ballisticCoefficient, out TrajectoryCalculator trajectoryInfo) { }

	public bool get_AreAllFragmentsFinished() { }

	[CompilerGenerated]
	public float get_BallisticCoefficient() { }

	[CompilerGenerated]
	public EBulletState get_BulletState() { }

	public Vector3 get_CurrentDirection() { }

	public Vector3 get_CurrentPosition() { }

	public Vector3 get_CurrentVelocity() { }

	public float get_GetTimeSinceShot() { }

	public bool get_HasAchievedTarget() { }

	public override Collider get_HitCollider() { }

	public float get_HitCosDirectionToNormal() { }

	public override Vector3 get_HitNormal() { }

	public override Vector3 get_HitPoint() { }

	public bool get_IsFirstFragment() { }

	public bool get_IsFirstHit() { }

	public bool get_IsFlyingOutOfTime() { }

	public bool get_IsShotAndParentFinished() { }

	public bool get_IsShotFinished() { }

	public float get_VelocityMagnitude() { }

	public float get_VelocitySqrMagnitude() { }

	public int GetAllFragmentsRecursively(Shot[] shots) { }

	private Vector3 GetDeviatedTrajectory() { }

	private static int GetRicochetCount(Shot shot, int count = 0) { }

	private static Shot GetShotFromPool() { }

	private void HandleCollision(float deltaTime, Vector3 prevVector3, Vector3 prevVelocity) { }

	protected void Init(Item ammo, int fragmentIndex, int seed, Vector3 origin, Vector3 direction, float initialSpeed, float speed, float bulletMassKg, float bulletDiameterM, float damage, float penetrationPower, float penetrationChance, float ricochetChance, float fragmentationChance, float deviationChance, int minFragmentsCount, int maxFragmentsCount, BallisticCollider defaultBallisticCollider, IRandom randoms, float ballisticCoefficient, Vector3 abc, int playerRaidId, Item weapon, int fireIndex, Shot parent, bool delayedDamage) { }

	private static bool IsArmorPlateTheSame(ArmorPlateCollider one, ArmorPlateCollider other) { }

	private bool IsBulletDeviated() { }

	private bool IsBulletFragmented() { }

	public static bool IsHitIgnored(IObserverToPlayerBridge player, RaycastHit hit, bool isFirstFragment) { }

	private bool IsHitIgnored(RaycastHit hit) { }

	private bool IsIgnoreSameCollider(RaycastHit hit) { }

	private static bool IsParentHasSameBodyPart(Shot shot, Shot parent) { }

	private bool IsPlayerNotAIWithGrenade(IObserverToPlayerBridge player, Item item) { }

	private bool IsRicocheted() { }

	private bool IsShotDeflectedByHeavyArmor() { }

	private bool IsTargetPenetrated() { }

	public static bool LinecastInBothSides(Vector3 start, Vector3 end, out RaycastHit bestHit, out bool isForwardHit, LayerMask forwardLayerMask, LayerMask backwardLayerMask, Func isHitIgnoredTest) { }

	public static void PredictedTrajectoryCalculation(out Vector3 currentPosition, out Vector3 velocity, TrajectoryCalculator trajectoryInfo, float time) { }

	private void PrepareToPool() { }

	public static void Release(Shot shot) { }

	private static void ReturnShotToPool(Shot shot) { }

	[CompilerGenerated]
	private void set_BallisticCoefficient(float value) { }

	[CompilerGenerated]
	private void set_BulletState(EBulletState value) { }

	public static Tuple SquareRoots(float a, float b, float c) { }

	public void Tick(float deltaTime) { }

	public static float TimeToLevel(float deltaHeight, float startVelocity) { }

	public static float TimeToZeroLevel(float startVelocity, float speedRetardation) { }

	private bool TryGetBallisticCollider(RaycastHit hit, out BaseBallistic ballisticCollider) { }

	private void Update(float deltaTime) { }

	private void UpdateBulletPosition(float deltaTime) { }

	public static void Warmup() { }

}

