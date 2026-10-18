namespace EFT.InventoryLogic.Operations;

public sealed class BindItemOperation : AbstractAsyncOperation
{
	internal sealed class BindCommand : CommandWithOwner
	{
		[JsonProperty("Action")]
		public string Action; //Field offset: 0x18
		[JsonProperty("item")]
		public string Item; //Field offset: 0x20
		[JsonProperty("index")]
		public EBoundItem Index; //Field offset: 0x28

		public BindCommand() { }

	}

	private readonly Item _item; //Field offset: 0x68
	private readonly EBoundItem _index; //Field offset: 0x70

	public BindItemOperation(ushort id, ItemController controller, BindResult bindResult) { }

	protected virtual Task ExecuteInternal() { }

	public virtual BaseInventoryCommand ToBaseInventoryCommand(string ownerId) { }

	public virtual InventoryOperationDescriptor ToDescriptor() { }

}

