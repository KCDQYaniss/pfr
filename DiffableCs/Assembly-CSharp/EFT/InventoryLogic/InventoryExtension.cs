namespace EFT.InventoryLogic;

[Extension]
public static class InventoryExtension
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__18_0; //Field offset: 0x8
		public static Func <>9__18_1; //Field offset: 0x10
		public static Func <>9__25_0; //Field offset: 0x18
		public static Func <>9__26_0; //Field offset: 0x20
		public static Func <>9__27_1; //Field offset: 0x28
		public static Comparison <>9__29_0; //Field offset: 0x30

		private static <>c() { }

		public <>c() { }

		internal bool <FindGridToPickUp>b__27_1(GridItemAddress x) { }

		internal double <GetItemPriceWithItemsInside>b__25_0(Item notMergedItem) { }

		internal int <GetItemRarityWithItemsInside>b__26_0(Item notMergedItem) { }

		internal ECurrencyType <GetMoneySums>b__18_0(ECurrencyType x) { }

		internal int <GetMoneySums>b__18_1(ECurrencyType x) { }

		internal int <GetThrowablePriorityGrenadesList>b__29_0(ThrowWeap x, ThrowWeap y) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass20_0
	{
		public Item item; //Field offset: 0x10

		public <>c__DisplayClass20_0() { }

		internal bool <IsItemEquipped>b__0(Slot slot) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass27_0
	{
		public Item item; //Field offset: 0x10
		public InventoryController inventoryController; //Field offset: 0x18

		public <>c__DisplayClass27_0() { }

		internal GridItemAddress <FindGridToPickUp>b__0(Grid grid) { }

	}

	[CompilerGenerated]
	private sealed class <GetTopLevelItems>d__28 : IEnumerable, IEnumerable, IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private Item <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x20
		private IEnumerable collections; //Field offset: 0x28
		public IEnumerable <>3__collections; //Field offset: 0x30
		private IEnumerator <>7__wrap1; //Field offset: 0x38
		private CompoundItem <collection>5__3; //Field offset: 0x40
		private Slot[] <>7__wrap3; //Field offset: 0x48
		private int <>7__wrap4; //Field offset: 0x50
		private Grid[] <>7__wrap5; //Field offset: 0x58
		private Enumerator <>7__wrap6; //Field offset: 0x60

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
		public <GetTopLevelItems>d__28(int <>1__state) { }

		private void <>m__Finally1() { }

		private void <>m__Finally2() { }

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

	internal sealed class NoSpecialSlotsError : InventoryError
	{

		public NoSpecialSlotsError() { }

		public virtual string GetLocalizedDescription() { }

		public virtual string ToString() { }

	}

	internal sealed class NoSuitableSlotsToEquipItemError : InventoryError
	{
		public readonly Item Item; //Field offset: 0x10

		public NoSuitableSlotsToEquipItemError(Item item) { }

		public virtual string GetLocalizedDescription() { }

		public virtual string ToString() { }

	}

	internal sealed class NotSuitablePriceError : InventoryError
	{
		public readonly Item Item; //Field offset: 0x10

		public NotSuitablePriceError(Item item) { }

		public virtual string GetLocalizedDescription() { }

		public virtual string ToString() { }

	}

	internal sealed class NotSuitableRarityError : InventoryError
	{
		public readonly Item Item; //Field offset: 0x10

		public NotSuitableRarityError(Item item) { }

		public virtual string GetLocalizedDescription() { }

		public virtual string ToString() { }

	}

	private static readonly EquipmentSlot[] _armorSlots; //Field offset: 0x0
	private static readonly EquipmentSlot[] _eyeSlots; //Field offset: 0x8
	private static readonly EquipmentSlot[] _headSlots; //Field offset: 0x10
	private static readonly EquipmentSlot[] _faceSlots; //Field offset: 0x18
	private static readonly EquipmentSlot[] _earSlots; //Field offset: 0x20
	private static readonly EquipmentSlot[] _backpackSlots; //Field offset: 0x28
	private static readonly EquipmentSlot[] _vestSlots; //Field offset: 0x30
	private static readonly EquipmentSlot[] _scabbardSlots; //Field offset: 0x38
	private static readonly EquipmentSlot[] _armBandSlots; //Field offset: 0x40
	private static readonly EquipmentSlot[] _pistolSlots; //Field offset: 0x48
	private static readonly EquipmentSlot[] _weaponSlots; //Field offset: 0x50
	private static readonly EquipmentSlot[] _weaponSlotsWithoutPrimary; //Field offset: 0x58
	private static readonly EquipmentSlot[] _containerSlots; //Field offset: 0x60

	private static InventoryExtension() { }

	[Extension]
	public static bool AffectsDiscardLimits(IItemOwner itemController) { }

	[Extension]
	public static Option FindEquipmentSlotToReplaceWithBetterItem(InventoryController itemController, EBotLootSource lootSource, Item item, bool canEquipPistol, bool withoutPrimaryWeaponSlot, int playerId, out Item itemToThrow) { }

	[CanBeNull]
	[Extension]
	public static GridItemAddress FindGridToPickUp(InventoryController inventoryController, Item item) { }

	private static Option FindLocationToReplaceBetterItem(Item newItem, Slot slot, out Item itemToThrow) { }

	[CanBeNull]
	[Extension]
	public static ItemAddress FindSlotToPickUp(InventoryController inventoryController, Item item) { }

	[CanBeNull]
	[Extension]
	public static ItemAddress FindSlotToPickUp(InventoryEquipment equipment, Item item) { }

	[Extension]
	public static double GetItemPriceWithItemsInside(Item item) { }

	[Extension]
	public static int GetItemRarityWithItemsInside(Item item) { }

	public static Dictionary GetMoneySums(IEnumerable items) { }

	[Extension]
	public static void GetThrowableGrenadesNonAlloc(InventoryController inventoryController, List containersCache, SortedDictionary grenadesDictionary) { }

	[Extension]
	public static List GetThrowablePriorityGrenadesList(InventoryController inventoryController) { }

	[Extension]
	[IteratorStateMachine(typeof(<GetTopLevelItems>d__28))]
	public static IEnumerable GetTopLevelItems(IEnumerable collections) { }

	[Extension]
	public static bool HasDiscardLimits(Item item, ItemAddress to, out int limit) { }

	[Extension]
	public static bool IsItemEquipped(InventoryController inventoryController, Item item) { }

	[Extension]
	public static bool TryFindItem(IEnumerable containers, string itemId, out Item item) { }

}

