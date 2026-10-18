namespace EFT.InventoryLogic.Operations;

public sealed class PurchaseTraderServiceOperationResult : ISyncOperationResult, ISyncOperation, IRollable, IOperationResult, IDialogLineActionResult
{
	public readonly ETraderServiceType ServiceType; //Field offset: 0x10
	public readonly string SubServiceId; //Field offset: 0x18
	public readonly QuestController QuestController; //Field offset: 0x20
	public readonly InventoryController InventoryController; //Field offset: 0x28
	private readonly IReadOnlyList _operationResults; //Field offset: 0x30

	public PurchaseTraderServiceOperationResult(ETraderServiceType serviceType, string subServiceId, QuestController questController, InventoryController inventoryController, IReadOnlyList operationResults) { }

	public override bool CanExecute(ItemController itemController) { }

	public override OperationResult Execute() { }

	public override BaseInventoryCommand GetBaseInventoryCommand() { }

	public override Task LoadBundles() { }

	public override void RaiseEvents(IItemOwner controller, CommandStatus status) { }

	public override void RollBack() { }

	public override InventoryOperationDescriptor ToDescriptor(IOperationInfo operation) { }

}

