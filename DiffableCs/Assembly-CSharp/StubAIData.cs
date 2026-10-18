//Type is in global namespace

public class StubAIData : IAIData
{
	private StubAIDataRoomLogic _roomLogicLogic; //Field offset: 0x10
	[CompilerGenerated]
	private readonly PlayerHostilityData <PlayerHostilityData>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private readonly BotHostilityData <BotHostilityData>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private readonly AIVisitedThrowGrenadePlace <VisitedThrowGrenadePlace>k__BackingField; //Field offset: 0x28
	private HashSet _currentZones; //Field offset: 0x30
	[CompilerGenerated]
	private readonly bool <UseZombieSimpleAnimator>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	private BotOwner <BotOwner>k__BackingField; //Field offset: 0x40
	[CompilerGenerated]
	private readonly bool <IsDrunk>k__BackingField; //Field offset: 0x48
	[CompilerGenerated]
	private readonly DateTime <DrinkTimestamp>k__BackingField; //Field offset: 0x50
	[CompilerGenerated]
	private Action OnBecomeScavAttacker; //Field offset: 0x58
	[CompilerGenerated]
	private Action OnBecomeDrunk; //Field offset: 0x60
	[CompilerGenerated]
	private Action OnComeToPlace; //Field offset: 0x68
	[CompilerGenerated]
	private Action OnLeavePlace; //Field offset: 0x70

	public event Action OnBecomeDrunk
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public override event Action OnBecomeScavAttacker
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public override event Action OnComeToPlace
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public override event Action OnLeavePlace
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public override AIBossPlayer AIBossPlayer
	{
		 get { } //Length: 3
	}

	public override AIDataRequestController AskRequests
	{
		 get { } //Length: 3
	}

	public override BotHostilityData BotHostilityData
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public override BotOwner BotOwner
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public override Transform CurrentFoliageRoot
	{
		 get { } //Length: 3
	}

	public override Collider CurrentFoliageTrigger
	{
		 get { } //Length: 3
	}

	public override HashSet CurrentZones
	{
		 get { } //Length: 76
	}

	public override DateTime DrinkTimestamp
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public override int EnvironmentId
	{
		 get { } //Length: 6
	}

	public override float FlarePower
	{
		 get { } //Length: 4
	}

	public override float FoliageIntersectionPercent
	{
		 get { } //Length: 4
	}

	public override bool GetFlare
	{
		 get { } //Length: 3
	}

	public override bool HaveHelmet
	{
		 get { } //Length: 3
	}

	public override bool IAmBoss
	{
		 get { } //Length: 3
	}

	public override bool IsAI
	{
		 get { } //Length: 3
	}

	public override bool IsAxe
	{
		 get { } //Length: 3
	}

	public override bool IsDrunk
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public override bool IsInside
	{
		 get { } //Length: 3
	}

	public override bool IsInTree
	{
		 get { } //Length: 3
	}

	public override bool IsMute
	{
		 get { } //Length: 3
	}

	public override bool IsNoOffsetShooting
	{
		 get { } //Length: 3
	}

	public override bool IsScavAttacker
	{
		 get { } //Length: 3
	}

	public override float LastResetPlaceInfo
	{
		 get { } //Length: 4
	}

	public override float LastShotTime
	{
		 get { } //Length: 4
	}

	public override AIPlaceInfo PlaceInfo
	{
		 get { } //Length: 3
	}

	public override Player Player
	{
		 get { } //Length: 3
	}

	public override PlayerHostilityData PlayerHostilityData
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public override bool PlayerLoyaltyBossNoAttack
	{
		 get { } //Length: 3
	}

	public override bool PlayerLoyaltyCanBeFreeKilled
	{
		 get { } //Length: 3
	}

	public override bool PlayerLoyaltyIsAggressor
	{
		 get { } //Length: 3
	}

	public override string PlayerProfileNickname
	{
		 get { } //Length: 49
	}

	public override float PoseVisibilityCoef
	{
		 get { } //Length: 9
	}

	public override float PowerOfEquipment
	{
		 get { } //Length: 4
	}

	public override IAIDataRoomLogic roomLogicLogic
	{
		 get { } //Length: 5
	}

	public override bool ShallPursuit
	{
		 get { } //Length: 3
	}

	public override bool UseZombieSimpleAnimator
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public override bool UsingLight
	{
		 get { } //Length: 3
	}

	public override AIVisitedThrowGrenadePlace VisitedThrowGrenadePlace
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public StubAIData() { }

	public override void Activate() { }

	[CompilerGenerated]
	public void add_OnBecomeDrunk(Action value) { }

	[CompilerGenerated]
	public override void add_OnBecomeScavAttacker(Action value) { }

	[CompilerGenerated]
	public override void add_OnComeToPlace(Action value) { }

	[CompilerGenerated]
	public override void add_OnLeavePlace(Action value) { }

	public override void AddPlaceInfo(AIPlaceInfo aiPlaceInfo) { }

	public override void BecomeDrunk() { }

	public override void CalcPower() { }

	public override void Dispose() { }

	public override void DrawGizmosFoliageIntersection() { }

	public override void DrawGizmosSelectedVoxel() { }

	public override void EnterTree(TreeInteractive treeInteractive) { }

	public override void ExitTree(TreeInteractive treeInteractive) { }

	public override AIBossPlayer get_AIBossPlayer() { }

	public override AIDataRequestController get_AskRequests() { }

	[CompilerGenerated]
	public override BotHostilityData get_BotHostilityData() { }

	[CompilerGenerated]
	public override BotOwner get_BotOwner() { }

	public override Transform get_CurrentFoliageRoot() { }

	public override Collider get_CurrentFoliageTrigger() { }

	public override HashSet get_CurrentZones() { }

	[CompilerGenerated]
	public override DateTime get_DrinkTimestamp() { }

	public override int get_EnvironmentId() { }

	public override float get_FlarePower() { }

	public override float get_FoliageIntersectionPercent() { }

	public override bool get_GetFlare() { }

	public override bool get_HaveHelmet() { }

	public override bool get_IAmBoss() { }

	public override bool get_IsAI() { }

	public override bool get_IsAxe() { }

	[CompilerGenerated]
	public override bool get_IsDrunk() { }

	public override bool get_IsInside() { }

	public override bool get_IsInTree() { }

	public override bool get_IsMute() { }

	public override bool get_IsNoOffsetShooting() { }

	public override bool get_IsScavAttacker() { }

	public override float get_LastResetPlaceInfo() { }

	public override float get_LastShotTime() { }

	public override AIPlaceInfo get_PlaceInfo() { }

	public override Player get_Player() { }

	[CompilerGenerated]
	public override PlayerHostilityData get_PlayerHostilityData() { }

	public override bool get_PlayerLoyaltyBossNoAttack() { }

	public override bool get_PlayerLoyaltyCanBeFreeKilled() { }

	public override bool get_PlayerLoyaltyIsAggressor() { }

	public override string get_PlayerProfileNickname() { }

	public override float get_PoseVisibilityCoef() { }

	public override float get_PowerOfEquipment() { }

	public override IAIDataRoomLogic get_roomLogicLogic() { }

	public override bool get_ShallPursuit() { }

	[CompilerGenerated]
	public override bool get_UseZombieSimpleAnimator() { }

	public override bool get_UsingLight() { }

	[CompilerGenerated]
	public override AIVisitedThrowGrenadePlace get_VisitedThrowGrenadePlace() { }

	public override bool IsBossOrFollowerRequireRevenge() { }

	public override void KillEnemy(Player player) { }

	public override void LateUpdate() { }

	public override void LeavePlace(AIPlaceInfo aiPlaceInfo) { }

	[CompilerGenerated]
	public void remove_OnBecomeDrunk(Action value) { }

	[CompilerGenerated]
	public override void remove_OnBecomeScavAttacker(Action value) { }

	[CompilerGenerated]
	public override void remove_OnComeToPlace(Action value) { }

	[CompilerGenerated]
	public override void remove_OnLeavePlace(Action value) { }

	[CompilerGenerated]
	public override void set_BotOwner(BotOwner value) { }

	public override void SetAttackByLoyalityScav() { }

	public override void SetEnvironment(IndoorTrigger trigger) { }

	public override void SetPosToVoxel(Vector3 ownerPosition) { }

	public override void SetStationaryWeapon(Weapon stationaryWeaponItem) { }

	public override void StayInTree(TreeInteractive treeInteractive, Collider enteredCollider, Collider triggerCollider) { }

	public override void TacticalModeChange(bool p0) { }

	public override void TryPlayShootSound(Player getPlayer, Vector3 position, AISoundType spredPower) { }

}

