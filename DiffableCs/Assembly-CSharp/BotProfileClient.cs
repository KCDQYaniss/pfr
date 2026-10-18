//Type is in global namespace

public class BotProfileClient : ABotProfileCreator
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__8_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal CountTypeBotWave <.ctor>b__8_0(SpawnWave spawnWave) { }

	}

	[CompilerGenerated]
	private struct <CreateProfile>d__16 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public BotProfileClient <>4__this; //Field offset: 0x20
		public BotCreationData data; //Field offset: 0x28
		public bool withDelete; //Field offset: 0x30
		public CancellationToken cancellationToken; //Field offset: 0x38
		private Profile <profile>5__2; //Field offset: 0x40
		private TaskAwaiter <>u__1; //Field offset: 0x48
		private List <optimized>5__3; //Field offset: 0x50
		private TaskAwaiter <>u__2; //Field offset: 0x58
		private TaskAwaiter <>u__3; //Field offset: 0x60

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <FillCreationDataWithProfiles>d__18 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public BotProfileClient <>4__this; //Field offset: 0x20
		public BotCreationData data; //Field offset: 0x28
		public CancellationToken cancellationToken; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38
		private List <optimized>5__2; //Field offset: 0x40
		private TaskAwaiter <>u__2; //Field offset: 0x48
		private TaskAwaiter <>u__3; //Field offset: 0x50

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <LoadBots>d__11 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public BotProfileClient <>4__this; //Field offset: 0x20
		public List waves; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30
		private TaskAwaiter <>u__2; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <LoadProfiles>d__12 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public BotProfileClient <>4__this; //Field offset: 0x20
		public List waves; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <TryLoadBotsProfilesOnStart>d__10 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public BotProfileClient <>4__this; //Field offset: 0x20
		public IEnumerable external; //Field offset: 0x28
		private Enumerator <>7__wrap1; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private int _loadBundlesProcess; //Field offset: 0x20
	private readonly IEftSession _backEndSession; //Field offset: 0x28
	private int _profilesToLoad; //Field offset: 0x30
	private List _delayed; //Field offset: 0x38
	private List listWaves; //Field offset: 0x40
	private readonly BotProfileBackuploader _backupLoader; //Field offset: 0x48

	public virtual int BundlesLoading
	{
		 get { } //Length: 4
	}

	public BotProfileClient(IEftSession backEndSession, SpawnWave[] waves, BossLocationSpawn[] bossWaves, CountTypeBotWave[] nonWaves = null, bool checkProfilesLoaded = false) { }

	public virtual void AddToTargetBackup(BotDifficulty difficulty, WildSpawnType role, int count) { }

	public void CheckLoadingResult(Profile[] result, List conditions) { }

	[AsyncStateMachine(typeof(<CreateProfile>d__16))]
	public virtual Task CreateProfile(BotCreationData data, CancellationToken cancellationToken, bool withDelete) { }

	public virtual void FillBackupProfilesData(DebugBotProfilesStructContainer resultCache) { }

	[AsyncStateMachine(typeof(<FillCreationDataWithProfiles>d__18))]
	public Task FillCreationDataWithProfiles(BotCreationData data, CancellationToken cancellationToken) { }

	public virtual int get_BundlesLoading() { }

	[AsyncStateMachine(typeof(<LoadBots>d__11))]
	private Task LoadBots(List waves) { }

	private void LoadedByBackup(List profiles) { }

	[AsyncStateMachine(typeof(<LoadProfiles>d__12))]
	private Task LoadProfiles(List waves, EProfilesAskingStat stat) { }

	private List OptimizeBotWaves(List wavesProfiles, out List delayed) { }

	[AsyncStateMachine(typeof(<TryLoadBotsProfilesOnStart>d__10))]
	public Task TryLoadBotsProfilesOnStart(IEnumerable external = null) { }

}

