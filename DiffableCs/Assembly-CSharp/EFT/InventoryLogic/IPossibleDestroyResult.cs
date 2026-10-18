namespace EFT.InventoryLogic;

public interface IPossibleDestroyResult : IOperationResult, IRollable
{

	public bool DestroysMainItem
	{
		 get { } //Length: 0
	}

	[CanBeNull]
	public ItemAddress From
	{
		 get { } //Length: 0
	}

	public bool ItemsDestroyRequired
	{
		 get { } //Length: 0
	}

	public IEnumerable ItemsToDestroy
	{
		 get { } //Length: 0
	}

	[CanBeNull]
	public ItemAddress To
	{
		 get { } //Length: 0
	}

	public bool get_DestroysMainItem() { }

	public ItemAddress get_From() { }

	public bool get_ItemsDestroyRequired() { }

	public IEnumerable get_ItemsToDestroy() { }

	public ItemAddress get_To() { }

}

