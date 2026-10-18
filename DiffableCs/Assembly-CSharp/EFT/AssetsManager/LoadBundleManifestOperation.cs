namespace EFT.AssetsManager;

public sealed class LoadBundleManifestOperation : Operation
{
	[CompilerGenerated]
	private struct <Coroutine>d__1 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public LoadBundleManifestOperation <>4__this; //Field offset: 0x28
		public string path; //Field offset: 0x30
		public string bundleName; //Field offset: 0x38
		public string assetName; //Field offset: 0x40
		private string <url>5__2; //Field offset: 0x48
		private UnityWebRequest <uwr>5__3; //Field offset: 0x50
		private TaskAwaiter <>u__1; //Field offset: 0x58
		private AssetBundleRequest <request>5__4; //Field offset: 0x60

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}


	public LoadBundleManifestOperation() { }

	[AsyncStateMachine(typeof(<Coroutine>d__1))]
	private void Coroutine(string path, string bundleName, string assetName) { }

	public static Operation Run(string path, string bandleName, string assetName) { }

}

