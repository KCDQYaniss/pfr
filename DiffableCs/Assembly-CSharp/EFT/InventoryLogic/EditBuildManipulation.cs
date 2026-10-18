namespace EFT.InventoryLogic;

public sealed class EditBuildManipulation : DropdownManipulation
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__6_0; //Field offset: 0x8
		public static Func <>9__10_0; //Field offset: 0x10
		public static Func <>9__11_1; //Field offset: 0x18
		public static Func <>9__11_2; //Field offset: 0x20

		private static <>c() { }

		public <>c() { }

		internal Item <CollectAvailableItems>b__11_1(Slot x) { }

		internal bool <CollectAvailableItems>b__11_2(Item x) { }

		internal MongoID <GetItemCollections>b__6_0(Item x) { }

		internal bool <GetMissingItems>b__10_0(Item item) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass10_0
	{
		public List availableItems; //Field offset: 0x10

		public <>c__DisplayClass10_0() { }

		internal bool <GetMissingItems>b__1(Item x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass10_1
	{
		public Item x; //Field offset: 0x10

		public <>c__DisplayClass10_1() { }

		internal bool <GetMissingItems>b__2(string templateId) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass11_0
	{
		public Item item; //Field offset: 0x10

		public <>c__DisplayClass11_0() { }

		internal bool <CollectAvailableItems>b__0(Item x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass6_0
	{
		public EditBuildManipulation <>4__this; //Field offset: 0x10
		public Slot slot; //Field offset: 0x18

		public <>c__DisplayClass6_0() { }

		internal bool <GetItemCollections>b__1(Item searchResult) { }

		internal bool <GetItemCollections>b__2(Item item) { }

	}

	[CanBeNull]
	private readonly Item[] _playerItems; //Field offset: 0x20
	[CanBeNull]
	private readonly Dictionary _itemsAvailability; //Field offset: 0x28
	[CanBeNull]
	private readonly Profile _profile; //Field offset: 0x30
	private readonly bool _ragfairAvailable; //Field offset: 0x38

	public EditBuildManipulation(InventoryController controller, CompoundItem[] manipulationCollections, Item[] playerItems, Profile profile, bool ragfairAvailable) { }

	private void CollectAvailableItems(IEnumerable items, IEnumerable requiredItems, ref List availableItems, Func prerequisites) { }

	public EditBuildManipulation CreateOtherManipulation(Item[] playerItems, Profile profile, bool ragfairAvailable) { }

	public virtual EEditBuildItemAvailability GetItemAvailability(Item item) { }

	private EEditBuildItemAvailability GetItemAvailability(Item item, bool isInventoryItem) { }

	public virtual IEnumerable GetItemCollections(Slot slot) { }

	public IEnumerable GetMissingItems(IEnumerable itemsToCheck, IEnumerable alreadyInstalledItems) { }

	protected virtual bool Select(Item item, Slot slot, bool simulate, out Error error) { }

}

