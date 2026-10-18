namespace EFT.InventoryLogic;

public class Pockets : SearchableItem
{

	public virtual bool CanBePickedUp
	{
		 get { } //Length: 3
	}

	public Pockets(string id, PocketsTemplate template) { }

	public virtual bool get_CanBePickedUp() { }

}

