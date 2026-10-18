namespace EFT.InventoryLogic;

[Extension]
public static class InventoryEquipmentExtension
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__7_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal Item <GetCollections>b__7_0(Slot x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass8_0
	{
		public Item item; //Field offset: 0x10

		public <>c__DisplayClass8_0() { }

		internal bool <IsItemEquipped>b__0(Slot slot) { }

	}


	[Extension]
	public static IEnumerable GetAllSlots(InventoryEquipment equipment) { }

	[Extension]
	public static IEnumerable GetCollections(InventoryEquipment equipment, IEnumerable slotNames) { }

	[Extension]
	public static IEnumerable GetPrioritizedContainersForLoot(InventoryEquipment equipment, Item item) { }

	[Extension]
	public static IEnumerable GetPrioritizedGridsForLoot(InventoryEquipment equipment, Item item) { }

	[Extension]
	public static IEnumerable GetPrioritizedGridsForUnloadedObject(InventoryEquipment equipment, bool backpackIncluded = false) { }

	private static Grid[] GetSearchedItemGrids(SearchableItem item) { }

	[Extension]
	public static IEnumerable GetSlotsByName(InventoryEquipment equipment, IEnumerable slotNames) { }

	[Extension]
	public static void GetSlotsByNameNonAlloc(InventoryEquipment equipment, IEnumerable slotNames, IList preallocatedList) { }

	[Extension]
	public static bool IsItemEquipped(InventoryEquipment equipment, Item item) { }

	[Extension]
	public static bool TryGetHeadphones(InventoryEquipment equipment, out Headphones headphones) { }

}

