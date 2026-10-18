namespace EFT.InventoryLogic;

public abstract class OwnerItself : ItemAddress
{
	private readonly IItemOwner _owner; //Field offset: 0x18

	public virtual string ContainerName
	{
		 get { } //Length: 59
	}

	protected OwnerItself(IItemOwner owner) { }

	public virtual OperationResult Add(Item item, bool simulate) { }

	public virtual OperationResult AddWithoutRestrictions(Item item) { }

	public virtual bool Equals(object obj) { }

	public virtual string get_ContainerName() { }

	public virtual Option GetMaxAddCount(Item item) { }

	public virtual OperationResult Remove(Item item, bool simulate) { }

	public virtual OperationResult RemoveWithoutRestrictions(Item item) { }

	public virtual ItemAddressDescriptor ToDescriptor() { }

}

