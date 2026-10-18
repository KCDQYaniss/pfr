namespace EFT.InventoryLogic;

public abstract class GridItemAddress : ItemAddress
{
	public readonly LocationInGrid LocationInGrid; //Field offset: 0x18
	private readonly int _hashCode; //Field offset: 0x20
	private readonly int _hashSum; //Field offset: 0x24
	public readonly Grid Grid; //Field offset: 0x28

	public virtual string ContainerName
	{
		 get { } //Length: 27
	}

	protected GridItemAddress(Grid grid, LocationInGrid locationInGrid) { }

	public virtual OperationResult Add(Item item, bool simulate) { }

	public virtual OperationResult AddWithoutRestrictions(Item item) { }

	public virtual bool Equals(object obj) { }

	public virtual string get_ContainerName() { }

	public virtual int GetHashCode() { }

	public virtual int GetHashSum() { }

	public virtual Option GetMaxAddCount(Item item) { }

	public virtual OperationResult Remove(Item item, bool simulate) { }

	public virtual OperationResult RemoveWithoutRestrictions(Item item) { }

	public virtual ItemAddressDescriptor ToDescriptor() { }

	public virtual string ToString() { }

}

