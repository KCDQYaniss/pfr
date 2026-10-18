namespace EFT.InventoryLogic;

public interface IMissingChildrenContextComponent
{

	public MissingItemsError Error
	{
		 get { } //Length: 0
	}

	public bool HasMissingChildren
	{
		 get { } //Length: 0
	}

	public MissingItemsError get_Error() { }

	public bool get_HasMissingChildren() { }

}

