namespace EFT.AssetsManager;

public class BundlesManager
{
	private class AssetBundleReference
	{
		public readonly AssetBundle AssetBundle; //Field offset: 0x10
		public int Counter; //Field offset: 0x18

		public AssetBundleReference(AssetBundle assetBundle) { }

	}

	internal class BundleBytesLoadOperation : Operation
	{
		[CompilerGenerated]
		private struct <Coroutine>d__1 : IAsyncStateMachine
		{
			public int <>1__state; //Field offset: 0x0
			public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
			public string url; //Field offset: 0x28
			public string bundleName; //Field offset: 0x30
			public BundleBytesLoadOperation <>4__this; //Field offset: 0x38
			private UnityWebRequest <uwr>5__2; //Field offset: 0x40
			private TaskAwaiter <>u__1; //Field offset: 0x48

			private override void MoveNext() { }

			[DebuggerHidden]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}


		public BundleBytesLoadOperation() { }

		[AsyncStateMachine(typeof(<Coroutine>d__1))]
		private void Coroutine(string url, string bundleName) { }

		internal static BundleBytesLoadOperation Run(string url, string bundleName) { }

	}

	private class BundleLoadOperation : Operation
	{
		[CompilerGenerated]
		private sealed class <>c__DisplayClass1_0
		{
			public BundlesManager manager; //Field offset: 0x10

			public <>c__DisplayClass1_0() { }

			internal IOperation <Coroutine>b__0(string dependency) { }

		}

		[CompilerGenerated]
		private struct <Coroutine>d__1 : IAsyncStateMachine
		{
			public int <>1__state; //Field offset: 0x0
			public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
			public BundlesManager manager; //Field offset: 0x28
			public string bundleName; //Field offset: 0x30
			public BundleLoadOperation <>4__this; //Field offset: 0x38
			public bool logErrors; //Field offset: 0x40
			private <>c__DisplayClass1_0 <>8__1; //Field offset: 0x48
			private IOperation[] <nestedOperations>5__2; //Field offset: 0x50
			private UnityWebRequest <uwr>5__3; //Field offset: 0x58
			private TaskAwaiter <>u__1; //Field offset: 0x60
			private IOperation[] <>7__wrap3; //Field offset: 0x68
			private int <>7__wrap4; //Field offset: 0x70
			private OperationAwaiter <>u__2; //Field offset: 0x78

			private override void MoveNext() { }

			[DebuggerHidden]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}


		public BundleLoadOperation() { }

		[AsyncStateMachine(typeof(<Coroutine>d__1))]
		private void Coroutine(BundlesManager manager, string bundleName, bool logErrors) { }

		internal static BundleLoadOperation Run(BundlesManager manager, string bundleName, bool logErrors) { }

	}

	private readonly Dictionary _bundles; //Field offset: 0x10
	private readonly Dictionary _loadBundleOperations; //Field offset: 0x18
	private readonly List _excludedDependenciesMask; //Field offset: 0x20
	[CompilerGenerated]
	private readonly string <DownloadingUrl>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private readonly string <LoadingUrl>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	private readonly CompatibilityAssetBundleManifest <Manifest>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	private string[] <Variants>k__BackingField; //Field offset: 0x40

	public string DownloadingUrl
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public string LoadingUrl
	{
		[CompilerGenerated]
		 get { } //Length: 76
	}

	public CompatibilityAssetBundleManifest Manifest
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public string[] Variants
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 82
	}

	internal BundlesManager(CompatibilityAssetBundleManifest manifest, string downloadingUrl, List excludedDependenciesMask) { }

	[CompilerGenerated]
	private bool <FindDependences>b__21_0(string dependency) { }

	public AssetBundle FindBundle(string bundleName) { }

	public IEnumerable FindDependences(string bundleName) { }

	[CompilerGenerated]
	public string get_DownloadingUrl() { }

	[CompilerGenerated]
	public string get_LoadingUrl() { }

	[CompilerGenerated]
	public CompatibilityAssetBundleManifest get_Manifest() { }

	[CompilerGenerated]
	public string[] get_Variants() { }

	public IOperation LoadBundleAsync(string bundleName, bool logErrors = true) { }

	private string RemapVariantName(string bundleName) { }

	[CompilerGenerated]
	public void set_Variants(string[] value) { }

	public void UnloadBundle(string bundleName, bool unloadAllLoadedObjects) { }

}

