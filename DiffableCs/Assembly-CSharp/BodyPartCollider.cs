//Type is in global namespace

public class BodyPartCollider : BallisticCollider
{
	internal interface IObserverToPlayerBridge
	{

		public IPlayer iPlayer
		{
			 get { } //Length: 0
		}

		public bool UsingSimplifiedSkeleton
		{
			 get { } //Length: 0
		}

		public float WorldTime
		{
			 get { } //Length: 0
		}

		public void ApplyDamageInfo(DamageInfo damageInfo, EBodyPart bodyPartType, EBodyPartColliderType bodyPartCollider, float absorbed) { }

		public PlayerHitInfo ApplyShot(DamageInfo damageInfo, EBodyPart bodyPart, EBodyPartColliderType bodyPartCollider, EArmorPlateCollider armorPlateCollider, ShotId shotId) { }

		public bool CheckArmorHitByDirection(BodyPartCollider bodypart, Vector3 hitpoint, Vector3 shotNormal, Vector3 shotDirection) { }

		public IPlayer get_iPlayer() { }

		public bool get_UsingSimplifiedSkeleton() { }

		public float get_WorldTime() { }

		public bool IsShotDeflectedByHeavyArmor(EBodyPartColliderType colliderType, EArmorPlateCollider armorPlateCollider, int shotSeed) { }

		public bool SetShotStatus(BodyPartCollider bodypart, Shot shot, Vector3 hitpoint, Vector3 shotNormal, Vector3 shotDirection) { }

		public bool TryGetArmorResistData(BodyPartCollider bodyPart, float penetrationPower, out ArmorResistanceData armorResistanceData) { }

	}

	internal class ObserverBridge : IObserverToPlayerBridge
	{
		private ObservedPlayerView _observedPlayer; //Field offset: 0x10
		private PrecalculatedFloatRandoms _heavyVestsDeflectRandoms; //Field offset: 0x18

		public override IPlayer iPlayer
		{
			 get { } //Length: 5
		}

		private IEnumerable ObservedPlayerArmorInfo
		{
			private get { } //Length: 103
		}

		public override bool UsingSimplifiedSkeleton
		{
			 get { } //Length: 30
		}

		public override float WorldTime
		{
			 get { } //Length: 28
		}

		public ObserverBridge(ObservedPlayerView player) { }

		public override void ApplyDamageInfo(DamageInfo damageInfo, EBodyPart bodyPartType, EBodyPartColliderType bodyPartColliderType, float absorbed) { }

		public override PlayerHitInfo ApplyShot(DamageInfo damageInfo, EBodyPart bodyPartType, EBodyPartColliderType colliderType, EArmorPlateCollider armorPlateCollider, ShotId shotId) { }

		public override bool CheckArmorHitByDirection(BodyPartCollider bodypart, Vector3 hitpoint, Vector3 shotNormal, Vector3 shotDirection) { }

		public override IPlayer get_iPlayer() { }

		private IEnumerable get_ObservedPlayerArmorInfo() { }

		public override bool get_UsingSimplifiedSkeleton() { }

		public override float get_WorldTime() { }

		public override bool IsShotDeflectedByHeavyArmor(EBodyPartColliderType colliderType, EArmorPlateCollider armorPlateCollider, int shotSeed) { }

		public override bool SetShotStatus(BodyPartCollider bodypart, Shot shot, Vector3 hitpoint, Vector3 shotNormal, Vector3 shotDirection) { }

		public override bool TryGetArmorResistData(BodyPartCollider bodyPart, float penetrationPower, out ArmorResistanceData armorResistanceData) { }

	}

	internal class PlayerBridge : IObserverToPlayerBridge
	{
		private Player _player; //Field offset: 0x10

		public override IPlayer iPlayer
		{
			 get { } //Length: 5
		}

		public override bool UsingSimplifiedSkeleton
		{
			 get { } //Length: 30
		}

		public override float WorldTime
		{
			 get { } //Length: 137
		}

		public PlayerBridge(Player player) { }

		public override void ApplyDamageInfo(DamageInfo damageInfo, EBodyPart bodyPartType, EBodyPartColliderType bodyPartCollider, float absorbed) { }

		public override PlayerHitInfo ApplyShot(DamageInfo damageInfo, EBodyPart bodyPart, EBodyPartColliderType bodyPartCollider, EArmorPlateCollider armorPlateCollider, ShotId shotId) { }

		public override bool CheckArmorHitByDirection(BodyPartCollider bodypart, Vector3 hitpoint, Vector3 shotNormal, Vector3 shotDirection) { }

		public override IPlayer get_iPlayer() { }

		public override bool get_UsingSimplifiedSkeleton() { }

		public override float get_WorldTime() { }

		public override bool IsShotDeflectedByHeavyArmor(EBodyPartColliderType colliderType, EArmorPlateCollider armorPlateCollider, int shotSeed) { }

		public override bool SetShotStatus(BodyPartCollider bodypart, Shot shot, Vector3 hitpoint, Vector3 shotNormal, Vector3 shotDirection) { }

		public override bool TryGetArmorResistData(BodyPartCollider bodyPart, float penetrationPower, out ArmorResistanceData armorResistanceData) { }

	}

	private const float SLICE_LENGTH_TO_RESET = 0.5; //Field offset: 0x0
	private const float SLICE_DAMAGE_PER_METER = 2; //Field offset: 0x0
	private const float MIN_SLICE_DAMAGE_TO_APPLY = 1; //Field offset: 0x0
	private const float FLAME_DAMAGE = 7.5; //Field offset: 0x0
	private const float FLAME_CALL_DELAY = 0.5; //Field offset: 0x0
	private const float PLATFORM_IMPACT_PERIOD = 1; //Field offset: 0x0
	private const float INSTANT_KILL_DAMAGE = 9999; //Field offset: 0x0
	[Range(0, 1)]
	public float penetrationDamageMod; //Field offset: 0x58
	private float _barbDamage; //Field offset: 0x5C
	private float _flameTimer; //Field offset: 0x60
	private float _platformImpactTimer; //Field offset: 0x64
	private Vector3 _lastBardCutPosition; //Field offset: 0x68
	public EBodyPart BodyPartType; //Field offset: 0x74
	public EBodyPartColliderType BodyPartColliderType; //Field offset: 0x78
	public Collider Collider; //Field offset: 0x80
	public IObserverToPlayerBridge playerBridge; //Field offset: 0x88
	public string PlayerProfileID; //Field offset: 0x90
	public Transform ColliderTransformCached; //Field offset: 0x98
	public Transform TransformCached; //Field offset: 0xA0
	private Func ColliderCenter; //Field offset: 0xA8

	public Vector3 Center
	{
		 get { } //Length: 147
	}

	public IPlayer Player
	{
		 get { } //Length: 81
	}

	public Vector3 RealCenter
	{
		 get { } //Length: 928
	}

	public BodyPartCollider() { }

	public void ApplyEnvironmentalDamage(DamageInfo damageInfo) { }

	public virtual PlayerHitInfo ApplyHit(DamageInfo damageInfo, ShotId shotID) { }

	public void ApplyInstantKill(DamageInfo damageInfo) { }

	public virtual void Awake() { }

	public virtual bool Deflects(float _hitCosDirectionToNormal, Shot shot, Vector3 hitPoint, Vector3 shotNormal, Vector3 shotDirection) { }

	public Vector3 get_Center() { }

	public IPlayer get_Player() { }

	public Vector3 get_RealCenter() { }

	private static Bounds GetBounds(Collider collider) { }

	public Vector3 GetRandomPointToCastLocal(Vector3 lookFromPoint) { }

	protected override void InitColliderSettings() { }

	public bool IsHitToArmor(Vector3 hitPoint, Vector3 shotNormal, Vector3 shotDirection) { }

	public virtual bool IsPenetrated(Shot shot, Vector3 hitPoint) { }

	public bool ProceedBarb() { }

	public void ProceedFlame() { }

	public void ProceedInstantKill() { }

	public void ProceedPlatformImpact(float damage) { }

	public void SetUpPlayer(IPlayer iPlayer) { }

	public virtual void TakeSettingsFrom(BaseBallistic collider) { }

}

