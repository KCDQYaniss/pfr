namespace EFT.InventoryLogic.Operations;

public sealed class AddToWishlistOperationResult : ISyncOperation, IRollable, IOperationResult
{
	public readonly MongoID TemplateId; //Field offset: 0x10
	public readonly EWishlistGroup GroupType; //Field offset: 0x28
	private readonly WishlistManager _manager; //Field offset: 0x30

	public AddToWishlistOperationResult(WishlistManager manager, MongoID templateId, EWishlistGroup groupType) { }

	public override bool CanExecute(ItemController itemController) { }

	public override OperationResult Execute() { }

	public override void RaiseEvents(IItemOwner controller, CommandStatus status) { }

	public override void RollBack() { }

}

