namespace EFT;

public abstract class CommonClientApplication`1 : ClientApplication
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass19_0
	{
		public ConsistencyController filesChecker; //Field offset: 0x0
		public ConsistencyEnsuranceMode ordinaryFileEnsuranceMode; //Field offset: 0x0
		public ConsistencyEnsuranceMode criticalFileEnsuranceMode; //Field offset: 0x0
		public CancellationToken token; //Field offset: 0x0

		public <>c__DisplayClass19_0() { }

		internal Task <RunFilesChecking>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass19_1
	{
		public TaskCompletionSource completionSource; //Field offset: 0x0

		public <>c__DisplayClass19_1() { }

		internal void <RunFilesChecking>b__1() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass20_0
	{
		public ConsistencyController filesChecker; //Field offset: 0x0
		public string resultPath; //Field offset: 0x0
		public ConsistencyEnsuranceMode ordinaryFileEnsuranceMode; //Field offset: 0x0
		public ConsistencyEnsuranceMode criticalFileEnsuranceMode; //Field offset: 0x0

		public <>c__DisplayClass20_0() { }

		internal Task <DefaultBundleCheck>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass20_1
	{
		public TaskCompletionSource completionSource; //Field offset: 0x0

		public <>c__DisplayClass20_1() { }

		internal void <DefaultBundleCheck>b__1() { }

	}

	[CompilerGenerated]
	private struct <DefaultBundleCheck>d__20 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x0
		public string bundlePath; //Field offset: 0x0
		private <>c__DisplayClass20_0 <>8__1; //Field offset: 0x0
		public CommonClientApplication <>4__this; //Field offset: 0x0
		private TaskAwaiter <>u__1; //Field offset: 0x0
		private Token <>7__wrap1; //Field offset: 0x0
		private TaskAwaiter <>u__2; //Field offset: 0x0
		private TaskAwaiter <>u__3; //Field offset: 0x0

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <RunFilesChecking>d__19 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x0
		public ConsistencyEnsuranceMode ordinaryFileEnsuranceMode; //Field offset: 0x0
		public ConsistencyEnsuranceMode criticalFileEnsuranceMode; //Field offset: 0x0
		public CancellationToken token; //Field offset: 0x0
		public CommonClientApplication <>4__this; //Field offset: 0x0
		private Token <>7__wrap1; //Field offset: 0x0
		private TaskAwaiter <>u__1; //Field offset: 0x0
		private TaskAwaiter <>u__2; //Field offset: 0x0

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <StartTask>d__17 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x0
		public CommonClientApplication <>4__this; //Field offset: 0x0
		private TaskAwaiter <>u__1; //Field offset: 0x0
		private Token <>7__wrap1; //Field offset: 0x0
		private Task <backendCreation>5__3; //Field offset: 0x0
		private Token <>7__wrap3; //Field offset: 0x0
		private OperationAwaiter <>u__2; //Field offset: 0x0

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[SerializeField]
	protected bool _developMode; //Field offset: 0x0
	[SerializeField]
	protected int _fixedFrameRate; //Field offset: 0x0
	[SerializeField]
	protected float _fixedDeltaTime; //Field offset: 0x0
	[SerializeField]
	protected string _localGameDate; //Field offset: 0x0
	[SerializeField]
	protected string _localGameTime; //Field offset: 0x0
	[SerializeField]
	protected float _localGameTimeFactor; //Field offset: 0x0
	[SerializeField]
	protected bool _resetSettings; //Field offset: 0x0
	[SerializeField]
	protected string _matchingVersion; //Field offset: 0x0
	[SerializeField]
	private bool _enableSteamDebug; //Field offset: 0x0
	protected ObjectsFactoryConfig _objectsFactoryConfig; //Field offset: 0x0
	protected CommandLineArgs _commandLineArgs; //Field offset: 0x0
	protected string _backendUrl; //Field offset: 0x0
	protected bool _sessionCreated; //Field offset: 0x0
	protected string _buildVersion; //Field offset: 0x0

	protected CommonClientApplication`1() { }

	[CompilerGenerated]
	[DebuggerHidden]
	private Task <>n__0() { }

	[CompilerGenerated]
	private void <StartTask>b__17_0() { }

	public virtual void Awake() { }

	protected abstract Task BundleCheck(string bundlePath) { }

	protected override bool ConfigureApplication() { }

	protected abstract Task CreateBackend(EGameMode gameMode) { }

	[AsyncStateMachine(typeof(<DefaultBundleCheck>d__20))]
	protected Task DefaultBundleCheck(string bundlePath) { }

	public void InitSteam() { }

	protected abstract Task LoadLoginScenes() { }

	protected abstract Task LoadMainMenu() { }

	private void OnValidate() { }

	[AsyncStateMachine(typeof(<RunFilesChecking>d__19))]
	protected Task RunFilesChecking(ConsistencyEnsuranceMode ordinaryFileEnsuranceMode = 3, ConsistencyEnsuranceMode criticalFileEnsuranceMode = 7, CancellationToken token = null) { }

	[AsyncStateMachine(typeof(<StartTask>d__17))]
	protected virtual Task StartTask() { }

}

