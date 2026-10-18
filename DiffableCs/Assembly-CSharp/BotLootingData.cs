//Type is in global namespace

public class BotLootingData : BotData
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__5_0; //Field offset: 0x8
		public static Func <>9__5_1; //Field offset: 0x10
		public static Predicate <>9__5_2; //Field offset: 0x18
		public static Comparison <>9__11_0; //Field offset: 0x20
		public static Comparison <>9__11_1; //Field offset: 0x28

		private static <>c() { }

		public <>c() { }

		internal bool <LootItemsAsync>b__5_0(Item item) { }

		internal bool <LootItemsAsync>b__5_1(Item item) { }

		internal bool <LootItemsAsync>b__5_2(WeightedItem item) { }

		internal int <SortItemsByWeight>b__11_0(WeightedItem a, WeightedItem b) { }

		internal int <SortItemsByWeight>b__11_1(WeightedItem a, WeightedItem b) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass7_0
	{
		public TaskCompletionSource completion; //Field offset: 0x10

		public <>c__DisplayClass7_0() { }

		internal void <TryReplaceWithNewItem>b__0(IResult arg) { }

	}

	[CompilerGenerated]
	private struct <LootingRemainingItemsAsync>d__8 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public BotLootingData <>4__this; //Field offset: 0x20
		public List itemsToLoot; //Field offset: 0x28
		public Item rootItem; //Field offset: 0x30
		public CancellationToken token; //Field offset: 0x38
		private bool <rootItemWasMoved>5__2; //Field offset: 0x40
		private InventoryController <botInventoryController>5__3; //Field offset: 0x48
		private Item <itemToLoot>5__4; //Field offset: 0x50
		private bool <isRootItem>5__5; //Field offset: 0x58
		private TaskAwaiter <>u__1; //Field offset: 0x60
		private TaskAwaiter <>u__2; //Field offset: 0x68

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <LootItemsAsync>d__5 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public BotLootingData <>4__this; //Field offset: 0x20
		public Item rootItem; //Field offset: 0x28
		public EBotLootSource lootSource; //Field offset: 0x30
		public CancellationToken token; //Field offset: 0x38
		private InventoryEquipment <botEquipment>5__2; //Field offset: 0x40
		[TupleElementNames(new IL2CPP_TYPE_STRING[] {"ContinueLooting", "RootItemWasMoved"})]
		private ValueTuple <equipResult>5__3; //Field offset: 0x48
		[TupleElementNames(new IL2CPP_TYPE_STRING[] {"continueLooting", "rootItemWasMoved"})]
		private TaskAwaiter <>u__1; //Field offset: 0x50
		private TaskAwaiter <>u__2; //Field offset: 0x58

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <TryEquipItemsAsync>d__6 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		[TupleElementNames(new IL2CPP_TYPE_STRING[] {"continueLooting", "rootItemWasMoved"})]
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public InventoryController botInventoryController; //Field offset: 0x20
		public BotLootingData <>4__this; //Field offset: 0x28
		public Item sourceRootItem; //Field offset: 0x30
		public EBotLootSource lootSource; //Field offset: 0x38
		public CancellationToken token; //Field offset: 0x40
		private bool <rootItemWasMoved>5__2; //Field offset: 0x48
		private Slot <holsterSlot>5__3; //Field offset: 0x50
		private bool <lootItemIsRoot>5__4; //Field offset: 0x58
		[TupleElementNames(new IL2CPP_TYPE_STRING[] {"CanEquip", "IsBackpack"})]
		private ValueTuple <evaluationData>5__5; //Field offset: 0x59
		private TaskAwaiter <>u__1; //Field offset: 0x60

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <TryReplaceWithNewItem>d__7 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public InventoryController botInventoryController; //Field offset: 0x20
		public Item lootItem; //Field offset: 0x28
		public Option itemAddressData; //Field offset: 0x30
		public Item itemToThrow; //Field offset: 0x40
		public BotLootingData <>4__this; //Field offset: 0x48
		public CancellationToken token; //Field offset: 0x50
		private OperationResult <moveOperation>5__2; //Field offset: 0x58
		private Task <networkTransactionTask>5__3; //Field offset: 0x68
		private TaskAwaiter <>u__1; //Field offset: 0x70

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private sealed class WeightedItem
	{
		public readonly float Weight; //Field offset: 0x10
		public readonly Item Item; //Field offset: 0x18

		public WeightedItem(float weight, Item item) { }

		public virtual string ToString() { }

	}

	private readonly List _botContainersCache; //Field offset: 0x18
	private readonly List _sortedItemsToLoot; //Field offset: 0x20
	private int _moveItemIdx; //Field offset: 0x28

	public BotLootingData(BotOwner owner) { }

	private ValueTuple EvaluateItemForEquip(Item itemFromSlot, Item lootItem) { }

	[AsyncStateMachine(typeof(<LootingRemainingItemsAsync>d__8))]
	private Task LootingRemainingItemsAsync(Item rootItem, List itemsToLoot, CancellationToken token) { }

	[AsyncStateMachine(typeof(<LootItemsAsync>d__5))]
	public Task LootItemsAsync(Item rootItem, EBotLootSource lootSource, CancellationToken token) { }

	private void ResetLootState() { }

	private static void SortItemsByWeight(IEnumerable source, List sortedList, bool ascending) { }

	[AsyncStateMachine(typeof(<TryEquipItemsAsync>d__6))]
	private Task TryEquipItemsAsync(InventoryController botInventoryController, Item sourceRootItem, EBotLootSource lootSource, CancellationToken token) { }

	[AsyncStateMachine(typeof(<TryReplaceWithNewItem>d__7))]
	private Task TryReplaceWithNewItem(InventoryController botInventoryController, Item itemToThrow, Item lootItem, Option itemAddressData, CancellationToken token) { }

	private void UpdateBotContainersCache(InventoryEquipment botEquipment) { }

}

