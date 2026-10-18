namespace EFT.Hideout;

public class QTEController : UIElement
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__13_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal bool <Stop>b__13_0(GameObject spawnedQte) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass10_0
	{
		public QuickTimeEvent quickTimeEvent; //Field offset: 0x10

		public <>c__DisplayClass10_0() { }

		internal bool <SpawnAction>b__0(QteTemplate q) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass12_0
	{
		public CancellationToken cancellationToken; //Field offset: 0x10

		public <>c__DisplayClass12_0() { }

		internal bool <StartQteBySequence>b__0() { }

	}

	[CompilerGenerated]
	private struct <RunEvent>d__11 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public QTEController <>4__this; //Field offset: 0x20
		public QuickTimeEvent quickTimeEvent; //Field offset: 0x28
		private CancellationToken <cancellationToken>5__2; //Field offset: 0x30
		private QTEAction <action>5__3; //Field offset: 0x38
		private TaskAwaiter <>u__1; //Field offset: 0x40
		private TaskAwaiter <>u__2; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <StartQteBySequence>d__12 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public QTEController <>4__this; //Field offset: 0x20
		public IEnumerable qteDatas; //Field offset: 0x28
		private <>c__DisplayClass12_0 <>8__1; //Field offset: 0x30
		private Task <cancelTask>5__2; //Field offset: 0x38
		private IEnumerator <>7__wrap2; //Field offset: 0x40
		private TaskAwaiter <>u__1; //Field offset: 0x48
		private TaskAwaiter <>u__2; //Field offset: 0x50

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[SerializeField]
	private QteTemplate[] _qteTemplates; //Field offset: 0x70
	[SerializeField]
	private bool _isLoop; //Field offset: 0x78
	private IEnumerable _qteDatas; //Field offset: 0x80
	private readonly CompositeDisposable _compositeDisposable; //Field offset: 0x88
	private readonly List _spawnedQtes; //Field offset: 0x90
	private QTEResult _qteResult; //Field offset: 0x98
	private bool _forceStop; //Field offset: 0xA0
	[CompilerGenerated]
	private Action OnSingleQteFinished; //Field offset: 0xA8

	public event Action OnSingleQteFinished
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	public QTEController() { }

	[CompilerGenerated]
	public void add_OnSingleQteFinished(Action value) { }

	[CompilerGenerated]
	public void remove_OnSingleQteFinished(Action value) { }

	[AsyncStateMachine(typeof(<RunEvent>d__11))]
	private Task RunEvent(QuickTimeEvent quickTimeEvent) { }

	private QTEAction SpawnAction(QuickTimeEvent quickTimeEvent) { }

	[AsyncStateMachine(typeof(<StartQteBySequence>d__12))]
	public Task StartQteBySequence(IEnumerable qteDatas) { }

	public void Stop() { }

}

