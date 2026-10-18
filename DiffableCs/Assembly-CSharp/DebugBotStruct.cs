//Type is in global namespace

public struct DebugBotStruct
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass242_0
	{
		public DebugBotStruct cache; //Field offset: 0x10
		public IObserverToPlayerBridge player; //Field offset: 0x278

		public <>c__DisplayClass242_0() { }

		internal void <InitProfile>g__OnIPlayerDeadOrUnspawn|0(IPlayer obj) { }

	}

	public const int MAX_HEALTH = 16000; //Field offset: 0x0
	public const int MAX_WAY_POINTS = 8; //Field offset: 0x0
	private static bool _clientDebugBotPanelSessionErrorLogged; //Field offset: 0x0
	[CompilerGenerated]
	private static int <BrokenPacketErrorsCount>k__BackingField; //Field offset: 0x4
	public DebugBotDataStructInner BotData; //Field offset: 0x0
	public DebugAIDataStruct AIData; //Field offset: 0x168
	public DebugHeathsDataStructInner HeathsData; //Field offset: 0x1B0
	public DebugBotCoverStruct CoverStruct; //Field offset: 0x208
	public DebugBotVisionStruct VisionData; //Field offset: 0x230
	public float Dist; //Field offset: 0x240
	public IObserverToPlayerBridge PlayerOwner; //Field offset: 0x248
	[CompilerGenerated]
	private string <FakeProfileID>k__BackingField; //Field offset: 0x250
	public int PlayerRaidId; //Field offset: 0x258
	[CompilerGenerated]
	private bool <IsLeavedOrDead>k__BackingField; //Field offset: 0x25C
	public bool CanLookThoughtGrass; //Field offset: 0x25D
	public bool InBuildingTarget; //Field offset: 0x25E
	public bool InBuildingMe; //Field offset: 0x25F
	public bool CanShoot; //Field offset: 0x260

	public float AccuratySpeed
	{
		 get { } //Length: 9
	}

	public int Ammo
	{
		 get { } //Length: 4
	}

	public bool AnyInited
	{
		 get { } //Length: 25
	}

	public float BaseVisibilityChangeSpeed
	{
		 get { } //Length: 6
	}

	public int BotDifficulty
	{
		 get { } //Length: 7
	}

	public int BotMoverCurrentState
	{
		 get { } //Length: 4
	}

	public int BotRole
	{
		 get { } //Length: 7
	}

	public private static int BrokenPacketErrorsCount
	{
		[CompilerGenerated]
		 get { } //Length: 59
		[CompilerGenerated]
		private set { } //Length: 64
	}

	public int CoverIndex
	{
		 get { } //Length: 4
	}

	public string CurrentHandsControllerState
	{
		 get { } //Length: 8
	}

	public string CurrentHandsItemTemplateId
	{
		 get { } //Length: 8
	}

	public string CustomData
	{
		 get { } //Length: 8
	}

	public bool Damaged
	{
		 get { } //Length: 8
	}

	public Vector3 DoorOpenerCurrentDoorPosition
	{
		 get { } //Length: 19
	}

	public private string FakeProfileID
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public int GoalEnemyPlayerId
	{
		 get { } //Length: 4
	}

	public float GreenDist
	{
		 get { } //Length: 6
	}

	public byte GreenType
	{
		 get { } //Length: 5
	}

	public bool Hands
	{
		 get { } //Length: 8
	}

	public bool HandsControllerCanRemove
	{
		 get { } //Length: 8
	}

	public bool HaveAxeEnemy
	{
		 get { } //Length: 5
	}

	public bool HaveGrenade
	{
		 get { } //Length: 5
	}

	public bool HaveMeds
	{
		 get { } //Length: 8
	}

	public bool HaveStimulator
	{
		 get { } //Length: 8
	}

	public bool HaveSurgical
	{
		 get { } //Length: 8
	}

	public bool HaveUnderbarrelLauncher
	{
		 get { } //Length: 8
	}

	public int HealthBody
	{
		 get { } //Length: 7
	}

	public bool HealthBodyBL
	{
		 get { } //Length: 8
	}

	public bool HealthBodyBroken
	{
		 get { } //Length: 8
	}

	public int HealthHead
	{
		 get { } //Length: 7
	}

	public bool HealthHeadBL
	{
		 get { } //Length: 8
	}

	public bool HealthHeadBroken
	{
		 get { } //Length: 8
	}

	public int HealthLeftArm
	{
		 get { } //Length: 7
	}

	public bool HealthLeftArmBL
	{
		 get { } //Length: 8
	}

	public bool HealthLeftArmBroken
	{
		 get { } //Length: 8
	}

	public int HealthLeftLeg
	{
		 get { } //Length: 7
	}

	public bool HealthLeftLegBL
	{
		 get { } //Length: 8
	}

	public bool HealthLeftLegBroken
	{
		 get { } //Length: 8
	}

	public int HealthRightArm
	{
		 get { } //Length: 7
	}

	public bool HealthRightArmBL
	{
		 get { } //Length: 8
	}

	public bool HealthRightArmBroken
	{
		 get { } //Length: 8
	}

	public int HealthRightLeg
	{
		 get { } //Length: 7
	}

	public bool HealthRightLegBL
	{
		 get { } //Length: 8
	}

	public bool HealthRightLegBroken
	{
		 get { } //Length: 8
	}

	public int HealthStomach
	{
		 get { } //Length: 7
	}

	public bool HealthStomachBL
	{
		 get { } //Length: 8
	}

	public bool HealthStomachBroken
	{
		 get { } //Length: 8
	}

	public int HitsOnMe
	{
		 get { } //Length: 7
	}

	public int HourServer
	{
		 get { } //Length: 4
	}

	public int Id
	{
		 get { } //Length: 7
	}

	public bool InCover
	{
		 get { } //Length: 5
	}

	public bool InitedBotData
	{
		 get { } //Length: 4
	}

	public bool IsChangingWeapon
	{
		 get { } //Length: 8
	}

	public bool IsFlashed
	{
		 get { } //Length: 5
	}

	public bool IsGoalEnemyVisible
	{
		 get { } //Length: 5
	}

	public bool IsHandsNull
	{
		 get { } //Length: 8
	}

	public bool IsInInteractionStrictCheck
	{
		 get { } //Length: 8
	}

	public bool IsInPronePos
	{
		 get { } //Length: 5
	}

	public bool IsInSpawnWeapon
	{
		 get { } //Length: 5
	}

	public bool IsLay
	{
		 get { } //Length: 5
	}

	public private bool IsLeavedOrDead
	{
		[CompilerGenerated]
		[IsReadOnly]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public bool IsParametesChanged
	{
		 get { } //Length: 5
	}

	public bool IsProblem
	{
		 get { } //Length: 5
	}

	public string LayerName
	{
		 get { } //Length: 8
	}

	public string LookDirType
	{
		 get { } //Length: 5
	}

	public int MainTactic
	{
		 get { } //Length: 4
	}

	public int MaxHealthBody
	{
		 get { } //Length: 7
	}

	public int MaxHealthHead
	{
		 get { } //Length: 7
	}

	public int MaxHealthLeftArm
	{
		 get { } //Length: 7
	}

	public int MaxHealthLeftLeg
	{
		 get { } //Length: 7
	}

	public int MaxHealthRightArm
	{
		 get { } //Length: 7
	}

	public int MaxHealthRightLeg
	{
		 get { } //Length: 7
	}

	public int MaxHealthStomach
	{
		 get { } //Length: 7
	}

	public string Name
	{
		 get { } //Length: 5
	}

	public string NodeName
	{
		 get { } //Length: 8
	}

	public int NodeRepeats
	{
		 get { } //Length: 7
	}

	public bool PatrolPointStatus
	{
		 get { } //Length: 8
	}

	public bool PatrolWayStatus
	{
		 get { } //Length: 8
	}

	public EPlayerState PlayerState
	{
		 get { } //Length: 8
	}

	public float PoseLevel
	{
		 get { } //Length: 6
	}

	public Vector3 PositionOnWay
	{
		 get { } //Length: 25
	}

	public string PrevNodeExitReason
	{
		 get { } //Length: 8
	}

	public string PrevNodeName
	{
		 get { } //Length: 8
	}

	public string Reason
	{
		 get { } //Length: 8
	}

	public bool Reloading
	{
		 get { } //Length: 5
	}

	public int Request
	{
		 get { } //Length: 4
	}

	public float RuntimeVisionEffectK
	{
		 get { } //Length: 9
	}

	public float RuntimeVisionEffectKCur
	{
		 get { } //Length: 9
	}

	public float ScatteringPerMeter
	{
		 get { } //Length: 9
	}

	public float ScatteringPerMeterCur
	{
		 get { } //Length: 9
	}

	public bool ShallRunIfNoAmmo
	{
		 get { } //Length: 8
	}

	public bool Shooting
	{
		 get { } //Length: 5
	}

	public int ShootsOnMe
	{
		 get { } //Length: 7
	}

	public BotStandByType StandBy
	{
		 get { } //Length: 7
	}

	public bool StateIsSuitableForHandInput
	{
		 get { } //Length: 8
	}

	public EBotState Status
	{
		 get { } //Length: 164
	}

	public string StrategyName
	{
		 get { } //Length: 5
	}

	public string Target
	{
		 get { } //Length: 76
	}

	public Vector3 TargetPoint
	{
		 get { } //Length: 25
	}

	public bool TriangleLoad
	{
		 get { } //Length: 5
	}

	public bool UnderbarrelLauncherActive
	{
		 get { } //Length: 8
	}

	public bool UnderbarrelLauncherHasAmmoInChamber
	{
		 get { } //Length: 8
	}

	public bool UnderFire
	{
		 get { } //Length: 5
	}

	public bool UseMeds
	{
		 get { } //Length: 8
	}

	public bool UseStimulator
	{
		 get { } //Length: 8
	}

	public bool UseSurgical
	{
		 get { } //Length: 8
	}

	public float VisibleDist
	{
		 get { } //Length: 6
	}

	public Vector3[] WayPoints
	{
		 get { } //Length: 8
	}

	public int WayPointsCount
	{
		 get { } //Length: 29
	}

	public DebugBotStruct(BotOwner owner, float dist, IPlayer currentPlayer) { }

	public DebugBotStruct(IAIData aiData, float dist, IPlayer currentPlayer) { }

	public float get_AccuratySpeed() { }

	public int get_Ammo() { }

	public bool get_AnyInited() { }

	public float get_BaseVisibilityChangeSpeed() { }

	public int get_BotDifficulty() { }

	public int get_BotMoverCurrentState() { }

	public int get_BotRole() { }

	[CompilerGenerated]
	public static int get_BrokenPacketErrorsCount() { }

	public int get_CoverIndex() { }

	public string get_CurrentHandsControllerState() { }

	public string get_CurrentHandsItemTemplateId() { }

	public string get_CustomData() { }

	public bool get_Damaged() { }

	public Vector3 get_DoorOpenerCurrentDoorPosition() { }

	[CompilerGenerated]
	[IsReadOnly]
	public string get_FakeProfileID() { }

	public int get_GoalEnemyPlayerId() { }

	public float get_GreenDist() { }

	public byte get_GreenType() { }

	public bool get_Hands() { }

	public bool get_HandsControllerCanRemove() { }

	public bool get_HaveAxeEnemy() { }

	public bool get_HaveGrenade() { }

	public bool get_HaveMeds() { }

	public bool get_HaveStimulator() { }

	public bool get_HaveSurgical() { }

	public bool get_HaveUnderbarrelLauncher() { }

	public int get_HealthBody() { }

	public bool get_HealthBodyBL() { }

	public bool get_HealthBodyBroken() { }

	public int get_HealthHead() { }

	public bool get_HealthHeadBL() { }

	public bool get_HealthHeadBroken() { }

	public int get_HealthLeftArm() { }

	public bool get_HealthLeftArmBL() { }

	public bool get_HealthLeftArmBroken() { }

	public int get_HealthLeftLeg() { }

	public bool get_HealthLeftLegBL() { }

	public bool get_HealthLeftLegBroken() { }

	public int get_HealthRightArm() { }

	public bool get_HealthRightArmBL() { }

	public bool get_HealthRightArmBroken() { }

	public int get_HealthRightLeg() { }

	public bool get_HealthRightLegBL() { }

	public bool get_HealthRightLegBroken() { }

	public int get_HealthStomach() { }

	public bool get_HealthStomachBL() { }

	public bool get_HealthStomachBroken() { }

	public int get_HitsOnMe() { }

	public int get_HourServer() { }

	public int get_Id() { }

	public bool get_InCover() { }

	public bool get_InitedBotData() { }

	public bool get_IsChangingWeapon() { }

	public bool get_IsFlashed() { }

	public bool get_IsGoalEnemyVisible() { }

	public bool get_IsHandsNull() { }

	public bool get_IsInInteractionStrictCheck() { }

	public bool get_IsInPronePos() { }

	public bool get_IsInSpawnWeapon() { }

	public bool get_IsLay() { }

	[CompilerGenerated]
	[IsReadOnly]
	public bool get_IsLeavedOrDead() { }

	public bool get_IsParametesChanged() { }

	public bool get_IsProblem() { }

	public string get_LayerName() { }

	public string get_LookDirType() { }

	public int get_MainTactic() { }

	public int get_MaxHealthBody() { }

	public int get_MaxHealthHead() { }

	public int get_MaxHealthLeftArm() { }

	public int get_MaxHealthLeftLeg() { }

	public int get_MaxHealthRightArm() { }

	public int get_MaxHealthRightLeg() { }

	public int get_MaxHealthStomach() { }

	public string get_Name() { }

	public string get_NodeName() { }

	public int get_NodeRepeats() { }

	public bool get_PatrolPointStatus() { }

	public bool get_PatrolWayStatus() { }

	public EPlayerState get_PlayerState() { }

	public float get_PoseLevel() { }

	public Vector3 get_PositionOnWay() { }

	public string get_PrevNodeExitReason() { }

	public string get_PrevNodeName() { }

	public string get_Reason() { }

	public bool get_Reloading() { }

	public int get_Request() { }

	public float get_RuntimeVisionEffectK() { }

	public float get_RuntimeVisionEffectKCur() { }

	public float get_ScatteringPerMeter() { }

	public float get_ScatteringPerMeterCur() { }

	public bool get_ShallRunIfNoAmmo() { }

	public bool get_Shooting() { }

	public int get_ShootsOnMe() { }

	public BotStandByType get_StandBy() { }

	public bool get_StateIsSuitableForHandInput() { }

	public EBotState get_Status() { }

	public string get_StrategyName() { }

	public string get_Target() { }

	public Vector3 get_TargetPoint() { }

	public bool get_TriangleLoad() { }

	public bool get_UnderbarrelLauncherActive() { }

	public bool get_UnderbarrelLauncherHasAmmoInChamber() { }

	public bool get_UnderFire() { }

	public bool get_UseMeds() { }

	public bool get_UseStimulator() { }

	public bool get_UseSurgical() { }

	public float get_VisibleDist() { }

	public Vector3[] get_WayPoints() { }

	public int get_WayPointsCount() { }

	private static EDebugBotEffect GetDebugEffects(IEnumerable activeEffects) { }

	private Vector3 GetTargetPoint(BotOwner owner) { }

	private Vector3[] GetWayPoints(BotOwner owner) { }

	private bool HaveBloodloss(IHealthController owner, EBodyPart part) { }

	private void InitAIData(IAIData aiData) { }

	private static void InitProfile(ref DebugBotStruct data, IBitStream stream) { }

	private bool IsBroken(BotOwner owner, EBodyPart part) { }

	public static void SafeExecuteDebugPanelClientOperation(Action operation) { }

	public static void Serialize(ref DebugBotStruct data, IBitStream stream) { }

	private static void SerializeAICoverData(ref DebugBotStruct data, IBitStream stream) { }

	private static void SerializeAIData(ref DebugBotStruct data, IBitStream stream) { }

	private static void SerializeBotData(ref DebugBotStruct data, IBitStream stream) { }

	private static void SerializeCoversLastSearch(ref DebugBotStruct data, IBitStream stream) { }

	private static void SerializeVisionData(ref DebugBotStruct data, IBitStream stream) { }

	[CompilerGenerated]
	private static void set_BrokenPacketErrorsCount(int value) { }

	[CompilerGenerated]
	private void set_FakeProfileID(string value) { }

	[CompilerGenerated]
	private void set_IsLeavedOrDead(bool value) { }

	private void SetCoverStruct(IDebugCoverSearchGraph info) { }

	private void SetDebugCovers(BotOwner owner) { }

	private void SetHealthData(IHealthController healthController) { }

	private void SetMemorySettings(BotOwner owner) { }

	private void SetSettings(BotOwner owner) { }

	public static bool TryDeserializeForDebugPanel(ref DebugBotStruct data, IBitStream stream) { }

}

