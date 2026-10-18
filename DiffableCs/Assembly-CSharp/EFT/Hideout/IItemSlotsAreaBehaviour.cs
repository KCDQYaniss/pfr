namespace EFT.Hideout;

public interface IItemSlotsAreaBehaviour
{

	public event Action OnItemInSlotChanged
	{
		[CompilerGenerated]
		 add { } //Length: 0
		[CompilerGenerated]
		 remove { } //Length: 0
	}

	public bool Changeable
	{
		 get { } //Length: 0
	}

	public AdditionalSlotsBonus Slots
	{
		 get { } //Length: 0
	}

	public Item[] UsingItems
	{
		 get { } //Length: 0
	}

	[CompilerGenerated]
	public void add_OnItemInSlotChanged(Action value) { }

	public bool CanAcceptItem(Item item) { }

	public bool get_Changeable() { }

	public AdditionalSlotsBonus get_Slots() { }

	public Item[] get_UsingItems() { }

	public void InstallConsumableItems(Item[] installedSupplies) { }

	[CompilerGenerated]
	public void remove_OnItemInSlotChanged(Action value) { }

}

