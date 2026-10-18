namespace EFT.InventoryLogic;

public class RecorderItem : SpecItem
{

	public virtual IEnumerable ItemInteractionButtons
	{
		 get { } //Length: 346
	}

	public RecorderItem(string id, RecorderItemTemplate itemTemplate) { }

	public virtual IEnumerable get_ItemInteractionButtons() { }

}

