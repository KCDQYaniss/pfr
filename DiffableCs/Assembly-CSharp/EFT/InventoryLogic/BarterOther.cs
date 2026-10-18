namespace EFT.InventoryLogic;

public class BarterOther : BarterItem
{
	[Component]
	public readonly DogtagComponent Dogtag; //Field offset: 0x80

	public BarterOther(string id, BarterOtherTemplate template) { }

}

