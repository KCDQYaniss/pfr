namespace EFT;

public sealed class ItemFactory
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__20_0; //Field offset: 0x8
		public static Func <>9__20_1; //Field offset: 0x10
		public static Func <>9__29_0; //Field offset: 0x18
		public static Func <>9__29_1; //Field offset: 0x20
		public static Func <>9__34_0; //Field offset: 0x28
		public static Func <>9__35_0; //Field offset: 0x30
		public static Func <>9__35_1; //Field offset: 0x38
		public static Func <>9__36_0; //Field offset: 0x40
		public static Func <>9__36_1; //Field offset: 0x48
		public static Func <>9__40_3; //Field offset: 0x50
		public static Func <>9__40_1; //Field offset: 0x58
		public static Func <>9__40_5; //Field offset: 0x60

		private static <>c() { }

		public <>c() { }

		internal bool <BriefWeaponPresetName>b__29_0(Slot x) { }

		internal MongoID <BriefWeaponPresetName>b__29_1(Slot x) { }

		internal bool <CreateAllItemsEver>b__34_0(KeyValuePair x) { }

		internal bool <CreateAllModsEver>b__36_0(KeyValuePair x) { }

		internal bool <CreateAllModsEver>b__36_1(KeyValuePair x) { }

		internal bool <CreateAndFillItem>b__35_0(ItemFilter filter) { }

		internal bool <CreateAndFillItem>b__35_1(ItemFilter filter) { }

		internal MongoID <GetDiscardLimits>b__20_0(KeyValuePair limits) { }

		internal int <GetDiscardLimits>b__20_1(KeyValuePair limits) { }

		internal IEnumerable <TreeToFlatItems>b__40_1(ContainerCollection collection) { }

		internal IEnumerable <TreeToFlatItems>b__40_3(IContainer container) { }

		internal bool <TreeToFlatItems>b__40_5(Item item) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass29_0
	{
		public List itemNamesSet; //Field offset: 0x10
		public Func <>9__2; //Field offset: 0x18

		public <>c__DisplayClass29_0() { }

		internal bool <BriefWeaponPresetName>b__2(MongoID key) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass40_0
	{
		public ContainerCollection collection; //Field offset: 0x10
		public ItemFactory <>4__this; //Field offset: 0x18

		public <>c__DisplayClass40_0() { }

		internal IEnumerable <TreeToFlatItems>b__4(IContainer container) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass40_1
	{
		public IContainer container; //Field offset: 0x10
		public <>c__DisplayClass40_0 CS$<>8__locals1; //Field offset: 0x18

		public <>c__DisplayClass40_1() { }

		internal FlatItem <TreeToFlatItems>b__6(Item item) { }

	}

	[CompilerGenerated]
	private sealed class <CreateManyItems>d__21 : IEnumerable, IEnumerable, IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private Item <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x20
		private FlatItem[] flatItems; //Field offset: 0x28
		public FlatItem[] <>3__flatItems; //Field offset: 0x30
		public ItemFactory <>4__this; //Field offset: 0x38
		private FlatItem[] <>7__wrap1; //Field offset: 0x40
		private int <>7__wrap2; //Field offset: 0x48

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
		public <CreateManyItems>d__21(int <>1__state) { }

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

	internal struct FlatItemsToTreeResult
	{
		public Dictionary Items; //Field offset: 0x0
		public List DeserializationErrors; //Field offset: 0x8

	}

	[IsReadOnly]
	private struct ItemCachedName
	{
		private const int SUBSTRING_COUNT = 30; //Field offset: 0x0
		public readonly int Version; //Field offset: 0x0
		public readonly string WeaponName; //Field offset: 0x8
		public readonly string FoundName; //Field offset: 0x10

		public string BriefName
		{
			 get { } //Length: 139
		}

		public ItemCachedName(int version, string weaponName, string foundName) { }

		public string get_BriefName() { }

	}

	private sealed class ItemNamedPreset
	{
		public readonly Item Item; //Field offset: 0x10
		public readonly MongoID[] Children; //Field offset: 0x18
		public readonly string Name; //Field offset: 0x20

		public ItemNamedPreset(Item item, MongoID[] children, string name) { }

	}

	internal sealed class NoContainerWithIdError : Error
	{
		private readonly FlatItem _flatItem; //Field offset: 0x10
		private readonly Item _parentItem; //Field offset: 0x18
		private readonly string _availableContainers; //Field offset: 0x20

		public NoContainerWithIdError(FlatItem flatItem, Item parentItem, IEnumerable availableContainers) { }

		public virtual string ToString() { }

	}

	internal sealed class NoParentWithIdError : Error
	{
		private readonly FlatItem _flatItem; //Field offset: 0x10

		public NoParentWithIdError(FlatItem flatItem) { }

		public virtual string ToString() { }

	}

	public static readonly MongoID UNKNOWN_TEMPLATE_ID; //Field offset: 0x0
	public const string OBSERVED_PLAYER_TEMP_CONTAINER_NAME = "TempObservedContainer"; //Field offset: 0x0
	private const string SORTING_TABLE_TEMPLATE_ID = "6050cac987d3f925bf016837"; //Field offset: 0x0
	public readonly ItemTemplates ItemTemplates; //Field offset: 0x10
	[CompilerGenerated]
	private ItemPreset[] <SavedPresets>k__BackingField; //Field offset: 0x18
	private Dictionary _itemPresets; //Field offset: 0x20
	private List _itemNamedPresets; //Field offset: 0x28
	private readonly Dictionary _discardLimitsCache; //Field offset: 0x30
	private readonly Dictionary _cachedItemNames; //Field offset: 0x38
	private WeaponBuildsStorage _weaponBuildsStorage; //Field offset: 0x40
	private MongoID _fakeItemsId; //Field offset: 0x48

	private MongoID NextId
	{
		private get { } //Length: 258
	}

	public private ItemPreset[] SavedPresets
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 82
	}

	private static ItemFactory() { }

	public ItemFactory(ItemTemplates itemTemplates) { }

	[CompilerGenerated]
	private Item <CreateAllItemsEver>b__34_1(KeyValuePair x) { }

	[CompilerGenerated]
	private Item <CreateAllModsEver>b__36_2(KeyValuePair x) { }

	[CompilerGenerated]
	private bool <FlatItemsToTree>b__39_0(FlatItem x) { }

	[CompilerGenerated]
	private bool <FlatItemsToTree>b__39_1(FlatItem x) { }

	[CompilerGenerated]
	private Type <GetFilterTypes>b__19_0(MongoID node) { }

	[CompilerGenerated]
	private FlatItem <TreeToFlatItems>b__40_0(Item item) { }

	[CompilerGenerated]
	private IEnumerable <TreeToFlatItems>b__40_2(ContainerCollection collection) { }

	public string BriefItemName(Item item, string defaultName) { }

	private string BriefWeaponBuildName(Weapon weapon) { }

	private string BriefWeaponPresetName(Weapon weapon) { }

	public IEnumerable CreateAllItemsEver() { }

	public Item[] CreateAllModsEver() { }

	private Item CreateAndFillItem(MongoID templateId) { }

	public Stash CreateFakeStash(Nullable stashId = null) { }

	public Item CreateItem(string itemId, string templateId, UnparsedData itemDiff) { }

	[IteratorStateMachine(typeof(<CreateManyItems>d__21))]
	private IEnumerable CreateManyItems(FlatItem[] flatItems) { }

	public Stash FlatItemsToStash(FlatItem[] flatItems) { }

	public FlatItemsToTreeResult FlatItemsToTree(FlatItem[] flatItems, bool silentMode = false, Dictionary preexistingItems = null) { }

	private MongoID get_NextId() { }

	[CompilerGenerated]
	public ItemPreset[] get_SavedPresets() { }

	[CanBeNull]
	public UnparsedData GetDiff(Item item) { }

	public Dictionary GetDiscardLimits() { }

	public IEnumerable GetFilterTypes(MongoID[] filters) { }

	public Item GetHideoutSchemeItem(MongoID templateId, string id, EOwnerType ownerType, bool spawnedInSession) { }

	public Item GetPresetItem(string templateId) { }

	public Item GetPresetItemByName(string name) { }

	public static void LogErrors(List errors, string caption) { }

	public void RemoveCachedItemName(string name) { }

	[CompilerGenerated]
	private void set_SavedPresets(ItemPreset[] value) { }

	public void SetItemPresets(ItemPreset[] itemPresets) { }

	public void SetWeaponBuildsStorage(WeaponBuildsStorage storage) { }

	public FlatItem[] TreeToFlatItems(IEnumerable rootItems) { }

	public FlatItem[] TreeToFlatItems(Item[] rootItems) { }

}

