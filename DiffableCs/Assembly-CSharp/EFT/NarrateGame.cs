namespace EFT;

internal class NarrateGame : AbstractGame
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__26_0; //Field offset: 0x8
		public static Func <>9__26_1; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal float <PlayerFactory>b__26_0() { }

		internal float <PlayerFactory>b__26_1() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass22_0
	{
		public IInputTree inputTree; //Field offset: 0x10
		public IEftSession backEndSession; //Field offset: 0x18
		public GameUI gameUI; //Field offset: 0x20
		public NarrateGame game; //Field offset: 0x28

		public <>c__DisplayClass22_0() { }

		internal NarratePlayerOwner <Create>b__0(LocalPlayer player) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass22_1
	{
		public NarratePlayerOwner owner; //Field offset: 0x10
		public <>c__DisplayClass22_0 CS$<>8__locals1; //Field offset: 0x18

		public <>c__DisplayClass22_1() { }

		internal void <Create>g__StopGame|1() { }

	}

	[CompilerGenerated]
	private sealed class <AdjustCameraRoutine>d__30 : IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private object <>2__current; //Field offset: 0x18
		public NarrateGame <>4__this; //Field offset: 0x20
		public PlayerCameraController cameraController; //Field offset: 0x28

		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		[DebuggerHidden]
		public <AdjustCameraRoutine>d__30(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	private struct <DisposeAsync>d__33 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public NarrateGame <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <PlayerFactory>d__26 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public NarrateGame <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <Run>d__27 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public NarrateGame <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <Stop>d__32 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public NarrateGame <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private const float FOV = 55; //Field offset: 0x0
	private GameWorld _gameWorld; //Field offset: 0x60
	private IEftSession _backEnd; //Field offset: 0x68
	private Action _callback; //Field offset: 0x70
	private Func _ownerFactory; //Field offset: 0x78
	private GameUI _gameUI; //Field offset: 0x80
	private Profile _profile; //Field offset: 0x88
	private StaticCameraObservationPoint _observationPoint; //Field offset: 0x90
	[CompilerGenerated]
	private EftGamePlayerOwner <PlayerOwner>k__BackingField; //Field offset: 0x98
	private QuestController _questController; //Field offset: 0xA0
	private AchievementsController _achievementsController; //Field offset: 0xA8
	private BaseTraderDialogController _dialogController; //Field offset: 0xB0

	protected virtual GameUI GameUi
	{
		 get { } //Length: 8
	}

	public virtual string LocationId
	{
		 get { } //Length: 59
	}

	public virtual string LocationObjectId
	{
		 get { } //Length: 59
	}

	public private EftGamePlayerOwner PlayerOwner
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	protected virtual string ProfileId
	{
		 get { } //Length: 30
	}

	protected virtual int RaidID
	{
		 get { } //Length: 44
	}

	public NarrateGame() { }

	[CompilerGenerated]
	[DebuggerHidden]
	private void <>n__0() { }

	[IteratorStateMachine(typeof(<AdjustCameraRoutine>d__30))]
	private IEnumerator AdjustCameraRoutine(PlayerCameraController cameraController) { }

	public static NarrateGame Create(IInputTree inputTree, GameWorld gameWorld, GameUI gameUI, Action callback, float fixedDeltaTime, EUpdateQueue updateQueue, IEftSession backEndSession, MainMenuShowOperation mainMenuShowOperation) { }

	public virtual void Dispose() { }

	[AsyncStateMachine(typeof(<DisposeAsync>d__33))]
	private Task DisposeAsync() { }

	protected virtual GameUI get_GameUi() { }

	public virtual string get_LocationId() { }

	public virtual string get_LocationObjectId() { }

	[CompilerGenerated]
	public EftGamePlayerOwner get_PlayerOwner() { }

	protected virtual string get_ProfileId() { }

	protected virtual int get_RaidID() { }

	public void Hide() { }

	public void Move() { }

	[AsyncStateMachine(typeof(<PlayerFactory>d__26))]
	private Task PlayerFactory() { }

	[AsyncStateMachine(typeof(<Run>d__27))]
	public Task Run() { }

	[CompilerGenerated]
	private void set_PlayerOwner(EftGamePlayerOwner value) { }

	[AsyncStateMachine(typeof(<Stop>d__32))]
	public Task Stop() { }

	public static bool TryGetObservationPoint(out StaticCameraObservationPoint observationPoint, out Transform observationTransform) { }

}

