namespace EFT.InventoryLogic;

public abstract class DropdownManipulation
{
	[CompilerGenerated]
	private readonly InventoryController <InventoryController>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private readonly CompoundItem[] <Collections>k__BackingField; //Field offset: 0x18

	protected CompoundItem[] Collections
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	protected InventoryController InventoryController
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	protected DropdownManipulation(CompoundItem[] collections, InventoryController inventoryController) { }

	[CompilerGenerated]
	protected CompoundItem[] get_Collections() { }

	[CompilerGenerated]
	protected InventoryController get_InventoryController() { }

	public abstract EEditBuildItemAvailability GetItemAvailability(Item item) { }

	public abstract IEnumerable GetItemCollections(Slot slot) { }

	private static void PlayInstallationSound(Item item) { }

	private static void PlayUseSound(Item item) { }

	protected abstract bool Select(Item item, Slot slot, bool simulate, out Error error) { }

	public bool Select(Item item, Slot slot, out Error error) { }

	public bool SelectCheck(Item item, Slot slot, out Error error) { }

}

