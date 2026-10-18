//Type is in global namespace

public sealed class BotCreatorClient : IBotCreator
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__21_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal bool <StoreBotRenderers>b__21_0(Renderer x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass16_0
	{
		public BotCreationData data; //Field offset: 0x10
		public BotCreatorClient <>4__this; //Field offset: 0x18
		public BotZone zone; //Field offset: 0x20
		public Action callback; //Field offset: 0x28
		public Func groupAction; //Field offset: 0x30
		public BotSpawnBossAndGroupParams groupParams; //Field offset: 0x38

		public <>c__DisplayClass16_0() { }

		internal void <ActivateBot>b__0(BotOwner bot) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass17_0
	{
		public BotCreatorClient <>4__this; //Field offset: 0x10
		public BotZone zone; //Field offset: 0x18
		public Action callback; //Field offset: 0x20
		public Func groupAction; //Field offset: 0x28
		public BotSpawnBossAndGroupParams shallBeGroup; //Field offset: 0x30

		public <>c__DisplayClass17_0() { }

		internal void <ActivateBot>b__0(BotOwner bot) { }

	}

	[CompilerGenerated]
	private struct <ActivateBot>d__16 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public BotCreationData data; //Field offset: 0x20
		public BotCreatorClient <>4__this; //Field offset: 0x28
		public BotZone zone; //Field offset: 0x30
		public Action callback; //Field offset: 0x38
		public Func groupAction; //Field offset: 0x40
		public BotSpawnBossAndGroupParams groupParams; //Field offset: 0x48
		public CancellationToken cancellationToken; //Field offset: 0x50
		private TaskAwaiter <>u__1; //Field offset: 0x58

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <CreateBot>d__15 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public BotCreatorClient <>4__this; //Field offset: 0x20
		public Profile profile; //Field offset: 0x28
		public PositionNote bornInfo; //Field offset: 0x30
		public CancellationToken cancellationToken; //Field offset: 0x38
		public bool isLocalGame; //Field offset: 0x40
		public Action callback; //Field offset: 0x48
		private TaskAwaiter <>u__1; //Field offset: 0x50

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <GenerateProfile>d__23 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public BotCreatorClient <>4__this; //Field offset: 0x20
		public BotCreationData data; //Field offset: 0x28
		public CancellationToken cancellationToken; //Field offset: 0x30
		public bool withDelete; //Field offset: 0x38
		private int <delta>5__2; //Field offset: 0x3C
		private TaskAwaiter <>u__1; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SpawnBot>d__5 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public BotCreationData data; //Field offset: 0x20
		public BotSpawnBossAndGroupParams shallBeGroup; //Field offset: 0x28
		public CancellationToken cancellationToken; //Field offset: 0x30
		public BotCreatorClient <>4__this; //Field offset: 0x38
		public Action callback; //Field offset: 0x40
		private Enumerator <>7__wrap1; //Field offset: 0x48
		private TaskAwaiter <>u__1; //Field offset: 0x60

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SpawnBot>d__6 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public Profile profile; //Field offset: 0x20
		public BotSpawnBossAndGroupParams shallBeGroup; //Field offset: 0x28
		public BotCreatorClient <>4__this; //Field offset: 0x30
		public PositionNote position; //Field offset: 0x38
		public Action callback; //Field offset: 0x40
		public CancellationToken cancellationToken; //Field offset: 0x48
		private YieldAwaiter <>u__1; //Field offset: 0x50

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private readonly IBotGame _game; //Field offset: 0x10
	private readonly IBotProfileCreator _creatorProfile; //Field offset: 0x18
	private readonly Func _playerCreator; //Field offset: 0x20
	private readonly Dictionary _botRenders; //Field offset: 0x28
	[CompilerGenerated]
	private int <BotsLoading>k__BackingField; //Field offset: 0x30

	public private override int BotsLoading
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	public override int BundlesLoading
	{
		 get { } //Length: 78
	}

	public override bool StartProfilesLoaded
	{
		 get { } //Length: 78
	}

	public BotCreatorClient(IBotGame game, IBotProfileCreator profileCreator, Func playerCreator) { }

	[AsyncStateMachine(typeof(<ActivateBot>d__16))]
	public override Task ActivateBot(BotCreationData data, BotZone zone, BotSpawnBossAndGroupParams groupParams, Func groupAction, Action callback, CancellationToken cancellationToken) { }

	public override Task ActivateBot(Profile profile, PositionNote position, BotZone zone, BotSpawnBossAndGroupParams shallBeGroup, Func groupAction, Action callback, CancellationToken cancellationToken) { }

	private void ActivationFaze(BotZone zone, BotOwner bot, Action callback, Func groupAction, BotSpawnBossAndGroupParams bossAndGroup) { }

	public override void AddToTargetBackup(BotDifficulty difficulty, WildSpawnType role, int count) { }

	[AsyncStateMachine(typeof(<CreateBot>d__15))]
	private Task CreateBot(Profile profile, PositionNote bornInfo, Action callback, bool isLocalGame, CancellationToken cancellationToken) { }

	public override void FillBackupProfilesData(DebugBotProfilesStructContainer resultCache) { }

	[AsyncStateMachine(typeof(<GenerateProfile>d__23))]
	public override Task GenerateProfile(BotCreationData data, CancellationToken cancellationToken, bool withDelete) { }

	[CompilerGenerated]
	public override int get_BotsLoading() { }

	public override int get_BundlesLoading() { }

	public override bool get_StartProfilesLoaded() { }

	[CompilerGenerated]
	private void set_BotsLoading(int value) { }

	[AsyncStateMachine(typeof(<SpawnBot>d__5))]
	private Task SpawnBot(BotCreationData data, BotSpawnBossAndGroupParams shallBeGroup, Action callback, CancellationToken cancellationToken, bool withDelete) { }

	[AsyncStateMachine(typeof(<SpawnBot>d__6))]
	private Task SpawnBot(Profile profile, PositionNote position, BotSpawnBossAndGroupParams shallBeGroup, Action callback, CancellationToken cancellationToken) { }

	private void StoreBotRenderers(Player player) { }

	private void SwitchBotVisual(BotOwner owner, bool switch) { }

}

