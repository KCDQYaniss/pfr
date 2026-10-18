namespace EFT.InventoryLogic;

public abstract class StackSlotItemAddress : ItemAddress
{
	public readonly StackSlot StackSlot; //Field offset: 0x18

	public virtual string ContainerName
	{
		 get { } //Length: 72
	}

	protected StackSlotItemAddress(StackSlot stackSlot) { }

	public virtual OperationResult Add(Item item, bool simulate) { }

	public virtual OperationResult AddWithoutRestrictions(Item item) { }

	public virtual string get_ContainerName() { }

	public virtual Option GetMaxAddCount(Item item) { }

	public virtual OperationResult Remove(Item item, bool simulate) { }

	public virtual OperationResult RemoveWithoutRestrictions(Item item) { }

	public virtual ItemAddressDescriptor ToDescriptor() { }

	public virtual string ToString() { }

}

