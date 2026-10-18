namespace EFT.Console.Commands;

[ConsoleCommand("wait", null, null, null, new IL2CPP_TYPE_STRING[] {"w"})]
public class WaitCommand : AsyncCommand
{
	[CompilerGenerated]
	private struct <Execute>d__4 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public WaitCommand <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private float _seconds; //Field offset: 0x18

	public virtual object[] ArgumentsValue
	{
		 get { } //Length: 192
	}

	public WaitCommand(float seconds) { }

	[AsyncStateMachine(typeof(<Execute>d__4))]
	public virtual Task Execute() { }

	public virtual object[] get_ArgumentsValue() { }

}

