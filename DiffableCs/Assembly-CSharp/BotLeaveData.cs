//Type is in global namespace

public class BotLeaveData : BotData
{
	private Vector3 _pointToLeave; //Field offset: 0x18
	private AIPeriodAction _gotoPeriod; //Field offset: 0x28
	private AIPeriodAction _checkPeriod; //Field offset: 0x30
	private bool _canLeave; //Field offset: 0x38
	private bool _canLeaveByMyself; //Field offset: 0x39
	private float DistToCanLeave; //Field offset: 0x3C
	private readonly float MinLeaveTime; //Field offset: 0x40
	[CompilerGenerated]
	private Action OnLeave; //Field offset: 0x48
	[CompilerGenerated]
	private bool <WannaLeave>k__BackingField; //Field offset: 0x50
	[CompilerGenerated]
	private bool <LeaveComplete>k__BackingField; //Field offset: 0x51

	public event Action OnLeave
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public private bool LeaveComplete
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public private bool WannaLeave
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public BotLeaveData(BotOwner owner) { }

	[CompilerGenerated]
	private Vector3 <DoLeave>b__27_0(int i) { }

	public void Activate(float leaveDist) { }

	[CompilerGenerated]
	public void add_OnLeave(Action value) { }

	public void BlockLeave() { }

	public void CheckCanLeave() { }

	public void Dispose() { }

	private void DoLeave() { }

	public void DoLeaveExternal() { }

	[CompilerGenerated]
	public bool get_LeaveComplete() { }

	[CompilerGenerated]
	public bool get_WannaLeave() { }

	private void GoToCompletePoint() { }

	[CompilerGenerated]
	public void remove_OnLeave(Action value) { }

	public void RemoveFromMap() { }

	[CompilerGenerated]
	private void set_LeaveComplete(bool value) { }

	[CompilerGenerated]
	private void set_WannaLeave(bool value) { }

	public void UpdateByNode() { }

	public void UpdateFromLayer() { }

}

