namespace Diz.Jobs;

public class JobYield
{
	[CompilerGenerated]
	private struct <Yield>d__26 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public JobYield <>4__this; //Field offset: 0x20
		public string jobStageName; //Field offset: 0x28
		private object <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	internal struct Token : IDisposable
	{
		private JobYield _jobYield; //Field offset: 0x0

		public Token(JobYield jobYield) { }

		public override void Dispose() { }

	}

	private YieldDelegate _yieldDelegate; //Field offset: 0x10
	[CompilerGenerated]
	private EJobPriority <Priority>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private bool <IsInProgress>k__BackingField; //Field offset: 0x1C
	[CompilerGenerated]
	private bool <IsCanceled>k__BackingField; //Field offset: 0x1D
	[CompilerGenerated]
	private string <Name>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private string <CurrentStageName>k__BackingField; //Field offset: 0x28
	private bool _cancelOnce; //Field offset: 0x30
	private Stack _cancelActions; //Field offset: 0x38

	public private string CurrentStageName
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private bool IsCanceled
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public private bool IsInProgress
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public string Name
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public private EJobPriority Priority
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public JobYield(string name = null) { }

	public void AddCancelAction(Action action) { }

	public Token Begin() { }

	public void Cancel(bool once = false) { }

	private void ClearCancelActions() { }

	public void End() { }

	private void ExecuteCancelActions() { }

	public bool ForceFinish() { }

	[CompilerGenerated]
	public string get_CurrentStageName() { }

	[CompilerGenerated]
	public bool get_IsCanceled() { }

	[CompilerGenerated]
	public bool get_IsInProgress() { }

	[CompilerGenerated]
	public string get_Name() { }

	[CompilerGenerated]
	public EJobPriority get_Priority() { }

	public void Reset() { }

	[CompilerGenerated]
	private void set_CurrentStageName(string value) { }

	[CompilerGenerated]
	private void set_IsCanceled(bool value) { }

	[CompilerGenerated]
	private void set_IsInProgress(bool value) { }

	[CompilerGenerated]
	public void set_Name(string value) { }

	[CompilerGenerated]
	private void set_Priority(EJobPriority value) { }

	private void TryToCancel() { }

	public JobYield WithPriority(EJobPriority priority) { }

	[AsyncStateMachine(typeof(<Yield>d__26))]
	public Task Yield(string jobStageName = null) { }

}

