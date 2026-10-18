namespace EFT;

public sealed class LocalKolotunController : KolotunController
{
	[CompilerGenerated]
	private struct <DamageDistributor>d__2 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public int delayMS; //Field offset: 0x20
		public CancellationToken token; //Field offset: 0x28
		public LocalKolotunController <>4__this; //Field offset: 0x30
		private GameTimer <gameTimer>5__2; //Field offset: 0x38
		private TaskAwaiter <>u__1; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <FrostbiteDistributor>d__1 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public int delayMS; //Field offset: 0x20
		public CancellationToken token; //Field offset: 0x28
		public LocalKolotunController <>4__this; //Field offset: 0x30
		private GameTimer <gameTimer>5__2; //Field offset: 0x38
		private TaskAwaiter <>u__1; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}


	public LocalKolotunController(KolotunGlobalSettings settings, Location location, LocationSettings locationSettings) { }

	private void ApplyFrostbiteDamage(ActiveHealthController healthController) { }

	[AsyncStateMachine(typeof(<DamageDistributor>d__2))]
	private Task DamageDistributor(int delayMS, CancellationToken token) { }

	[AsyncStateMachine(typeof(<FrostbiteDistributor>d__1))]
	private Task FrostbiteDistributor(int delayMS, CancellationToken token) { }

	protected virtual bool IsInDoor(Player player) { }

}

