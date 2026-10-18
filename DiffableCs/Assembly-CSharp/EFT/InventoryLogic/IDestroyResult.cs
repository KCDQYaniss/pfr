namespace EFT.InventoryLogic;

public interface IDestroyResult : IOperationResult, IRollable
{

	public bool DestroysMainItem
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

	public bool Contains(Item item, out ItemsCount numberToDestroy) { }

	public bool get_DestroysMainItem() { }

	public bool get_ItemsDestroyRequired() { }

	public IEnumerable get_ItemsToDestroy() { }

}

