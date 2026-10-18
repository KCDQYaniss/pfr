namespace EFT.InventoryLogic;

public class LootContainer : SearchableItem
{

	public virtual bool CanBePickedUp
	{
		 get { } //Length: 3
	}

	public LootContainer(string id, LootContainerTemplate template) { }

	public virtual bool get_CanBePickedUp() { }

}

