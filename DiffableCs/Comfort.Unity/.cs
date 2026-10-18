//Type is in global namespace

internal sealed class  : IDispatchingScheduler
{
	private readonly IUnityScheduller ; //Field offset: 0x10
	private readonly Queue ; //Field offset: 0x18
	private bool ; //Field offset: 0x20
	private Action ; //Field offset: 0x28
	private DateTime ; //Field offset: 0x30
	private ulong ; //Field offset: 0x38
	[CompilerGenerated]
	private Action ; //Field offset: 0x40

	public override Action PingAction
	{
		 set { } //Length: 82
	}

	public override Action ReceiveAction
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 82
	}

	internal IUnityScheduller 
	{
		internal get { } //Length: 5
	}

	public (IUnityScheduller ) { }

	public override void Execute(Action action) { }

	public override void ExecuteOnSchedule(Action action) { }

	[CompilerGenerated]
	public Action get_ReceiveAction() { }

	internal IUnityScheduller get_() { }

	public override ulong GetFrameIndex() { }

	public override void ScheduleExecution(Action action) { }

	public override void set_PingAction(Action value) { }

	[CompilerGenerated]
	public override void set_ReceiveAction(Action value) { }

	public override void TryReceive() { }

	private void () { }

}

