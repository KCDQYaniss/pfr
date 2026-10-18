namespace EFT.Hideout;

public class HideoutAreaStashController
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Action <>9__27_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal void <SpawnNewItem>b__27_0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass20_0
	{
		public CancellationTokenSource updateCancellationToken; //Field offset: 0x10

		public <>c__DisplayClass20_0() { }

		internal void <UpdateStash>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass20_1
	{
		public StashItemModel model; //Field offset: 0x10

		public <>c__DisplayClass20_1() { }

		internal bool <UpdateStash>b__1(StashItemModelSpawnPoint p) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass31_0
	{
		public CompoundItem stash; //Field offset: 0x10

		public <>c__DisplayClass31_0() { }

		internal bool <IsContainerOfItemIsLocalStash>b__0(Item parent) { }

	}

	[CompilerGenerated]
	private struct <EnableAnimator>d__22 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public Item item; //Field offset: 0x20
		public HideoutAreaStashController <>4__this; //Field offset: 0x28
		public CancellationTokenSource updateCancellationToken; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ProcessSpawnOperation>d__21 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public HideoutAreaStashController <>4__this; //Field offset: 0x20
		public Dictionary spawnPoints; //Field offset: 0x28
		public CancellationTokenSource updateCancellationToken; //Field offset: 0x30
		private IEnumerator <>7__wrap1; //Field offset: 0x38
		private StashItemModelSpawnPoint <spawnPoint>5__3; //Field offset: 0x40
		private IEnumerator <>7__wrap3; //Field offset: 0x48
		private Item <item>5__5; //Field offset: 0x50
		private TaskAwaiter <>u__1; //Field offset: 0x58
		private TaskAwaiter <>u__2; //Field offset: 0x60

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SpawnNewItem>d__27 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public HideoutAreaStashController <>4__this; //Field offset: 0x20
		public Item item; //Field offset: 0x28
		public CancellationTokenSource updateCancellationToken; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38
		private TaskAwaiter <>u__2; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <UpdateStash>d__20 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public HideoutAreaStashController <>4__this; //Field offset: 0x20
		public bool clearCache; //Field offset: 0x28
		private Dictionary <spawnPoints>5__2; //Field offset: 0x30
		private CancellationTokenRegistration <>7__wrap2; //Field offset: 0x38
		private TaskAwaiter <>u__1; //Field offset: 0x50

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private InventoryController _inventoryController; //Field offset: 0x10
	private HideoutArea _area; //Field offset: 0x18
	protected CompoundItem _areaStash; //Field offset: 0x20
	private CancellationTokenSource _cancellationToken; //Field offset: 0x28
	private CancellationTokenSource _updateCancellationToken; //Field offset: 0x30
	protected readonly Dictionary _itemModelDict; //Field offset: 0x38
	protected readonly Dictionary _itemModelCache; //Field offset: 0x40
	private readonly Dictionary _transferredItems; //Field offset: 0x48
	private float _gridStep; //Field offset: 0x50
	private readonly InventoryEquipmentStashLoader _inventoryEquipmentStashLoader; //Field offset: 0x58
	private EAreaType _areaType; //Field offset: 0x60
	private Dictionary _stashObjectsSpawnPoints; //Field offset: 0x68
	private Dictionary _mannequinPoses; //Field offset: 0x70

	public Dictionary LoadedInventoryEquipment
	{
		 get { } //Length: 27
	}

	public HideoutAreaStashController() { }

	[CompilerGenerated]
	private void <Init>b__15_0(bool silent) { }

	private void DeActivateUnusedComponents(GameObject itemGameObject) { }

	private void DeSpawnItem(StashItemModel model) { }

	public void Dispose() { }

	[AsyncStateMachine(typeof(<EnableAnimator>d__22))]
	private Task EnableAnimator(CancellationTokenSource updateCancellationToken, Item item) { }

	public Dictionary get_LoadedInventoryEquipment() { }

	protected LocationInGrid GetItemLocation(Item item) { }

	private bool GetSpawnPoint(IReadOnlyDictionary spawnPoints, IContainer container, out StashItemModelSpawnPoint spawnPoint) { }

	public void Init(HideoutArea hideoutArea, InventoryController inventoryController, CompoundItem areaStash, float gridStep, Dictionary spawnPoints = null, Dictionary mannequinPoses = null) { }

	public static bool IsContainerOfItemIsLocalStash(IContainer container, CompoundItem stash) { }

	private void OnItemAdded(AddItemEventArgs addInfo) { }

	private void OnItemRemoved(RemoveItemEventArgs removeInfo) { }

	protected void PositionGameObject(StashItemModel model, LocationInGrid locationInGrid, StashItemModelSpawnPoint spawnPoint) { }

	[AsyncStateMachine(typeof(<ProcessSpawnOperation>d__21))]
	protected override Task ProcessSpawnOperation(Dictionary spawnPoints, CancellationTokenSource updateCancellationToken) { }

	public void SetMannequinPoses(Dictionary mannequinPoses) { }

	public void SetStash(CompoundItem stash) { }

	[AsyncStateMachine(typeof(<SpawnNewItem>d__27))]
	protected Task SpawnNewItem(Item item, CancellationTokenSource updateCancellationToken) { }

	private void StashUpdateHandler(EAreaType areaType, CompoundItem stash) { }

	private bool TryGetRecentlyTransferredModel(Item item, out StashItemModel itemModel) { }

	private void UnSubscribe() { }

	public void UpdateMannequinCustomization(Item equipment, string suite) { }

	public void UpdateMannequinCustomization(Item equipment, CustomizationSuite suite) { }

	public void UpdateMannequinPose(Item equipment, string poseAnimationClipName) { }

	[AsyncStateMachine(typeof(<UpdateStash>d__20))]
	public Task UpdateStash(bool clearCache = false) { }

}

