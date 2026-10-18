namespace EFT;

[GenerateBinarySerialization]
public sealed class InventoryDescriptor
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__44_0; //Field offset: 0x8
		public static Func <>9__44_1; //Field offset: 0x10
		public static Func <>9__44_2; //Field offset: 0x18
		public static Func <>9__44_3; //Field offset: 0x20
		public static Func <>9__47_0; //Field offset: 0x28
		public static Func <>9__47_1; //Field offset: 0x30
		public static Func <>9__47_2; //Field offset: 0x38

		private static <>c() { }

		public <>c() { }

		internal EBoundItem <.ctor>b__44_0(KeyValuePair boundItem) { }

		internal MongoID <.ctor>b__44_1(KeyValuePair boundItem) { }

		internal MongoID <.ctor>b__44_2(KeyValuePair limit) { }

		internal int <.ctor>b__44_3(KeyValuePair limit) { }

		internal EAreaType <OnJSONSerializing>b__47_0(KeyValuePair pair) { }

		internal MongoID <OnJSONSerializing>b__47_1(KeyValuePair pair) { }

		internal bool <OnJSONSerializing>b__47_2(Item container) { }

	}

	[IgnoreBinarySerialization]
	[JsonProperty("items")]
	private FlatItem[] _items; //Field offset: 0x10
	[IgnoreBinarySerialization]
	[JsonProperty("equipment")]
	private MongoID _equipmentId; //Field offset: 0x18
	[DefaultValue(null)]
	[IgnoreBinarySerialization]
	[JsonProperty(PropertyName = "stash", NullValueHandling = NullValueHandling::Ignore (1))]
	private Nullable _stashId; //Field offset: 0x30
	[DefaultValue(null)]
	[IgnoreBinarySerialization]
	[JsonProperty(PropertyName = "questRaidItems", NullValueHandling = NullValueHandling::Ignore (1))]
	private Nullable _questRaidItemsId; //Field offset: 0x50
	[DefaultValue(null)]
	[IgnoreBinarySerialization]
	[JsonProperty(PropertyName = "questStashItems", NullValueHandling = NullValueHandling::Ignore (1))]
	private Nullable _questStashItemsId; //Field offset: 0x70
	[DefaultValue(null)]
	[IgnoreBinarySerialization]
	[JsonProperty(PropertyName = "sortingTable", NullValueHandling = NullValueHandling::Ignore (1))]
	private Nullable _sortingTableId; //Field offset: 0x90
	[DefaultValue(null)]
	[IgnoreBinarySerialization]
	[JsonProperty("hideoutAreaStashes", NullValueHandling = NullValueHandling::Ignore (1))]
	private Dictionary _hideoutAreaStashesIds; //Field offset: 0xB0
	[JsonProperty("fastPanel")]
	public Dictionary FastAccess; //Field offset: 0xB8
	[JsonProperty("favoriteItems")]
	public List FavoriteItemsStorage; //Field offset: 0xC0
	[DefaultValue(null)]
	[IgnoreBinarySerialization]
	[JsonProperty(PropertyName = "hideoutCustomizationStashId", NullValueHandling = NullValueHandling::Ignore (1))]
	private Nullable _hideoutCustomizationStashId; //Field offset: 0xC8
	[JsonIgnore]
	public bool CheckInventoryHash; //Field offset: 0xE8
	[JsonIgnore]
	public Dictionary DiscardLimits; //Field offset: 0xF0
	private ItemDescriptor _equipment; //Field offset: 0xF8
	private ItemDescriptor _stash; //Field offset: 0x100
	private ItemDescriptor _questRaidItems; //Field offset: 0x108
	private ItemDescriptor _questStashItems; //Field offset: 0x110
	private ItemDescriptor _sortingTable; //Field offset: 0x118
	private ItemDescriptor _hideoutCustomizationStash; //Field offset: 0x120
	private Dictionary _hideoutAreaStashes; //Field offset: 0x128
	private Inventory _inventory; //Field offset: 0x130
	private readonly ISearchController _searchController; //Field offset: 0x138
	private List _deserializationErrors; //Field offset: 0x140

	[JsonIgnore]
	public ItemDescriptor Equipment
	{
		 get { } //Length: 29
		 set { } //Length: 82
	}

	[CanBeNull]
	[JsonIgnore]
	[Nullable]
	public Dictionary HideoutAreaStashes
	{
		 get { } //Length: 29
		 set { } //Length: 82
	}

	[CanBeNull]
	[JsonIgnore]
	[Nullable]
	public ItemDescriptor HideoutCustomizationStash
	{
		 get { } //Length: 29
		 set { } //Length: 82
	}

	[CanBeNull]
	[JsonIgnore]
	[Nullable]
	public ItemDescriptor QuestRaidItems
	{
		 get { } //Length: 29
		 set { } //Length: 82
	}

	[CanBeNull]
	[JsonIgnore]
	[Nullable]
	public ItemDescriptor QuestStashItems
	{
		 get { } //Length: 29
		 set { } //Length: 82
	}

	[CanBeNull]
	[JsonIgnore]
	[Nullable]
	public ItemDescriptor SortingTable
	{
		 get { } //Length: 29
		 set { } //Length: 82
	}

	[CanBeNull]
	[JsonIgnore]
	[Nullable]
	public ItemDescriptor Stash
	{
		 get { } //Length: 29
		 set { } //Length: 82
	}

	public InventoryDescriptor(Inventory inventory, ISearchController searchController) { }

	public InventoryDescriptor() { }

	private void FillBinaryData() { }

	public ItemDescriptor get_Equipment() { }

	public Dictionary get_HideoutAreaStashes() { }

	public ItemDescriptor get_HideoutCustomizationStash() { }

	public ItemDescriptor get_QuestRaidItems() { }

	public ItemDescriptor get_QuestStashItems() { }

	public ItemDescriptor get_SortingTable() { }

	public ItemDescriptor get_Stash() { }

	[OnSerializing]
	private void OnJSONSerializing(StreamingContext context) { }

	public void set_Equipment(ItemDescriptor value) { }

	public void set_HideoutAreaStashes(Dictionary value) { }

	public void set_HideoutCustomizationStash(ItemDescriptor value) { }

	public void set_QuestRaidItems(ItemDescriptor value) { }

	public void set_QuestStashItems(ItemDescriptor value) { }

	public void set_SortingTable(ItemDescriptor value) { }

	public void set_Stash(ItemDescriptor value) { }

	public Inventory ToInventory() { }

}

