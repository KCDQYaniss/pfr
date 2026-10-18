namespace EFT.Hideout;

public sealed class SetActiveAmbiance : AmbianceObject
{
	[CompilerGenerated]
	private struct <PerformInteraction>d__0 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public SetActiveAmbiance <>4__this; //Field offset: 0x20
		public ELightStatus status; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}


	public SetActiveAmbiance() { }

	[CompilerGenerated]
	[DebuggerHidden]
	private Task <>n__0(ELightStatus status) { }

	[AsyncStateMachine(typeof(<PerformInteraction>d__0))]
	public virtual Task PerformInteraction(ELightStatus status) { }

}

