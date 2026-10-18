namespace EFT;

public sealed class BotOwner : MonoBehaviour, IPlayer, IBotOwner
{
	public const float DIST_CHECK_NAVMESH = 0.6; //Field offset: 0x0
	public static readonly Vector3 STAY_HEIGHT; //Field offset: 0x0
	public const string PATH_TO_AI = "AI"; //Field offset: 0x0
	public const string PATH_TO_AI_DEBUG = "AIDebug"; //Field offset: 0x0
	public static readonly Vector3 SIT_HEIGHT; //Field offset: 0xC
	public static int BotCount; //Field offset: 0x18
	[CompilerGenerated]
	private int <RaidId>k__BackingField; //Field offset: 0x20
	private Action _botDiedCallback; //Field offset: 0x28
	private EBotState _botState; //Field offset: 0x30
	private bool _lastHitEvent; //Field offset: 0x34
	private float _nextGetGoalTime; //Field offset: 0x38
	private float _preActivateTime; //Field offset: 0x3C
	private float _activateTime; //Field offset: 0x40
	private float _nextTimeCheckBorn; //Field offset: 0x44
	public DecisionProxy DecisionProxy; //Field offset: 0x48
	public BotDebugMemory DebugMemory; //Field offset: 0x50
	public Transform LookedTransform; //Field offset: 0x58
	[CompilerGenerated]
	private BotMemory <Memory>k__BackingField; //Field offset: 0x60
	[CompilerGenerated]
	private BotSettings <Settings>k__BackingField; //Field offset: 0x68
	private bool _isLocalGame; //Field offset: 0x70
	public float InertiaonDownSpeedTEMP; //Field offset: 0x74
	public float CollectedAngDownSpeedTEMP; //Field offset: 0x78
	[CompilerGenerated]
	private StandartBotBrain <Brain>k__BackingField; //Field offset: 0x80
	[CompilerGenerated]
	private float <ENEMY_LOOK_AT_ME>k__BackingField; //Field offset: 0x88
	[CompilerGenerated]
	private LookSensor <LookSensor>k__BackingField; //Field offset: 0x90
	[CompilerGenerated]
	private DeadBodyData <DeadBodyData>k__BackingField; //Field offset: 0x98
	[CompilerGenerated]
	private BotLay <BotLay>k__BackingField; //Field offset: 0xA0
	[CompilerGenerated]
	private BotTilt <Tilt>k__BackingField; //Field offset: 0xA8
	[CompilerGenerated]
	private BotExfiltrationData <Exfiltration>k__BackingField; //Field offset: 0xB0
	[CompilerGenerated]
	private BotCalcGoal <GoalCulculator>k__BackingField; //Field offset: 0xB8
	[CompilerGenerated]
	private BotGoToPointData <GoToSomePointData>k__BackingField; //Field offset: 0xC0
	[CompilerGenerated]
	private LookData <LookData>k__BackingField; //Field offset: 0xC8
	[CompilerGenerated]
	private BotLight <BotLight>k__BackingField; //Field offset: 0xD0
	[CompilerGenerated]
	private BotTurnAwayLight <BotTurnAwayLight>k__BackingField; //Field offset: 0xD8
	[CompilerGenerated]
	private BotCoverSearchInfo <CoverSearchInfo>k__BackingField; //Field offset: 0xE0
	[CompilerGenerated]
	private BotBoss <Boss>k__BackingField; //Field offset: 0xE8
	[CompilerGenerated]
	private BotLeaveData <LeaveData>k__BackingField; //Field offset: 0xF0
	[CompilerGenerated]
	private BotFollower <BotFollower>k__BackingField; //Field offset: 0xF8
	[CompilerGenerated]
	private BotNeutralsCheskData <NeutralsCheskData>k__BackingField; //Field offset: 0x100
	[CompilerGenerated]
	private BotNightVisionData <NightVision>k__BackingField; //Field offset: 0x108
	[CompilerGenerated]
	private BotLoyaltyData <LoyaltyData>k__BackingField; //Field offset: 0x110
	[CompilerGenerated]
	private BotMinesData <MinesData>k__BackingField; //Field offset: 0x118
	[CompilerGenerated]
	private BotMinesRealtimePlaceFinder <MinesRealtimePlaceFinder>k__BackingField; //Field offset: 0x120
	[CompilerGenerated]
	private BotVoxelesPersonalData <VoxelesPersonalData>k__BackingField; //Field offset: 0x128
	[CompilerGenerated]
	private BotAssaultBuildingData <AssaultBuildingData>k__BackingField; //Field offset: 0x130
	[CompilerGenerated]
	private BotRun <BotRun>k__BackingField; //Field offset: 0x138
	[CompilerGenerated]
	private BotMoveOutFriend <BotMoveOutFriend>k__BackingField; //Field offset: 0x140
	[CompilerGenerated]
	private BotSteering <Steering>k__BackingField; //Field offset: 0x148
	[CompilerGenerated]
	private BotEnemyLookData <EnemyLookData>k__BackingField; //Field offset: 0x150
	[CompilerGenerated]
	private BotGrenadeToPortal <GrenadeToPortal>k__BackingField; //Field offset: 0x158
	[CompilerGenerated]
	private FindPlaceToShootManager <FindPlaceToShoot>k__BackingField; //Field offset: 0x160
	[CompilerGenerated]
	private BotHealAnotherTarget <HealAnotherTarget>k__BackingField; //Field offset: 0x168
	[CompilerGenerated]
	private BotNearDoorData <NearDoorData>k__BackingField; //Field offset: 0x170
	[CompilerGenerated]
	private BotRandomPlanItemDropper <RandomPlanItemDropper>k__BackingField; //Field offset: 0x178
	[CompilerGenerated]
	private BotPeaceHardAim <PeaceHardAim>k__BackingField; //Field offset: 0x180
	[CompilerGenerated]
	private BotPeaceLook <PeaceLook>k__BackingField; //Field offset: 0x188
	[CompilerGenerated]
	private BotUnityEditorRunChecker <UnityEditorRunChecker>k__BackingField; //Field offset: 0x190
	[CompilerGenerated]
	private BotDogFight <DogFight>k__BackingField; //Field offset: 0x198
	[CompilerGenerated]
	private BotPriorityAxeTarget <PriorityAxeTarget>k__BackingField; //Field offset: 0x1A0
	[CompilerGenerated]
	private BotFriendChecker <FriendChecker>k__BackingField; //Field offset: 0x1A8
	[CompilerGenerated]
	private BotNavMeshCutterController <NavMeshCutterController>k__BackingField; //Field offset: 0x1B0
	[CompilerGenerated]
	private BotAvoidDangerPlaces <BotAvoidDangerPlaces>k__BackingField; //Field offset: 0x1B8
	[CompilerGenerated]
	private BotBewarePlantedMine <BewarePlantedMine>k__BackingField; //Field offset: 0x1C0
	[CompilerGenerated]
	private BotBewareGrenade <BewareGrenade>k__BackingField; //Field offset: 0x1C8
	[CompilerGenerated]
	private BotBewareGas <BewareGas>k__BackingField; //Field offset: 0x1D0
	[CompilerGenerated]
	private BotBewareBTR <BewareBTR>k__BackingField; //Field offset: 0x1D8
	[CompilerGenerated]
	private BotPlayerFollowData <PlayerFollowData>k__BackingField; //Field offset: 0x1E0
	[CompilerGenerated]
	private BotMoveToEnemyData <MoveToEnemyData>k__BackingField; //Field offset: 0x1E8
	[CompilerGenerated]
	private BotMoveByMiddleGraph <MoveByMiddleGraph>k__BackingField; //Field offset: 0x1F0
	[CompilerGenerated]
	private ArtilleryDangerPlace <ArtilleryDangerPlace>k__BackingField; //Field offset: 0x1F8
	[CompilerGenerated]
	private BewareArtillery <BewareArtillery>k__BackingField; //Field offset: 0x200
	[CompilerGenerated]
	private BotFlashGrenade <FlashGrenade>k__BackingField; //Field offset: 0x208
	[CompilerGenerated]
	private GrenadeSuicideBotData <GrenadeSuicide>k__BackingField; //Field offset: 0x210
	[CompilerGenerated]
	private BotHealingBySomebody <HealingBySomebody>k__BackingField; //Field offset: 0x218
	[CompilerGenerated]
	private BotPeacefulActions <PeacefulActions>k__BackingField; //Field offset: 0x220
	[CompilerGenerated]
	private BotDeadBodyWork <DeadBodyWork>k__BackingField; //Field offset: 0x228
	[CompilerGenerated]
	private BotLootingData <Looting>k__BackingField; //Field offset: 0x230
	[CompilerGenerated]
	private BotMagazineChecker <MagazineChecker>k__BackingField; //Field offset: 0x238
	[CompilerGenerated]
	private BotSmokeGrenade <SmokeGrenade>k__BackingField; //Field offset: 0x240
	[CompilerGenerated]
	private BotSuppressShoot <SuppressShoot>k__BackingField; //Field offset: 0x248
	[CompilerGenerated]
	private BotSuppressStationary <SuppressStationary>k__BackingField; //Field offset: 0x250
	[CompilerGenerated]
	private BotEnemyChooser <EnemyChooser>k__BackingField; //Field offset: 0x258
	[CompilerGenerated]
	private BotGiftData <GiftData>k__BackingField; //Field offset: 0x260
	[CompilerGenerated]
	private BotDangerPointsData <DangerPointsData>k__BackingField; //Field offset: 0x268
	[CompilerGenerated]
	private BotSuppressGrenade <SuppressGrenade>k__BackingField; //Field offset: 0x270
	[CompilerGenerated]
	private BotBtrData <BotBtrData>k__BackingField; //Field offset: 0x278
	[CompilerGenerated]
	private ShootData <ShootData>k__BackingField; //Field offset: 0x280
	[CompilerGenerated]
	private BotEnemiesController <EnemiesController>k__BackingField; //Field offset: 0x288
	[CompilerGenerated]
	private AimingManager <AimingManager>k__BackingField; //Field offset: 0x290
	[CompilerGenerated]
	private BotPlanDropItem <PlanDropItem>k__BackingField; //Field offset: 0x298
	[CompilerGenerated]
	private BotStandBy <StandBy>k__BackingField; //Field offset: 0x2A0
	[CompilerGenerated]
	private BotCullingState <BotCullingState>k__BackingField; //Field offset: 0x2A8
	[CompilerGenerated]
	private BotHeadData <HeadData>k__BackingField; //Field offset: 0x2B0
	[CompilerGenerated]
	private BotEatDrinkData <EatDrinkData>k__BackingField; //Field offset: 0x2B8
	[CompilerGenerated]
	private BotSecondWeaponData <SecondWeaponData>k__BackingField; //Field offset: 0x2C0
	[CompilerGenerated]
	private BotMedecine <Medecine>k__BackingField; //Field offset: 0x2C8
	[CompilerGenerated]
	private RecoilData <RecoilData>k__BackingField; //Field offset: 0x2D0
	[CompilerGenerated]
	private BotCallForHelp <CallForHelp>k__BackingField; //Field offset: 0x2D8
	[CompilerGenerated]
	private BotCalledData <CalledData>k__BackingField; //Field offset: 0x2E0
	[CompilerGenerated]
	private BotAmbushData <Ambush>k__BackingField; //Field offset: 0x2E8
	[CompilerGenerated]
	private BotFriendlyTilt <FriendlyTilt>k__BackingField; //Field offset: 0x2F0
	[CompilerGenerated]
	private BotLootOpener <LootOpener>k__BackingField; //Field offset: 0x2F8
	[CompilerGenerated]
	private BotCoversData <Covers>k__BackingField; //Field offset: 0x300
	[CompilerGenerated]
	private BotWeaponManager <WeaponManager>k__BackingField; //Field offset: 0x308
	[CompilerGenerated]
	private BotTacticData <Tactic>k__BackingField; //Field offset: 0x310
	[CompilerGenerated]
	private BotDoorOpener <DoorOpener>k__BackingField; //Field offset: 0x318
	[CompilerGenerated]
	private BotGesture <Gesture>k__BackingField; //Field offset: 0x320
	[CompilerGenerated]
	private BotDangerArea <DangerArea>k__BackingField; //Field offset: 0x328
	[CompilerGenerated]
	private BotAssaultDangerArea <AssaultDangerArea>k__BackingField; //Field offset: 0x330
	[CompilerGenerated]
	private BotReceiver <Receiver>k__BackingField; //Field offset: 0x338
	[CompilerGenerated]
	private BotItemTaker <ItemTaker>k__BackingField; //Field offset: 0x340
	[CompilerGenerated]
	private BotExternalItemsController <ExternalItemsController>k__BackingField; //Field offset: 0x348
	[CompilerGenerated]
	private BotItemDropper <ItemDropper>k__BackingField; //Field offset: 0x350
	[CompilerGenerated]
	private BotSearchData <SearchData>k__BackingField; //Field offset: 0x358
	[CompilerGenerated]
	private BotPersonalStats <BotPersonalStats>k__BackingField; //Field offset: 0x360
	[CompilerGenerated]
	private BotShootFromPlace <ShootFromPlace>k__BackingField; //Field offset: 0x368
	[CompilerGenerated]
	private BotWarnData <WarnData>k__BackingField; //Field offset: 0x370
	[CompilerGenerated]
	private BotZoneMigration <BotZoneMigration>k__BackingField; //Field offset: 0x378
	[CompilerGenerated]
	private BotHearingSensor <HearingSensor>k__BackingField; //Field offset: 0x380
	[CompilerGenerated]
	private BotRequestController <BotRequestController>k__BackingField; //Field offset: 0x388
	[CompilerGenerated]
	private BotsController <BotsController>k__BackingField; //Field offset: 0x390
	[CompilerGenerated]
	private BifacialTransform <MyHead>k__BackingField; //Field offset: 0x398
	[CompilerGenerated]
	private DecisionQueue <DecisionQueue>k__BackingField; //Field offset: 0x3A0
	[CompilerGenerated]
	private BotGameEventsData <GameEventsData>k__BackingField; //Field offset: 0x3A8
	[CompilerGenerated]
	private AICorePoint <StartCorePoint>k__BackingField; //Field offset: 0x3B0
	[CompilerGenerated]
	private GameDateTime <GameDateTime>k__BackingField; //Field offset: 0x3B8
	[CompilerGenerated]
	private Vector2 <Lean>k__BackingField; //Field offset: 0x3C0
	[CompilerGenerated]
	private BotAttackManager <BotAttackManager>k__BackingField; //Field offset: 0x3C8
	[CompilerGenerated]
	private BotMover <Mover>k__BackingField; //Field offset: 0x3D0
	[CompilerGenerated]
	private BotTalk <BotTalk>k__BackingField; //Field offset: 0x3D8
	[CompilerGenerated]
	private IGetProfileData <SpawnProfileData>k__BackingField; //Field offset: 0x3E0
	[CompilerGenerated]
	private Action OnBotStateChange; //Field offset: 0x3E8
	[CompilerGenerated]
	private BotsGroup <BotsGroup>k__BackingField; //Field offset: 0x3F0
	[CompilerGenerated]
	private PatrollingData <PatrollingData>k__BackingField; //Field offset: 0x3F8
	[CompilerGenerated]
	private string <ProfileId>k__BackingField; //Field offset: 0x400
	[CompilerGenerated]
	private int <Id>k__BackingField; //Field offset: 0x408
	[CompilerGenerated]
	private BotZone <SpawnBotZone>k__BackingField; //Field offset: 0x410
	[CompilerGenerated]
	private Player <GetPlayer>k__BackingField; //Field offset: 0x418
	[CompilerGenerated]
	private Action OnIPlayerDeadOrUnspawn; //Field offset: 0x420
	[CompilerGenerated]
	private bool <IsInBufferZone>k__BackingField; //Field offset: 0x428
	[CompilerGenerated]
	private EPlayerBtrState <BtrState>k__BackingField; //Field offset: 0x42C
	[CompilerGenerated]
	private readonly byte <ChannelIndex>k__BackingField; //Field offset: 0x430
	[CompilerGenerated]
	private bool <IsDead>k__BackingField; //Field offset: 0x431
	[CompilerGenerated]
	private readonly ECameraType <VisibleToCameraType>k__BackingField; //Field offset: 0x434
	[CompilerGenerated]
	private readonly bool <IsVisibleToCamera>k__BackingField; //Field offset: 0x438

	public event Action OnBotStateChange
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public override event Action OnIPlayerDeadOrUnspawn
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public override string AccountId
	{
		 get { } //Length: 42
	}

	public float ActivateTime
	{
		 get { } //Length: 6
	}

	public override IAIData AIData
	{
		 get { } //Length: 33
	}

	public private AimingManager AimingManager
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public override AITaskManager AITaskManager
	{
		 get { } //Length: 30
	}

	public private BotAmbushData Ambush
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public override EUpdateMode ArmsUpdateMode
	{
		 get { } //Length: 32
	}

	public override EUpdateQueue ArmsUpdateQueue
	{
		 get { } //Length: 32
	}

	public private ArtilleryDangerPlace ArtilleryDangerPlace
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private override BotAssaultBuildingData AssaultBuildingData
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private override BotAssaultDangerArea AssaultDangerArea
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private BewareArtillery BewareArtillery
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private BotBewareBTR BewareBTR
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private BotBewareGas BewareGas
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private BotBewareGrenade BewareGrenade
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private BotBewarePlantedMine BewarePlantedMine
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private override BotBoss Boss
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private BotAttackManager BotAttackManager
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private BotAvoidDangerPlaces BotAvoidDangerPlaces
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private BotBtrData BotBtrData
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private BotCullingState BotCullingState
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private override BotFollower BotFollower
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public override BotHostilityData BotHostilityData
	{
		 get { } //Length: 93
	}

	public private BotLay BotLay
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private BotLight BotLight
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private BotMoveOutFriend BotMoveOutFriend
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private BotPersonalStats BotPersonalStats
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private override BotRequestController BotRequestController
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private BotRun BotRun
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private BotsController BotsController
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public override BotsGroup BotsGroup
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public private override EBotState BotState
	{
		 get { } //Length: 4
		private set { } //Length: 36
	}

	public private override BotTalk BotTalk
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private BotTurnAwayLight BotTurnAwayLight
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private BotZoneMigration BotZoneMigration
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private override StandartBotBrain Brain
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public override EPlayerBtrState BtrState
	{
		[CompilerGenerated]
		 get { } //Length: 7
		[CompilerGenerated]
		 set { } //Length: 7
	}

	public private BotCalledData CalledData
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private BotCallForHelp CallForHelp
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public bool CanSprintPlayer
	{
		 get { } //Length: 57
	}

	public byte ChannelIndex
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	public override ICharacterController CharacterController
	{
		 get { } //Length: 3
	}

	public private BotCoversData Covers
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private BotCoverSearchInfo CoverSearchInfo
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private BotDangerArea DangerArea
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private override BotDangerPointsData DangerPointsData
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private DeadBodyData DeadBodyData
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private override BotDeadBodyWork DeadBodyWork
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private DecisionQueue DecisionQueue
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public Nullable Destination
	{
		 get { } //Length: 84
	}

	public override BotDifficulty Difficulty
	{
		 get { } //Length: 62
	}

	public private BotDogFight DogFight
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private BotDoorOpener DoorOpener
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private BotEatDrinkData EatDrinkData
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private override BotEnemiesController EnemiesController
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private float ENEMY_LOOK_AT_ME
	{
		[CompilerGenerated]
		 get { } //Length: 9
		[CompilerGenerated]
		private set { } //Length: 9
	}

	public private BotEnemyChooser EnemyChooser
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private BotEnemyLookData EnemyLookData
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private BotExfiltrationData Exfiltration
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private BotExternalItemsController ExternalItemsController
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private FindPlaceToShootManager FindPlaceToShoot
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public BifacialTransform Fireport
	{
		 get { } //Length: 186
	}

	public private BotFlashGrenade FlashGrenade
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private BotFriendChecker FriendChecker
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private BotFriendlyTilt FriendlyTilt
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private GameDateTime GameDateTime
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private override BotGameEventsData GameEventsData
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private BotGesture Gesture
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private override Player GetPlayer
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private BotGiftData GiftData
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private BotCalcGoal GoalCulculator
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private BotGoToPointData GoToSomePointData
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private GrenadeSuicideBotData GrenadeSuicide
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private BotGrenadeToPortal GrenadeToPortal
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public override string GroupId
	{
		 get { } //Length: 51
	}

	public override bool HasPathAndNotComplete
	{
		 get { } //Length: 64
	}

	public private BotHeadData HeadData
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private BotHealAnotherTarget HealAnotherTarget
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private BotHealingBySomebody HealingBySomebody
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public override IHealthController HealthController
	{
		 get { } //Length: 33
	}

	public private BotHearingSensor HearingSensor
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private override int Id
	{
		[CompilerGenerated]
		 get { } //Length: 7
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public string Infiltration
	{
		 get { } //Length: 51
	}

	public override InventoryController InventoryController
	{
		 get { } //Length: 45
	}

	public override bool IsAI
	{
		 get { } //Length: 106
	}

	public override bool IsDead
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 7
	}

	public override bool IsInBufferZone
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 7
	}

	public override bool IsVisibleToCamera
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	public override bool IsYourPlayer
	{
		 get { } //Length: 3
	}

	public private BotItemDropper ItemDropper
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private override BotItemTaker ItemTaker
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public bool KeepZoneOnSpawn
	{
		 get { } //Length: 81
	}

	public Vector2 Lean
	{
		[CompilerGenerated]
		 get { } //Length: 25
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public private BotLeaveData LeaveData
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private LookData LookData
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public override Vector3 LookDirection
	{
		 get { } //Length: 59
	}

	public private LookSensor LookSensor
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private BotLootingData Looting
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private BotLootOpener LootOpener
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public override PlayerLoyaltyData Loyalty
	{
		 get { } //Length: 33
	}

	public private BotLoyaltyData LoyaltyData
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private BotMagazineChecker MagazineChecker
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public override Dictionary MainParts
	{
		 get { } //Length: 33
	}

	public private BotMedecine Medecine
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private override BotMemory Memory
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private BotMinesData MinesData
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private BotMinesRealtimePlaceFinder MinesRealtimePlaceFinder
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private BotMoveByMiddleGraph MoveByMiddleGraph
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private override BotMover Mover
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private BotMoveToEnemyData MoveToEnemyData
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private BifacialTransform MyHead
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private BotNavMeshCutterController NavMeshCutterController
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private BotNearDoorData NearDoorData
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private BotNeutralsCheskData NeutralsCheskData
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private BotNightVisionData NightVision
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private override PatrollingData PatrollingData
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private BotPeacefulActions PeacefulActions
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private BotPeaceHardAim PeaceHardAim
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private BotPeaceLook PeaceLook
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private BotPlanDropItem PlanDropItem
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public override PlayerBody PlayerBody
	{
		 get { } //Length: 3
	}

	public override PlayerBones PlayerBones
	{
		 get { } //Length: 33
	}

	public private BotPlayerFollowData PlayerFollowData
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public override Vector3 Position
	{
		 get { } //Length: 86
	}

	public private BotPriorityAxeTarget PriorityAxeTarget
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public override Profile Profile
	{
		 get { } //Length: 33
	}

	public private override string ProfileId
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private override int RaidId
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public private BotRandomPlanItemDropper RandomPlanItemDropper
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private BotReceiver Receiver
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private RecoilData RecoilData
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public override PlayerRecorderController RecorderController
	{
		 get { } //Length: 45
	}

	public override WildSpawnType Role
	{
		 get { } //Length: 62
	}

	public override Vector2 Rotation
	{
		 get { } //Length: 41
	}

	public override IPlayerSearchController SearchController
	{
		 get { } //Length: 57
	}

	public private BotSearchData SearchData
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private BotSecondWeaponData SecondWeaponData
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private override BotSettings Settings
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private override ShootData ShootData
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private BotShootFromPlace ShootFromPlace
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public override EPlayerSide Side
	{
		 get { } //Length: 50
	}

	public private BotSmokeGrenade SmokeGrenade
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private BotZone SpawnBotZone
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public IGetProfileData SpawnProfileData
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public private BotStandBy StandBy
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private override AICorePoint StartCorePoint
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public override bool StateIsSuitableForHandInput
	{
		 get { } //Length: 32
	}

	public private BotSteering Steering
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private BotSuppressGrenade SuppressGrenade
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private BotSuppressShoot SuppressShoot
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private override BotSuppressStationary SuppressStationary
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private override BotTacticData Tactic
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public override string TeamId
	{
		 get { } //Length: 51
	}

	public private BotTilt Tilt
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	[Obsolete("Use Player.Transform instead!", True)]
	public Transform transform
	{
		 get { } //Length: 78
	}

	public override BifacialTransform Transform
	{
		 get { } //Length: 45
	}

	public private BotUnityEditorRunChecker UnityEditorRunChecker
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public override Vector3 Velocity
	{
		 get { } //Length: 153
	}

	public override ECameraType VisibleToCameraType
	{
		[CompilerGenerated]
		 get { } //Length: 7
	}

	public private BotVoxelesPersonalData VoxelesPersonalData
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private override BotWarnData WarnData
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private override BotWeaponManager WeaponManager
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public override BifacialTransform WeaponRoot
	{
		 get { } //Length: 45
	}

	private static BotOwner() { }

	public BotOwner() { }

	private void Activate() { }

	[CompilerGenerated]
	public void add_OnBotStateChange(Action value) { }

	[CompilerGenerated]
	public override void add_OnIPlayerDeadOrUnspawn(Action value) { }

	private void AfterActivationSubscribe() { }

	private void ApplyEffects() { }

	public void CalcGoal() { }

	public HashSet CarePositions() { }

	public static BotOwner Create(Player player, GameObject behaviourTreePrefab, GameDateTime gameDataTime, BotsController botsController, bool isLocalGame, AICorePoint corePointId) { }

	[CanBeNull]
	public ShootToPoint CurrentEnemyTargetPosition(bool sensPosition) { }

	public void Deactivate() { }

	private void DestroyInfo(Func condition, IPlayer person) { }

	public void Disable() { }

	public void Dispose(bool withNulls = true) { }

	public float DistTo(Vector3 v) { }

	private void ExcludeCollisions() { }

	public override CultistAmulet FindCultistAmulet() { }

	public override Option FindItemById(MongoID itemId, bool checkDistance = true, bool checkOwnership = true) { }

	public override RadioTransmitterRecodableComponent FindRadioTransmitter() { }

	private void FixedUpdate() { }

	public override string get_AccountId() { }

	public float get_ActivateTime() { }

	public override IAIData get_AIData() { }

	[CompilerGenerated]
	public AimingManager get_AimingManager() { }

	public override AITaskManager get_AITaskManager() { }

	[CompilerGenerated]
	public BotAmbushData get_Ambush() { }

	public override EUpdateMode get_ArmsUpdateMode() { }

	public override EUpdateQueue get_ArmsUpdateQueue() { }

	[CompilerGenerated]
	public ArtilleryDangerPlace get_ArtilleryDangerPlace() { }

	[CompilerGenerated]
	public override BotAssaultBuildingData get_AssaultBuildingData() { }

	[CompilerGenerated]
	public override BotAssaultDangerArea get_AssaultDangerArea() { }

	[CompilerGenerated]
	public BewareArtillery get_BewareArtillery() { }

	[CompilerGenerated]
	public BotBewareBTR get_BewareBTR() { }

	[CompilerGenerated]
	public BotBewareGas get_BewareGas() { }

	[CompilerGenerated]
	public BotBewareGrenade get_BewareGrenade() { }

	[CompilerGenerated]
	public BotBewarePlantedMine get_BewarePlantedMine() { }

	[CompilerGenerated]
	public override BotBoss get_Boss() { }

	[CompilerGenerated]
	public BotAttackManager get_BotAttackManager() { }

	[CompilerGenerated]
	public BotAvoidDangerPlaces get_BotAvoidDangerPlaces() { }

	[CompilerGenerated]
	public BotBtrData get_BotBtrData() { }

	[CompilerGenerated]
	public BotCullingState get_BotCullingState() { }

	[CompilerGenerated]
	public override BotFollower get_BotFollower() { }

	public override BotHostilityData get_BotHostilityData() { }

	[CompilerGenerated]
	public BotLay get_BotLay() { }

	[CompilerGenerated]
	public BotLight get_BotLight() { }

	[CompilerGenerated]
	public BotMoveOutFriend get_BotMoveOutFriend() { }

	[CompilerGenerated]
	public BotPersonalStats get_BotPersonalStats() { }

	[CompilerGenerated]
	public override BotRequestController get_BotRequestController() { }

	[CompilerGenerated]
	public BotRun get_BotRun() { }

	[CompilerGenerated]
	public BotsController get_BotsController() { }

	[CompilerGenerated]
	public override BotsGroup get_BotsGroup() { }

	public override EBotState get_BotState() { }

	[CompilerGenerated]
	public override BotTalk get_BotTalk() { }

	[CompilerGenerated]
	public BotTurnAwayLight get_BotTurnAwayLight() { }

	[CompilerGenerated]
	public BotZoneMigration get_BotZoneMigration() { }

	[CompilerGenerated]
	public override StandartBotBrain get_Brain() { }

	[CompilerGenerated]
	public override EPlayerBtrState get_BtrState() { }

	[CompilerGenerated]
	public BotCalledData get_CalledData() { }

	[CompilerGenerated]
	public BotCallForHelp get_CallForHelp() { }

	public bool get_CanSprintPlayer() { }

	[CompilerGenerated]
	public byte get_ChannelIndex() { }

	public override ICharacterController get_CharacterController() { }

	[CompilerGenerated]
	public BotCoversData get_Covers() { }

	[CompilerGenerated]
	public BotCoverSearchInfo get_CoverSearchInfo() { }

	[CompilerGenerated]
	public BotDangerArea get_DangerArea() { }

	[CompilerGenerated]
	public override BotDangerPointsData get_DangerPointsData() { }

	[CompilerGenerated]
	public DeadBodyData get_DeadBodyData() { }

	[CompilerGenerated]
	public override BotDeadBodyWork get_DeadBodyWork() { }

	[CompilerGenerated]
	public DecisionQueue get_DecisionQueue() { }

	public Nullable get_Destination() { }

	public override BotDifficulty get_Difficulty() { }

	[CompilerGenerated]
	public BotDogFight get_DogFight() { }

	[CompilerGenerated]
	public BotDoorOpener get_DoorOpener() { }

	[CompilerGenerated]
	public BotEatDrinkData get_EatDrinkData() { }

	[CompilerGenerated]
	public override BotEnemiesController get_EnemiesController() { }

	[CompilerGenerated]
	public float get_ENEMY_LOOK_AT_ME() { }

	[CompilerGenerated]
	public BotEnemyChooser get_EnemyChooser() { }

	[CompilerGenerated]
	public BotEnemyLookData get_EnemyLookData() { }

	[CompilerGenerated]
	public BotExfiltrationData get_Exfiltration() { }

	[CompilerGenerated]
	public BotExternalItemsController get_ExternalItemsController() { }

	[CompilerGenerated]
	public FindPlaceToShootManager get_FindPlaceToShoot() { }

	public BifacialTransform get_Fireport() { }

	[CompilerGenerated]
	public BotFlashGrenade get_FlashGrenade() { }

	[CompilerGenerated]
	public BotFriendChecker get_FriendChecker() { }

	[CompilerGenerated]
	public BotFriendlyTilt get_FriendlyTilt() { }

	[CompilerGenerated]
	public GameDateTime get_GameDateTime() { }

	[CompilerGenerated]
	public override BotGameEventsData get_GameEventsData() { }

	[CompilerGenerated]
	public BotGesture get_Gesture() { }

	[CompilerGenerated]
	public override Player get_GetPlayer() { }

	[CompilerGenerated]
	public BotGiftData get_GiftData() { }

	[CompilerGenerated]
	public BotCalcGoal get_GoalCulculator() { }

	[CompilerGenerated]
	public BotGoToPointData get_GoToSomePointData() { }

	[CompilerGenerated]
	public GrenadeSuicideBotData get_GrenadeSuicide() { }

	[CompilerGenerated]
	public BotGrenadeToPortal get_GrenadeToPortal() { }

	public override string get_GroupId() { }

	public override bool get_HasPathAndNotComplete() { }

	[CompilerGenerated]
	public BotHeadData get_HeadData() { }

	[CompilerGenerated]
	public BotHealAnotherTarget get_HealAnotherTarget() { }

	[CompilerGenerated]
	public BotHealingBySomebody get_HealingBySomebody() { }

	public override IHealthController get_HealthController() { }

	[CompilerGenerated]
	public BotHearingSensor get_HearingSensor() { }

	[CompilerGenerated]
	public override int get_Id() { }

	public string get_Infiltration() { }

	public override InventoryController get_InventoryController() { }

	public override bool get_IsAI() { }

	[CompilerGenerated]
	public override bool get_IsDead() { }

	[CompilerGenerated]
	public override bool get_IsInBufferZone() { }

	[CompilerGenerated]
	public override bool get_IsVisibleToCamera() { }

	public override bool get_IsYourPlayer() { }

	[CompilerGenerated]
	public BotItemDropper get_ItemDropper() { }

	[CompilerGenerated]
	public override BotItemTaker get_ItemTaker() { }

	public bool get_KeepZoneOnSpawn() { }

	[CompilerGenerated]
	public Vector2 get_Lean() { }

	[CompilerGenerated]
	public BotLeaveData get_LeaveData() { }

	[CompilerGenerated]
	public LookData get_LookData() { }

	public override Vector3 get_LookDirection() { }

	[CompilerGenerated]
	public LookSensor get_LookSensor() { }

	[CompilerGenerated]
	public BotLootingData get_Looting() { }

	[CompilerGenerated]
	public BotLootOpener get_LootOpener() { }

	public override PlayerLoyaltyData get_Loyalty() { }

	[CompilerGenerated]
	public BotLoyaltyData get_LoyaltyData() { }

	[CompilerGenerated]
	public BotMagazineChecker get_MagazineChecker() { }

	public override Dictionary get_MainParts() { }

	[CompilerGenerated]
	public BotMedecine get_Medecine() { }

	[CompilerGenerated]
	public override BotMemory get_Memory() { }

	[CompilerGenerated]
	public BotMinesData get_MinesData() { }

	[CompilerGenerated]
	public BotMinesRealtimePlaceFinder get_MinesRealtimePlaceFinder() { }

	[CompilerGenerated]
	public BotMoveByMiddleGraph get_MoveByMiddleGraph() { }

	[CompilerGenerated]
	public override BotMover get_Mover() { }

	[CompilerGenerated]
	public BotMoveToEnemyData get_MoveToEnemyData() { }

	[CompilerGenerated]
	public BifacialTransform get_MyHead() { }

	[CompilerGenerated]
	public BotNavMeshCutterController get_NavMeshCutterController() { }

	[CompilerGenerated]
	public BotNearDoorData get_NearDoorData() { }

	[CompilerGenerated]
	public BotNeutralsCheskData get_NeutralsCheskData() { }

	[CompilerGenerated]
	public BotNightVisionData get_NightVision() { }

	[CompilerGenerated]
	public override PatrollingData get_PatrollingData() { }

	[CompilerGenerated]
	public BotPeacefulActions get_PeacefulActions() { }

	[CompilerGenerated]
	public BotPeaceHardAim get_PeaceHardAim() { }

	[CompilerGenerated]
	public BotPeaceLook get_PeaceLook() { }

	[CompilerGenerated]
	public BotPlanDropItem get_PlanDropItem() { }

	public override PlayerBody get_PlayerBody() { }

	public override PlayerBones get_PlayerBones() { }

	[CompilerGenerated]
	public BotPlayerFollowData get_PlayerFollowData() { }

	public override Vector3 get_Position() { }

	[CompilerGenerated]
	public BotPriorityAxeTarget get_PriorityAxeTarget() { }

	public override Profile get_Profile() { }

	[CompilerGenerated]
	public override string get_ProfileId() { }

	[CompilerGenerated]
	public override int get_RaidId() { }

	[CompilerGenerated]
	public BotRandomPlanItemDropper get_RandomPlanItemDropper() { }

	[CompilerGenerated]
	public BotReceiver get_Receiver() { }

	[CompilerGenerated]
	public RecoilData get_RecoilData() { }

	public override PlayerRecorderController get_RecorderController() { }

	public override WildSpawnType get_Role() { }

	public override Vector2 get_Rotation() { }

	public override IPlayerSearchController get_SearchController() { }

	[CompilerGenerated]
	public BotSearchData get_SearchData() { }

	[CompilerGenerated]
	public BotSecondWeaponData get_SecondWeaponData() { }

	[CompilerGenerated]
	public override BotSettings get_Settings() { }

	[CompilerGenerated]
	public override ShootData get_ShootData() { }

	[CompilerGenerated]
	public BotShootFromPlace get_ShootFromPlace() { }

	public override EPlayerSide get_Side() { }

	[CompilerGenerated]
	public BotSmokeGrenade get_SmokeGrenade() { }

	[CompilerGenerated]
	public BotZone get_SpawnBotZone() { }

	[CompilerGenerated]
	public IGetProfileData get_SpawnProfileData() { }

	[CompilerGenerated]
	public BotStandBy get_StandBy() { }

	[CompilerGenerated]
	public override AICorePoint get_StartCorePoint() { }

	public override bool get_StateIsSuitableForHandInput() { }

	[CompilerGenerated]
	public BotSteering get_Steering() { }

	[CompilerGenerated]
	public BotSuppressGrenade get_SuppressGrenade() { }

	[CompilerGenerated]
	public BotSuppressShoot get_SuppressShoot() { }

	[CompilerGenerated]
	public override BotSuppressStationary get_SuppressStationary() { }

	[CompilerGenerated]
	public override BotTacticData get_Tactic() { }

	public override string get_TeamId() { }

	[CompilerGenerated]
	public BotTilt get_Tilt() { }

	public Transform get_transform() { }

	public override BifacialTransform get_Transform() { }

	[CompilerGenerated]
	public BotUnityEditorRunChecker get_UnityEditorRunChecker() { }

	public override Vector3 get_Velocity() { }

	[CompilerGenerated]
	public override ECameraType get_VisibleToCameraType() { }

	[CompilerGenerated]
	public BotVoxelesPersonalData get_VoxelesPersonalData() { }

	[CompilerGenerated]
	public override BotWarnData get_WarnData() { }

	[CompilerGenerated]
	public override BotWeaponManager get_WeaponManager() { }

	public override BifacialTransform get_WeaponRoot() { }

	public override IAnimator GetArmsAnimatorCommon() { }

	public void GoToByWay(Vector3[] way, float reachDist = -1) { }

	public NavMeshPathStatus GoToPoint(Vector3 position, bool slowAtTheEnd = true, float reachDist = -1, bool getUpWithCheck = false, bool mustHaveWay = true, bool mustGetUp = true, bool onlyShortTrie = false, bool force = false) { }

	public void GoToPoint(CustomNavigationPoint targetPoint) { }

	public override void HandleFlareSuccessEvent(Vector3 position, AmmoTemplate ammoTemplate) { }

	public override bool HasMarkOfUnknown(out MarkOfUnknown markOfUnknown) { }

	private override bool IBotOwner.get_isActiveAndEnabled() { }

	private override string IBotOwner.get_name() { }

	public override bool IsEnemyLookingAtMe(IPlayer gamePerson) { }

	public bool IsEnemyLookingAtMe(EnemyInfo goalEnemy) { }

	public bool IsFollower() { }

	public bool IsRole(WildSpawnType role) { }

	public void MigrateTo(AICorePoint selectedCore, BotZone zone) { }

	public void MovementPause(float pauseTime) { }

	public void MovementResume() { }

	private void OnApplyDamage(EBodyPart bodyPart, float damage, DamageInfo damageInfo) { }

	private void OnBeenKilledByAggressor(Player player, IPlayer lastAggressor, DamageInfo lastDamageInfo, EBodyPart lastBodyPart) { }

	private void OnBodyBotDead(Vector3 obj) { }

	public override void OnDeserializeFromServer(byte channelId, IBitReaderStream reader) { }

	private void OnDied(EDamageType damageType) { }

	private void OnDrawGizmos() { }

	public void OnDrawGizmosSelected() { }

	private void OnGetHit(DamageInfo damageInfo, EBodyPart bodyType, float damageReducedByArmor) { }

	public override void PlantItemLocalOnly(Item item, string zone) { }

	public override Vector3 PlayerColliderPointOnCenterAxis(float relativeHeight) { }

	public void PostActivate() { }

	public void PreActivate(BotZone zone, GameDateTime time, BotsGroup group, AICoversData covers, bool autoActivate = true) { }

	[CompilerGenerated]
	public void remove_OnBotStateChange(Action value) { }

	[CompilerGenerated]
	public override void remove_OnIPlayerDeadOrUnspawn(Action value) { }

	public void SayGroupAboutEnemy(IPlayer person, Nullable partPos = null) { }

	public float SDistTo(Vector3 v) { }

	[CompilerGenerated]
	private void set_AimingManager(AimingManager value) { }

	[CompilerGenerated]
	private void set_Ambush(BotAmbushData value) { }

	[CompilerGenerated]
	private void set_ArtilleryDangerPlace(ArtilleryDangerPlace value) { }

	[CompilerGenerated]
	private void set_AssaultBuildingData(BotAssaultBuildingData value) { }

	[CompilerGenerated]
	private void set_AssaultDangerArea(BotAssaultDangerArea value) { }

	[CompilerGenerated]
	private void set_BewareArtillery(BewareArtillery value) { }

	[CompilerGenerated]
	private void set_BewareBTR(BotBewareBTR value) { }

	[CompilerGenerated]
	private void set_BewareGas(BotBewareGas value) { }

	[CompilerGenerated]
	private void set_BewareGrenade(BotBewareGrenade value) { }

	[CompilerGenerated]
	private void set_BewarePlantedMine(BotBewarePlantedMine value) { }

	[CompilerGenerated]
	private void set_Boss(BotBoss value) { }

	[CompilerGenerated]
	private void set_BotAttackManager(BotAttackManager value) { }

	[CompilerGenerated]
	private void set_BotAvoidDangerPlaces(BotAvoidDangerPlaces value) { }

	[CompilerGenerated]
	private void set_BotBtrData(BotBtrData value) { }

	[CompilerGenerated]
	private void set_BotCullingState(BotCullingState value) { }

	[CompilerGenerated]
	private void set_BotFollower(BotFollower value) { }

	[CompilerGenerated]
	private void set_BotLay(BotLay value) { }

	[CompilerGenerated]
	private void set_BotLight(BotLight value) { }

	[CompilerGenerated]
	private void set_BotMoveOutFriend(BotMoveOutFriend value) { }

	[CompilerGenerated]
	private void set_BotPersonalStats(BotPersonalStats value) { }

	[CompilerGenerated]
	private void set_BotRequestController(BotRequestController value) { }

	[CompilerGenerated]
	private void set_BotRun(BotRun value) { }

	[CompilerGenerated]
	private void set_BotsController(BotsController value) { }

	[CompilerGenerated]
	public void set_BotsGroup(BotsGroup value) { }

	private void set_BotState(EBotState value) { }

	[CompilerGenerated]
	private void set_BotTalk(BotTalk value) { }

	[CompilerGenerated]
	private void set_BotTurnAwayLight(BotTurnAwayLight value) { }

	[CompilerGenerated]
	private void set_BotZoneMigration(BotZoneMigration value) { }

	[CompilerGenerated]
	private void set_Brain(StandartBotBrain value) { }

	[CompilerGenerated]
	public override void set_BtrState(EPlayerBtrState value) { }

	[CompilerGenerated]
	private void set_CalledData(BotCalledData value) { }

	[CompilerGenerated]
	private void set_CallForHelp(BotCallForHelp value) { }

	[CompilerGenerated]
	private void set_Covers(BotCoversData value) { }

	[CompilerGenerated]
	private void set_CoverSearchInfo(BotCoverSearchInfo value) { }

	[CompilerGenerated]
	private void set_DangerArea(BotDangerArea value) { }

	[CompilerGenerated]
	private void set_DangerPointsData(BotDangerPointsData value) { }

	[CompilerGenerated]
	private void set_DeadBodyData(DeadBodyData value) { }

	[CompilerGenerated]
	private void set_DeadBodyWork(BotDeadBodyWork value) { }

	[CompilerGenerated]
	private void set_DecisionQueue(DecisionQueue value) { }

	[CompilerGenerated]
	private void set_DogFight(BotDogFight value) { }

	[CompilerGenerated]
	private void set_DoorOpener(BotDoorOpener value) { }

	[CompilerGenerated]
	private void set_EatDrinkData(BotEatDrinkData value) { }

	[CompilerGenerated]
	private void set_EnemiesController(BotEnemiesController value) { }

	[CompilerGenerated]
	private void set_ENEMY_LOOK_AT_ME(float value) { }

	[CompilerGenerated]
	private void set_EnemyChooser(BotEnemyChooser value) { }

	[CompilerGenerated]
	private void set_EnemyLookData(BotEnemyLookData value) { }

	[CompilerGenerated]
	private void set_Exfiltration(BotExfiltrationData value) { }

	[CompilerGenerated]
	private void set_ExternalItemsController(BotExternalItemsController value) { }

	[CompilerGenerated]
	private void set_FindPlaceToShoot(FindPlaceToShootManager value) { }

	[CompilerGenerated]
	private void set_FlashGrenade(BotFlashGrenade value) { }

	[CompilerGenerated]
	private void set_FriendChecker(BotFriendChecker value) { }

	[CompilerGenerated]
	private void set_FriendlyTilt(BotFriendlyTilt value) { }

	[CompilerGenerated]
	private void set_GameDateTime(GameDateTime value) { }

	[CompilerGenerated]
	private void set_GameEventsData(BotGameEventsData value) { }

	[CompilerGenerated]
	private void set_Gesture(BotGesture value) { }

	[CompilerGenerated]
	private void set_GetPlayer(Player value) { }

	[CompilerGenerated]
	private void set_GiftData(BotGiftData value) { }

	[CompilerGenerated]
	private void set_GoalCulculator(BotCalcGoal value) { }

	[CompilerGenerated]
	private void set_GoToSomePointData(BotGoToPointData value) { }

	[CompilerGenerated]
	private void set_GrenadeSuicide(GrenadeSuicideBotData value) { }

	[CompilerGenerated]
	private void set_GrenadeToPortal(BotGrenadeToPortal value) { }

	[CompilerGenerated]
	private void set_HeadData(BotHeadData value) { }

	[CompilerGenerated]
	private void set_HealAnotherTarget(BotHealAnotherTarget value) { }

	[CompilerGenerated]
	private void set_HealingBySomebody(BotHealingBySomebody value) { }

	[CompilerGenerated]
	private void set_HearingSensor(BotHearingSensor value) { }

	[CompilerGenerated]
	private void set_Id(int value) { }

	[CompilerGenerated]
	public void set_IsDead(bool value) { }

	[CompilerGenerated]
	public override void set_IsInBufferZone(bool value) { }

	[CompilerGenerated]
	private void set_ItemDropper(BotItemDropper value) { }

	[CompilerGenerated]
	private void set_ItemTaker(BotItemTaker value) { }

	[CompilerGenerated]
	public void set_Lean(Vector2 value) { }

	[CompilerGenerated]
	private void set_LeaveData(BotLeaveData value) { }

	[CompilerGenerated]
	private void set_LookData(LookData value) { }

	[CompilerGenerated]
	private void set_LookSensor(LookSensor value) { }

	[CompilerGenerated]
	private void set_Looting(BotLootingData value) { }

	[CompilerGenerated]
	private void set_LootOpener(BotLootOpener value) { }

	[CompilerGenerated]
	private void set_LoyaltyData(BotLoyaltyData value) { }

	[CompilerGenerated]
	private void set_MagazineChecker(BotMagazineChecker value) { }

	[CompilerGenerated]
	private void set_Medecine(BotMedecine value) { }

	[CompilerGenerated]
	private void set_Memory(BotMemory value) { }

	[CompilerGenerated]
	private void set_MinesData(BotMinesData value) { }

	[CompilerGenerated]
	private void set_MinesRealtimePlaceFinder(BotMinesRealtimePlaceFinder value) { }

	[CompilerGenerated]
	private void set_MoveByMiddleGraph(BotMoveByMiddleGraph value) { }

	[CompilerGenerated]
	private void set_Mover(BotMover value) { }

	[CompilerGenerated]
	private void set_MoveToEnemyData(BotMoveToEnemyData value) { }

	[CompilerGenerated]
	private void set_MyHead(BifacialTransform value) { }

	[CompilerGenerated]
	private void set_NavMeshCutterController(BotNavMeshCutterController value) { }

	[CompilerGenerated]
	private void set_NearDoorData(BotNearDoorData value) { }

	[CompilerGenerated]
	private void set_NeutralsCheskData(BotNeutralsCheskData value) { }

	[CompilerGenerated]
	private void set_NightVision(BotNightVisionData value) { }

	[CompilerGenerated]
	private void set_PatrollingData(PatrollingData value) { }

	[CompilerGenerated]
	private void set_PeacefulActions(BotPeacefulActions value) { }

	[CompilerGenerated]
	private void set_PeaceHardAim(BotPeaceHardAim value) { }

	[CompilerGenerated]
	private void set_PeaceLook(BotPeaceLook value) { }

	[CompilerGenerated]
	private void set_PlanDropItem(BotPlanDropItem value) { }

	[CompilerGenerated]
	private void set_PlayerFollowData(BotPlayerFollowData value) { }

	[CompilerGenerated]
	private void set_PriorityAxeTarget(BotPriorityAxeTarget value) { }

	[CompilerGenerated]
	private void set_ProfileId(string value) { }

	[CompilerGenerated]
	private void set_RaidId(int value) { }

	[CompilerGenerated]
	private void set_RandomPlanItemDropper(BotRandomPlanItemDropper value) { }

	[CompilerGenerated]
	private void set_Receiver(BotReceiver value) { }

	[CompilerGenerated]
	private void set_RecoilData(RecoilData value) { }

	[CompilerGenerated]
	private void set_SearchData(BotSearchData value) { }

	[CompilerGenerated]
	private void set_SecondWeaponData(BotSecondWeaponData value) { }

	[CompilerGenerated]
	private void set_Settings(BotSettings value) { }

	[CompilerGenerated]
	private void set_ShootData(ShootData value) { }

	[CompilerGenerated]
	private void set_ShootFromPlace(BotShootFromPlace value) { }

	[CompilerGenerated]
	private void set_SmokeGrenade(BotSmokeGrenade value) { }

	[CompilerGenerated]
	private void set_SpawnBotZone(BotZone value) { }

	[CompilerGenerated]
	public void set_SpawnProfileData(IGetProfileData value) { }

	[CompilerGenerated]
	private void set_StandBy(BotStandBy value) { }

	[CompilerGenerated]
	private void set_StartCorePoint(AICorePoint value) { }

	[CompilerGenerated]
	private void set_Steering(BotSteering value) { }

	[CompilerGenerated]
	private void set_SuppressGrenade(BotSuppressGrenade value) { }

	[CompilerGenerated]
	private void set_SuppressShoot(BotSuppressShoot value) { }

	[CompilerGenerated]
	private void set_SuppressStationary(BotSuppressStationary value) { }

	[CompilerGenerated]
	private void set_Tactic(BotTacticData value) { }

	[CompilerGenerated]
	private void set_Tilt(BotTilt value) { }

	[CompilerGenerated]
	private void set_UnityEditorRunChecker(BotUnityEditorRunChecker value) { }

	[CompilerGenerated]
	private void set_VoxelesPersonalData(BotVoxelesPersonalData value) { }

	[CompilerGenerated]
	private void set_WarnData(BotWarnData value) { }

	[CompilerGenerated]
	private void set_WeaponManager(BotWeaponManager value) { }

	public override void SetArmsAnimatorCommon(IAnimator animator) { }

	public void SetBotPlayerColliderState(bool state) { }

	public void SetDieCallback(Action botDied) { }

	public void SetHandle(string toString) { }

	public override void SetInteractInHands(EInteraction interaction) { }

	public void SetLean(Vector2 lean) { }

	public void SetPose(float targetPose) { }

	public void SetTargetMoveSpeed(float speed) { }

	public bool ShouldApplyDamage(Player target, DamageInfo damage, EBodyPart bodyPartType) { }

	public void Sprint(bool val, bool withDebugCallback = true) { }

	public float SqrDistHorizontal(Vector3 trg) { }

	public void StopMove() { }

	private void SubscribeOnPlayerEvents() { }

	private void UnsubscribeAll() { }

	public override void UpdateInteractionCast() { }

	public void UpdateManual() { }

}

