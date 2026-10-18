//Type is in global namespace

public abstract class BotRequest
{
	public const float BASE_REQUEST_LIFETIME_SEC = 120; //Field offset: 0x0
	protected AICoreActionEnd FinishNodeLogic; //Field offset: 0x10
	protected AICoreActionEnd ContinueNodeLogic; //Field offset: 0x20
	public IPlayer Requester; //Field offset: 0x30
	public BotRequestType BotRequestType; //Field offset: 0x38
	public float EndTimeBeforeTaken; //Field offset: 0x3C
	public float EndTimeByExecutor; //Field offset: 0x40
	public bool ShallEndByExecutor; //Field offset: 0x44
	public bool EndIfCantExecute; //Field offset: 0x45
	public bool DisposeOtherRequestsWhenTaken; //Field offset: 0x46
	protected BotOwner Executor; //Field offset: 0x48
	private BotGroupRequestController _groupRequestController; //Field offset: 0x50
	private List _possibleExecutors; //Field offset: 0x58
	[CompilerGenerated]
	private bool <CanExecuteByMyself>k__BackingField; //Field offset: 0x60
	[CompilerGenerated]
	private bool <Taken>k__BackingField; //Field offset: 0x61
	protected float _takenTime; //Field offset: 0x64
	[CompilerGenerated]
	private bool <Removed>k__BackingField; //Field offset: 0x68

	public bool CanExecuteByMyself
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public bool Removed
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 4
	}

	protected override float requestLifetime
	{
		 get { } //Length: 9
	}

	public abstract EBotRequestMode RequestMode
	{
		 get { } //Length: 0
	}

	public private bool Taken
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	protected BotRequest(IPlayer requester, BotRequestType requestType) { }

	public override void Activate() { }

	public void AddPossibleExecutors(IBotOwner owner) { }

	public abstract bool CanProceed() { }

	public override bool CanRequest(IPlayer player) { }

	public abstract bool CanRequest(BotOwner requester) { }

	public override bool CanStartExecute(BotOwner executor) { }

	public void CheckIsEndBeforeTake() { }

	public void CheckSelfEnd() { }

	public override void Complete() { }

	public override void Dispose() { }

	public override AICoreActionEnd EndHoldPosition() { }

	public string ExecutorInfo() { }

	public override bool FindPoint(CoverSearchData data, Func func, bool checkCurrent, out CustomNavigationPoint customNavigationPoint) { }

	[CompilerGenerated]
	public bool get_CanExecuteByMyself() { }

	[CompilerGenerated]
	public bool get_Removed() { }

	protected override float get_requestLifetime() { }

	public abstract EBotRequestMode get_RequestMode() { }

	[CompilerGenerated]
	public bool get_Taken() { }

	public override void PlayerDestroy(Player player) { }

	[CompilerGenerated]
	protected void set_CanExecuteByMyself(bool value) { }

	[CompilerGenerated]
	public void set_Removed(bool value) { }

	[CompilerGenerated]
	private void set_Taken(bool value) { }

	public void SetEndTimeOnTake(float period) { }

	public bool SetGroup(BotGroupRequestController groupRequestController) { }

	public override void Take(BotOwner executor) { }

	public void UseOnlySelf() { }

}

