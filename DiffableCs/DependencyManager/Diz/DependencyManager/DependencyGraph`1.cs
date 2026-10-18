namespace Diz.DependencyManager;

public sealed class DependencyGraph`1
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass2_0
	{
		public Func shouldExclude; //Field offset: 0x0
		public DependencyGraph <>4__this; //Field offset: 0x0

		public <>c__DisplayClass2_0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass2_1
	{
		public T loadable; //Field offset: 0x0
		public <>c__DisplayClass2_0 CS$<>8__locals1; //Field offset: 0x0

		public <>c__DisplayClass2_1() { }

		internal IEnumerable <.ctor>b__0(string x) { }

	}

	[CompilerGenerated]
	private struct <RetainRecursiveAsync>d__17 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x0
		public CancellationToken ct; //Field offset: 0x0
		public List nodes; //Field offset: 0x0
		public Node node; //Field offset: 0x0
		private YieldAwaiter <>u__1; //Field offset: 0x0
		private int <i>5__2; //Field offset: 0x0
		private TaskAwaiter <>u__2; //Field offset: 0x0

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <RetainSeparateAsync>d__20 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x0
		public IEnumerable keys; //Field offset: 0x0
		public CancellationToken ct; //Field offset: 0x0
		public DependencyGraph <>4__this; //Field offset: 0x0
		public IProgress progress; //Field offset: 0x0
		private List <nodes>5__2; //Field offset: 0x0
		private Dictionary <tokenDict>5__3; //Field offset: 0x0
		private float <cycleCount>5__4; //Field offset: 0x0
		private float <keysCountForProgress>5__5; //Field offset: 0x0
		private IEnumerator <>7__wrap5; //Field offset: 0x0
		private string <key>5__7; //Field offset: 0x0
		private TaskAwaiter <>u__1; //Field offset: 0x0

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	internal sealed class Token : TokenBase
	{
		[CompilerGenerated]
		private sealed class <>c
		{
			public static readonly <>c <>9; //Field offset: 0x0
			public static Func <>9__6_0; //Field offset: 0x0

			private static <>c() { }

			public <>c() { }

			internal string <ToString>b__6_0(Node node) { }

		}

		internal readonly List Nodes; //Field offset: 0x0
		internal readonly CancellationToken CancellationToken; //Field offset: 0x0
		private readonly DependencyGraph _graph; //Field offset: 0x0

		internal Token(DependencyGraph graph, List nodes, IProgress progressReporter, CancellationToken cancellationToken) { }

		protected virtual void ReleaseInternal() { }

		public virtual string ToString() { }

		internal virtual void UpdateProgress() { }

	}

	internal abstract class TokenBase
	{
		protected readonly TaskCompletionSource _loadingJob; //Field offset: 0x0
		[CanBeNull]
		protected IProgress _progressReporter; //Field offset: 0x0
		protected bool _released; //Field offset: 0x0
		[CompilerGenerated]
		private bool <Finished>k__BackingField; //Field offset: 0x0
		[CompilerGenerated]
		private float <Progress>k__BackingField; //Field offset: 0x0

		internal bool Active
		{
			internal get { } //Length: 17
		}

		public bool Finished
		{
			[CompilerGenerated]
			 get { } //Length: 5
			[CompilerGenerated]
			 set { } //Length: 4
		}

		public Task LoadingJob
		{
			 get { } //Length: 66
		}

		public float Progress
		{
			[CompilerGenerated]
			 get { } //Length: 6
			[CompilerGenerated]
			 set { } //Length: 6
		}

		protected TokenBase(IProgress progressReporter) { }

		internal bool get_Active() { }

		[CompilerGenerated]
		public bool get_Finished() { }

		public Task get_LoadingJob() { }

		[CompilerGenerated]
		public float get_Progress() { }

		public void Release() { }

		protected abstract void ReleaseInternal() { }

		[CompilerGenerated]
		protected void set_Finished(bool value) { }

		[CompilerGenerated]
		protected void set_Progress(float value) { }

		internal abstract void UpdateProgress() { }

	}

	internal sealed class TokenContainer : TokenBase
	{
		[CompilerGenerated]
		private sealed class <>c
		{
			public static readonly <>c <>9; //Field offset: 0x0
			public static Action <>9__7_0; //Field offset: 0x0

			private static <>c() { }

			public <>c() { }

			internal void <ReleaseInternal>b__7_0(Token x) { }

		}

		private CancellationToken _cancellationToken; //Field offset: 0x0
		[CompilerGenerated]
		private Dictionary <TokenDict>k__BackingField; //Field offset: 0x0
		private readonly HashSet _uniqueNodes; //Field offset: 0x0

		public private Dictionary TokenDict
		{
			[CompilerGenerated]
			 get { } //Length: 76
			[CompilerGenerated]
			private set { } //Length: 82
		}

		internal TokenContainer(Dictionary tokens, IProgress progressReporter, CancellationToken cancellationToken) { }

		[CompilerGenerated]
		public Dictionary get_TokenDict() { }

		protected virtual void ReleaseInternal() { }

		[CompilerGenerated]
		private void set_TokenDict(Dictionary value) { }

		internal virtual void UpdateProgress() { }

	}

	private static int RETAIN_COUNT_FOR_AWAIT; //Field offset: 0x0
	private static int _currentRetainCountForAsync; //Field offset: 0x0
	public readonly Dictionary Nodes; //Field offset: 0x0
	private readonly string _defaultKey; //Field offset: 0x0
	private readonly List _activeTokens; //Field offset: 0x0
	private readonly List _tokensToAdd; //Field offset: 0x0
	private readonly List _inputRetains; //Field offset: 0x0
	private readonly List _inputReleases; //Field offset: 0x0
	private readonly List _refCountChanges; //Field offset: 0x0
	private readonly List _pendingLoads; //Field offset: 0x0
	private readonly List _pendingUnloads; //Field offset: 0x0

	private static DependencyGraph`1() { }

	public DependencyGraph`1(T[] loadables, string defaultKey, Func shouldExclude) { }

	private static void CollectDependencies(List input, List temp, List output, Func shouldExclude) { }

	public Node GetDefaultNode() { }

	public Node GetNode(string key) { }

	private static void ProcessPendingLoads(List pendingLoads) { }

	private static void ProcessPendingUnloads(List pendingUnloads, List refCountChanges) { }

	private static void ProcessRefCountChanges(List refCountChanges, List pendingLoads, List pendingUnloads) { }

	internal void Release(ICollection nodes) { }

	public Token Retain(IEnumerable keys, IProgress progress, CancellationToken ct = null) { }

	public Token Retain(string key, IProgress progress = null) { }

	private static void RetainRecursive(Node node, List nodes) { }

	[AsyncStateMachine(typeof(<RetainRecursiveAsync>d__17))]
	private static Task RetainRecursiveAsync(Node node, List nodes, CancellationToken ct) { }

	public TokenContainer RetainSeparate(IEnumerable keys, IProgress progress, CancellationToken ct = null) { }

	[AsyncStateMachine(typeof(<RetainSeparateAsync>d__20))]
	public Task RetainSeparateAsync(IEnumerable keys, IProgress progress, CancellationToken ct = null) { }

	public void Update() { }

	private static void UpdateRefCounts(List retains, List releases, List refCountChanges) { }

}

