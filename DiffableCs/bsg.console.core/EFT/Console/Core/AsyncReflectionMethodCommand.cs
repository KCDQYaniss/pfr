namespace EFT.Console.Core;

public class AsyncReflectionMethodCommand : AsyncCommand, ICustomPrintCommand
{
	[CompilerGenerated]
	private struct <Execute>d__6 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public AsyncReflectionMethodCommand <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private readonly Func _method; //Field offset: 0x18
	[CompilerGenerated]
	private readonly object[] <ArgumentsValue>k__BackingField; //Field offset: 0x20
	protected Func _originalInput; //Field offset: 0x28

	public virtual object[] ArgumentsValue
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public AsyncReflectionMethodCommand(Func originalInput, Func method, object[] pars) { }

	[AsyncStateMachine(typeof(<Execute>d__6))]
	public virtual Task Execute() { }

	[CompilerGenerated]
	public virtual object[] get_ArgumentsValue() { }

	public override string PrintCommand() { }

}

