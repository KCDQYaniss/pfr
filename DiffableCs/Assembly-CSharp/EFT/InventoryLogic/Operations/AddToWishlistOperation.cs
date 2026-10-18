namespace EFT.InventoryLogic.Operations;

public sealed class AddToWishlistOperation : AbstractAsyncOperation
{
	internal sealed class AddToWishlistCommand : BaseInventoryCommand
	{
		[JsonProperty("Action")]
		public string Action; //Field offset: 0x10
		[JsonProperty("items")]
		public Dictionary Items; //Field offset: 0x18

		public AddToWishlistCommand() { }

	}

	private readonly MongoID _templateId; //Field offset: 0x68
	private readonly EWishlistGroup _groupType; //Field offset: 0x80

	internal AddToWishlistOperation(ushort id, ItemController controller, AddToWishlistOperationResult addToWishlistResult) { }

	protected virtual Task ExecuteInternal() { }

	public virtual BaseInventoryCommand ToBaseInventoryCommand(string ownerId) { }

	public virtual InventoryOperationDescriptor ToDescriptor() { }

}

