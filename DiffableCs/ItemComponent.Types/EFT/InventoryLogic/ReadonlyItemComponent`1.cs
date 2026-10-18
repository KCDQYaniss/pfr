namespace EFT.InventoryLogic;

public class ReadonlyItemComponent`1 : IReadonlyItemComponent, IItemComponent
{
	public readonly TItemTemplate Template; //Field offset: 0x0

	public override bool Serialized
	{
		 get { } //Length: 3
	}

	public ReadonlyItemComponent`1(TItemTemplate template) { }

	public override bool get_Serialized() { }

}

