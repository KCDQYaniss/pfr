namespace Diz.Resources;

public sealed class EasyAssets : MonoBehaviour, IEasyAssets
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__9_0; //Field offset: 0x8
		public static Func <>9__9_1; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal string <Init>b__9_0(KeyValuePair x) { }

		internal BundleDetails <Init>b__9_1(KeyValuePair x) { }

	}

	[CompilerGenerated]
	private struct <Create>d__8 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public GameObject gameObject; //Field offset: 0x20
		public IBundleLock bundleLock; //Field offset: 0x28
		public string defaultKey; //Field offset: 0x30
		public string rootPath; //Field offset: 0x38
		public string platformName; //Field offset: 0x40
		public Func shouldExclude; //Field offset: 0x48
		public Func bundleCheck; //Field offset: 0x50
		private EasyAssets <easyAssets>5__2; //Field offset: 0x58
		private TaskAwaiter <>u__1; //Field offset: 0x60

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <Init>d__9 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public string rootPath; //Field offset: 0x20
		public string platformName; //Field offset: 0x28
		public EasyAssets <>4__this; //Field offset: 0x30
		public IBundleLock bundleLock; //Field offset: 0x38
		public Func bundleCheck; //Field offset: 0x40
		public string defaultKey; //Field offset: 0x48
		public Func shouldExclude; //Field offset: 0x50
		private string <path>5__2; //Field offset: 0x58
		private string[] <bundleNames>5__3; //Field offset: 0x60
		private int <i>5__4; //Field offset: 0x68
		private object <>u__1; //Field offset: 0x70

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private struct IntermediateBundleDetails
	{
		public string FileName; //Field offset: 0x0
		public uint Crc; //Field offset: 0x8
		public string[] Dependencies; //Field offset: 0x10

	}

	public List Log; //Field offset: 0x20
	[CompilerGenerated]
	private DependencyGraph <System>k__BackingField; //Field offset: 0x28
	private EasyBundle[] _bundles; //Field offset: 0x30
	public CompatibilityAssetBundleManifest Manifest; //Field offset: 0x38

	public private override DependencyGraph System
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public EasyAssets() { }

	[AsyncStateMachine(typeof(<Create>d__8))]
	public static Task Create(GameObject gameObject, IBundleLock bundleLock, string defaultKey, string rootPath, string platformName, Func shouldExclude, Func bundleCheck) { }

	[CompilerGenerated]
	public override DependencyGraph get_System() { }

	[AsyncStateMachine(typeof(<Init>d__9))]
	private Task Init(IBundleLock bundleLock, string defaultKey, string rootPath, string platformName, Func shouldExclude, Func bundleCheck) { }

	[CompilerGenerated]
	private void set_System(DependencyGraph value) { }

	private void Update() { }

}

