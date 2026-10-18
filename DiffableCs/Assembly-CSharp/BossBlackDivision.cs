//Type is in global namespace

public class BossBlackDivision : ABossLogic
{
	internal enum EBlackDivisionLogic
	{
		defence = 0,
		assault = 1,
		flank = 2,
		supressAssault = 3,
	}

	private const float ASSAULT_DELTA_NO_SEE_TO_ATTACK = 5; //Field offset: 0x0
	private const float SDIST_TO_SUPPRESS_FROM_ATTACK = 10000; //Field offset: 0x0
	private const float ENEMY_NOT_SEE_TO_ATTACK_MAX = 40; //Field offset: 0x0
	private const float ENEMY_NOT_SEE_TO_ATTACK = 9; //Field offset: 0x0
	private const float IS_RUN_CHECK_TOO_LONG_CHECK_TIME = 15; //Field offset: 0x0
	private const float SDIST_TO_WORK_WITH_BODY = 400; //Field offset: 0x0
	private const float TIME_TO_PERSUIT = 80; //Field offset: 0x0
	private EBlackDivisionLogic _status; //Field offset: 0x20
	private float _lastStatusChnage; //Field offset: 0x24
	private float CONTROL_BUILDING_DISTANCE; //Field offset: 0x28
	private float _atBuildingCheck; //Field offset: 0x2C
	public bool InFight; //Field offset: 0x30
	public bool _noAttackAi; //Field offset: 0x31
	private bool _lastAtBuilding; //Field offset: 0x32
	public Vector3 _areaCenter; //Field offset: 0x34
	private BossBlackDivisionSuppress _suppress; //Field offset: 0x40
	private BossBlackDivisionPatrol _patrol; //Field offset: 0x48
	private int _areaId; //Field offset: 0x50
	private Vector3 _lastEnemyPos; //Field offset: 0x54
	private int _lastEnemyId; //Field offset: 0x60
	private float _lastEnemyCheck; //Field offset: 0x64
	private float _lastChnageStatusToAssault; //Field offset: 0x68
	public bool IsEnemyRun; //Field offset: 0x6C
	private bool _isUnderAttack; //Field offset: 0x6D
	private float _endUnderAttack; //Field offset: 0x70
	private float _nextCheck; //Field offset: 0x74
	private AIPeriodAction _enemyRunCheck; //Field offset: 0x78
	private AIPeriodAction _assaultCheck; //Field offset: 0x80
	private AIPeriodAction _canStartAssaultTackticCheck; //Field offset: 0x88
	private AIPeriodAction _flankCheck; //Field offset: 0x90
	private AIPeriodAction _deadBodyCheck; //Field offset: 0x98
	private IBotOwner _botWithBody; //Field offset: 0xA0
	private Dictionary _readyToAttack; //Field offset: 0xA8
	[CompilerGenerated]
	private Action OnDoDefence; //Field offset: 0xB0
	[CompilerGenerated]
	private Action OnDoAssault; //Field offset: 0xB8
	[CompilerGenerated]
	private Action OnDoFlank; //Field offset: 0xC0
	[CompilerGenerated]
	private Action OnDoSuppressAssault; //Field offset: 0xC8
	[CompilerGenerated]
	private Nullable <FlankPoint>k__BackingField; //Field offset: 0xD0
	private bool _havePlaceToDef; //Field offset: 0xE0

	public event Action OnDoAssault
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public event Action OnDoDefence
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public event Action OnDoFlank
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public event Action OnDoSuppressAssault
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	private BotBlackDivisionController _controller
	{
		private get { } //Length: 48
	}

	public Vector3 AreaCenter
	{
		 get { } //Length: 19
	}

	public int AreaId
	{
		 get { } //Length: 4
	}

	public Nullable FlankPoint
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 11
	}

	public BotsGroup Group
	{
		 get { } //Length: 30
	}

	public bool HavePlaceToDef
	{
		 get { } //Length: 8
	}

	public BossBlackDivisionPatrol Patrol
	{
		 get { } //Length: 5
	}

	public EBlackDivisionLogic Status
	{
		 get { } //Length: 4
		 set { } //Length: 99
	}

	public bool UnderAttack
	{
		 get { } //Length: 5
	}

	public BossBlackDivision(BotOwner owner, BotBoss bossLogic) { }

	public virtual void Activate() { }

	[CompilerGenerated]
	public void add_OnDoAssault(Action value) { }

	[CompilerGenerated]
	public void add_OnDoDefence(Action value) { }

	[CompilerGenerated]
	public void add_OnDoFlank(Action value) { }

	[CompilerGenerated]
	public void add_OnDoSuppressAssault(Action value) { }

	private void AssaultPeriod() { }

	public void BecomeUnderAttack() { }

	public virtual void BossLogicUpdate() { }

	public bool CanDoPersuit() { }

	public bool CanGoWithSupperss(BotOwner owner) { }

	public bool CanStartAssault() { }

	private void CanStartAssaultTackticCheck() { }

	public virtual void CopyData(ABossLogic bossBossLogic) { }

	public virtual void Dispose() { }

	private bool DistEnemyCheckOnControlBuilding() { }

	public void DoAssault(int objCoverGroupId, IPlayer trg) { }

	public void DoAssaultSuppress(int objCoverGroupId, IPlayer trg) { }

	public void DoDefence(int objCoverGroupId, IPlayer trg) { }

	public void DoFlank(int coverGroupId, IPlayer trg, Nullable flankPoint) { }

	private void FlankPeriod() { }

	private void FoundAreaCOntrols(AIPlaceInfo aiPlaceInfo, AIPlaceInfoLogicBlackDivision infoLogicBlack) { }

	private BotBlackDivisionController get__controller() { }

	public Vector3 get_AreaCenter() { }

	public int get_AreaId() { }

	[CompilerGenerated]
	public Nullable get_FlankPoint() { }

	public BotsGroup get_Group() { }

	public bool get_HavePlaceToDef() { }

	public BossBlackDivisionPatrol get_Patrol() { }

	public EBlackDivisionLogic get_Status() { }

	public bool get_UnderAttack() { }

	public bool HaveDeadBody(out Vector3 posDeadBody) { }

	private void IsEnemyRunCheck() { }

	private bool IsReadyToAssault(IBotOwner mem) { }

	private void OnMemberRemove(BotOwner obj) { }

	private void PeriodAskHelp() { }

	private void PeriodCheckOnDeadBodies() { }

	public void ReadyToAttack(BotOwner owner) { }

	[CompilerGenerated]
	public void remove_OnDoAssault(Action value) { }

	[CompilerGenerated]
	public void remove_OnDoDefence(Action value) { }

	[CompilerGenerated]
	public void remove_OnDoFlank(Action value) { }

	[CompilerGenerated]
	public void remove_OnDoSuppressAssault(Action value) { }

	[CompilerGenerated]
	public void set_FlankPoint(Nullable value) { }

	public void set_Status(EBlackDivisionLogic value) { }

	public virtual void SetPatrolMode() { }

	public bool ShouldControlBuilding() { }

	public void StartWithSup(int ownerId) { }

	public void StopWithSup(int ownerId) { }

	private void TryFoundAIPlaceToDef() { }

	private void TryFoundArea() { }

	private void UpdateAssaultChecks() { }

	private void UpdateDefenceChecks() { }

	private void UpdateFlank() { }

	private void UpdateLogicsChecks() { }

}

