namespace EFT.AssetsManager;

public sealed class LoadBundleManifestWithUpdateOperation : Operation
{
	[CompilerGenerated]
	private struct <Coroutine>d__1 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public string downloadingUrl; //Field offset: 0x28
		public string bundleName; //Field offset: 0x30
		public string assetName; //Field offset: 0x38
		public string updateUrl; //Field offset: 0x40
		public LoadBundleManifestWithUpdateOperation <>4__this; //Field offset: 0x48
		private OperationAwaiter <>u__1; //Field offset: 0x50
		private BundlesManifestContainer <manifest>5__2; //Field offset: 0x58
		private BundlesManifestContainer <updateManifest>5__3; //Field offset: 0x60
		private OperationAwaiter <>u__2; //Field offset: 0x68

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}


	public LoadBundleManifestWithUpdateOperation() { }

	[AsyncStateMachine(typeof(<Coroutine>d__1))]
	private void Coroutine(string downloadingUrl, string bundleName, string assetName, string updateUrl) { }

	public static Operation Run(AssetsManagerSettings settings) { }

}

