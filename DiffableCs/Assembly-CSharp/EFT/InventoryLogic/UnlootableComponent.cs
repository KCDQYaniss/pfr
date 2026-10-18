namespace EFT.InventoryLogic;

public class UnlootableComponent : ItemComponent
{
	public readonly IUnlootableComponentTemplate Template; //Field offset: 0x18

	public UnlootableComponent(Item item, IUnlootableComponentTemplate template) { }

	public bool IsUnlootableFrom(IContainer container) { }

}

