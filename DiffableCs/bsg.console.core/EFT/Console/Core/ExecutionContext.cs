namespace EFT.Console.Core;

public class ExecutionContext
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass30_0
	{
		public ExecutionContext <>4__this; //Field offset: 0x10
		public IConsoleCommand command; //Field offset: 0x18
		public CompleteCallback onComplete; //Field offset: 0x20

		public <>c__DisplayClass30_0() { }

		internal void <ExecuteCommand>b__0(Exception e) { }

	}

	[CompilerGenerated]
	private struct <StartProcessNextCommand>d__29 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ExecutionContext <>4__this; //Field offset: 0x20
		private CommandRegisterData <el>5__2; //Field offset: 0x28
		private YieldAwaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	internal sealed class CompleteCallback : MulticastDelegate
	{

		public CompleteCallback(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(Exception exception, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(Exception exception) { }

	}

	private const int MAX_COMMAND_PER_FRAME = 20; //Field offset: 0x0
	[CompilerGenerated]
	private Action OnSchedule; //Field offset: 0x10
	[CompilerGenerated]
	private Action OnExecuteStart; //Field offset: 0x18
	[CompilerGenerated]
	private Action OnExecuteSuccess; //Field offset: 0x20
	[CompilerGenerated]
	private Action OnExecuteFailed; //Field offset: 0x28
	[CompilerGenerated]
	private readonly string <Name>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	private float <LastBusyTime>k__BackingField; //Field offset: 0x38
	private ConsoleProcessor _processor; //Field offset: 0x40
	private readonly LinkedList _queue; //Field offset: 0x48
	private bool _isBusy; //Field offset: 0x50
	[TupleElementNames(new IL2CPP_TYPE_STRING[] {"currentFrame", "commandCount"})]
	private ValueTuple _frameStatus; //Field offset: 0x54

	public event Action OnExecuteFailed
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public event Action OnExecuteStart
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public event Action OnExecuteSuccess
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public event Action OnSchedule
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public bool IsBusy
	{
		 get { } //Length: 83
	}

	public private float LastBusyTime
	{
		[CompilerGenerated]
		 get { } //Length: 6
		[CompilerGenerated]
		private set { } //Length: 6
	}

	public string Name
	{
		[CompilerGenerated]
		 get { } //Length: 76
	}

	public ExecutionContext(ConsoleProcessor owner, string name) { }

	[CompilerGenerated]
	private LinkedListNode <RegisterForExecute>b__28_0(LinkedListNode accum, CommandRegisterData el) { }

	[CompilerGenerated]
	public void add_OnExecuteFailed(Action value) { }

	[CompilerGenerated]
	public void add_OnExecuteStart(Action value) { }

	[CompilerGenerated]
	public void add_OnExecuteSuccess(Action value) { }

	[CompilerGenerated]
	public void add_OnSchedule(Action value) { }

	private void ExecuteCommand(IConsoleCommand command, CompleteCallback onComplete) { }

	private void ExecuteCommandCallback(IConsoleCommand command, Exception error, CompleteCallback onComplete) { }

	public bool get_IsBusy() { }

	[CompilerGenerated]
	public float get_LastBusyTime() { }

	[CompilerGenerated]
	public string get_Name() { }

	public void RegisterForExecute(ERegisterMode mode, IEnumerable toRegister) { }

	[CompilerGenerated]
	public void remove_OnExecuteFailed(Action value) { }

	[CompilerGenerated]
	public void remove_OnExecuteStart(Action value) { }

	[CompilerGenerated]
	public void remove_OnExecuteSuccess(Action value) { }

	[CompilerGenerated]
	public void remove_OnSchedule(Action value) { }

	[CompilerGenerated]
	private void set_LastBusyTime(float value) { }

	[AsyncStateMachine(typeof(<StartProcessNextCommand>d__29))]
	private Task StartProcessNextCommand() { }

}

