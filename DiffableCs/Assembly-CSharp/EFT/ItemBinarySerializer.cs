namespace EFT;

public static class ItemBinarySerializer
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__2_0; //Field offset: 0x8
		public static Func <>9__2_1; //Field offset: 0x10
		public static Func <>9__9_0; //Field offset: 0x18
		public static Func <>9__9_1; //Field offset: 0x20
		public static Func <>9__10_0; //Field offset: 0x28
		public static Func <>9__10_1; //Field offset: 0x30

		private static <>c() { }

		public <>c() { }

		internal EBodyModelPart <DeserializeJsonLootItem>b__10_0(KeyValuePair x) { }

		internal MongoID <DeserializeJsonLootItem>b__10_1(KeyValuePair x) { }

		internal int <SerializeItem>b__2_0(KeyValuePair pair) { }

		internal byte <SerializeItem>b__2_1(KeyValuePair pair) { }

		internal int <SerializeJsonLootItem>b__9_0(KeyValuePair x) { }

		internal MongoID <SerializeJsonLootItem>b__9_1(KeyValuePair x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass7_0
	{
		public ISearchController searchController; //Field offset: 0x10

		public <>c__DisplayClass7_0() { }

		internal JsonLootItemDescriptor <SerializeLootData>b__0(JsonLootItem item) { }

	}

	[CompilerGenerated]
	private static class <>O
	{
		public static Func <0>__DeserializeJsonLootItem; //Field offset: 0x0

	}


	public static void DeserializeComponent(ItemComponentDescriptor descriptor, Item item) { }

	[CanBeNull]
	public static Item DeserializeItem(ItemDescriptor itemDescriptor, ItemFactory itemFactory, Dictionary items) { }

	[CanBeNull]
	private static Item DeserializeItemInternal(ItemFactory itemFactory, Dictionary items, ItemDescriptor itemDescriptor) { }

	private static JsonLootItem DeserializeJsonLootItem(JsonLootItemDescriptor t) { }

	public static LootData DeserializeLootData(LootDataDescriptor lootDataDescriptor) { }

	[CanBeNull]
	private static ItemComponentDescriptor SerializeComponent(IItemComponent component) { }

	[CanBeNull]
	public static ItemDescriptor SerializeItem(Item item, ISearchController searchController) { }

	private static JsonLootItemDescriptor SerializeJsonLootItem(JsonLootItem t, ISearchController searchController) { }

	public static LootDataDescriptor SerializeLootData(IEnumerable lootData, ISearchController searchController) { }

	public static NestedItemDescriptor SerializeNestedItem(Item item, ItemAddress newAddress, ISearchController searchController) { }

	private static ItemDescriptor SerializeSubItem(Item item, ItemAddress address, ISearchController searchController) { }

}

