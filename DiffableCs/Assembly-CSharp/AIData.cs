//Type is in global namespace

public class AIData : IAIData
{
	public const float TILT_VALUE = 5; //Field offset: 0x0
	private const string VODKDA = "5d40407c86f774318526545a"; //Field offset: 0x0
	private const string JACK = "5d403f9186f7743cac3f229b"; //Field offset: 0x0
	private const string MOONSHINE = "5d1b376e86f774252519444e"; //Field offset: 0x0
	private const float ARMORED_GROUP_RECALC_PERIOD = 25; //Field offset: 0x0
	private const int BUHOI_SAVAGE = 2; //Field offset: 0x0
	private const int BUHOI_PMC = 8; //Field offset: 0x0
	private float _nextShootTime; //Field offset: 0x10
	private float _endFlareTime; //Field offset: 0x14
	private float _endMoveTime; //Field offset: 0x18
	private bool useMove; //Field offset: 0x1C
	private readonly MovementContext _movementContext; //Field offset: 0x20
	private BotOwner _botOwner; //Field offset: 0x28
	private TreeInteractive _treeInteractive; //Field offset: 0x30
	private int _kills; //Field offset: 0x38
	private AIDataRoomLogic _roomLogicLogic; //Field offset: 0x40
	private float _lastTiltTime; //Field offset: 0x48
	private float _lastTiltSide; //Field offset: 0x4C
	private readonly HashSet _currentZones; //Field offset: 0x50
	private Vector3 _oldPos; //Field offset: 0x58
	private float _nextCheckTime; //Field offset: 0x64
	private IVoxelChecker _voxelChecker; //Field offset: 0x68
	private bool _cachedHaveArmoredGroup; //Field offset: 0x70
	private bool _isDrunk; //Field offset: 0x71
	private float _prevArmoredGroupCalc; //Field offset: 0x74
	private float _scavAttackerEndPeriod; //Field offset: 0x78
	[CompilerGenerated]
	private readonly AIVisitedThrowGrenadePlace <VisitedThrowGrenadePlace>k__BackingField; //Field offset: 0x80
	[CompilerGenerated]
	private Action OnStationaryTaken; //Field offset: 0x88
	[CompilerGenerated]
	private Action OnBecomeScavAttacker; //Field offset: 0x90
	[CompilerGenerated]
	private Action OnBecomeDrunk; //Field offset: 0x98
	[CompilerGenerated]
	private Action OnTiltDone; //Field offset: 0xA0
	[CompilerGenerated]
	private Action OnComeToPlace; //Field offset: 0xA8
	[CompilerGenerated]
	private Action OnLeavePlace; //Field offset: 0xB0
	[CompilerGenerated]
	private bool <IsAxe>k__BackingField; //Field offset: 0xB8
	[CompilerGenerated]
	private int <EnvironmentId>k__BackingField; //Field offset: 0xBC
	[CompilerGenerated]
	private float <LastShotTime>k__BackingField; //Field offset: 0xC0
	[CompilerGenerated]
	private DateTime <DrinkTimestamp>k__BackingField; //Field offset: 0xC8
	private int _drinks; //Field offset: 0xD0
	[CompilerGenerated]
	private AIPlaceInfo <PlaceInfo>k__BackingField; //Field offset: 0xD8
	[CompilerGenerated]
	private readonly AIDataRequestController <AskRequests>k__BackingField; //Field offset: 0xE0
	[CompilerGenerated]
	private readonly AIBossPlayer <AIBossPlayer>k__BackingField; //Field offset: 0xE8
	[CompilerGenerated]
	private bool <GetFlare>k__BackingField; //Field offset: 0xF0
	[CompilerGenerated]
	private bool <UsingLight>k__BackingField; //Field offset: 0xF1
	[CompilerGenerated]
	private readonly Player <Player>k__BackingField; //Field offset: 0xF8
	[CompilerGenerated]
	private float <PowerOfEquipment>k__BackingField; //Field offset: 0x100
	[CompilerGenerated]
	private float <LastResetPlaceInfo>k__BackingField; //Field offset: 0x104
	[CompilerGenerated]
	private bool <IsAI>k__BackingField; //Field offset: 0x108
	[CompilerGenerated]
	private PlayerHostilityData <PlayerHostilityData>k__BackingField; //Field offset: 0x110
	[CompilerGenerated]
	private BotHostilityData <BotHostilityData>k__BackingField; //Field offset: 0x118
	private bool _haveHelmet; //Field offset: 0x120
	[CompilerGenerated]
	private bool <IsNoOffsetShooting>k__BackingField; //Field offset: 0x121
	private readonly FoliageIntersectionSystem _foliageIntersectionSystem; //Field offset: 0x128

	public event Action OnBecomeDrunk
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public override event Action OnBecomeScavAttacker
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public override event Action OnComeToPlace
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public override event Action OnLeavePlace
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public event Action OnStationaryTaken
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public event Action OnTiltDone
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public override AIBossPlayer AIBossPlayer
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	public override AIDataRequestController AskRequests
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	public private override BotHostilityData BotHostilityData
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public override BotOwner BotOwner
	{
		 get { } //Length: 5
		 set { } //Length: 1827
	}

	public override Transform CurrentFoliageRoot
	{
		 get { } //Length: 30
	}

	public override Collider CurrentFoliageTrigger
	{
		 get { } //Length: 30
	}

	public override HashSet CurrentZones
	{
		 get { } //Length: 5
	}

	public private override DateTime DrinkTimestamp
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 8
	}

	public private override int EnvironmentId
	{
		[CompilerGenerated]
		 get { } //Length: 7
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public override float FlarePower
	{
		 get { } //Length: 383
	}

	public override float FoliageIntersectionPercent
	{
		 get { } //Length: 31
	}

	public private override bool GetFlare
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public override bool HaveHelmet
	{
		 get { } //Length: 8
	}

	public override bool IAmBoss
	{
		 get { } //Length: 30
	}

	public private override bool IsAI
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public private override bool IsAxe
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public override bool IsDrunk
	{
		 get { } //Length: 5
	}

	public override bool IsInside
	{
		 get { } //Length: 11
	}

	public override bool IsInTree
	{
		 get { } //Length: 203
	}

	public override bool IsMute
	{
		 get { } //Length: 239
	}

	public override bool IsNoOffsetShooting
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 7
	}

	public override bool IsScavAttacker
	{
		 get { } //Length: 90
	}

	public private override float LastResetPlaceInfo
	{
		[CompilerGenerated]
		 get { } //Length: 9
		[CompilerGenerated]
		private set { } //Length: 9
	}

	public private override float LastShotTime
	{
		[CompilerGenerated]
		 get { } //Length: 9
		[CompilerGenerated]
		private set { } //Length: 9
	}

	public private override AIPlaceInfo PlaceInfo
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public override Player Player
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	public private override PlayerHostilityData PlayerHostilityData
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public override bool PlayerLoyaltyBossNoAttack
	{
		 get { } //Length: 57
	}

	public override bool PlayerLoyaltyCanBeFreeKilled
	{
		 get { } //Length: 42
	}

	public override bool PlayerLoyaltyIsAggressor
	{
		 get { } //Length: 44
	}

	public override string PlayerProfileNickname
	{
		 get { } //Length: 51
	}

	public override float PoseVisibilityCoef
	{
		 get { } //Length: 288
	}

	public private override float PowerOfEquipment
	{
		[CompilerGenerated]
		 get { } //Length: 9
		[CompilerGenerated]
		private set { } //Length: 9
	}

	public override IAIDataRoomLogic roomLogicLogic
	{
		 get { } //Length: 5
	}

	public override bool ShallPursuit
	{
		 get { } //Length: 124
	}

	private bool UseFlare
	{
		private set { } //Length: 206
	}

	public override bool UseZombieSimpleAnimator
	{
		 get { } //Length: 72
	}

	public private override bool UsingLight
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public override AIVisitedThrowGrenadePlace VisitedThrowGrenadePlace
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	public AIData(BotOwner owner, Player player) { }

	public override void Activate() { }

	[CompilerGenerated]
	public void add_OnBecomeDrunk(Action value) { }

	[CompilerGenerated]
	public override void add_OnBecomeScavAttacker(Action value) { }

	[CompilerGenerated]
	public override void add_OnComeToPlace(Action value) { }

	[CompilerGenerated]
	public override void add_OnLeavePlace(Action value) { }

	[CompilerGenerated]
	public void add_OnStationaryTaken(Action value) { }

	[CompilerGenerated]
	public void add_OnTiltDone(Action value) { }

	public override void AddPlaceInfo(AIPlaceInfo place) { }

	public override void BecomeDrunk() { }

	private bool CalcAxe(Player player) { }

	public override void CalcPower() { }

	private float CalcTotalArmors() { }

	private void CheckVoxel() { }

	public override void Dispose() { }

	public void DoMove() { }

	public override void DrawGizmosFoliageIntersection() { }

	public override void DrawGizmosSelectedVoxel() { }

	private void EffectStartedEvent(IHealthEffect obj) { }

	public override void EnterTree(TreeInteractive treeInteractive) { }

	public override void ExitTree(TreeInteractive treeInteractive) { }

	[CompilerGenerated]
	public override AIBossPlayer get_AIBossPlayer() { }

	[CompilerGenerated]
	public override AIDataRequestController get_AskRequests() { }

	[CompilerGenerated]
	public override BotHostilityData get_BotHostilityData() { }

	public override BotOwner get_BotOwner() { }

	public override Transform get_CurrentFoliageRoot() { }

	public override Collider get_CurrentFoliageTrigger() { }

	public override HashSet get_CurrentZones() { }

	[CompilerGenerated]
	public override DateTime get_DrinkTimestamp() { }

	[CompilerGenerated]
	public override int get_EnvironmentId() { }

	public override float get_FlarePower() { }

	public override float get_FoliageIntersectionPercent() { }

	[CompilerGenerated]
	public override bool get_GetFlare() { }

	public override bool get_HaveHelmet() { }

	public override bool get_IAmBoss() { }

	[CompilerGenerated]
	public override bool get_IsAI() { }

	[CompilerGenerated]
	public override bool get_IsAxe() { }

	public override bool get_IsDrunk() { }

	public override bool get_IsInside() { }

	public override bool get_IsInTree() { }

	public override bool get_IsMute() { }

	[CompilerGenerated]
	public override bool get_IsNoOffsetShooting() { }

	public override bool get_IsScavAttacker() { }

	[CompilerGenerated]
	public override float get_LastResetPlaceInfo() { }

	[CompilerGenerated]
	public override float get_LastShotTime() { }

	[CompilerGenerated]
	public override AIPlaceInfo get_PlaceInfo() { }

	[CompilerGenerated]
	public override Player get_Player() { }

	[CompilerGenerated]
	public override PlayerHostilityData get_PlayerHostilityData() { }

	public override bool get_PlayerLoyaltyBossNoAttack() { }

	public override bool get_PlayerLoyaltyCanBeFreeKilled() { }

	public override bool get_PlayerLoyaltyIsAggressor() { }

	public override string get_PlayerProfileNickname() { }

	public override float get_PoseVisibilityCoef() { }

	[CompilerGenerated]
	public override float get_PowerOfEquipment() { }

	public override IAIDataRoomLogic get_roomLogicLogic() { }

	public override bool get_ShallPursuit() { }

	public override bool get_UseZombieSimpleAnimator() { }

	[CompilerGenerated]
	public override bool get_UsingLight() { }

	[CompilerGenerated]
	public override AIVisitedThrowGrenadePlace get_VisitedThrowGrenadePlace() { }

	private bool HaveArmoredGroup() { }

	public override bool IsBossOrFollowerRequireRevenge() { }

	public override void KillEnemy(Player victim) { }

	public override void LateUpdate() { }

	public override void LeavePlace(AIPlaceInfo place) { }

	private void OnMotionApplied(CollisionFlags obj, Vector3 motion) { }

	private void OnPlayerPoseChanged(int poseToInt) { }

	private void OnTiltChanged(float tiltSide) { }

	[CompilerGenerated]
	public void remove_OnBecomeDrunk(Action value) { }

	[CompilerGenerated]
	public override void remove_OnBecomeScavAttacker(Action value) { }

	[CompilerGenerated]
	public override void remove_OnComeToPlace(Action value) { }

	[CompilerGenerated]
	public override void remove_OnLeavePlace(Action value) { }

	[CompilerGenerated]
	public void remove_OnStationaryTaken(Action value) { }

	[CompilerGenerated]
	public void remove_OnTiltDone(Action value) { }

	private void ResetZones() { }

	[CompilerGenerated]
	private void set_BotHostilityData(BotHostilityData value) { }

	public override void set_BotOwner(BotOwner value) { }

	[CompilerGenerated]
	private void set_DrinkTimestamp(DateTime value) { }

	[CompilerGenerated]
	private void set_EnvironmentId(int value) { }

	[CompilerGenerated]
	private void set_GetFlare(bool value) { }

	[CompilerGenerated]
	private void set_IsAI(bool value) { }

	[CompilerGenerated]
	private void set_IsAxe(bool value) { }

	[CompilerGenerated]
	public void set_IsNoOffsetShooting(bool value) { }

	[CompilerGenerated]
	private void set_LastResetPlaceInfo(float value) { }

	[CompilerGenerated]
	private void set_LastShotTime(float value) { }

	[CompilerGenerated]
	private void set_PlaceInfo(AIPlaceInfo value) { }

	[CompilerGenerated]
	private void set_PlayerHostilityData(PlayerHostilityData value) { }

	[CompilerGenerated]
	private void set_PowerOfEquipment(float value) { }

	private void set_UseFlare(bool value) { }

	[CompilerGenerated]
	private void set_UsingLight(bool value) { }

	public void SetAim(bool value) { }

	public override void SetAttackByLoyalityScav() { }

	public override void SetEnvironment(IndoorTrigger trigger) { }

	public override void SetPosToVoxel(Vector3 pos) { }

	public override void SetStationaryWeapon(Weapon stationaryWeaponItem) { }

	public override void StayInTree(TreeInteractive treeInteractive, Collider enteredCollider, Collider triggerCollider) { }

	public override void TacticalModeChange(bool siActive) { }

	private void TiltDone() { }

	public override void TryPlayShootSound(Player getPlayer, Vector3 position, AISoundType soundType) { }

}

