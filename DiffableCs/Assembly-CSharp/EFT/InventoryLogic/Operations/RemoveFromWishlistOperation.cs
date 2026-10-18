namespace EFT.InventoryLogic.Operations;

public sealed class RemoveFromWishlistOperation : AbstractAsyncOperation
{
	internal sealed class RemoveFromWishlistOperationCommand : BaseInventoryCommand
	{
		[JsonProperty("Action")]
		public string Action; //Field offset: 0x10
		[JsonProperty("items")]
		public MongoID[] Items; //Field offset: 0x18

		public RemoveFromWishlistOperationCommand() { }

	}

	private readonly MongoID _templateId; //Field offset: 0x68
	private readonly EWishlistGroup _groupType; //Field offset: 0x80

	internal RemoveFromWishlistOperation(ushort id, ItemController controller, RemoveFromWishlistOperationResult removeFromWishlistResult) { }

	protected virtual Task ExecuteInternal() { }

	public virtual BaseInventoryCommand ToBaseInventoryCommand(string ownerId) { }

	public virtual InventoryOperationDescriptor ToDescriptor() { }

}

