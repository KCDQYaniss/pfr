namespace EFT.InventoryLogic;

public sealed class Inventory
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__28_0; //Field offset: 0x8
		public static Func <>9__30_0; //Field offset: 0x10
		public static Func <>9__30_1; //Field offset: 0x18
		public static Func <>9__40_0; //Field offset: 0x20
		public static Func <>9__43_0; //Field offset: 0x28
		public static Func <>9__43_1; //Field offset: 0x30
		public static Func <>9__44_0; //Field offset: 0x38
		public static Func <>9__44_1; //Field offset: 0x40

		private static <>c() { }

		public <>c() { }

		internal bool <AllSlotsContainItem>b__44_0(Slot x) { }

		internal MongoID <AllSlotsContainItem>b__44_1(Slot x) { }

		internal Type <AllSlotsOfCategory>b__43_0(string cat) { }

		internal bool <AllSlotsOfCategory>b__43_1(Slot slot) { }

		internal bool <get_AllRealPlayerItems>b__28_0(Item item) { }

		internal bool <get_EquippedInSlotsTemplateIds>b__30_0(Slot x) { }

		internal string <get_EquippedInSlotsTemplateIds>b__30_1(Slot x) { }

		internal bool <GetWeaponAssembly>b__40_0(Weapon x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass26_0
	{
		public string templateId; //Field offset: 0x10

		public <>c__DisplayClass26_0() { }

		internal bool <GetAllItemByTemplate>b__0(Item x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass40_0
	{
		public ConditionWeaponAssembly condition; //Field offset: 0x10
		public bool displayLog; //Field offset: 0x18

		public <>c__DisplayClass40_0() { }

		internal bool <GetWeaponAssembly>b__1(Weapon x) { }

		internal bool <GetWeaponAssembly>b__2(Weapon weapon) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass43_0
	{
		public Type type; //Field offset: 0x10

		public <>c__DisplayClass43_0() { }

		internal bool <AllSlotsOfCategory>b__2(Slot slot) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass44_0
	{
		public MongoID[] slots; //Field offset: 0x10

		public <>c__DisplayClass44_0() { }

		internal bool <AllSlotsContainItem>b__2(string itemId) { }

	}

	[CompilerGenerated]
	private static class <>O
	{
		public static Comparison <0>__OrderLockedLast; //Field offset: 0x0

	}

	public static readonly EquipmentSlot[] BindAvailableSlotsExtended; //Field offset: 0x0
	public static readonly EquipmentSlot[] ArmorSlots; //Field offset: 0x8
	public static readonly EquipmentSlot[] FastAccessSlots; //Field offset: 0x10
	[CompilerGenerated]
	private readonly bool <CheckHash>k__BackingField; //Field offset: 0x10
	public InventoryEquipment Equipment; //Field offset: 0x18
	public Stash Stash; //Field offset: 0x20
	public readonly Stash QuestRaidItems; //Field offset: 0x28
	public Stash QuestStashItems; //Field offset: 0x30
	public Dictionary HideoutAreaStashes; //Field offset: 0x38
	public CompoundItem HideoutCustomizationStash; //Field offset: 0x40
	public readonly SortingTable SortingTable; //Field offset: 0x48
	public readonly FastAccess FastAccess; //Field offset: 0x50
	public readonly Deferred TotalWeight; //Field offset: 0x58
	public readonly Deferred TotalWeightEliteSkill; //Field offset: 0x60
	public readonly List DeserializationErrors; //Field offset: 0x68
	public Dictionary DiscardLimits; //Field offset: 0x70
	public readonly FavoriteItemsStorage FavoriteItemsStorage; //Field offset: 0x78
	private readonly List _preallocatedSlotsList; //Field offset: 0x80
	public Action OnAreaStashUpdate; //Field offset: 0x88
	private readonly BindableEvent _onWeightUpdated; //Field offset: 0x90

	public IEnumerable AllRealPlayerItems
	{
		 get { } //Length: 386
	}

	[JsonIgnore]
	public bool CheckHash
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public List EquippedInSlotsTemplateIds
	{
		 get { } //Length: 1391
	}

	public IBindableEvent OnWeightUpdated
	{
		 get { } //Length: 8
	}

	private static Inventory() { }

	public Inventory(InventoryEquipment equipment, Stash stash, Stash questRaidItems, Stash questStashItems, SortingTable sortingTable, CompoundItem hideoutCustomizationStash, Dictionary hideoutAreaStashes, Dictionary fastAccess, Dictionary discardLimits, List favoriteItems, List deserializationErrors, bool checkHash) { }

	[CompilerGenerated]
	private float <.ctor>b__24_0() { }

	[CompilerGenerated]
	private float <.ctor>b__24_1() { }

	[CompilerGenerated]
	private Item <GetItemsInSlots>b__34_0(EquipmentSlot x) { }

	private static bool AllSlotsContainItem(CompoundItem weapon, string[] itemIds) { }

	private static bool AllSlotsOfCategory(CompoundItem weapon, string[] types) { }

	public int CreateInventoryHashSum(EquipmentSlot[] excludedSLots = null) { }

	public static Inventory Deserialize(NetworkReader reader) { }

	public IEnumerable get_AllRealPlayerItems() { }

	[CompilerGenerated]
	public bool get_CheckHash() { }

	public List get_EquippedInSlotsTemplateIds() { }

	public IBindableEvent get_OnWeightUpdated() { }

	public IEnumerable GetAllItemByTemplate(string templateId) { }

	public IEnumerable GetItemsInSlots(IEnumerable slots) { }

	public IEnumerable GetPlayerItems(EPlayerItems itemsMask = 63) { }

	public void GetPlayerItemsNonAlloc(List items, EPlayerItems itemsMask = 63) { }

	public IEnumerable GetPutOnArmors() { }

	public void GetPutOnArmorsNonAlloc(List armorComponents) { }

	public EquipmentPenaltyComponent GetPutOnBackpack() { }

	public static List GetWeaponAssembly(IEnumerable collection, ConditionWeaponAssembly condition, bool displayLog = false) { }

	public static bool HasMissingVitalParts(CompoundItem item) { }

	public static bool IsWeaponFitsCondition(Weapon weapon, ConditionWeaponAssembly condition, bool displayLog = false) { }

	private static int OrderArmorComponent(ArmorComponent armorComponent) { }

	private static int OrderLockedLast(ArmorComponent first, ArmorComponent second) { }

	private static bool Test(float current, WeaponAssemblyParameter parameter, Weapon weapon, string name, bool displayLog) { }

	public void UpdateTotalWeight(EventArgs args = null) { }

}

