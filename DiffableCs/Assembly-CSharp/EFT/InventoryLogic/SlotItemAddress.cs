namespace EFT.InventoryLogic;

public abstract class SlotItemAddress : ItemAddress
{
	public readonly Slot Slot; //Field offset: 0x18

	public virtual string ContainerName
	{
		 get { } //Length: 91
	}

	protected SlotItemAddress(Slot slot) { }

	public virtual OperationResult Add(Item item, bool simulate) { }

	public virtual OperationResult AddWithoutRestrictions(Item item) { }

	public virtual string get_ContainerName() { }

	public virtual Option GetMaxAddCount(Item item) { }

	public virtual bool IsSpecialSlotAddress() { }

	public virtual void RaiseAddEvent(Item item, CommandStatus status, IItemOwner itemOwner) { }

	public virtual void RaiseRemoveEvent(Item item, CommandStatus status, IItemOwner owner) { }

	public virtual OperationResult Remove(Item item, bool simulate) { }

	public virtual OperationResult RemoveWithoutRestrictions(Item item) { }

	public virtual ItemAddressDescriptor ToDescriptor() { }

	public virtual string ToString() { }

}

