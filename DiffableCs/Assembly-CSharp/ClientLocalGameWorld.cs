//Type is in global namespace

internal class ClientLocalGameWorld : ClientGameWorld
{
	[CompilerGenerated]
	private struct <PreloadAdditionalData>d__8 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ClientLocalGameWorld <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private StartMissionController _startMissionController; //Field offset: 0x330

	public ClientLocalGameWorld() { }

	[CompilerGenerated]
	[DebuggerHidden]
	private Task <>n__0() { }

	protected virtual void Awake() { }

	public virtual void Dispose() { }

	public virtual Task InitLevel(ItemFactory itemFactory, ObjectsFactoryConfig config, bool loadBundlesAndCreatePools = true, List resources = null, IProgress progress = null, CancellationToken ct = null) { }

	public virtual bool IsLocalGame() { }

	protected virtual void PlayerTick(float dt) { }

	[AsyncStateMachine(typeof(<PreloadAdditionalData>d__8))]
	protected virtual Task PreloadAdditionalData() { }

	public virtual void RegisterGameOwner(Player player) { }

	public void StartTutorial() { }

	protected override void UpdateSynchronizableObjectLogic(float dt) { }

}

