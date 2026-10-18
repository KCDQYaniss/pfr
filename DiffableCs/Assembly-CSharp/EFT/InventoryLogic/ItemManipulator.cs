namespace EFT.InventoryLogic;

public static class ItemManipulator
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__3_2; //Field offset: 0x8
		public static Func <>9__4_0; //Field offset: 0x10
		public static Func <>9__4_4; //Field offset: 0x18
		public static Func <>9__18_0; //Field offset: 0x20
		public static Func <>9__33_0; //Field offset: 0x28
		public static Func <>9__59_0; //Field offset: 0x30
		public static Func <>9__62_1; //Field offset: 0x38
		public static Func <>9__62_2; //Field offset: 0x40
		public static Func <>9__62_3; //Field offset: 0x48
		public static Func <>9__64_0; //Field offset: 0x50
		public static Func <>9__64_1; //Field offset: 0x58
		public static Func <>9__68_1; //Field offset: 0x60
		public static Func <>9__68_2; //Field offset: 0x68
		public static Func <>9__71_1; //Field offset: 0x70
		public static Func <>9__72_0; //Field offset: 0x78
		public static Func <>9__72_1; //Field offset: 0x80
		public static Func <>9__72_2; //Field offset: 0x88
		public static Func <>9__72_4; //Field offset: 0x90
		public static Func <>9__72_5; //Field offset: 0x98
		public static Func <>9__72_6; //Field offset: 0xA0
		public static Func <>9__72_7; //Field offset: 0xA8
		public static Func <>9__72_8; //Field offset: 0xB0
		public static Func <>9__72_10; //Field offset: 0xB8
		public static Func <>9__77_1; //Field offset: 0xC0
		public static Func <>9__77_0; //Field offset: 0xC8
		public static Func <>9__78_1; //Field offset: 0xD0
		public static Func <>9__79_1; //Field offset: 0xD8
		public static Func <>9__79_2; //Field offset: 0xE0
		public static Func <>9__79_4; //Field offset: 0xE8
		public static Func <>9__79_5; //Field offset: 0xF0

		private static <>c() { }

		public <>c() { }

		internal bool <Add>b__33_0(Mod x) { }

		internal bool <CanFold>b__59_0(Mod x) { }

		internal bool <FindUserItems>b__78_1(Item availableItem) { }

		internal bool <GetItemsForAddress>b__68_1(Item item) { }

		internal MongoID <GetItemsForAddress>b__68_2(Item item) { }

		internal bool <PurchaseTraderService>b__62_1(Slot slot) { }

		internal IEnumerable <PurchaseTraderService>b__62_2(Slot slot) { }

		internal bool <PurchaseTraderService>b__62_3(Item x) { }

		internal bool <QuickFindAppropriatePlace>b__3_2(IContainer container) { }

		internal IEnumerable <Sort>b__64_0(Grid grid) { }

		internal bool <Sort>b__64_1(Item gridItem) { }

		internal bool <SortUserItems>b__72_0(Item item) { }

		internal float <SortUserItems>b__72_1(Item item) { }

		internal bool <SortUserItems>b__72_10(Item x) { }

		internal bool <SortUserItems>b__72_2(Item x) { }

		internal int <SortUserItems>b__72_4(Item x) { }

		internal int <SortUserItems>b__72_5(Item x) { }

		internal bool <SortUserItems>b__72_6(Item x) { }

		internal bool <SortUserItems>b__72_7(Item x) { }

		internal int <SortUserItems>b__72_8(Item itemStack) { }

		internal Item <SwapEquipment>b__79_1(Item item) { }

		internal ItemAddress <SwapEquipment>b__79_2(Item item) { }

		internal Item <SwapEquipment>b__79_4(Item item) { }

		internal ItemAddress <SwapEquipment>b__79_5(Item item) { }

		internal int <TransferContent>b__71_1(Item stackItem) { }

		internal bool <TransferItemsFromPreset>b__77_0(Item item) { }

		internal bool <TransferItemsFromPreset>b__77_1(IItemComponent component) { }

		internal IEnumerable <TryFindMergeableItem>b__4_0(IContainer x) { }

		internal bool <TryFindMergeableItem>b__4_4(StackableItem x) { }

		internal IEnumerable <UnbindItems>b__18_0(IContainer x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass16_0
	{
		public Item item; //Field offset: 0x10

		public <>c__DisplayClass16_0() { }

		internal bool <TryUnbindOneItem>b__0(KeyValuePair x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass3_0
	{
		public Item item; //Field offset: 0x10
		public ItemController controller; //Field offset: 0x18
		public Error noActionsError; //Field offset: 0x20
		public Error noSpaceError; //Field offset: 0x28
		public EMoveItemOrder order; //Field offset: 0x30
		public bool simulate; //Field offset: 0x34

		public <>c__DisplayClass3_0() { }

		internal OperationResult <QuickFindAppropriatePlace>g__CheckContainers|1(IEnumerable containersToPut) { }

		internal IEnumerable <QuickFindAppropriatePlace>g__GetTargetContainers|0(CompoundItem compoundItem) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass4_0
	{
		public Item itemToMerge; //Field offset: 0x10
		public int overrideCount; //Field offset: 0x18

		public <>c__DisplayClass4_0() { }

		internal bool <TryFindMergeableItem>b__1(StackableItem x) { }

		internal bool <TryFindMergeableItem>b__2(StackableItem x) { }

		internal bool <TryFindMergeableItem>b__3(StackableItem x) { }

		internal bool <TryFindMergeableItem>b__5(StackableItem item) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass62_0
	{
		public string subServiceId; //Field offset: 0x10

		public <>c__DisplayClass62_0() { }

		internal bool <PurchaseTraderService>b__0(SubService subService) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass67_0
	{
		public CompoundItem oldStash; //Field offset: 0x10

		public <>c__DisplayClass67_0() { }

		internal bool <MoveExistingItemsToNewStash>b__0(ContainerCollection containerCollection) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass67_1
	{
		public GridItemAddress <oldGridAddress>5__2; //Field offset: 0x10
		public SlotItemAddress <oldSlotAddress>5__3; //Field offset: 0x18

		public <>c__DisplayClass67_1() { }

		internal bool <MoveExistingItemsToNewStash>b__1(Grid newGrid) { }

		internal bool <MoveExistingItemsToNewStash>b__2(Slot newSlot) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass68_0
	{
		public ItemAddress itemAddress; //Field offset: 0x10

		public <>c__DisplayClass68_0() { }

		internal bool <GetItemsForAddress>b__0(Item item) { }

	}

	[CompilerGenerated]
	private struct <>c__DisplayClass71_0
	{
		public CompoundItem transferSource; //Field offset: 0x0
		public InventoryController inventoryController; //Field offset: 0x8
		public bool createFakeItems; //Field offset: 0x10
		public List preAllocatedNotFoundItems; //Field offset: 0x18
		public List operationResults; //Field offset: 0x20
		public IEnumerable transferContainers; //Field offset: 0x28
		public IEnumerable transferIgnoreSlotsList; //Field offset: 0x30

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass71_1
	{
		public IAmmoContainer ammoContainer; //Field offset: 0x10
		public Func <>9__2; //Field offset: 0x18

		public <>c__DisplayClass71_1() { }

		internal bool <TransferContent>b__2(IContainer foundGrid) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass71_2
	{
		public Slot presetSlot; //Field offset: 0x10

		public <>c__DisplayClass71_2() { }

		internal bool <TransferContent>b__3(Slot foundSlot) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass71_3
	{
		public Grid presetGrid; //Field offset: 0x10
		public Func <>9__4; //Field offset: 0x18

		public <>c__DisplayClass71_3() { }

		internal bool <TransferContent>b__4(Grid foundGrid) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass72_0
	{
		public Item presetItem; //Field offset: 0x10

		public <>c__DisplayClass72_0() { }

		internal bool <SortUserItems>b__3(Item x) { }

		internal bool <SortUserItems>b__9(Item itemStack) { }

	}

	[CompilerGenerated]
	private struct <>c__DisplayClass75_0
	{
		public Dictionary parts; //Field offset: 0x0

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass78_0
	{
		public Item presetItem; //Field offset: 0x10

		public <>c__DisplayClass78_0() { }

		internal bool <FindUserItems>b__0(Item availableItem) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass79_0
	{
		public IEnumerable ignoreSlotsList; //Field offset: 0x10

		public <>c__DisplayClass79_0() { }

		internal bool <SwapEquipment>b__0(Item item) { }

		internal bool <SwapEquipment>b__3(Item item) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass79_1
	{
		public string containerId; //Field offset: 0x10

		public <>c__DisplayClass79_1() { }

		internal bool <SwapEquipment>b__6(IContainer container) { }

	}

	[CompilerGenerated]
	private struct <QuickEmptyContainer>d__2 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ContainerCollection container; //Field offset: 0x20
		public InventoryController controller; //Field offset: 0x28
		public IEnumerable targetItems; //Field offset: 0x30
		public EMoveItemOrder order; //Field offset: 0x38
		private IEnumerator <>7__wrap1; //Field offset: 0x40
		private IContainer <subContainer>5__3; //Field offset: 0x48
		private TaskAwaiter <>u__1; //Field offset: 0x50

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	internal sealed class AddCountError : InventoryError
	{
		public readonly Item Item; //Field offset: 0x10
		public readonly ItemAddress Location; //Field offset: 0x18
		public readonly int MaxAllowedCount; //Field offset: 0x20

		public AddCountError(Item item, ItemAddress location, int maxAllowedCount) { }

		public virtual string ToString() { }

	}

	internal sealed class CannotLootUnlootableError : InventoryError
	{
		public readonly UnlootableComponent Unlootable; //Field offset: 0x10

		public CannotLootUnlootableError(UnlootableComponent unlootable) { }

		public virtual string GetLocalizedDescription() { }

		public virtual string ToString() { }

	}

	internal sealed class CannotPutUnlootableError : InventoryError
	{
		public readonly UnlootableComponent Unlootable; //Field offset: 0x10

		public CannotPutUnlootableError(UnlootableComponent unlootable) { }

		public virtual string GetLocalizedDescription() { }

		public virtual string ToString() { }

	}

	internal sealed class CantRemoveFromEquipmentSlotDuringRaid : InventoryError
	{
		private readonly Item _item; //Field offset: 0x10
		private readonly string _containerId; //Field offset: 0x18

		public CantRemoveFromEquipmentSlotDuringRaid(Item item, string containerId) { }

		public virtual string GetLocalizedDescription() { }

		public virtual string ToString() { }

	}

	internal sealed class ContainerLockedError : InventoryError
	{
		private readonly ItemComponent _itemComponent; //Field offset: 0x10

		public ContainerLockedError(ItemComponent itemComponent) { }

		public virtual string ToString() { }

	}

	internal sealed class ContainerWithLockedItemError : InventoryError
	{
		private readonly CompoundItem _container; //Field offset: 0x10
		private readonly Item _lockedItem; //Field offset: 0x18

		public ContainerWithLockedItemError(CompoundItem container, Item lockedItem) { }

		public virtual string GetLocalizedDescription() { }

		public virtual string ToString() { }

	}

	internal sealed class CountLimitError : InventoryError
	{
		public readonly Item Item; //Field offset: 0x10
		public readonly int Limit; //Field offset: 0x18
		public readonly int AvailableCount; //Field offset: 0x1C

		public CountLimitError(Item item, int limit, int availableCount) { }

		public virtual string GetLocalizedDescription() { }

		public virtual string ToString() { }

	}

	internal sealed class DeepMoveError : InventoryError
	{
		private readonly ItemAddress Address; //Field offset: 0x10
		private readonly int Max; //Field offset: 0x18

		public DeepMoveError(ItemAddress address, int max) { }

		public virtual string GetLocalizedDescription() { }

		public virtual string ToString() { }

	}

	[Flags]
	internal enum EMoveItemOrder
	{
		TryMerge = 1,
		TryTransfer = 3,
		PrioritizeParent = 4,
		PrioritizeTargetsOrder = 8,
		IgnoreItemParent = 16,
		TryEquip = 32,
		MoveToAnotherSide = 11,
		UnloadAmmo = 15,
		Apply = 19,
		PickUp = 51,
		UnloadWeapon = 12,
		ForcePush = 25,
	}

	internal enum EPinLockPermission
	{
		ProhibitedAll = 0,
		ChildrenAllowed = 1,
		AllowedAll = 2,
	}

	internal enum EResizeAction
	{
		Addition = 0,
		Removal = 1,
		Fold = 2,
		Unfold = 3,
	}

	internal sealed class InstallToFoldedError : InventoryError
	{
		public readonly Item Item; //Field offset: 0x10

		public InstallToFoldedError(Item item) { }

		public virtual string GetLocalizedDescription() { }

		public virtual string ToString() { }

	}

	internal sealed class ItemAlreadyThereError : InventoryError
	{
		public readonly Item Item; //Field offset: 0x10

		public ItemAlreadyThereError(Item item) { }

		public virtual string GetLocalizedDescription() { }

		public virtual string ToString() { }

	}

	internal sealed class ItemCycleError : InventoryError
	{
		public readonly Item Item; //Field offset: 0x10
		public readonly ItemAddress To; //Field offset: 0x18

		public ItemCycleError(Item item, ItemAddress to) { }

		public virtual string GetLocalizedDescription() { }

		public virtual string ToString() { }

	}

	private sealed class ItemLockSameStateError : InventoryError
	{
		private const string ITEM_ALREADY_UNLOCKED_ERROR = "InventoryErrors/PinLock/ItemAlreadyUnlocked{0}"; //Field offset: 0x0
		private const string ITEM_ALREADY_PINNED_ERROR = "InventoryErrors/PinLock/ItemAlreadyPinned{0}"; //Field offset: 0x0
		private const string ITEM_ALREADY_LOCKED_ERROR = "InventoryErrors/PinLock/ItemAlreadyLocked{0}"; //Field offset: 0x0
		private readonly Item _item; //Field offset: 0x10
		private readonly EItemPinLockState _state; //Field offset: 0x18

		public ItemLockSameStateError(Item item, EItemPinLockState state) { }

		public virtual string GetLocalizedDescription() { }

	}

	private sealed class ItemLockWrongContainerError : InventoryError
	{
		private const string ITEM_IN_WRONG_CONTAINER_LOCK_ERROR = "InventoryErrors/PinLock/ItemLockInWrongContainer"; //Field offset: 0x0
		private const string ITEM_IN_WRONG_CONTAINER_PIN_ERROR = "InventoryErrors/PinLock/ItemPinInWrongContainer"; //Field offset: 0x0
		private readonly EItemPinLockState _state; //Field offset: 0x10

		public ItemLockWrongContainerError(EItemPinLockState state) { }

		public virtual string GetLocalizedDescription() { }

	}

	internal sealed class ItemManuallyLockedError : InventoryError
	{
		private readonly Item _item; //Field offset: 0x10

		public ItemManuallyLockedError(Item item) { }

		public virtual string GetLocalizedDescription() { }

		public virtual string ToString() { }

	}

	internal sealed class MalfunctionError : InventoryError
	{
		public readonly Item Item; //Field offset: 0x10
		public readonly Weapon Weapon; //Field offset: 0x18

		public MalfunctionError(Item item, Weapon weapon) { }

		public virtual string GetLocalizedDescription() { }

		public virtual string ToString() { }

	}

	internal sealed class MovingToScavError : InventoryError
	{
		public readonly ItemAddress Address; //Field offset: 0x10

		public MovingToScavError(ItemAddress address) { }

		public virtual string GetLocalizedDescription() { }

		public virtual string ToString() { }

	}

	internal sealed class MovingToTraderError : InventoryError
	{
		public readonly ItemAddress Address; //Field offset: 0x10

		public MovingToTraderError(ItemAddress address) { }

		public virtual string GetLocalizedDescription() { }

		public virtual string ToString() { }

	}

	internal sealed class NonQuestItemInQuestStashError : InventoryError
	{
		private readonly Item _item; //Field offset: 0x10

		public NonQuestItemInQuestStashError(Item item) { }

		public virtual string GetLocalizedDescription() { }

		public virtual string ToString() { }

	}

	internal sealed class NotRaidMovableToSafeContainer : InventoryError
	{

		public NotRaidMovableToSafeContainer() { }

		public virtual string GetLocalizedDescription() { }

		public virtual string ToString() { }

	}

	internal sealed class QuestItemInNonQuestStashError : InventoryError
	{
		private readonly Item _item; //Field offset: 0x10

		public QuestItemInNonQuestStashError(Item item) { }

		public virtual string GetLocalizedDescription() { }

		public virtual string ToString() { }

	}

	internal sealed class ResizeError : InventoryError
	{
		public readonly Item Item; //Field offset: 0x10
		public readonly Item ConflictingItem; //Field offset: 0x18
		public readonly ItemAddress To; //Field offset: 0x20
		public readonly IntVec2 NewSize; //Field offset: 0x28

		public ResizeError(Item item, Item conflictingItem, ItemAddress to, IntVec2 newSize) { }

		public virtual string GetLocalizedDescription() { }

		public virtual string ToString() { }

	}

	internal sealed class SecureContainerPerkRestrictionError : InventoryError
	{
		private readonly Item _item; //Field offset: 0x10
		private readonly ItemAddress _to; //Field offset: 0x18
		private readonly string _localizationKey; //Field offset: 0x20

		public SecureContainerPerkRestrictionError(Item item, ItemAddress to, string localizationKey) { }

		public virtual string GetLocalizedDescription() { }

		public virtual string ToString() { }

	}

	internal sealed class TakeFromRagfairError : InventoryError
	{
		public readonly ItemAddress Address; //Field offset: 0x10

		public TakeFromRagfairError(ItemAddress address) { }

		public virtual string GetLocalizedDescription() { }

		public virtual string ToString() { }

	}

	internal sealed class TryLootUnmovableError : InventoryError
	{
		public readonly Item Item; //Field offset: 0x10

		public TryLootUnmovableError(Item item) { }

		public virtual string GetLocalizedDescription() { }

		public virtual string ToString() { }

	}


	[CompilerGenerated]
	internal static void <BuildLooseItemCounts>g__AddIfLoose|75_0(IEnumerable items, ref <>c__DisplayClass75_0 unnamed_param_1) { }

	[CompilerGenerated]
	internal static float <SortUserItems>g__GetRepairPercent|72_11(Item item) { }

	[CompilerGenerated]
	internal static Option <TransferContent>g__MoveUserItem|71_0(Item itemToFind, ItemAddress toAddress, ref <>c__DisplayClass71_0 unnamed_param_2) { }

	public static OperationResult AcceptQuest(Quest quest, QuestController questController, bool simulate) { }

	private static OperationResult Add(Item item, ItemAddress to, ItemController itemController, bool simulate, bool ignoreRestrictions) { }

	public static OperationResult Add(Item item, ItemAddress to, ItemController itemController, bool simulate = false) { }

	public static OperationResult AddWithoutRestrictions(Item item, ItemAddress to, ItemController itemController) { }

	public static OperationResult ApplySingleItemToAddress(Item item, IDatabaseIdGenerator idGenerator, ItemController itemController, ItemAddress to) { }

	private static bool AttachmentCountsEqual(IReadOnlyDictionary left, IReadOnlyDictionary right) { }

	private static Dictionary BuildLooseItemCounts(CompoundItem transferSource, SortingTable sortingTable) { }

	private static Dictionary BuildSlotAttachmentCounts(CompoundItem rootItem) { }

	public static bool CanFold(Item item, out FoldableComponent foldable) { }

	public static bool CanModifyItem(Item item, ItemAddress from, ItemController controller, out Error error) { }

	private static bool CanTransferTo(ItemAddress to, ItemController controller, out Error error) { }

	private static OperationResult ChangeLimitsWithoutDestroy(Item item, int count, ItemAddress to, ItemController controller) { }

	public static ChangeVersionResult ChangeVersion(Item item, bool simulate) { }

	private static bool CheckContains(IContainer parent, IContainer child) { }

	private static Option CheckCycle(Item item, ItemAddress to) { }

	private static Option CheckItemAddressForLocked(ItemAddress to) { }

	private static bool CheckItemCountLimit(Item item, ItemAddress to, ItemController itemController, out CountLimitError limitError) { }

	public static Option CheckItemForLocked(Item item) { }

	public static bool CheckMissingParts(Item item, ItemAddress to, ItemController itemController, out MissingVitalPartsError error) { }

	public static Option CheckMoveIgnoringTargetItem(Item item, Slot toSlot, ItemController itemController) { }

	private static Option CheckOnMove(Item item) { }

	public static Option DestinationCheck(ItemAddress fromAddress, ItemAddress to, ItemController itemController) { }

	private static OperationResult DestroyOverLimit(Item item, int count, IAntiRMTItemController from, ItemAddress to, ItemController itemController) { }

	public static IEnumerable DestroyOverLimit(Item item, ItemController itemController) { }

	private static OperationResult DestroyOverLimitAndChangeLimits(Item item, int count, ItemAddress to, ItemController itemController) { }

	private static OperationResult Discard(Item item, ItemController itemController, bool ignoreRestrictions, bool simulate) { }

	public static OperationResult Discard(Item item, ItemController itemController, bool simulate = false) { }

	public static OperationResult DiscardWithoutRestrictions(Item item, ItemController itemController) { }

	private static Option EmptyContainer(Item item, IEnumerable to, ItemController inventoryController, IEnumerable ignoreSlotsList = null, EMoveItemOrder moveItemOrder = 25, bool simulate = false) { }

	public static OperationResult EquipItemInSlot(Slot slot, Item item, InventoryController inventoryController, bool simulate) { }

	private static IEnumerable FindUserItems(Item presetItem, CompoundItem stashItem, SortingTable sortingTable) { }

	public static OperationResult FinishConditional(TConditional conditional, ItemController itemController, ConditionalController conditionalController, bool simulate) { }

	public static OperationResult Fold(FoldableComponent foldable, bool folded, bool simulate) { }

	private static int GetBackpackChildDeepRecursive(Backpack backpack) { }

	private static bool GetBackpacksDeep(Item item, ItemAddress toAddress, out int deep) { }

	public static IEnumerable GetItemsForAddress(ItemAddress itemAddress, InventoryController inventoryController) { }

	private static int GetMaxSplitCount(Item item) { }

	public static bool HasLockedContent(Item item, out LocalizedError error) { }

	private static bool IsItemLocked(Item item, out Error error) { }

	public static EPinLockPermission IsPinLockStateAllowed(EItemPinLockState state, ItemAddress address, InventoryController controller) { }

	public static OperationResult Merge(Item item, Item targetItem, ItemController itemController, bool simulate) { }

	public static OperationResult Move(Item item, ItemAddress to, ItemController itemController, bool simulate = false) { }

	private static void MoveExistingItemsToNewStash(ItemController inventoryController, CompoundItem oldStash, CompoundItem newStash) { }

	private static Option MovePathCheck(Item item, ItemAddress to, ItemController itemController) { }

	public static OperationResult PurchaseTraderService(ETraderServiceType serviceType, string subServiceId, QuestController questController, InventoryController inventoryController, bool simulate, bool checkAvailability = true) { }

	[AsyncStateMachine(typeof(<QuickEmptyContainer>d__2))]
	public static Task QuickEmptyContainer(ContainerCollection container, IEnumerable targetItems, EMoveItemOrder order, InventoryController controller) { }

	public static OperationResult QuickFindAppropriatePlace(Item item, ItemController controller, IEnumerable targets, EMoveItemOrder order, bool simulate) { }

	public static OperationResult Recode(RecodableComponent recodable, bool encoded, string visitorId, bool simulate) { }

	private static OperationResult Remove(Item item, ItemController itemController, bool simulate, bool ignoreRestrictions) { }

	public static OperationResult Remove(Item item, ItemController itemController, bool simulate = false) { }

	public static OperationResult RemoveWithoutRestrictions(Item item, ItemController itemController) { }

	private static void ResetSingleTag(TagComponent tag, in List setTagResults, bool simulate) { }

	private static void ResetTags(Item item, in List setTagResults, bool simulate) { }

	private static OperationResult Resize(Item item, IntVec2 oldSize, IntVec2 newSize, bool simulate) { }

	public static OperationResult Resize_Helper(Item item, ItemAddress location, EResizeAction resizeAction, bool backwards, bool simulate) { }

	private static Item SelectBestWeaponSource(IEnumerable foundItems, IReadOnlyDictionary requiredAttachments, IReadOnlyDictionary looseAttachments) { }

	public static OperationResult SetPinLockState(InventoryController controller, Item item, EItemPinLockState state, bool simulate) { }

	public static OperationResult SimulatePlantTripwire(InventoryController controller, ThrowWeap tripwire, PlantingKit plantingKit) { }

	public static OperationResult SimulateRechamberWeapon(InventoryController inventoryController, Weapon weapon) { }

	public static OperationResult Sort(CompoundItem sortedItem, InventoryController controller, bool simulate) { }

	private static IEnumerable SortUserItems(Item presetItem, IEnumerable foundItems) { }

	private static Option Split(T item, int count, IDatabaseIdGenerator idGenerator, ItemController itemController) { }

	public static OperationResult SplitExact(Item item, int count, ItemAddress to, ItemController itemController, IDatabaseIdGenerator idGenerator, bool simulate) { }

	public static OperationResult SplitMax(Item item, int count, ItemAddress to, ItemController itemController, IDatabaseIdGenerator idGenerator, bool simulate) { }

	public static OperationResult SplitToNowhere(Item item, int count, ItemController itemController, bool simulate) { }

	public static OperationResult Swap(Item item, ItemAddress toLocation, Item item1, ItemAddress toLocation1, ItemController itemController, bool simulate = false) { }

	public static Option SwapEquipment(InventoryController inventoryController, InventoryEquipment equipment2, IEnumerable ignoreSlotsList = null) { }

	public static OperationResult Throw(Item item, ItemController itemController, bool simulate = false) { }

	public static Option TransferContent(CompoundItem presetItem, CompoundItem toItem, IEnumerable transferContainers, CompoundItem transferSource, InventoryController inventoryController, List preAllocatedNotFoundItems, IEnumerable transferIgnoreSlotsList, bool createFakeItems, bool simulate) { }

	public static OperationResult TransferExact(Item item, int count, Item targetItem, ItemController itemController, bool simulate) { }

	private static Option TransferItemsFromPreset(Item presetItem, IEnumerable foundItems, ItemAddress toAddress, IEnumerable transferContainers, CompoundItem transferSource, InventoryController inventoryController, List preAllocatedNotFoundItems, IEnumerable transferIgnoreSlotsList, bool createFakeItems) { }

	public static OperationResult TransferMax(Item item, Item targetItem, int count, ItemController itemController, bool simulate) { }

	public static OperationResult TransferMaxStackCount(Item source, Item target, int count, ItemController itemController, bool simulate) { }

	public static OperationResult TransferOrMerge(Item item, Item targetItem, ItemController itemController, bool simulate) { }

	private static bool TryFindMergeableItem(IEnumerable containersToPut, Item itemToMerge, out StackableItem mergeableItem, int overrideCount = 0) { }

	private static IContainer TryGetCanPutIntoDuringTheRaidComponent(ItemAddress to) { }

	internal static bool TryGetSecureContainerPerkRestriction(Item item, ItemAddress to, out string errorKey) { }

	public static void TryUnbindItems(ItemController itemController, Item item, in List unbindResults, bool simulate) { }

	private static void TryUnbindOneItem(InventoryController controller, Item item, in List unbindResults, bool simulate) { }

	private static void UnbindItems(InventoryController controller, Item item, in List unbindResults, bool simulate) { }

	public static void UpdateAreaStashes(Dictionary addedHideoutAreaStashes, InventoryController inventoryController, ItemFactory itemFactory) { }

	private static void ValidateQuestRewardSlotId(TConditional quest) { }

}

