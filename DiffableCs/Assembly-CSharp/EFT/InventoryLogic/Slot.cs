namespace EFT.InventoryLogic;

public class Slot : IContainer, IItemContainer
{
	[CompilerGenerated]
	private sealed class <get_Items>d__33 : IEnumerable, IEnumerable, IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private Item <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x20
		public Slot <>4__this; //Field offset: 0x28

		private override Item System.Collections.Generic.IEnumerator<EFT.InventoryLogic.Item>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		[DebuggerHidden]
		public <get_Items>d__33(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.Generic.IEnumerable<EFT.InventoryLogic.Item>.GetEnumerator() { }

		[DebuggerHidden]
		private override Item System.Collections.Generic.IEnumerator<EFT.InventoryLogic.Item>.get_Current() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	private sealed class <GetColliderTypes>d__57 : IEnumerable, IEnumerable, IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private EBodyPartColliderType <>2__current; //Field offset: 0x14
		private int <>l__initialThreadId; //Field offset: 0x18
		public Slot <>4__this; //Field offset: 0x20
		private ItemFilter[] <>7__wrap1; //Field offset: 0x28
		private int <>7__wrap2; //Field offset: 0x30
		private EBodyPartColliderType[] <>7__wrap3; //Field offset: 0x38
		private int <>7__wrap4; //Field offset: 0x40

		private override EBodyPartColliderType System.Collections.Generic.IEnumerator<EBodyPartColliderType>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 4
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 72
		}

		[DebuggerHidden]
		public <GetColliderTypes>d__57(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.Generic.IEnumerable<EBodyPartColliderType>.GetEnumerator() { }

		[DebuggerHidden]
		private override EBodyPartColliderType System.Collections.Generic.IEnumerator<EBodyPartColliderType>.get_Current() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	private sealed class <GetConflictingSlot>d__61 : IEnumerable, IEnumerable, IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private Slot <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x20
		public Slot <>4__this; //Field offset: 0x28
		private Item item; //Field offset: 0x30
		public Item <>3__item; //Field offset: 0x38
		private string[] <>7__wrap1; //Field offset: 0x40
		private int <>7__wrap2; //Field offset: 0x48

		private override Slot System.Collections.Generic.IEnumerator<EFT.InventoryLogic.Slot>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		[DebuggerHidden]
		public <GetConflictingSlot>d__61(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.Generic.IEnumerable<EFT.InventoryLogic.Slot>.GetEnumerator() { }

		[DebuggerHidden]
		private override Slot System.Collections.Generic.IEnumerator<EFT.InventoryLogic.Slot>.get_Current() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	internal class CantAttachWhileFoldedError : InventoryError
	{
		public readonly Item Item; //Field offset: 0x10
		public readonly Item RootItem; //Field offset: 0x18

		public CantAttachWhileFoldedError(Item item, Item rootItem) { }

		public virtual string GetLocalizedDescription() { }

		public virtual string ToString() { }

	}

	internal class ConflictingItemError : InventoryError
	{
		public readonly Item Item; //Field offset: 0x10
		public readonly Item RootItem; //Field offset: 0x18
		public readonly Item ConflictingItem; //Field offset: 0x20

		public ConflictingItemError(Item item, Item rootItem, Item conflictingItem) { }

		public virtual string GetLocalizedDescription() { }

		public virtual string ToString() { }

	}

	internal class ConflictingSlotBlockedError : InventoryError
	{
		public readonly Item Item; //Field offset: 0x10
		public readonly Slot Slot; //Field offset: 0x18
		public readonly Slot ConflictingSlot; //Field offset: 0x20

		public ConflictingSlotBlockedError(Item item, Slot slot, Slot conflictingSlot) { }

		public virtual string GetLocalizedDescription() { }

		public virtual string ToString() { }

	}

	internal class EquippedLockedSlot : InventoryError
	{

		public EquippedLockedSlot() { }

		public virtual string GetLocalizedDescription() { }

		public virtual string ToString() { }

	}

	internal class InstallNotExaminedError : InventoryError
	{
		public readonly Item Item; //Field offset: 0x10
		public readonly Slot Slot; //Field offset: 0x18

		public InstallNotExaminedError(Item item, Slot slot) { }

		public virtual string GetLocalizedDescription() { }

		public virtual string ToString() { }

	}

	internal class ItemFiltersWontAllowError : InventoryError
	{
		[CompilerGenerated]
		private sealed class <>c
		{
			public static readonly <>c <>9; //Field offset: 0x0
			public static Func <>9__3_0; //Field offset: 0x8
			public static Func <>9__3_1; //Field offset: 0x10
			public static Func <>9__3_2; //Field offset: 0x18
			public static Func <>9__3_3; //Field offset: 0x20
			public static Func <>9__3_4; //Field offset: 0x28

			private static <>c() { }

			public <>c() { }

			internal IEnumerable <ToString>b__3_0(ItemFilter x) { }

			internal string <ToString>b__3_1(MongoID x) { }

			internal bool <ToString>b__3_2(ItemFilter x) { }

			internal IEnumerable <ToString>b__3_3(ItemFilter x) { }

			internal string <ToString>b__3_4(MongoID x) { }

		}

		public readonly Item Item; //Field offset: 0x10
		public readonly Slot Slot; //Field offset: 0x18

		public ItemFiltersWontAllowError(Item item, Slot slot) { }

		public virtual string GetLocalizedDescription() { }

		public virtual string ToString() { }

	}

	private sealed class ItemNotInSlotError : InventoryError
	{
		private readonly string _itemId; //Field offset: 0x10
		private readonly Item _item; //Field offset: 0x18
		private readonly Slot _slot; //Field offset: 0x20

		public ItemNotInSlotError(Item item, Slot slot) { }

		public virtual string ToString() { }

	}

	internal class MissingVitalPartsError : InventoryError
	{
		[CompilerGenerated]
		private sealed class <>c
		{
			public static readonly <>c <>9; //Field offset: 0x0
			public static Func <>9__4_0; //Field offset: 0x8
			public static Func <>9__5_0; //Field offset: 0x10

			private static <>c() { }

			public <>c() { }

			internal string <GetLocalizedDescription>b__5_0(Slot x) { }

			internal string <ToString>b__4_0(Slot x) { }

		}

		public readonly Item Item; //Field offset: 0x10
		public readonly IContainer Container; //Field offset: 0x18
		public IEnumerable MissingParts; //Field offset: 0x20

		public MissingVitalPartsError(Item item, IContainer container, IEnumerable missingParts) { }

		public virtual string GetLocalizedDescription() { }

		public virtual string ToString() { }

	}

	private sealed class ProtectedSlotItemAddress : SlotItemAddress
	{

		public ProtectedSlotItemAddress(Slot slot) { }

	}

	internal class SlotBlockedError : InventoryError
	{
		[CompilerGenerated]
		private sealed class <>c
		{
			public static readonly <>c <>9; //Field offset: 0x0
			public static Func <>9__3_0; //Field offset: 0x8
			public static Func <>9__4_0; //Field offset: 0x10

			private static <>c() { }

			public <>c() { }

			internal string <GetLocalizedDescription>b__4_0(Slot x) { }

			internal string <ToString>b__3_0(Slot x) { }

		}

		public readonly Item Item; //Field offset: 0x10
		public readonly Slot Slot; //Field offset: 0x18

		public SlotBlockedError(Item item, Slot slot) { }

		public virtual string GetLocalizedDescription() { }

		public virtual string ToString() { }

	}

	internal class SlotLockedError : InventoryError
	{
		public readonly Slot Slot; //Field offset: 0x10

		public SlotLockedError(Slot slot) { }

		public virtual string GetLocalizedDescription() { }

		public virtual string ToString() { }

	}

	internal class SlotNotEmptyError : InventoryError
	{
		public readonly Item Item; //Field offset: 0x10
		public readonly Slot Slot; //Field offset: 0x18

		public SlotNotEmptyError(Item item, Slot slot) { }

		public virtual string GetLocalizedDescription() { }

		public virtual string ToString() { }

	}

	internal class TakeNotExaminedError : InventoryError
	{
		public readonly Item Item; //Field offset: 0x10
		public readonly Slot Slot; //Field offset: 0x18

		public TakeNotExaminedError(Item item, Slot slot) { }

		public virtual string GetLocalizedDescription() { }

		public virtual string ToString() { }

	}

	internal class TooLargeStackError : InventoryError
	{
		public readonly Item Item; //Field offset: 0x10
		public readonly Slot Slot; //Field offset: 0x18
		public readonly int MaxAllowedCount; //Field offset: 0x20

		public TooLargeStackError(Item item, Slot slot, int maxAllowedCount) { }

		public virtual string ToString() { }

	}

	private const string SPECIAL_SLOT_PREFIX = "SpecialSlot"; //Field offset: 0x0
	public const string BUILD_SLOT = "BuildSlot"; //Field offset: 0x0
	[CompilerGenerated]
	private Action OnAddOrRemoveItem; //Field offset: 0x10
	public readonly bool Required; //Field offset: 0x18
	private readonly BindableState _reactiveContainedItem; //Field offset: 0x20
	public Dictionary ConflictingSlots; //Field offset: 0x28
	public readonly List BlockerSlots; //Field offset: 0x30
	private string _cachedSlotName; //Field offset: 0x38
	public bool Deleted; //Field offset: 0x40
	private Nullable _isSpecial; //Field offset: 0x41
	[CompilerGenerated]
	private Item <ContainedItem>k__BackingField; //Field offset: 0x48
	[CompilerGenerated]
	private readonly Item <ParentItem>k__BackingField; //Field offset: 0x50
	[CompilerGenerated]
	private readonly string <ID>k__BackingField; //Field offset: 0x58
	[CompilerGenerated]
	private readonly EParentMergeType <MergeContainerWithChildren>k__BackingField; //Field offset: 0x60
	[CompilerGenerated]
	private readonly EBodyPartColliderType[] <ArmorColliders>k__BackingField; //Field offset: 0x68
	[CompilerGenerated]
	private readonly EArmorPlateCollider <ArmorPlateColliderMask>k__BackingField; //Field offset: 0x70
	[CompilerGenerated]
	private readonly ItemFilter[] <Filters>k__BackingField; //Field offset: 0x78
	[CompilerGenerated]
	private readonly bool <Locked>k__BackingField; //Field offset: 0x80
	[CompilerGenerated]
	private bool <BluntDamageReduceFromSoftArmor>k__BackingField; //Field offset: 0x81

	public event Action OnAddOrRemoveItem
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public EBodyPartColliderType[] ArmorColliders
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public EArmorPlateCollider ArmorPlateColliderMask
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public private bool BluntDamageReduceFromSoftArmor
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 7
	}

	[CanBeNull]
	public private override Item ContainedItem
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public override ItemFilter[] Filters
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public string FullId
	{
		 get { } //Length: 266
	}

	public override string ID
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public bool IsSpecial
	{
		 get { } //Length: 182
	}

	public override IEnumerable Items
	{
		[IteratorStateMachine(typeof(<get_Items>d__33))]
		 get { } //Length: 175
	}

	public bool Locked
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	public override EParentMergeType MergeContainerWithChildren
	{
		[CompilerGenerated]
		 get { } //Length: 4
	}

	public string Name
	{
		 get { } //Length: 875
	}

	[NotNull]
	public override Item ParentItem
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public BindableState ReactiveContainedItem
	{
		 get { } //Length: 87
	}

	public Slot(string id, ItemFilter[] filters, bool required, EParentMergeType mergeSlotWithChildren) { }

	public Slot(Slot slot, CompoundItem parentItem) { }

	private void Add(Item item) { }

	public OperationResult Add(Item item, bool simulate, bool ignoreMalfunction = false) { }

	[CompilerGenerated]
	public void add_OnAddOrRemoveItem(Action value) { }

	private OperationResult AddInternal(Item item, bool ignoreRestrictions, bool ignoreMalfunction, bool simulate) { }

	public OperationResult AddWithoutRestrictions(Item item) { }

	public void ApplyContainedItem() { }

	protected override bool CanAcceptRaid(out InventoryError error) { }

	public bool CanReplace(Item item) { }

	public void ChangeContainedItemDirectly(Item item) { }

	public override bool CheckCompatibility(Item item) { }

	private Option CheckConditions(Item item, bool ignoreRestrictions = false, bool ignoreMalfunction = false) { }

	private Option CheckConflictingItems(Item item) { }

	public ItemAddress CreateItemAddress() { }

	private override ItemAddress EFT.InventoryLogic.IContainer.CreateItemAddress(ItemAddressDescriptor descriptor) { }

	private bool Examined(Item item) { }

	[CanBeNull]
	public ItemAddress FindLocationForItem(Item item, out Error error) { }

	[CompilerGenerated]
	public EBodyPartColliderType[] get_ArmorColliders() { }

	[CompilerGenerated]
	public EArmorPlateCollider get_ArmorPlateColliderMask() { }

	[CompilerGenerated]
	public bool get_BluntDamageReduceFromSoftArmor() { }

	[CompilerGenerated]
	public override Item get_ContainedItem() { }

	[CompilerGenerated]
	public override ItemFilter[] get_Filters() { }

	public string get_FullId() { }

	[CompilerGenerated]
	public override string get_ID() { }

	public bool get_IsSpecial() { }

	[IteratorStateMachine(typeof(<get_Items>d__33))]
	public override IEnumerable get_Items() { }

	[CompilerGenerated]
	public bool get_Locked() { }

	[CompilerGenerated]
	public override EParentMergeType get_MergeContainerWithChildren() { }

	public string get_Name() { }

	[CompilerGenerated]
	public override Item get_ParentItem() { }

	public BindableState get_ReactiveContainedItem() { }

	private EArmorPlateCollider GetArmorPlateMask() { }

	[IteratorStateMachine(typeof(<GetColliderTypes>d__57))]
	private IEnumerable GetColliderTypes() { }

	[IteratorStateMachine(typeof(<GetConflictingSlot>d__61))]
	private IEnumerable GetConflictingSlot(Item item) { }

	public override int GetHashSum() { }

	public string LocalizedName() { }

	private static bool MatchesConflictingId(Item item, MongoID[] conflictingIds) { }

	[CompilerGenerated]
	public void remove_OnAddOrRemoveItem(Action value) { }

	public OperationResult RemoveItem(bool simulate = false) { }

	protected override OperationResult RemoveItemInternal(bool simulate, bool ignoreRestrictions) { }

	public OperationResult RemoveItemWithoutRestrictions() { }

	[CompilerGenerated]
	private void set_BluntDamageReduceFromSoftArmor(bool value) { }

	[CompilerGenerated]
	private void set_ContainedItem(Item value) { }

	public virtual string ToString() { }

	public bool TryFindItem(Func predicate, out Item item) { }

	public override bool TryFindItem(string itemId, out Item item) { }

	public override bool TryFindLocationForItem(Item item, out ItemAddress location) { }

}

