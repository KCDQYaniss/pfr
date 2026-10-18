namespace EFT;

[Extension]
public static class EasyAssetsExtensions
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__14_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal Task <LoadBundles>b__14_0(Token x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__4`1
	{
		public static readonly <>c__4 <>9; //Field offset: 0x0
		public static Func <>9__4_1; //Field offset: 0x0

		private static <>c__4`1() { }

		public <>c__4`1() { }

		internal bool <GetAsset>b__4_1(Object a) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass4_0`1
	{
		public string assetName; //Field offset: 0x0

		public <>c__DisplayClass4_0`1() { }

		internal bool <GetAsset>b__0(Object x) { }

	}

	[CompilerGenerated]
	private struct <WaitForAllBundles>d__10 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public Token[] bundles; //Field offset: 0x28
		public Action onFinished; //Field offset: 0x30
		public CancellationToken cancellationToken; //Field offset: 0x38
		public IProgress progress; //Field offset: 0x40
		private TaskAwaiter <>u__1; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <WaitForAllBundles>d__11 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public Token bundles; //Field offset: 0x28
		public Action onFinished; //Field offset: 0x30
		public CancellationToken cancellationToken; //Field offset: 0x38
		public IProgress progress; //Field offset: 0x40
		private TaskAwaiter <>u__1; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <WaitForAllBundlesJob>d__12 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public Token[] bundles; //Field offset: 0x20
		public CancellationToken cancellationToken; //Field offset: 0x28
		public Action onFinished; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <WaitForAllBundlesJob>d__13 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public Token bundles; //Field offset: 0x20
		public CancellationToken cancellationToken; //Field offset: 0x28
		public Action onFinished; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}


	[CanBeNull]
	[Extension]
	public static T GetAsset(IEasyAssets easyAssets, ResourceKey key) { }

	[CanBeNull]
	[Extension]
	public static T GetAsset(IEasyAssets easyAssets, string key, string assetName = null) { }

	[CanBeNull]
	[Extension]
	public static Object GetDefaultAsset(IEasyAssets easyAssets) { }

	[Extension]
	public static T InstantiateAsset(IEasyAssets easyAssets, string key) { }

	[Extension]
	public static T InstantiateAsset(IEasyAssets easyAssets, ResourceKey key, Transform parent = null) { }

	[Extension]
	public static bool IsAssetLoaded(IEasyAssets easyAssets, string key) { }

	public static Task LoadBundles(Token bundles) { }

	public static Task LoadBundles(Token[] bundles) { }

	[Extension]
	public static Token Retain(IEasyAssets easyAssets, string key, Func dependencyPredicate, IProgress progress) { }

	[Extension]
	public static Token Retain(IEasyAssets easyAssets, IEnumerable keys, IProgress progress = null, CancellationToken ct = null) { }

	[Extension]
	public static TokenContainer RetainSeparate(IEasyAssets easyAssets, IEnumerable keys, IProgress progress = null, CancellationToken ct = null) { }

	[Extension]
	public static Task RetainSeparateTask(IEasyAssets easyAssets, IEnumerable keys, IProgress progress = null, CancellationToken ct = null) { }

	[Extension]
	public static bool TryGetAsset(IEasyAssets easyAssets, out T asset, string key, string assetName = null) { }

	[AsyncStateMachine(typeof(<WaitForAllBundles>d__10))]
	public static void WaitForAllBundles(Token[] bundles, Action onFinished, CancellationToken cancellationToken = null, IProgress progress = null) { }

	[AsyncStateMachine(typeof(<WaitForAllBundles>d__11))]
	public static void WaitForAllBundles(Token bundles, Action onFinished, CancellationToken cancellationToken = null, IProgress progress = null) { }

	[AsyncStateMachine(typeof(<WaitForAllBundlesJob>d__12))]
	private static Task WaitForAllBundlesJob(Token[] bundles, Action onFinished, CancellationToken cancellationToken = null, IProgress progress = null) { }

	[AsyncStateMachine(typeof(<WaitForAllBundlesJob>d__13))]
	public static Task WaitForAllBundlesJob(Token bundles, Action onFinished, CancellationToken cancellationToken = null, IProgress progress = null) { }

}

