namespace EFT;

public class BundlesLoadApplication : AbstractApplication
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Action <>9__18_0; //Field offset: 0x8
		public static Action <>9__18_1; //Field offset: 0x10
		public static Func <>9__21_0; //Field offset: 0x18
		public static Func <>9__21_1; //Field offset: 0x20
		public static Func <>9__21_3; //Field offset: 0x28
		public static Func <>9__21_4; //Field offset: 0x30

		private static <>c() { }

		public <>c() { }

		internal Item <LoadLootRun>b__21_0(JsonLootItem x) { }

		internal Item <LoadLootRun>b__21_1(KeyValuePair pair) { }

		internal bool <LoadLootRun>b__21_3(Item x) { }

		internal IEnumerable <LoadLootRun>b__21_4(Item x) { }

		internal void <Update>b__18_0(float f) { }

		internal void <Update>b__18_1(float f) { }

	}

	[CompilerGenerated]
	private struct <LoadBundles>d__19 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public Token poolBundles; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <LoadLootRun>d__21 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public BundlesLoadApplication <>4__this; //Field offset: 0x20
		private ClientBackEndEmulator <backend>5__2; //Field offset: 0x28
		private ClientBackendSessionEmulator <session>5__3; //Field offset: 0x30
		private ItemFactory <itemFactory>5__4; //Field offset: 0x38
		private GlobalConfigurationResponse <globalConfiguration>5__5; //Field offset: 0x40
		private TaskAwaiter <>u__1; //Field offset: 0x48
		private TaskAwaiter <>u__2; //Field offset: 0x50
		private TaskAwaiter <>u__3; //Field offset: 0x58

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <Start>d__3 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public BundlesLoadApplication <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28
		private OperationAwaiter <>u__2; //Field offset: 0x30
		private TaskAwaiter <>u__3; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	public string BundleName; //Field offset: 0x30
	public string BundleName1; //Field offset: 0x38
	private IEasyAssets _easyAssets; //Field offset: 0x40
	private Task _loadJob; //Field offset: 0x48
	private GameObject _item; //Field offset: 0x50
	public string LocationLootFile; //Field offset: 0x58
	public bool LoadAllLoot; //Field offset: 0x60
	private string _labelString; //Field offset: 0x68
	[SerializeField]
	private int _maxConcurrentLoadOperations; //Field offset: 0x70
	private BundleLock _bundleLock; //Field offset: 0x78
	private Location _location; //Field offset: 0x80
	public bool LoadLootFromTheStart; //Field offset: 0x88
	public string _itemTemplateId; //Field offset: 0x90

	protected virtual EUpdateQueue PlayerUpdateQueue
	{
		 get { } //Length: 3
	}

	public BundlesLoadApplication() { }

	[CompilerGenerated]
	private bool <LoadLootRun>b__21_2(Item item) { }

	[CompilerGenerated]
	private void <LoadLootRun>b__21_5(InitLevelProgress p) { }

	private void CreateItem() { }

	protected virtual LogConfiguration CreateLogConfiguration() { }

	protected virtual EUpdateQueue get_PlayerUpdateQueue() { }

	[AsyncStateMachine(typeof(<LoadBundles>d__19))]
	private static Task LoadBundles(Token poolBundles) { }

	[AsyncStateMachine(typeof(<LoadLootRun>d__21))]
	private Task LoadLootRun() { }

	private void Log(string log) { }

	protected void OnGUI() { }

	private void OnValidate() { }

	private void ReturnItem() { }

	[AsyncStateMachine(typeof(<Start>d__3))]
	protected override Task Start() { }

	protected virtual void Update() { }

}

