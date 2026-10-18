namespace EFT.InventoryLogic;

public abstract class ItemAddress
{
	public readonly IContainer Container; //Field offset: 0x10

	public abstract string ContainerName
	{
		 get { } //Length: 0
	}

	protected ItemAddress(IContainer container) { }

	public abstract OperationResult Add(Item item, bool simulate) { }

	public abstract OperationResult AddWithoutRestrictions(Item item) { }

	public override Option CanAccept(Item item) { }

	public virtual bool Equals(object obj) { }

	public abstract string get_ContainerName() { }

	public virtual int GetHashCode() { }

	public override int GetHashSum() { }

	public abstract Option GetMaxAddCount(Item item) { }

	public override bool IsSpecialSlotAddress() { }

	public override void RaiseAddEvent(Item item, CommandStatus status, IItemOwner controller) { }

	public override void RaiseRemoveEvent(Item item, CommandStatus status, IItemOwner owner) { }

	public abstract OperationResult Remove(Item item, bool simulate) { }

	public abstract OperationResult RemoveWithoutRestrictions(Item item) { }

	public abstract ItemAddressDescriptor ToDescriptor() { }

}

