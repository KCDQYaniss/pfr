//Type is in global namespace

public sealed class EnemyPartVision
{
	[CompilerGenerated]
	private bool <Visible>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private EEnemyPartVisibleType <VisibleType>k__BackingField; //Field offset: 0x14
	[CompilerGenerated]
	private bool <HasLineOfSight>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private ELookObstacleType <BotToTargetObstacleType>k__BackingField; //Field offset: 0x1C
	[CompilerGenerated]
	private float <VisibilityDuration>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private float <ObstaclePenetrationDepth>k__BackingField; //Field offset: 0x24
	[CompilerGenerated]
	private byte <ObstacleType>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private float <VisibilityLevel>k__BackingField; //Field offset: 0x2C
	public RaycastHit BotToTargetHit; //Field offset: 0x30
	private float _lastVisibleTime; //Field offset: 0x5C
	private float _timeSinceLastVisible; //Field offset: 0x60
	private bool _isGreen; //Field offset: 0x64
	private float _visibilityLevelDelta; //Field offset: 0x68
	private int _grenadesCountAlongLine; //Field offset: 0x6C
	private bool _botToTargetLineOfSight; //Field offset: 0x70
	private float _greenK; //Field offset: 0x74
	private bool _greenTransparent; //Field offset: 0x78
	private SphereCollider _smokeCollider; //Field offset: 0x80
	private float _visibilityChangeSpeed; //Field offset: 0x88
	private bool _canShoot; //Field offset: 0x8C
	private bool _canShootLastValue; //Field offset: 0x8D
	private readonly bool _canAimToPart; //Field offset: 0x8E
	[CompilerGenerated]
	private Vector3 <LastShootCastOffsetLocal>k__BackingField; //Field offset: 0x90
	private Vector3 _lastVisibilityCastOffsetLocal; //Field offset: 0x9C
	private bool _visCastForShootIsTried; //Field offset: 0xA8

	public private ELookObstacleType BotToTargetObstacleType
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public private bool CanShoot
	{
		 get { } //Length: 8
		private set { } //Length: 16
	}

	public private bool HasLineOfSight
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public private Vector3 LastShootCastOffsetLocal
	{
		[CompilerGenerated]
		 get { } //Length: 25
		[CompilerGenerated]
		private set { } //Length: 22
	}

	public private float ObstaclePenetrationDepth
	{
		[CompilerGenerated]
		 get { } //Length: 6
		[CompilerGenerated]
		private set { } //Length: 6
	}

	public private byte ObstacleType
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public private float VisibilityDuration
	{
		[CompilerGenerated]
		 get { } //Length: 6
		[CompilerGenerated]
		private set { } //Length: 6
	}

	public private float VisibilityLevel
	{
		[CompilerGenerated]
		 get { } //Length: 6
		[CompilerGenerated]
		private set { } //Length: 6
	}

	public private bool Visible
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public private EEnemyPartVisibleType VisibleType
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public EnemyPartVision(bool canAimToPart) { }

	public void AppendLogInfo(StringBuilder builder, LogLevel level) { }

	private static float CalcGreenK(float maxVisionPenetrationDepth, float dist, out bool greenTransparent) { }

	public void CalculatePartVisibility(BotOwner owner, EnemyPart enemyPart, LayerMask lookSensorMask, bool onSense, bool onSenceGreen, float addSensorDistance, float visibilityChangeSpeedK, float deltaTime) { }

	private float CalculatePenetration(Vector3 sensorOrigin, Vector3 raycastTargetPosition, Vector3 castDirection, float fullCastDistance) { }

	public void CheckCanShoot(BotOwner botOwner, EnemyPart enemyPart, bool checkOnlyIfVisible = true) { }

	private void CheckLineOfSight(BotOwner owner, EnemyPart part, LayerMask lookSensorMask, float addSensorDistance, ref float visibilityChangeSpeedK) { }

	private void DoCastAndCacheObstacles(BotOwner botOwner, LayerMask lookSensorMask, Vector3 sensorOrigin, Vector3 partRaycastTarget) { }

	[CompilerGenerated]
	public ELookObstacleType get_BotToTargetObstacleType() { }

	public bool get_CanShoot() { }

	[CompilerGenerated]
	public bool get_HasLineOfSight() { }

	[CompilerGenerated]
	public Vector3 get_LastShootCastOffsetLocal() { }

	[CompilerGenerated]
	public float get_ObstaclePenetrationDepth() { }

	[CompilerGenerated]
	public byte get_ObstacleType() { }

	[CompilerGenerated]
	public float get_VisibilityDuration() { }

	[CompilerGenerated]
	public float get_VisibilityLevel() { }

	[CompilerGenerated]
	public bool get_Visible() { }

	[CompilerGenerated]
	public EEnemyPartVisibleType get_VisibleType() { }

	private static ELookObstacleType GetLookObstacleTypeAndCacheIt(Dictionary lookObstaclesCache, Collider hittedCollider) { }

	private static float GetMaxPenetrationDepth(BotOwner botOwner, IPlayer enemyPlayer) { }

	private Vector3 GetPartRaycastTarget(EnemyPart enemyPart, bool hasLineOfSight, Vector3 sensorOrigin) { }

	private EEnemyPartVisibleType GetVisibilityType(bool onSence, bool onSenceGreen) { }

	private bool IsFullDisappearForShoot(BotOwner owner) { }

	private static bool OwnerFullInFoliage(BotOwner botOwner) { }

	private void ProcessTransparentObstacle(IPlayer enemyPlayer, float fullCastDistance, float maxVisionPenetrationDepth) { }

	private void ProcessVisionObstacles(BotOwner botOwner, IPlayer enemyPlayer, Vector3 sensorOrigin, Vector3 raycastTargetPosition, Vector3 castDirection, float fullCastDistance, ref float visibilityChangeSpeedK) { }

	[CompilerGenerated]
	private void set_BotToTargetObstacleType(ELookObstacleType value) { }

	private void set_CanShoot(bool value) { }

	[CompilerGenerated]
	private void set_HasLineOfSight(bool value) { }

	[CompilerGenerated]
	private void set_LastShootCastOffsetLocal(Vector3 value) { }

	[CompilerGenerated]
	private void set_ObstaclePenetrationDepth(float value) { }

	[CompilerGenerated]
	private void set_ObstacleType(byte value) { }

	[CompilerGenerated]
	private void set_VisibilityDuration(float value) { }

	[CompilerGenerated]
	private void set_VisibilityLevel(float value) { }

	[CompilerGenerated]
	private void set_Visible(bool value) { }

	[CompilerGenerated]
	private void set_VisibleType(EEnemyPartVisibleType value) { }

	private static float SphereIntersectionLength(Vector3 center, float radius, Vector3 segmentStart, Vector3 segmentEnd, Vector3 castDirection, float castLength) { }

	private void UpdateVisibility(BotOwner owner, bool onSence, bool onSenceGreen, float deltaTime, float visibilityChangeSpeedK = 1) { }

	private float UpdateVisibilityLevel(BotOwner owner, float visibilityChangeSpeedK, float visibleTime, float deltaTime) { }

	private float UpdateVisibleTime(BotOwner owner, float deltaTime, bool isOnSenceAny) { }

}

