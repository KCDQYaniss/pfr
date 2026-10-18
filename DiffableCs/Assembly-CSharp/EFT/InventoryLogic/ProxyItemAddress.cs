namespace EFT.InventoryLogic;

public sealed class ProxyItemAddress : ItemAddress
{
	public readonly bool Searched; //Field offset: 0x18
	private readonly ItemAddress _sourceAddress; //Field offset: 0x20

	public virtual string ContainerName
	{
		 get { } //Length: 42
	}

	public ProxyItemAddress(ItemAddress sourceAddress, bool searched) { }

	public virtual OperationResult Add(Item item, bool simulate) { }

	public virtual OperationResult AddWithoutRestrictions(Item item) { }

	public virtual string get_ContainerName() { }

	public virtual Option GetMaxAddCount(Item item) { }

	public virtual OperationResult Remove(Item item, bool simulate) { }

	public virtual OperationResult RemoveWithoutRestrictions(Item item) { }

	public virtual ItemAddressDescriptor ToDescriptor() { }

}

