namespace EFT.InventoryLogic;

public class KeycardComponent : ItemComponent
{
	public readonly IKeyComponentTemplate Template; //Field offset: 0x18
	public readonly KeyComponent Key; //Field offset: 0x20

	public KeycardComponent(Item item, IKeyComponentTemplate template) { }

}

