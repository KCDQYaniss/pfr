namespace EFT.UI;

public class AsyncViewList`2 : TemplateList
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass5_0
	{
		public Func templateFactory; //Field offset: 0x0
		public AsyncViewList <>4__this; //Field offset: 0x0

		public <>c__DisplayClass5_0() { }

		internal TView <InitAsync>g__ViewFactory|0(TItem item) { }

	}

	[CompilerGenerated]
	private struct <CreateViews>d__7 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x0
		public AsyncViewList <>4__this; //Field offset: 0x0
		private YieldAwaiter <>u__1; //Field offset: 0x0

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <InitAsync>d__5 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x0
		public Func templateFactory; //Field offset: 0x0
		public AsyncViewList <>4__this; //Field offset: 0x0
		public IEnumerable items; //Field offset: 0x0
		public Func container; //Field offset: 0x0
		public Action showAction; //Field offset: 0x0
		private TaskAwaiter <>u__1; //Field offset: 0x0

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private int _creationIndex; //Field offset: 0x0
	[CompilerGenerated]
	private Task <InitTask>k__BackingField; //Field offset: 0x0

	public private Task InitTask
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public AsyncViewList`2() { }

	[AsyncStateMachine(typeof(<CreateViews>d__7))]
	private Task CreateViews() { }

	public virtual void Dispose() { }

	[CompilerGenerated]
	public Task get_InitTask() { }

	[AsyncStateMachine(typeof(<InitAsync>d__5))]
	public Task InitAsync(IEnumerable items, Func templateFactory, Func container, Action showAction) { }

	private void ItemsOrderChanged() { }

	[CompilerGenerated]
	private void set_InitTask(Task value) { }

}

