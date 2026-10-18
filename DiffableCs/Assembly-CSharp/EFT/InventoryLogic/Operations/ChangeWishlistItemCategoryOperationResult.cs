namespace EFT.InventoryLogic.Operations;

public sealed class ChangeWishlistItemCategoryOperationResult : ISyncOperation, IRollable, IOperationResult
{
	public readonly MongoID TemplateId; //Field offset: 0x10
	public readonly EWishlistGroup GroupType; //Field offset: 0x28
	private readonly WishlistManager _manager; //Field offset: 0x30
	private readonly EWishlistGroup _oldGroupType; //Field offset: 0x38

	public ChangeWishlistItemCategoryOperationResult(WishlistManager manager, MongoID templateId, EWishlistGroup groupType, EWishlistGroup oldGroup) { }

	public override bool CanExecute(ItemController itemController) { }

	public override OperationResult Execute() { }

	public override void RaiseEvents(IItemOwner controller, CommandStatus status) { }

	public override void RollBack() { }

}

