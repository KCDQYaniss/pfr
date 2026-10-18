namespace EFT.InventoryLogic.Operations;

public sealed class ChangeItemsOperationDescriptor : InventoryOperationDescriptor
{
	[CompilerGenerated]
	private struct <>c__DisplayClass6_0
	{
		public IPlayer player; //Field offset: 0x0

	}

	[CanBeNull]
	[Nullable]
	public List ChangedItems; //Field offset: 0x30
	[CanBeNull]
	[Nullable]
	public List RemovedItems; //Field offset: 0x38
	[CanBeNull]
	[Nullable]
	public Dictionary MovedItems; //Field offset: 0x40
	[CanBeNull]
	[Nullable]
	public List NewItems; //Field offset: 0x48
	[CanBeNull]
	[Nullable]
	public InventoryOperationDescriptor InternalOperationDescriptor; //Field offset: 0x50

	public ChangeItemsOperationDescriptor() { }

	[CompilerGenerated]
	internal static bool <ToInventoryOperation>g__TryGetItem|6_1(in MongoID itemId, out Item item, ref <>c__DisplayClass6_0 unnamed_param_2) { }

	[CompilerGenerated]
	internal static bool <ToInventoryOperation>g__TryGetItemAddress|6_0(ItemAddressDescriptor addressDescriptor, out ItemAddress address) { }

	public virtual OperationCreationResult ToInventoryOperation(IPlayer player) { }

}

