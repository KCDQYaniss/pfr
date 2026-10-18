namespace EFT.AssetsManager;

public sealed class AssetsManager : IAssetsManager
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__25_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal string <LoadBundlesAsync>b__25_0(string name) { }

	}

	internal sealed class AssetsManagerLogger : AbstractLogger
	{

		public AssetsManagerLogger() { }

		public void AssetLoadedFromBundle(string assetName, string bundleName) { }

		public void AssetLoadFromBundleFinished(string name, string bundleName) { }

		public void BundleNotFound(ResourceKey resourceKey) { }

		public void CantGetAsset(string assetName) { }

		public void CantGetAssetOfType(string assetName, Type type) { }

		public void CantLoadAssetFromBundle(string bundleName) { }

		internal void CantLoadAssetFromBundle(string assetName, string bundleName) { }

		public void FinishLoadBundlesListOperation(string[] bundleNames) { }

		public void LoadAllAssetOperationFinished(AssetBundle bundle) { }

		public void LoadAllAssetOperationStarted(AssetBundle bundle) { }

		public void StartLoadBundlesListOperation(string[] bundleNames) { }

		public void UnloadingUnusedResources() { }

	}

	private sealed class LoadAllAssetOperation : LoadOperation
	{
		[CompilerGenerated]
		private struct <LoadContentCoroutine>d__0 : IAsyncStateMachine
		{
			public int <>1__state; //Field offset: 0x0
			public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
			public AssetsManager manager; //Field offset: 0x20
			public AssetBundle bundle; //Field offset: 0x28
			public LoadAllAssetOperation <>4__this; //Field offset: 0x30
			private AssetBundleRequest <request>5__2; //Field offset: 0x38
			private TaskAwaiter <>u__1; //Field offset: 0x40

			private override void MoveNext() { }

			[DebuggerHidden]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}


		public LoadAllAssetOperation() { }

		protected virtual void LoadContent(AssetsManager manager, AssetBundle bundle) { }

		private void LoadContent(AssetsManager manager, AssetBundle bundle, Object[] assets) { }

		[AsyncStateMachine(typeof(<LoadContentCoroutine>d__0))]
		protected virtual Task LoadContentCoroutine(AssetsManager manager, AssetBundle bundle) { }

	}

	private sealed class LoadAssetOperation : LoadOperation
	{
		[CompilerGenerated]
		private struct <LoadContentCoroutine>d__0 : IAsyncStateMachine
		{
			public int <>1__state; //Field offset: 0x0
			public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
			public AssetBundle bundle; //Field offset: 0x20
			public LoadAssetOperation <>4__this; //Field offset: 0x28
			public AssetsManager manager; //Field offset: 0x30
			private string <name>5__2; //Field offset: 0x38
			private AssetBundleRequest <request>5__3; //Field offset: 0x40
			private TaskAwaiter <>u__1; //Field offset: 0x48

			private override void MoveNext() { }

			[DebuggerHidden]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}


		public LoadAssetOperation() { }

		protected virtual void LoadContent(AssetsManager manager, AssetBundle bundle) { }

		private void LoadContent(AssetsManager manager, string bundleName, Object asset) { }

		[AsyncStateMachine(typeof(<LoadContentCoroutine>d__0))]
		protected virtual Task LoadContentCoroutine(AssetsManager manager, AssetBundle bundle) { }

	}

	private class LoadListBundleOperation : Operation
	{
		[CompilerGenerated]
		private struct <Coroutine>d__1 : IAsyncStateMachine
		{
			public int <>1__state; //Field offset: 0x0
			public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
			public AssetsManager manager; //Field offset: 0x28
			public string[] bundleNames; //Field offset: 0x30
			public LoadListBundleOperation <>4__this; //Field offset: 0x38
			private List <resultList>5__2; //Field offset: 0x40
			private List <operationList>5__3; //Field offset: 0x48
			private Enumerator <>7__wrap3; //Field offset: 0x50
			private OperationAwaiter <>u__1; //Field offset: 0x68

			private override void MoveNext() { }

			[DebuggerHidden]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}


		public LoadListBundleOperation() { }

		[AsyncStateMachine(typeof(<Coroutine>d__1))]
		private void Coroutine(AssetsManager manager, string[] bundleNames) { }

		internal static LoadListBundleOperation Run(AssetsManager manager, string[] bundleNames, string keyFormat) { }

	}

	private sealed class LoadMainAssetOperation : LoadOperation
	{

		public LoadMainAssetOperation() { }

		protected virtual void LoadContent(AssetsManager manager, AssetBundle bundle) { }

		private void LoadContent(AssetsManager manager, string bundleName, Object asset) { }

		protected virtual Task LoadContentCoroutine(AssetsManager manager, AssetBundle bundle) { }

	}

	private abstract class LoadOperation : Operation
	{
		[CompilerGenerated]
		private struct <LoadBundleCoroutine>d__14 : IAsyncStateMachine
		{
			public int <>1__state; //Field offset: 0x0
			public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
			public IOperation loadBundleOperation; //Field offset: 0x28
			public LoadOperation <>4__this; //Field offset: 0x30
			public AssetsManager manager; //Field offset: 0x38
			public bool loadAssetAsync; //Field offset: 0x40
			private OperationAwaiter <>u__1; //Field offset: 0x48

			private override void MoveNext() { }

			[DebuggerHidden]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}

		[CompilerGenerated]
		private string <BundleName>k__BackingField; //Field offset: 0x40
		[CompilerGenerated]
		private string <AssetName>k__BackingField; //Field offset: 0x48
		[CompilerGenerated]
		private string <Key>k__BackingField; //Field offset: 0x50

		public private string AssetName
		{
			[CompilerGenerated]
			 get { } //Length: 5
			[CompilerGenerated]
			private set { } //Length: 82
		}

		public private string BundleName
		{
			[CompilerGenerated]
			 get { } //Length: 5
			[CompilerGenerated]
			private set { } //Length: 82
		}

		public private string Key
		{
			[CompilerGenerated]
			 get { } //Length: 5
			[CompilerGenerated]
			private set { } //Length: 82
		}

		protected LoadOperation() { }

		[CompilerGenerated]
		public string get_AssetName() { }

		[CompilerGenerated]
		public string get_BundleName() { }

		[CompilerGenerated]
		public string get_Key() { }

		[AsyncStateMachine(typeof(<LoadBundleCoroutine>d__14))]
		private void LoadBundleCoroutine(AssetsManager manager, IOperation loadBundleOperation, bool loadAssetAsync) { }

		protected abstract void LoadContent(AssetsManager manager, AssetBundle bundle) { }

		protected abstract Task LoadContentCoroutine(AssetsManager manager, AssetBundle bundle) { }

		internal static LoadOperation Run(AssetsManager manager, string bundleName, string keyFormat, string assetName, bool loadAssetAsync) { }

		private void Run(AssetsManager manager, bool loadAssetAsync) { }

		[CompilerGenerated]
		private void set_AssetName(string value) { }

		[CompilerGenerated]
		private void set_BundleName(string value) { }

		[CompilerGenerated]
		private void set_Key(string value) { }

		private void TryLoadAsset(AssetsManager manager, IOperation loadBundleOperation, bool loadAssetAsync) { }

	}

	private sealed class LoadSceneOperation : LoadSceneOperation
	{
		[CompilerGenerated]
		private struct <Coroutine>d__1 : IAsyncStateMachine
		{
			public int <>1__state; //Field offset: 0x0
			public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
			public string bundleName; //Field offset: 0x28
			public AssetsManager manager; //Field offset: 0x30
			public string sceneName; //Field offset: 0x38
			public LoadSceneOperation <>4__this; //Field offset: 0x40
			public LoadSceneMode loadSceneMode; //Field offset: 0x48
			public bool allowSceneActivation; //Field offset: 0x4C
			public Action progressCallback; //Field offset: 0x50
			private float <time>5__2; //Field offset: 0x58
			private OperationAwaiter <>u__1; //Field offset: 0x60
			private float <progress>5__3; //Field offset: 0x68
			private YieldAwaiter <>u__2; //Field offset: 0x6C

			private override void MoveNext() { }

			[DebuggerHidden]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}


		public LoadSceneOperation() { }

		[AsyncStateMachine(typeof(<Coroutine>d__1))]
		private void Coroutine(AssetsManager manager, string bundleName, string sceneName, LoadSceneMode loadSceneMode, bool allowSceneActivation, Action progressCallback) { }

		internal static LoadSceneOperation Run(AssetsManager manager, string bundleName, string sceneName, LoadSceneMode loadSceneMode, bool allowSceneActivation, Action progressCallback) { }

	}

	private const string BundleKeyFormat = "{0}:"; //Field offset: 0x0
	private const string AssetKeyFormat = "{0}:Asset:{1}"; //Field offset: 0x0
	private const string MainAssetsKeyFormat = "{0}:MainAsset"; //Field offset: 0x0
	private const string AllAssetsKeyFormat = "{0}:AllAssets"; //Field offset: 0x0
	private readonly Dictionary _assets; //Field offset: 0x10
	private readonly Dictionary _loadAssetOperations; //Field offset: 0x18
	private readonly AssetsManagerLogger _assetsManagerLogger; //Field offset: 0x20
	[CompilerGenerated]
	private BundlesManager <BundlesManager>k__BackingField; //Field offset: 0x28

	public BundlesManager BundlesManager
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public override string[] Variants
	{
		 get { } //Length: 27
		 set { } //Length: 107
	}

	public AssetsManager(BundlesManager manager) { }

	private Object FindAsset(string assetName) { }

	private Object FindAssetByMask(string assetName, out string mask) { }

	[CompilerGenerated]
	public BundlesManager get_BundlesManager() { }

	public override string[] get_Variants() { }

	public override Object GetAsset(string assetName) { }

	public override T GetAsset(string assetName) { }

	public override string GetAssetName(ResourceKey resourceKey) { }

	public override IOperation LoadAssetAsync(ResourceKey resourceKey) { }

	public override IOperation LoadAssetAsync(string bundleName, string assetName) { }

	public override IOperation LoadAssetsAsync(string bundleName) { }

	public override IOperation LoadBundlesAsync(string[] bundleNames) { }

	public override IOperation LoadMainAssetAsync(string bundleName) { }

	public override LoadSceneOperation LoadScene(string bundleName, string sceneName, LoadSceneMode loadSceneMode, bool allowSceneActivation, Action progressCallback) { }

	[CompilerGenerated]
	public void set_BundlesManager(BundlesManager value) { }

	public override void set_Variants(string[] value) { }

	private void UnloadAssets(string bundleName) { }

	public override void UnloadBundle(string bundleName, bool unloadAllLoadedObjects) { }

	public override void UnloadBundleWithDependences(string bundleName, bool unloadAllLoadedObjects) { }

	public override void UnloadUnusedResources() { }

}

