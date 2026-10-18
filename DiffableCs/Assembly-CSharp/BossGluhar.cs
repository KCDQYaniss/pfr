//Type is in global namespace

public class BossGluhar : ABossLogic
{
	private const int CLUHAR_ATTACK_ = 4; //Field offset: 0x0
	private const string GLUHAR_PATROL = "BossGluhar"; //Field offset: 0x0
	private const string GLUHAR_PATROL_ALT = "BossGluharAlt"; //Field offset: 0x0
	private const string TRAIN_BOUNDS = "TrainBounds"; //Field offset: 0x0
	public bool TrainSecure; //Field offset: 0x20
	public bool _assaultFollowersShallAttack; //Field offset: 0x21
	private readonly bool _wannaAttack; //Field offset: 0x22
	private bool _securityWannaAttack; //Field offset: 0x23
	private float _logicUpdate; //Field offset: 0x24
	private float _nextCheckOn; //Field offset: 0x28
	private readonly Dictionary _covers; //Field offset: 0x30
	[CompilerGenerated]
	private Action OnScoutWannaAttack; //Field offset: 0x38
	[CompilerGenerated]
	private bool <HaveTrainInfo>k__BackingField; //Field offset: 0x40
	[CompilerGenerated]
	private AIPlaceInfo <TrainBounds>k__BackingField; //Field offset: 0x48
	[CompilerGenerated]
	private int <GoodCovers>k__BackingField; //Field offset: 0x50
	[CompilerGenerated]
	private bool <BossShallAttack>k__BackingField; //Field offset: 0x54
	[CompilerGenerated]
	private int <SecurityCount>k__BackingField; //Field offset: 0x58

	public event Action OnScoutWannaAttack
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public bool AssaultFollowersShallAttack
	{
		 get { } //Length: 5
		 set { } //Length: 295
	}

	public private bool BossShallAttack
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public AIPlaceInfo CorePlace
	{
		 get { } //Length: 102
	}

	public bool FightAtZone
	{
		 get { } //Length: 226
	}

	public private int GoodCovers
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public private bool HaveTrainInfo
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public bool IsInSector
	{
		 get { } //Length: 286
	}

	public private int SecurityCount
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public bool SecurityFightAtHomeEnought
	{
		 get { } //Length: 8
	}

	public bool SecurityWannaAttack
	{
		 get { } //Length: 485
		 set { } //Length: 308
	}

	public private AIPlaceInfo TrainBounds
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public BossGluhar(BotOwner owner, BotBoss bossLogic) { }

	public virtual void Activate() { }

	[CompilerGenerated]
	public void add_OnScoutWannaAttack(Action value) { }

	public virtual void BossLogicUpdate() { }

	public virtual void Dispose() { }

	public EnemyInfo FindDangerEnemyFor(BotOwner owner) { }

	public bool get_AssaultFollowersShallAttack() { }

	[CompilerGenerated]
	public bool get_BossShallAttack() { }

	public AIPlaceInfo get_CorePlace() { }

	public bool get_FightAtZone() { }

	[CompilerGenerated]
	public int get_GoodCovers() { }

	[CompilerGenerated]
	public bool get_HaveTrainInfo() { }

	public bool get_IsInSector() { }

	[CompilerGenerated]
	public int get_SecurityCount() { }

	public bool get_SecurityFightAtHomeEnought() { }

	public bool get_SecurityWannaAttack() { }

	[CompilerGenerated]
	public AIPlaceInfo get_TrainBounds() { }

	private void OnCurrentCheck(int obj) { }

	public void OneScoutDoAttack(BotOwner scoutAttack) { }

	private void OnFollowerStatusChange(IBotOwner follower, FollowerStatusChange status) { }

	private void OnTrainCome(ETravelState obj) { }

	[CompilerGenerated]
	public void remove_OnScoutWannaAttack(Action value) { }

	public bool SeenLessTimeBoss(float delta) { }

	public bool SeenLessTimeFollowersSecurity(float delta, out int count) { }

	public void set_AssaultFollowersShallAttack(bool value) { }

	[CompilerGenerated]
	private void set_BossShallAttack(bool value) { }

	[CompilerGenerated]
	private void set_GoodCovers(int value) { }

	[CompilerGenerated]
	private void set_HaveTrainInfo(bool value) { }

	[CompilerGenerated]
	private void set_SecurityCount(int value) { }

	public void set_SecurityWannaAttack(bool value) { }

	[CompilerGenerated]
	private void set_TrainBounds(AIPlaceInfo value) { }

	public void SetHaveCover(int id, bool haveCover) { }

	public virtual void SetPatrolMode() { }

	private void UpdateIndexes() { }

}

