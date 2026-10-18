namespace EFT.InventoryLogic;

public abstract class PersonItemController : ItemController
{
	public readonly EPlayerSide Side; //Field offset: 0xF8

	protected PersonItemController(Item rootItem, EPlayerSide side, string profileId, string name, bool canBeLocalized = true, EOwnerType type = 0) { }

}

