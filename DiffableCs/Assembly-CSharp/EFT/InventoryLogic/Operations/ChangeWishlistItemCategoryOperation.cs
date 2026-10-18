namespace EFT.InventoryLogic.Operations;

public sealed class ChangeWishlistItemCategoryOperation : AbstractAsyncOperation
{
	internal sealed class ChangeWishlistGroupCommand : BaseInventoryCommand
	{
		[JsonProperty("Action")]
		public string Action; //Field offset: 0x10
		[JsonProperty("item")]
		public MongoID Item; //Field offset: 0x18
		[JsonProperty("category")]
		public int Category; //Field offset: 0x30

		public ChangeWishlistGroupCommand() { }

	}

	private readonly MongoID _templateId; //Field offset: 0x68
	private readonly EWishlistGroup _groupType; //Field offset: 0x80

	internal ChangeWishlistItemCategoryOperation(ushort id, ItemController controller, ChangeWishlistItemCategoryOperationResult changeCategoryResult) { }

	protected virtual Task ExecuteInternal() { }

	public virtual BaseInventoryCommand ToBaseInventoryCommand(string ownerId) { }

	public virtual InventoryOperationDescriptor ToDescriptor() { }

}

