namespace EFT.Hideout;

public sealed class CircleOfCultistsAreaStashController : HideoutAreaStashController
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__1_1; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal bool <GetSpawnPoint>b__1_1(KeyValuePair p) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass1_0
	{
		public StashItemModel itemModel; //Field offset: 0x10

		public <>c__DisplayClass1_0() { }

		internal bool <GetSpawnPoint>b__0(KeyValuePair p) { }

	}

	[CompilerGenerated]
	private struct <ProcessSpawnOperation>d__0 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public CircleOfCultistsAreaStashController <>4__this; //Field offset: 0x20
		public CancellationTokenSource updateCancellationToken; //Field offset: 0x28
		public Dictionary spawnPoints; //Field offset: 0x30
		private IEnumerator <>7__wrap1; //Field offset: 0x38
		private Item <item>5__3; //Field offset: 0x40
		private TaskAwaiter <>u__1; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}


	public CircleOfCultistsAreaStashController() { }

	private void GetSpawnPoint(Dictionary spawnPoints, StashItemModel itemModel, out StashItemModelSpawnPoint spawnPoint) { }

	[AsyncStateMachine(typeof(<ProcessSpawnOperation>d__0))]
	protected virtual Task ProcessSpawnOperation(Dictionary spawnPoints, CancellationTokenSource updateCancellationToken) { }

}

