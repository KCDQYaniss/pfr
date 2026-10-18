namespace EFT;

[Extension]
public static class AssetsEnvironment
{
	[CompilerGenerated]
	private struct <CreateEasyAssets>d__4 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public GameObject gameObject; //Field offset: 0x20
		public IBundleLock bundleLock; //Field offset: 0x28
		public string platformName; //Field offset: 0x30
		public Func shouldExclude; //Field offset: 0x38
		public Func bundlesCheck; //Field offset: 0x40
		private TaskAwaiter <>u__1; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	public const string BUNDLE_EXTENSION = ".bundle"; //Field offset: 0x0
	public const string STREAMING_ASSETS_DIR_NAME = "StreamingAssets"; //Field offset: 0x0
	private const string ScenesFolder = "Assets/Scenes/"; //Field offset: 0x0
	private const string ModelsFolder; //Field offset: 0x0

	public static Operation CreateAssetsManager(bool updateBundles = false) { }

	[AsyncStateMachine(typeof(<CreateEasyAssets>d__4))]
	public static Task CreateEasyAssets(GameObject gameObject, Func shouldExclude, IBundleLock bundleLock, string platformName, Func bundlesCheck) { }

	public static string GetDownloadingUrl(string platformName) { }

	[Extension]
	public static string GetPlatformName(RuntimePlatform platform) { }

	public static string GetRelativePath() { }

	public static string GetStreamingAssetsFileUrl(string relativePath) { }

	private static string GetUpdateUrl(string platformName) { }

}

