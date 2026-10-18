namespace EFT.InventoryLogic.Operations;

public sealed class ApplyInventoryChangesOperation : AbstractOperation
{
	[CompilerGenerated]
	private static class <>O
	{
		public static Func <0>__FlatItemSelector; //Field offset: 0x0

	}

	internal sealed class ApplyInventoryChangesCommand : BaseInventoryCommand
	{
		[JsonProperty("Action")]
		public string Action; //Field offset: 0x10
		[JsonProperty("changedItems")]
		public IEnumerable ChangedItems; //Field offset: 0x18

		public virtual bool Queued
		{
			 get { } //Length: 3
		}

		public ApplyInventoryChangesCommand() { }

		public virtual bool get_Queued() { }

	}

	private readonly InventoryController _inventoryController; //Field offset: 0x40
	private readonly ApplySortItemsPositionResult _sortResult; //Field offset: 0x48

	public ApplyInventoryChangesOperation(ushort id, InventoryController controller, ApplySortItemsPositionResult sortResult) { }

	public virtual void Dispose() { }

	protected virtual void ExecuteInternal(Callback callback) { }

	private static FlatItem FlatItemSelector(GridAddResult itemResult) { }

	public virtual BaseInventoryCommand ToBaseInventoryCommand(string ownerId) { }

	public virtual InventoryOperationDescriptor ToDescriptor() { }

}

