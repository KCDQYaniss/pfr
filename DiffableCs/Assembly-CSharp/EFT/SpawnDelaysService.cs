namespace EFT;

public class SpawnDelaysService : IDisposable
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__8_0; //Field offset: 0x8
		public static Func <>9__12_0; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal string <CheckDelays>b__12_0(ISpawnDelayModel delayModel) { }

		internal int <get_WaitCount>b__8_0(ISpawnDelayModel delayedParams) { }

	}

	[CompilerGenerated]
	private struct <CheckDelays>d__12 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public SpawnDelaysService <>4__this; //Field offset: 0x20
		public CancellationToken token; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	internal enum ERemoveDelayReason
	{
		noData = 0,
		NoOneToSpawn = 1,
		CantBeRemoved = 2,
		Timeout = 3,
		CheckSpawnAfterDelay = 4,
		CheckSpawnOnFreeAfterDelay = 5,
	}

	private readonly List _possibleSpawn; //Field offset: 0x10
	private readonly List _toRemove; //Field offset: 0x18
	private readonly CancellationTokenSource _tokenSource; //Field offset: 0x20
	[CompilerGenerated]
	private readonly List <DelaysModels>k__BackingField; //Field offset: 0x28

	public List DelaysModels
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public int WaitCount
	{
		 get { } //Length: 387
	}

	public SpawnDelaysService() { }

	public void Add(ISpawnDelayModel simpleBotSpawnSpawnDelayResult) { }

	private static bool CanCheckSpawnByTime(ISpawnDelayModel delayModel) { }

	[AsyncStateMachine(typeof(<CheckDelays>d__12))]
	private Task CheckDelays(CancellationToken token) { }

	private void ClearDelays() { }

	public override void Dispose() { }

	[CompilerGenerated]
	public List get_DelaysModels() { }

	public int get_WaitCount() { }

	public void Remove(ISpawnDelayModel delayedBotsInfo, ERemoveDelayReason reason) { }

	private void RemoveDelays() { }

	private static bool ShallRemove(ISpawnDelayModel delayModel, out ERemoveDelayReason reason) { }

}

