//Type is in global namespace

public class PatrolDataFollower : BotData
{
	private PatrolFollowerAIBase followerAIBase; //Field offset: 0x18
	private PatrolFollowerPlayer followerPlayerBase; //Field offset: 0x20
	private readonly int _index; //Field offset: 0x28
	private Nullable _safeTarget; //Field offset: 0x2C
	private float _endStopTime; //Field offset: 0x3C
	[CompilerGenerated]
	private bool <IsInited>k__BackingField; //Field offset: 0x40
	[CompilerGenerated]
	private readonly bool <IsMainWay>k__BackingField; //Field offset: 0x41

	public bool HaveProblems
	{
		 get { } //Length: 40
		 set { } //Length: 26
	}

	public int Index
	{
		 get { } //Length: 47
	}

	public private bool IsInited
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public bool IsMainWay
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public PatrolDataFollower(BotOwner owner) { }

	public void Activate() { }

	public void Dispose() { }

	public bool get_HaveProblems() { }

	public int get_Index() { }

	[CompilerGenerated]
	public bool get_IsInited() { }

	[CompilerGenerated]
	public bool get_IsMainWay() { }

	public void Init(PatrolFollowerType followerType, PatrolMoveBossStayAtPlace simple) { }

	public void Init(PatrolFollowerType followerType, PatrolMoveSimple bossPatrolMoveSimple) { }

	public void InitPlayer(Player player) { }

	public void ManualUpdate() { }

	public void OnDrawGizmosSelected() { }

	public void set_HaveProblems(bool value) { }

	[CompilerGenerated]
	private void set_IsInited(bool value) { }

	public void SetCloseToTarget(bool closeToPoint) { }

	public void SetFolloweType(bool front) { }

	public void SetPeruit(IBotOwner bot) { }

	public void SetProblemsSomebody(bool trg) { }

	public bool SetTarget(FollowerPatrolTargetStruct trg, Nullable lookSide) { }

	private void SetTargetFromSafe() { }

	public void StopFor(float period) { }

}

