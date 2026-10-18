//Type is in global namespace

public sealed class BossWedgeDistTracker
{
	private const float CHECK_PERIOD = 3; //Field offset: 0x0
	private const float CLOSE_DIST = 12; //Field offset: 0x0
	private const float MID_DIST = 27; //Field offset: 0x0
	private readonly BotOwner _owner; //Field offset: 0x10
	private readonly NavMeshPath _path; //Field offset: 0x18
	private readonly AIPeriodAction _checkDist; //Field offset: 0x20
	private float _lastPath; //Field offset: 0x28
	[CompilerGenerated]
	private EBossWedgeDist <WedgeDist>k__BackingField; //Field offset: 0x2C

	public private EBossWedgeDist WedgeDist
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public BossWedgeDistTracker(BotOwner owner) { }

	private void CalcDistByPath(EnemyInfo enemy) { }

	private void CheckDistPeriod() { }

	public void Dispose() { }

	[CompilerGenerated]
	public EBossWedgeDist get_WedgeDist() { }

	private void OnGoalEnemyChanged(BotOwner obj) { }

	[CompilerGenerated]
	private void set_WedgeDist(EBossWedgeDist value) { }

	private void SetState(EBossWedgeDist next) { }

	public void Update() { }

}

