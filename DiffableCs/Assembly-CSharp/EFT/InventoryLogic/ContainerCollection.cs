namespace EFT.InventoryLogic;

public abstract class ContainerCollection : Item, IItemContainer
{

	public abstract IEnumerable Containers
	{
		 get { } //Length: 0
	}

	public virtual float TotalWeight
	{
		 get { } //Length: 604
	}

	protected ContainerCollection(string id, ItemTemplate template) { }

	public abstract IEnumerable get_Containers() { }

	public virtual float get_TotalWeight() { }

	[CanBeNull]
	public abstract IContainer GetContainer(string containerId) { }

	public abstract bool TryFindItem(string itemId, out Item item) { }

	public abstract bool TryFindItem(Func predicate, out Item item) { }

	protected bool TryFindSelf(string itemId, out Item item) { }

}

