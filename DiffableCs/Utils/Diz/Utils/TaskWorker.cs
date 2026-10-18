namespace Diz.Utils;

public sealed class TaskWorker
{
	[CompilerGenerated]
	private struct <Work>d__18 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public TaskWorker <>4__this; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private bool _shouldStop; //Field offset: 0x10
	private Thread _thread1; //Field offset: 0x18
	private Thread _thread2; //Field offset: 0x20
	private readonly EventWaitHandle _waitHandle; //Field offset: 0x28
	private readonly Queue _currentTasks; //Field offset: 0x30
	private readonly Queue _finishedCallbacks; //Field offset: 0x38
	[CompilerGenerated]
	private readonly int <MainThreadId>k__BackingField; //Field offset: 0x40

	public int MainThreadId
	{
		[CompilerGenerated]
		 get { } //Length: 4
	}

	public bool ShouldStop
	{
		 get { } //Length: 10
	}

	public TaskWorker() { }

	public void AddTask(Func task) { }

	public void CheckForFinishedTasks() { }

	public void CreateThread() { }

	private void ExecuteTask(Func task) { }

	[CompilerGenerated]
	public int get_MainThreadId() { }

	public bool get_ShouldStop() { }

	public void Kill() { }

	public void RunInMainTread(Action action) { }

	[AsyncStateMachine(typeof(<Work>d__18))]
	private void Work() { }

}

