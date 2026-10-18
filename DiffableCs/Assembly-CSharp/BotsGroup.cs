//Type is in global namespace

public class BotsGroup : IBotsGroup
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__121_0; //Field offset: 0x8
		public static Func <>9__121_1; //Field offset: 0x10
		public static Func <>9__185_0; //Field offset: 0x18
		public static Predicate <>9__187_0; //Field offset: 0x20
		public static Func <>9__190_0; //Field offset: 0x28
		public static Func <>9__190_1; //Field offset: 0x30
		public static Func <>9__192_0; //Field offset: 0x38

		private static <>c() { }

		public <>c() { }

		internal bool <CheckPointsToLifeTime>b__187_0(PlaceForCheck placeForCheck) { }

		internal float <CheckWhoCanSearch>b__185_0(EnemyInfo info) { }

		internal bool <get_EnemiesPower>b__121_0(KeyValuePair player) { }

		internal float <get_EnemiesPower>b__121_1(KeyValuePair player) { }

		internal bool <GetLastSeenPositions>b__190_0(KeyValuePair x) { }

		internal BotGroupEnemyInfo <GetLastSeenPositions>b__190_1(KeyValuePair x) { }

		internal float <MakeStrategyDecision>b__192_0(BotOwner x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass158_0
	{
		public BotsGroup <>4__this; //Field offset: 0x10
		public AISmokeGrenadePlace place; //Field offset: 0x18

		public <>c__DisplayClass158_0() { }

		internal void <AddSmokePlace>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass191_0
	{
		public PlaceForCheck place; //Field offset: 0x10

		public <>c__DisplayClass191_0() { }

		internal bool <PointReached>b__0(PlaceForCheck check) { }

	}

	internal enum BotCurrentTactic
	{
		Attack = 0,
		Ambush = 1,
		Protect = 2,
	}

	private static int _groupsIds; //Field offset: 0x0
	private readonly IBotGame _botGame; //Field offset: 0x10
	[CompilerGenerated]
	private readonly BotGroupHostility <BotGroupHostility>k__BackingField; //Field offset: 0x18
	public EPlayerSide Side; //Field offset: 0x20
	[CompilerGenerated]
	private bool <Locked>k__BackingField; //Field offset: 0x24
	public BotGroupCurrentEnemies CurrentEnemies; //Field offset: 0x28
	private readonly List _members; //Field offset: 0x30
	private readonly List _grenadeSmokePlaces; //Field offset: 0x38
	private float _nextGetGoalTime; //Field offset: 0x40
	private float _nextCheckDestination; //Field offset: 0x44
	private int _requestsMember; //Field offset: 0x48
	private readonly BotGroupDangerAreas GroupDangerAreas; //Field offset: 0x50
	private readonly WildSpawnType _defWildSpawnType; //Field offset: 0x58
	private readonly BotGlobalsMindSettings _initialBotMindSettings; //Field offset: 0x60
	private readonly List _enemyPlayerGroups; //Field offset: 0x68
	private BotOwner _initialBot; //Field offset: 0x70
	[CompilerGenerated]
	private OnReportEnemyDelegate OnReportEnemy; //Field offset: 0x78
	[CompilerGenerated]
	private Action OnBossSetted; //Field offset: 0x80
	[CompilerGenerated]
	private Action OnMemberRemove; //Field offset: 0x88
	[CompilerGenerated]
	private readonly WildSpawnType <InitialBotType>k__BackingField; //Field offset: 0x90
	[CompilerGenerated]
	private readonly BotDifficulty <InitialBotDifficulty>k__BackingField; //Field offset: 0x94
	[CompilerGenerated]
	private readonly BotSettingsComponents <InitialFileSettings>k__BackingField; //Field offset: 0x98
	[CompilerGenerated]
	private BossGroup <BossGroup>k__BackingField; //Field offset: 0xA0
	[CompilerGenerated]
	private float <EnemyLastSeenTimeSence>k__BackingField; //Field offset: 0xA8
	[CompilerGenerated]
	private float <EnemyLastSeenTimeReal>k__BackingField; //Field offset: 0xAC
	[CompilerGenerated]
	private readonly BotsGroupMarkOfUnknown <GroupMarkOfUnknown>k__BackingField; //Field offset: 0xB0
	[CompilerGenerated]
	private readonly BotsGroupGrenade <GroupGrenade>k__BackingField; //Field offset: 0xB8
	[CompilerGenerated]
	private readonly BotsGroupLaying <GroupLaying>k__BackingField; //Field offset: 0xC0
	[CompilerGenerated]
	private readonly BotGroupTalk <GroupTalk>k__BackingField; //Field offset: 0xC8
	[CompilerGenerated]
	private Vector3 <EnemyLastSeenPositionReal>k__BackingField; //Field offset: 0xD0
	[CompilerGenerated]
	private Vector3 <EnemyLastSeenPositionSence>k__BackingField; //Field offset: 0xDC
	[CompilerGenerated]
	private readonly LastSoundsController <LastSoundsController>k__BackingField; //Field offset: 0xE8
	[CompilerGenerated]
	private readonly CoverPointMaster <CoverPointMaster>k__BackingField; //Field offset: 0xF0
	[CompilerGenerated]
	private readonly IBotZone <BotZone>k__BackingField; //Field offset: 0xF8
	[CompilerGenerated]
	private readonly DeadBodiesController <DeadBodiesController>k__BackingField; //Field offset: 0x100
	[CompilerGenerated]
	private BotGroupWarnData <BotGroupWarnData>k__BackingField; //Field offset: 0x108
	[CompilerGenerated]
	private readonly string <Name>k__BackingField; //Field offset: 0x110
	[CompilerGenerated]
	private readonly int <Id>k__BackingField; //Field offset: 0x118
	[CompilerGenerated]
	private bool <IsLastPositionOld>k__BackingField; //Field offset: 0x11C
	[CompilerGenerated]
	private readonly BotGroupRequestController <RequestsController>k__BackingField; //Field offset: 0x120
	[CompilerGenerated]
	private int <HaveMaxMembers>k__BackingField; //Field offset: 0x128
	[CompilerGenerated]
	private readonly List <PlacesForCheck>k__BackingField; //Field offset: 0x130
	[CompilerGenerated]
	private bool <AnyBodyShootImmediately>k__BackingField; //Field offset: 0x138
	[CompilerGenerated]
	private int <TargetMembersCount>k__BackingField; //Field offset: 0x13C
	[CompilerGenerated]
	private bool <IsFull>k__BackingField; //Field offset: 0x140

	public event Action OnBossSetted
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public event Action OnMemberRemove
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public event OnReportEnemyDelegate OnReportEnemy
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public IReadOnlyDictionary Allies
	{
		 get { } //Length: 27
	}

	public int AllyCount
	{
		 get { } //Length: 84
	}

	public bool AnyBodyShootImmediately
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 7
	}

	public int AssaultGroupsCount
	{
		 get { } //Length: 71
	}

	public private BossGroup BossGroup
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public override IBotGame BotGame
	{
		 get { } //Length: 5
	}

	public BotGroupHostility BotGroupHostility
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public private BotGroupWarnData BotGroupWarnData
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public override IBotZone BotZone
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	public CoverPointMaster CoverPointMaster
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	public int DangerAreasCount
	{
		 get { } //Length: 80
	}

	public DeadBodiesController DeadBodiesController
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	public IReadOnlyDictionary Enemies
	{
		 get { } //Length: 27
	}

	private float EnemiesPower
	{
		private get { } //Length: 743
	}

	public private Vector3 EnemyLastSeenPositionReal
	{
		[CompilerGenerated]
		 get { } //Length: 25
		[CompilerGenerated]
		private set { } //Length: 22
	}

	public private Vector3 EnemyLastSeenPositionSence
	{
		[CompilerGenerated]
		 get { } //Length: 25
		[CompilerGenerated]
		private set { } //Length: 22
	}

	public private float EnemyLastSeenTimeReal
	{
		[CompilerGenerated]
		 get { } //Length: 9
		[CompilerGenerated]
		private set { } //Length: 9
	}

	public private float EnemyLastSeenTimeSence
	{
		[CompilerGenerated]
		 get { } //Length: 9
		[CompilerGenerated]
		private set { } //Length: 9
	}

	public BotsGroupGrenade GroupGrenade
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	public BotsGroupLaying GroupLaying
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	public BotsGroupMarkOfUnknown GroupMarkOfUnknown
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	public float GroupPower
	{
		 get { } //Length: 574
	}

	public BotGroupTalk GroupTalk
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	public private int HaveMaxMembers
	{
		[CompilerGenerated]
		 get { } //Length: 7
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public int Id
	{
		[CompilerGenerated]
		 get { } //Length: 7
	}

	public override BotDifficulty InitialBotDifficulty
	{
		[CompilerGenerated]
		 get { } //Length: 7
	}

	public BotGlobalsMindSettings InitialBotMindSettings
	{
		 get { } //Length: 5
	}

	public override WildSpawnType InitialBotType
	{
		[CompilerGenerated]
		 get { } //Length: 7
	}

	public BotSettingsComponents InitialFileSettings
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	public private bool IsFull
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public private bool IsLastPositionOld
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public LastSoundsController LastSoundsController
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	public private bool Locked
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public override int MembersCount
	{
		 get { } //Length: 65
	}

	public string Name
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	public IReadOnlyDictionary Neutrals
	{
		 get { } //Length: 27
	}

	public List PlacesForCheck
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	public BotGroupRequestController RequestsController
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	public int TargetMembersCount
	{
		[CompilerGenerated]
		 get { } //Length: 7
		[CompilerGenerated]
		 set { } //Length: 7
	}

	public HashSet WarnBotTypes
	{
		 get { } //Length: 38
	}

	public IReadOnlyDictionary Warns
	{
		 get { } //Length: 27
	}

	private static BotsGroup() { }

	public BotsGroup(BotZone zone, IBotGame botGame, BotOwner initialBot, DeadBodiesController deadBodiesController, bool forBoss) { }

	[CompilerGenerated]
	public void add_OnBossSetted(Action value) { }

	[CompilerGenerated]
	public void add_OnMemberRemove(Action value) { }

	[CompilerGenerated]
	public void add_OnReportEnemy(OnReportEnemyDelegate value) { }

	private void AddMember(BotOwner member) { }

	public void AddMember(BotOwner member, bool onActivation) { }

	public void AddMemberRequest() { }

	private void AddPlaceForCheck(PlaceForCheck placeForCheck) { }

	[CanBeNull]
	public PlaceForCheck AddPointToSearch(Vector3 suspectedPoint, float power, BotOwner owner, bool baseReacheble = true, bool canUseCovers = true) { }

	public void AddSmokePlace(Vector3 pos, float duration, float radius, Vector3 throwPos) { }

	public void BossAppear(BotOwner botBoss) { }

	public void CalcGoalForBot(BotOwner bot) { }

	public Vector3 Center() { }

	private void CheckIsLastPositionOld() { }

	private bool CheckIsLastPositionOld(float newestPosition) { }

	private bool CheckOnDestinationsPrev(Vector3 pos, PlaceForCheck place2check) { }

	private bool CheckOnDestinationsPrev(PlaceForCheck place2check) { }

	private void CheckPointsToLifeTime() { }

	private void CheckWhoCanSearch() { }

	public BotOwner ClosestMemberToPoint(Vector3 pos) { }

	public bool Contains(IBotOwner member) { }

	public bool ContainsEnemy(BotOwner bot) { }

	private PlaceForCheck CreatePlaceForChecking(BotOwner owner, Vector3 suspectedPoint, PlaceForCheckType type, bool canUseCovrPoints = true) { }

	public void Dispose() { }

	public IReadOnlyDictionary get_Allies() { }

	public int get_AllyCount() { }

	[CompilerGenerated]
	public bool get_AnyBodyShootImmediately() { }

	public int get_AssaultGroupsCount() { }

	[CompilerGenerated]
	public BossGroup get_BossGroup() { }

	public override IBotGame get_BotGame() { }

	[CompilerGenerated]
	public BotGroupHostility get_BotGroupHostility() { }

	[CompilerGenerated]
	public BotGroupWarnData get_BotGroupWarnData() { }

	[CompilerGenerated]
	public override IBotZone get_BotZone() { }

	[CompilerGenerated]
	public CoverPointMaster get_CoverPointMaster() { }

	public int get_DangerAreasCount() { }

	[CompilerGenerated]
	public DeadBodiesController get_DeadBodiesController() { }

	public IReadOnlyDictionary get_Enemies() { }

	private float get_EnemiesPower() { }

	[CompilerGenerated]
	public Vector3 get_EnemyLastSeenPositionReal() { }

	[CompilerGenerated]
	public Vector3 get_EnemyLastSeenPositionSence() { }

	[CompilerGenerated]
	public float get_EnemyLastSeenTimeReal() { }

	[CompilerGenerated]
	public float get_EnemyLastSeenTimeSence() { }

	[CompilerGenerated]
	public BotsGroupGrenade get_GroupGrenade() { }

	[CompilerGenerated]
	public BotsGroupLaying get_GroupLaying() { }

	[CompilerGenerated]
	public BotsGroupMarkOfUnknown get_GroupMarkOfUnknown() { }

	public float get_GroupPower() { }

	[CompilerGenerated]
	public BotGroupTalk get_GroupTalk() { }

	[CompilerGenerated]
	public int get_HaveMaxMembers() { }

	[CompilerGenerated]
	public int get_Id() { }

	[CompilerGenerated]
	public override BotDifficulty get_InitialBotDifficulty() { }

	public BotGlobalsMindSettings get_InitialBotMindSettings() { }

	[CompilerGenerated]
	public override WildSpawnType get_InitialBotType() { }

	[CompilerGenerated]
	public BotSettingsComponents get_InitialFileSettings() { }

	[CompilerGenerated]
	public bool get_IsFull() { }

	[CompilerGenerated]
	public bool get_IsLastPositionOld() { }

	[CompilerGenerated]
	public LastSoundsController get_LastSoundsController() { }

	[CompilerGenerated]
	public bool get_Locked() { }

	public override int get_MembersCount() { }

	[CompilerGenerated]
	public string get_Name() { }

	public IReadOnlyDictionary get_Neutrals() { }

	[CompilerGenerated]
	public List get_PlacesForCheck() { }

	[CompilerGenerated]
	public BotGroupRequestController get_RequestsController() { }

	[CompilerGenerated]
	public int get_TargetMembersCount() { }

	public HashSet get_WarnBotTypes() { }

	public IReadOnlyDictionary get_Warns() { }

	public List GetLastSeenPositions() { }

	public int GetMemberIndex(BotOwner owner) { }

	public BotOwner GetRandomMember() { }

	public void GetVision() { }

	public bool HaveBoss(out BotOwner botBoss) { }

	public bool HaveFollowTarget(IPlayer aggressor) { }

	public bool HaveMemberWithRole(WildSpawnType type) { }

	public bool IsAlly(IPlayer player) { }

	public bool IsEnemy(IPlayer player) { }

	public bool IsInSmoke(Vector3 p) { }

	private bool IsPlayerBadUsec(IPlayer player) { }

	public bool IsSuitable(WildSpawnType tested) { }

	public void Lock() { }

	public void LoseVision(IPlayer target) { }

	public void MakeStrategyDecision() { }

	private void ManualUpdate() { }

	public override IBotOwner Member(int i) { }

	public string MessageInfo() { }

	public string MessageInfoWide() { }

	public void PlaceChecked(PlaceForCheck currentPlaceForCheck) { }

	public void PointChecked(PlaceForCheck place) { }

	private void PointReached(PlaceForCheck place) { }

	[CompilerGenerated]
	public void remove_OnBossSetted(Action value) { }

	[CompilerGenerated]
	public void remove_OnMemberRemove(Action value) { }

	[CompilerGenerated]
	public void remove_OnReportEnemy(OnReportEnemyDelegate value) { }

	private List RemoveClosestPlaceForCheck(Vector3 pos, PlaceForCheck pfc = null) { }

	public void RemoveInfo(IPlayer person) { }

	public void RemoveMember(BotOwner member) { }

	public void ReportAboutEnemy(IPlayer enemy, EEnemyPartVisibleType isVisibleOnlyBySence, BotOwner reporter) { }

	[CompilerGenerated]
	public void set_AnyBodyShootImmediately(bool value) { }

	[CompilerGenerated]
	private void set_BossGroup(BossGroup value) { }

	[CompilerGenerated]
	private void set_BotGroupWarnData(BotGroupWarnData value) { }

	[CompilerGenerated]
	private void set_EnemyLastSeenPositionReal(Vector3 value) { }

	[CompilerGenerated]
	private void set_EnemyLastSeenPositionSence(Vector3 value) { }

	[CompilerGenerated]
	private void set_EnemyLastSeenTimeReal(float value) { }

	[CompilerGenerated]
	private void set_EnemyLastSeenTimeSence(float value) { }

	[CompilerGenerated]
	private void set_HaveMaxMembers(int value) { }

	[CompilerGenerated]
	private void set_IsFull(bool value) { }

	[CompilerGenerated]
	private void set_IsLastPositionOld(bool value) { }

	[CompilerGenerated]
	private void set_Locked(bool value) { }

	[CompilerGenerated]
	public void set_TargetMembersCount(int value) { }

	public void SetEnemyPos(IPlayer enemy, Vector3 enemyPos, Vector3 weaponRootLast, EEnemyPartVisibleType isVisibleOnlyBySense) { }

	public void SetLastVisionEnemyTimeReal(float enemyLastSeenTime, Vector3 pos) { }

	public void SetLastVisionEnemyTimeSence(float enemyLastSeenTime, Vector3 pos) { }

	private void SetTactic(BotOwner botOwner, BotCurrentTactic globalCurrentTactic) { }

	public bool ShallRevengeFor(IPlayer target) { }

	private void TryUpdAttackGoals() { }

	private void UpdateAttackGoals() { }

	[CanBeNull]
	public PlaceForCheck YoungestFastPlace(BotOwner owner, float distRestriction, float timeOld) { }

	[CanBeNull]
	public PlaceForCheck YoungestPlace(BotOwner owner, float distRestriction, bool priorityDanger) { }

}

