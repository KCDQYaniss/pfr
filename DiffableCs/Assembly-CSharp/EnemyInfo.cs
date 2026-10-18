//Type is in global namespace

public class EnemyInfo
{
	private static readonly StringBuilder _enemyBuilder; //Field offset: 0x0
	private static readonly StringBuilder _partBuilder; //Field offset: 0x8
	private static readonly StringBuilder _visibilityKBuilder; //Field offset: 0x10
	public BotGroupEnemyInfo GroupInfo; //Field offset: 0x10
	public bool CanISearch; //Field offset: 0x18
	public Vector3 Direction; //Field offset: 0x1C
	public float LastChangeVisionTime; //Field offset: 0x28
	private readonly EnemyVision _enemyVision; //Field offset: 0x30
	private EEnemyPartVisibleType _visibleType; //Field offset: 0x38
	protected bool _canShoot; //Field offset: 0x3C
	private readonly bool _forceHeadCheck; //Field offset: 0x3D
	private int _priorityIndex; //Field offset: 0x40
	private float _nextPartRndTime; //Field offset: 0x44
	private EEnemyPriority _priority; //Field offset: 0x48
	private readonly Dictionary _allParts; //Field offset: 0x50
	private readonly Dictionary _allPartsVision; //Field offset: 0x58
	private HashSet _activeParts; //Field offset: 0x60
	private readonly HashSet _maxparts; //Field offset: 0x68
	private readonly HashSet _middleParts; //Field offset: 0x70
	private readonly HashSet _farParts; //Field offset: 0x78
	private float _distance; //Field offset: 0x80
	private bool _lastCheckVision; //Field offset: 0x84
	private float _visibilityLevel; //Field offset: 0x88
	[CompilerGenerated]
	private bool <HaveSeenPersonal>k__BackingField; //Field offset: 0x8C
	[CompilerGenerated]
	private bool <IsVisible>k__BackingField; //Field offset: 0x8D
	[CompilerGenerated]
	private int <SearchIndex>k__BackingField; //Field offset: 0x90
	[CompilerGenerated]
	private readonly IPlayer <Person>k__BackingField; //Field offset: 0x98
	[CompilerGenerated]
	private readonly BotsGroup <GroupOwner>k__BackingField; //Field offset: 0xA0
	[CompilerGenerated]
	private float <LastChangeVisionTypeTime>k__BackingField; //Field offset: 0xA8
	[CompilerGenerated]
	private float <PersonalSeenTime>k__BackingField; //Field offset: 0xAC
	[CompilerGenerated]
	private float <PersonalLastSeenTime>k__BackingField; //Field offset: 0xB0
	[CompilerGenerated]
	private float <PersonalPersuitDistance>k__BackingField; //Field offset: 0xB4
	[CompilerGenerated]
	private float <PersonalLastShootTime>k__BackingField; //Field offset: 0xB8
	public int PersonalShoot; //Field offset: 0xBC
	[CompilerGenerated]
	private Vector3 <PersonalLastPos>k__BackingField; //Field offset: 0xC0
	private float aiming_7_PeriodToBody; //Field offset: 0xCC
	[CompilerGenerated]
	private float <FirstTimeSeen>k__BackingField; //Field offset: 0xD0
	[CompilerGenerated]
	private readonly float <AddTime>k__BackingField; //Field offset: 0xD4
	[CompilerGenerated]
	private readonly string <ProfileId>k__BackingField; //Field offset: 0xD8
	[CompilerGenerated]
	private EnemyPart <LastPartToShoot>k__BackingField; //Field offset: 0xE0
	[CompilerGenerated]
	private readonly BotOwner <Owner>k__BackingField; //Field offset: 0xE8
	[CompilerGenerated]
	private bool <IgnoreUntilAggression>k__BackingField; //Field offset: 0xF0
	[CompilerGenerated]
	private float <LastDoHitTime>k__BackingField; //Field offset: 0xF4
	[CompilerGenerated]
	private float <LastGetHitTime>k__BackingField; //Field offset: 0xF8
	[CompilerGenerated]
	private float <FirstTimeShoot>k__BackingField; //Field offset: 0xFC
	[CompilerGenerated]
	private int <MissRemain>k__BackingField; //Field offset: 0x100
	private EEnemyPartVisibleType _previousVisibleType; //Field offset: 0x104
	private float _visibilityChangeSpeedK; //Field offset: 0x108

	public float AddTime
	{
		[CompilerGenerated]
		 get { } //Length: 9
	}

	public HashSet AllActiveParts
	{
		 get { } //Length: 72
	}

	public override bool CanShoot
	{
		 get { } //Length: 5
	}

	protected override bool CheckPartCanShootOnlyIfVisible
	{
		 get { } //Length: 3
	}

	public Vector3 CurrPosition
	{
		 get { } //Length: 132
	}

	public private float Distance
	{
		 get { } //Length: 9
		private set { } //Length: 56
	}

	public Vector3 EnemyLastPosition
	{
		 get { } //Length: 41
	}

	public bool EnemyLastPositionCheck
	{
		 get { } //Length: 104
	}

	public Vector3 EnemyLastPositionReal
	{
		 get { } //Length: 41
	}

	public int EnemyPlayerId
	{
		 get { } //Length: 158
	}

	public Vector3 EnemyWeaponRootLastPos
	{
		 get { } //Length: 130
	}

	public private float FirstTimeSeen
	{
		[CompilerGenerated]
		 get { } //Length: 9
		[CompilerGenerated]
		private set { } //Length: 9
	}

	public float FirstTimeShoot
	{
		[CompilerGenerated]
		 get { } //Length: 9
		[CompilerGenerated]
		 set { } //Length: 9
	}

	public BotsGroup GroupOwner
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	public bool HaveSeen
	{
		 get { } //Length: 37
	}

	public private bool HaveSeenPersonal
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public private bool IgnoreUntilAggression
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public private override bool IsVisible
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public private float LastChangeVisionTypeTime
	{
		[CompilerGenerated]
		 get { } //Length: 9
		[CompilerGenerated]
		private set { } //Length: 9
	}

	public float LastDoHitTime
	{
		[CompilerGenerated]
		 get { } //Length: 9
		[CompilerGenerated]
		 set { } //Length: 9
	}

	public float LastGetHitTime
	{
		[CompilerGenerated]
		 get { } //Length: 9
		[CompilerGenerated]
		 set { } //Length: 9
	}

	public private EnemyPart LastPartToShoot
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public int MissRemain
	{
		[CompilerGenerated]
		 get { } //Length: 7
		[CompilerGenerated]
		 set { } //Length: 7
	}

	public string Nickname
	{
		 get { } //Length: 100
	}

	public BotOwner Owner
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	public IPlayer Person
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	public Vector3 PersonalLastPos
	{
		[CompilerGenerated]
		 get { } //Length: 25
		[CompilerGenerated]
		 set { } //Length: 22
	}

	public float PersonalLastSeenTime
	{
		[CompilerGenerated]
		 get { } //Length: 9
		[CompilerGenerated]
		 set { } //Length: 9
	}

	public float PersonalLastShootTime
	{
		[CompilerGenerated]
		 get { } //Length: 9
		[CompilerGenerated]
		 set { } //Length: 9
	}

	public float PersonalPersuitDistance
	{
		[CompilerGenerated]
		 get { } //Length: 9
		[CompilerGenerated]
		 set { } //Length: 9
	}

	public private float PersonalSeenTime
	{
		[CompilerGenerated]
		 get { } //Length: 9
		[CompilerGenerated]
		private set { } //Length: 9
	}

	public int PriorityIndex
	{
		 get { } //Length: 4
		 set { } //Length: 130
	}

	public string ProfileId
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	public int SearchIndex
	{
		[CompilerGenerated]
		 get { } //Length: 7
		[CompilerGenerated]
		 set { } //Length: 7
	}

	public float TimeLastSeen
	{
		 get { } //Length: 28
	}

	public float TimeLastSeenReal
	{
		 get { } //Length: 28
	}

	public float VisibilityLevel
	{
		 get { } //Length: 28
	}

	public override EEnemyPartVisibleType VisibleType
	{
		 get { } //Length: 4
	}

	private static EnemyInfo() { }

	public EnemyInfo(BotsGroup botsGroup, IPlayer enemy, BotOwner owner, BotGroupEnemyInfo groupInfo) { }

	[CompilerGenerated]
	private string <LogVision>b__185_0(BodyPartType partType) { }

	[CompilerGenerated]
	private string <LogVision>b__185_1(BodyPartType partType) { }

	[CompilerGenerated]
	private void <SetVisible>g__MissOneShotWithChanceIfLookAtSameDirection|145_0() { }

	[CompilerGenerated]
	private bool <SetVisible>g__MissTwoShotsIfRealPlayerFirstTimeHardToSee|145_1(bool haveSeenPersonal, out bool missShots) { }

	private static void AddIfHave(Dictionary from, HashSet to, BodyPartType partType) { }

	public float AdditionalWeightCauseHit() { }

	private static void ApplyVisionCheck(EnemyPartVision partVision, bool partCanShoot, EnemyVision enemyVision) { }

	public void CheckLookEnemy(LookAllData lookAll, float deltaTime) { }

	public override void Dispose() { }

	private void FindLastPartRnd(bool withLegs, bool canBeHead) { }

	[CompilerGenerated]
	public float get_AddTime() { }

	public HashSet get_AllActiveParts() { }

	public override bool get_CanShoot() { }

	protected override bool get_CheckPartCanShootOnlyIfVisible() { }

	public Vector3 get_CurrPosition() { }

	public float get_Distance() { }

	public Vector3 get_EnemyLastPosition() { }

	public bool get_EnemyLastPositionCheck() { }

	public Vector3 get_EnemyLastPositionReal() { }

	public int get_EnemyPlayerId() { }

	public Vector3 get_EnemyWeaponRootLastPos() { }

	[CompilerGenerated]
	public float get_FirstTimeSeen() { }

	[CompilerGenerated]
	public float get_FirstTimeShoot() { }

	[CompilerGenerated]
	public BotsGroup get_GroupOwner() { }

	public bool get_HaveSeen() { }

	[CompilerGenerated]
	public bool get_HaveSeenPersonal() { }

	[CompilerGenerated]
	public bool get_IgnoreUntilAggression() { }

	[CompilerGenerated]
	public override bool get_IsVisible() { }

	[CompilerGenerated]
	public float get_LastChangeVisionTypeTime() { }

	[CompilerGenerated]
	public float get_LastDoHitTime() { }

	[CompilerGenerated]
	public float get_LastGetHitTime() { }

	[CompilerGenerated]
	public EnemyPart get_LastPartToShoot() { }

	[CompilerGenerated]
	public int get_MissRemain() { }

	public string get_Nickname() { }

	[CompilerGenerated]
	public BotOwner get_Owner() { }

	[CompilerGenerated]
	public IPlayer get_Person() { }

	[CompilerGenerated]
	public Vector3 get_PersonalLastPos() { }

	[CompilerGenerated]
	public float get_PersonalLastSeenTime() { }

	[CompilerGenerated]
	public float get_PersonalLastShootTime() { }

	[CompilerGenerated]
	public float get_PersonalPersuitDistance() { }

	[CompilerGenerated]
	public float get_PersonalSeenTime() { }

	public int get_PriorityIndex() { }

	[CompilerGenerated]
	public string get_ProfileId() { }

	[CompilerGenerated]
	public int get_SearchIndex() { }

	public float get_TimeLastSeen() { }

	public float get_TimeLastSeenReal() { }

	public float get_VisibilityLevel() { }

	public override EEnemyPartVisibleType get_VisibleType() { }

	private float GetAdditionalSensorDistance(BotOwner owner) { }

	public ELookObstacleType GetAimObstacleType() { }

	private float GetAngleK(BotSettings settings, float distanceToEnemyNormalized, out float angleToEnemy) { }

	public Vector3 GetBodyPartPosition() { }

	public EnemyPartVision GetBodyPartVision() { }

	public override string GetDebugInfo() { }

	private float GetDistanceK(float distanceToEnemyNormalized) { }

	private float GetInfectedK() { }

	private float GetInsideFoliageK(out float foliageIntersectionPercent) { }

	public float GetLastBodyHitDistance() { }

	public Vector3 GetPartToShoot() { }

	private Vector3 GetPointBySence() { }

	private float GetRepeatedSeenK(float personalLastSeenTime, Vector3 personalLastSeenPos) { }

	private float GetVisibilityChangeSpeedK(BotSettings settings, IAIData enemyAiData, float personalLastSeenTime, Vector3 personalLastSeenPos, float distanceToEnemyNormalized, float clampedDistance, float deltaTime) { }

	private Vector3 GetVisiblePartToShoot() { }

	private float GetWeatherK(bool enemyIsInside, float enemyDistance, Vector3 directionToEnemy, out float rainK, out float fogK) { }

	public bool HaveNightVision() { }

	private bool IsFullDisappear(BotOwner owner) { }

	private bool IsFullDissapearGreen(BotOwner owner) { }

	public bool IsSuppressed() { }

	private void LogVision(HashSet activePartsTypes, bool startSeeing) { }

	private void PrevIsVisible(bool p0) { }

	private void set_Distance(float value) { }

	[CompilerGenerated]
	private void set_FirstTimeSeen(float value) { }

	[CompilerGenerated]
	public void set_FirstTimeShoot(float value) { }

	[CompilerGenerated]
	private void set_HaveSeenPersonal(bool value) { }

	[CompilerGenerated]
	private void set_IgnoreUntilAggression(bool value) { }

	[CompilerGenerated]
	private void set_IsVisible(bool value) { }

	[CompilerGenerated]
	private void set_LastChangeVisionTypeTime(float value) { }

	[CompilerGenerated]
	public void set_LastDoHitTime(float value) { }

	[CompilerGenerated]
	public void set_LastGetHitTime(float value) { }

	[CompilerGenerated]
	private void set_LastPartToShoot(EnemyPart value) { }

	[CompilerGenerated]
	public void set_MissRemain(int value) { }

	[CompilerGenerated]
	public void set_PersonalLastPos(Vector3 value) { }

	[CompilerGenerated]
	public void set_PersonalLastSeenTime(float value) { }

	[CompilerGenerated]
	public void set_PersonalLastShootTime(float value) { }

	[CompilerGenerated]
	public void set_PersonalPersuitDistance(float value) { }

	[CompilerGenerated]
	private void set_PersonalSeenTime(float value) { }

	public void set_PriorityIndex(int value) { }

	[CompilerGenerated]
	public void set_SearchIndex(int value) { }

	public void SetCanShoot(bool can) { }

	private void SetCloseParts() { }

	private void SetFarParts() { }

	public void SetIgnoreState(bool state = true) { }

	public void SetLastShootTime() { }

	private void SetMiddleParts() { }

	public void SetSuppressEndTime(float supressedEndTime) { }

	public void SetVisible(bool value) { }

	private void SetVisibleType(EEnemyPartVisibleType totalCheckOnlySense) { }

	public bool ShallISuppress() { }

	public bool ShallKnowEnemy() { }

	public bool ShallKnowEnemyLate() { }

	public virtual string ToString() { }

	private bool TryGetEnemyPart(BodyPartType partType, out EnemyPart enemyPart) { }

	private bool TryGetEnemyPartVision(BodyPartType partType, out EnemyPartVision partVision) { }

	private void UpdatePartsLODSet() { }

}

