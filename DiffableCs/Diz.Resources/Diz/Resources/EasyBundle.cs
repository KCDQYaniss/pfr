namespace Diz.Resources;

internal sealed class EasyBundle : IEasyBundle, ILoadable
{
	[CompilerGenerated]
	private struct <LoadingCoroutine>d__34 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public EasyBundle <>4__this; //Field offset: 0x20
		private bool <lockAcquired>5__2; //Field offset: 0x28
		private YieldAwaiter <>u__1; //Field offset: 0x29
		private AssetBundleCreateRequest <loadingOperation>5__3; //Field offset: 0x30
		private TaskAwaiter <>u__2; //Field offset: 0x38
		private object <>u__3; //Field offset: 0x40
		private int <i>5__4; //Field offset: 0x48

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private readonly string _keyWithoutExtension; //Field offset: 0x10
	private readonly IBundleLock _bundleLock; //Field offset: 0x18
	private readonly string _path; //Field offset: 0x20
	[CompilerGenerated]
	private IEnumerable <DependencyKeys>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private string <Key>k__BackingField; //Field offset: 0x30
	private AssetBundle _bundle; //Field offset: 0x38
	private AssetBundleRequest _loadingAssetOperation; //Field offset: 0x40
	[CompilerGenerated]
	private Object[] <Assets>k__BackingField; //Field offset: 0x48
	[CompilerGenerated]
	private Object <SameNameAsset>k__BackingField; //Field offset: 0x50
	[CompilerGenerated]
	private float <Progress>k__BackingField; //Field offset: 0x58
	[CompilerGenerated]
	private BindableState <LoadState>k__BackingField; //Field offset: 0x60
	private Task _loadingJob; //Field offset: 0x68
	private bool _shouldBeLoaded; //Field offset: 0x70
	private Func _bundleCheck; //Field offset: 0x78

	public private override Object[] Assets
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private override IEnumerable DependencyKeys
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private override string Key
	{
		[CompilerGenerated]
		 get { } //Length: 76
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private override BindableState LoadState
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private override float Progress
	{
		[CompilerGenerated]
		 get { } //Length: 6
		[CompilerGenerated]
		private set { } //Length: 6
	}

	public private override Object SameNameAsset
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public EasyBundle(string key, string rootPath, CompatibilityAssetBundleManifest manifest, IBundleLock bundleLock, Func bundleCheck) { }

	[CompilerGenerated]
	public override Object[] get_Assets() { }

	[CompilerGenerated]
	public override IEnumerable get_DependencyKeys() { }

	[CompilerGenerated]
	public override string get_Key() { }

	[CompilerGenerated]
	public override BindableState get_LoadState() { }

	[CompilerGenerated]
	public override float get_Progress() { }

	[CompilerGenerated]
	public override Object get_SameNameAsset() { }

	public override void Load() { }

	[AsyncStateMachine(typeof(<LoadingCoroutine>d__34))]
	private Task LoadingCoroutine() { }

	[CompilerGenerated]
	private void set_Assets(Object[] value) { }

	[CompilerGenerated]
	private void set_DependencyKeys(IEnumerable value) { }

	[CompilerGenerated]
	private void set_Key(string value) { }

	[CompilerGenerated]
	private void set_LoadState(BindableState value) { }

	[CompilerGenerated]
	private void set_Progress(float value) { }

	[CompilerGenerated]
	private void set_SameNameAsset(Object value) { }

	public override void Unload() { }

}

