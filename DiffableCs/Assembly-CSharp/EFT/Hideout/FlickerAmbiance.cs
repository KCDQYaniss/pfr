namespace EFT.Hideout;

public sealed class FlickerAmbiance : AmbianceObject
{
	[CompilerGenerated]
	private struct <PerformInteraction>d__1 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public FlickerAmbiance <>4__this; //Field offset: 0x20
		public ELightStatus status; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[SerializeField]
	private List _flickers; //Field offset: 0x78

	public FlickerAmbiance() { }

	[CompilerGenerated]
	[DebuggerHidden]
	private Task <>n__0(ELightStatus status) { }

	[AsyncStateMachine(typeof(<PerformInteraction>d__1))]
	public virtual Task PerformInteraction(ELightStatus status) { }

}

