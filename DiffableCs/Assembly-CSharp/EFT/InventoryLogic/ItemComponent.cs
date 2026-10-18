namespace EFT.InventoryLogic;

public class ItemComponent : IItemComponent
{
	public readonly Item Item; //Field offset: 0x10

	public override bool Serialized
	{
		 get { } //Length: 3
	}

	protected ItemComponent(Item item) { }

	public override bool get_Serialized() { }

}

