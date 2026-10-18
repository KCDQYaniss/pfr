namespace EFT.Hideout;

public sealed class LampControllerAmbiance : InteractiveAmbianceObject
{
	[CompilerGenerated]
	private struct <PerformInteraction>d__2 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public LampControllerAmbiance <>4__this; //Field offset: 0x20
		public ELightStatus status; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	internal sealed class LampControllerPattern
	{
		public bool Active; //Field offset: 0x10
		public RandomBetweenFloats Flickering; //Field offset: 0x18
		[Range(0, 100)]
		public float FlickeringChance; //Field offset: 0x20

		public LampControllerPattern() { }

	}

	public LampController AffectedObject; //Field offset: 0x88

	public LampControllerAmbiance() { }

	[CompilerGenerated]
	[DebuggerHidden]
	private Task <>n__0(ELightStatus status) { }

	[AsyncStateMachine(typeof(<PerformInteraction>d__2))]
	public virtual Task PerformInteraction(ELightStatus status) { }

}

