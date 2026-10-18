namespace EFT.InventoryLogic;

public class StationaryContainer : CompoundItem
{

	public virtual bool CanBePickedUp
	{
		 get { } //Length: 3
	}

	public virtual bool IsContainer
	{
		 get { } //Length: 3
	}

	public virtual IEnumerable ItemInteractionButtons
	{
		 get { } //Length: 70
	}

	public StationaryContainer(string id, StationaryContainerTemplate template) { }

	public virtual bool get_CanBePickedUp() { }

	public virtual bool get_IsContainer() { }

	public virtual IEnumerable get_ItemInteractionButtons() { }

}

