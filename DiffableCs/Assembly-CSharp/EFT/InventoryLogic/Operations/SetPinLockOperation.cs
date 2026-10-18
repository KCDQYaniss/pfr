namespace EFT.InventoryLogic.Operations;

public sealed class SetPinLockOperation : AbstractAsyncOperation
{
	private sealed class SetPinLockCommand : CommandWithOwner
	{
		[JsonProperty("Item")]
		public readonly MongoID ItemId; //Field offset: 0x18
		[JsonProperty("State")]
		public readonly EItemPinLockState State; //Field offset: 0x30

		[JsonProperty("Action")]
		public string Action
		{
			 get { } //Length: 49
		}

		public SetPinLockCommand(Item item, EItemPinLockState state, string ownerId) { }

		public string get_Action() { }

	}

	private readonly Item _item; //Field offset: 0x68
	private readonly EItemPinLockState _state; //Field offset: 0x70

	public SetPinLockOperation(ushort id, ItemController controller, SetPinLockResult pinLockResult) { }

	protected virtual Task ExecuteInternal() { }

	public virtual BaseInventoryCommand ToBaseInventoryCommand(string ownerId) { }

	public virtual InventoryOperationDescriptor ToDescriptor() { }

}

