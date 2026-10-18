//Type is in global namespace

public abstract class PatrolFollowerAIBase
{
	protected bool _frontMan; //Field offset: 0x10
	protected float _nextGoTime; //Field offset: 0x14
	protected bool _closeToPoint; //Field offset: 0x18
	protected BotObserveData _observe; //Field offset: 0x20
	protected BotOwner _owner; //Field offset: 0x28
	protected IBotOwner _persuitable; //Field offset: 0x30
	protected bool _someBodyhaveProblems; //Field offset: 0x38
	protected FollowerPatrolTargetStruct _curSettedTarget; //Field offset: 0x40
	protected Nullable _lookSide; //Field offset: 0x60
	protected PatrolPoint _bossPatrolPoint; //Field offset: 0x70
	private float _nextPosibleGo; //Field offset: 0x78
	[CompilerGenerated]
	private bool <HaveProblems>k__BackingField; //Field offset: 0x7C

	public bool HaveProblems
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public int Index
	{
		 get { } //Length: 38
	}

	protected PatrolFollowerAIBase(BotOwner owner) { }

	public override void Activate() { }

	[CanBeNull]
	protected override PatrolPoint BossPatrolPoint() { }

	public override void Dispose() { }

	[CompilerGenerated]
	public bool get_HaveProblems() { }

	public int get_Index() { }

	protected bool GoLikeBoss() { }

	public override void OnDrawSelectedGizmos() { }

	protected FollowerPatrolTargetStruct PosByTrg(out bool extraTarget) { }

	[CompilerGenerated]
	public void set_HaveProblems(bool value) { }

	public void SetClseToTarget(bool closeToPoint) { }

	public void SetFolloweType(bool front) { }

	public void SetPeruit(IBotOwner bot) { }

	public abstract bool SetTarget(FollowerPatrolTargetStruct trg, Nullable lookSide) { }

	public void SomeBodyhaveProblems(bool someBodyhaveProblems) { }

	public abstract void Update() { }

}

