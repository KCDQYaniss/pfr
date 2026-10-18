namespace EFT.AssetsManager;

public sealed class UpdateVersionOperation : Operation
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__1_0; //Field offset: 0x8
		public static Func <>9__1_2; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal string <Coroutine>b__1_0(string x) { }

		internal string <Coroutine>b__1_2(string x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass1_0
	{
		public BundlesManifestContainer primaryManifest; //Field offset: 0x10
		public BundlesManifestContainer updateManifest; //Field offset: 0x18

		public <>c__DisplayClass1_0() { }

		internal Hash128 <Coroutine>b__1(string x) { }

		internal Hash128 <Coroutine>b__3(string x) { }

	}

	[CompilerGenerated]
	private struct <Coroutine>d__1 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public BundlesManifestContainer primaryManifest; //Field offset: 0x28
		public BundlesManifestContainer updateManifest; //Field offset: 0x30
		public string primaryPath; //Field offset: 0x38
		public UpdateVersionOperation <>4__this; //Field offset: 0x40
		private <>c__DisplayClass1_0 <>8__1; //Field offset: 0x48
		private Dictionary <diskBundles>5__2; //Field offset: 0x50
		private bool <update>5__3; //Field offset: 0x58
		private Enumerator <>7__wrap3; //Field offset: 0x60
		private KeyValuePair <serverBundle>5__5; //Field offset: 0x90
		private OperationAwaiter <>u__1; //Field offset: 0xA8

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}


	public UpdateVersionOperation() { }

	[AsyncStateMachine(typeof(<Coroutine>d__1))]
	private void Coroutine(BundlesManifestContainer primaryManifest, string primaryPath, BundlesManifestContainer updateManifest, string updatePath) { }

	internal static Operation Run(BundlesManifestContainer primaryManifest, string primaryPath, BundlesManifestContainer updateManifest, string updatePath) { }

	private void Save(string name, string primaryPath, byte[] bytes) { }

}

