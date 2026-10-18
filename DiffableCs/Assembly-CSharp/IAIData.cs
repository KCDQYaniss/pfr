//Type is in global namespace

public interface IAIData
{

	public event Action OnBecomeScavAttacker
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public event Action OnComeToPlace
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public event Action OnLeavePlace
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public AIBossPlayer AIBossPlayer
	{
		 get { } //Length: 0
	}

	public AIDataRequestController AskRequests
	{
		 get { } //Length: 0
	}

	public BotHostilityData BotHostilityData
	{
		 get { } //Length: 0
	}

	public BotOwner BotOwner
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public Transform CurrentFoliageRoot
	{
		 get { } //Length: 0
	}

	public Collider CurrentFoliageTrigger
	{
		 get { } //Length: 0
	}

	public HashSet CurrentZones
	{
		 get { } //Length: 0
	}

	public DateTime DrinkTimestamp
	{
		 get { } //Length: 0
	}

	public int EnvironmentId
	{
		 get { } //Length: 0
	}

	public float FlarePower
	{
		 get { } //Length: 0
	}

	public float FoliageIntersectionPercent
	{
		 get { } //Length: 0
	}

	public bool GetFlare
	{
		 get { } //Length: 0
	}

	public bool HaveHelmet
	{
		 get { } //Length: 0
	}

	public bool IAmBoss
	{
		 get { } //Length: 0
	}

	public bool IsAI
	{
		 get { } //Length: 0
	}

	public bool IsAxe
	{
		 get { } //Length: 0
	}

	public bool IsDrunk
	{
		 get { } //Length: 0
	}

	public bool IsInside
	{
		 get { } //Length: 0
	}

	public bool IsInTree
	{
		 get { } //Length: 0
	}

	public bool IsMute
	{
		 get { } //Length: 0
	}

	public bool IsNoOffsetShooting
	{
		 get { } //Length: 0
	}

	public bool IsScavAttacker
	{
		 get { } //Length: 0
	}

	public float LastResetPlaceInfo
	{
		 get { } //Length: 0
	}

	public float LastShotTime
	{
		 get { } //Length: 0
	}

	public AIPlaceInfo PlaceInfo
	{
		 get { } //Length: 0
	}

	public Player Player
	{
		 get { } //Length: 0
	}

	public PlayerHostilityData PlayerHostilityData
	{
		 get { } //Length: 0
	}

	public bool PlayerLoyaltyBossNoAttack
	{
		 get { } //Length: 0
	}

	public bool PlayerLoyaltyCanBeFreeKilled
	{
		 get { } //Length: 0
	}

	public bool PlayerLoyaltyIsAggressor
	{
		 get { } //Length: 0
	}

	public string PlayerProfileNickname
	{
		 get { } //Length: 0
	}

	public float PoseVisibilityCoef
	{
		 get { } //Length: 0
	}

	public float PowerOfEquipment
	{
		 get { } //Length: 0
	}

	public IAIDataRoomLogic roomLogicLogic
	{
		 get { } //Length: 0
	}

	public bool ShallPursuit
	{
		 get { } //Length: 0
	}

	public bool UseZombieSimpleAnimator
	{
		 get { } //Length: 0
	}

	public bool UsingLight
	{
		 get { } //Length: 0
	}

	public AIVisitedThrowGrenadePlace VisitedThrowGrenadePlace
	{
		 get { } //Length: 0
	}

	public void Activate() { }

	[CompilerGenerated]
	public void add_OnBecomeScavAttacker(Action value) { }

	[CompilerGenerated]
	public void add_OnComeToPlace(Action value) { }

	[CompilerGenerated]
	public void add_OnLeavePlace(Action value) { }

	public void AddPlaceInfo(AIPlaceInfo aiPlaceInfo) { }

	public void BecomeDrunk() { }

	public void CalcPower() { }

	public void Dispose() { }

	public void DrawGizmosFoliageIntersection() { }

	public void DrawGizmosSelectedVoxel() { }

	public void EnterTree(TreeInteractive treeInteractive) { }

	public void ExitTree(TreeInteractive treeInteractive) { }

	public AIBossPlayer get_AIBossPlayer() { }

	public AIDataRequestController get_AskRequests() { }

	public BotHostilityData get_BotHostilityData() { }

	public BotOwner get_BotOwner() { }

	public Transform get_CurrentFoliageRoot() { }

	public Collider get_CurrentFoliageTrigger() { }

	public HashSet get_CurrentZones() { }

	public DateTime get_DrinkTimestamp() { }

	public int get_EnvironmentId() { }

	public float get_FlarePower() { }

	public float get_FoliageIntersectionPercent() { }

	public bool get_GetFlare() { }

	public bool get_HaveHelmet() { }

	public bool get_IAmBoss() { }

	public bool get_IsAI() { }

	public bool get_IsAxe() { }

	public bool get_IsDrunk() { }

	public bool get_IsInside() { }

	public bool get_IsInTree() { }

	public bool get_IsMute() { }

	public bool get_IsNoOffsetShooting() { }

	public bool get_IsScavAttacker() { }

	public float get_LastResetPlaceInfo() { }

	public float get_LastShotTime() { }

	public AIPlaceInfo get_PlaceInfo() { }

	public Player get_Player() { }

	public PlayerHostilityData get_PlayerHostilityData() { }

	public bool get_PlayerLoyaltyBossNoAttack() { }

	public bool get_PlayerLoyaltyCanBeFreeKilled() { }

	public bool get_PlayerLoyaltyIsAggressor() { }

	public string get_PlayerProfileNickname() { }

	public float get_PoseVisibilityCoef() { }

	public float get_PowerOfEquipment() { }

	public IAIDataRoomLogic get_roomLogicLogic() { }

	public bool get_ShallPursuit() { }

	public bool get_UseZombieSimpleAnimator() { }

	public bool get_UsingLight() { }

	public AIVisitedThrowGrenadePlace get_VisitedThrowGrenadePlace() { }

	public bool IsBossOrFollowerRequireRevenge() { }

	public void KillEnemy(Player player) { }

	public void LateUpdate() { }

	public void LeavePlace(AIPlaceInfo aiPlaceInfo) { }

	[CompilerGenerated]
	public void remove_OnBecomeScavAttacker(Action value) { }

	[CompilerGenerated]
	public void remove_OnComeToPlace(Action value) { }

	[CompilerGenerated]
	public void remove_OnLeavePlace(Action value) { }

	public void set_BotOwner(BotOwner value) { }

	public void SetAttackByLoyalityScav() { }

	public void SetEnvironment(IndoorTrigger trigger) { }

	public void SetPosToVoxel(Vector3 ownerPosition) { }

	public void SetStationaryWeapon(Weapon stationaryWeaponItem) { }

	public void StayInTree(TreeInteractive treeInteractive, Collider enteredCollider, Collider triggerCollider) { }

	public void TacticalModeChange(bool p0) { }

	public void TryPlayShootSound(Player getPlayer, Vector3 position, AISoundType spredPower) { }

}

