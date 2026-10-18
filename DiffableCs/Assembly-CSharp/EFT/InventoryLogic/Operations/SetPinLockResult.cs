namespace EFT.InventoryLogic.Operations;

public sealed class SetPinLockResult : ISyncOperation, IRollable, IItemOperationResult, IOperationResult
{
	public readonly Item Item; //Field offset: 0x10
	public readonly EItemPinLockState State; //Field offset: 0x18
	private readonly InventoryController _controller; //Field offset: 0x20
	private readonly EItemPinLockState _oldState; //Field offset: 0x28
	[CompilerGenerated]
	private readonly ItemAddress <From>k__BackingField; //Field offset: 0x30

	private override Item EFT.InventoryLogic.IItemOperationResult.Item
	{
		private get { } //Length: 5
	}

	private override Item EFT.InventoryLogic.IItemOperationResult.ResultItem
	{
		private get { } //Length: 5
	}

	public override ItemAddress From
	{
		[CompilerGenerated]
		 get { } //Length: 76
	}

	internal SetPinLockResult(InventoryController controller, Item item, EItemPinLockState state, EItemPinLockState oldState) { }

	public override bool CanExecute(ItemController itemController) { }

	private override Item EFT.InventoryLogic.IItemOperationResult.get_Item() { }

	private override Item EFT.InventoryLogic.IItemOperationResult.get_ResultItem() { }

	public override OperationResult Execute() { }

	[CompilerGenerated]
	public override ItemAddress get_From() { }

	public override void RaiseEvents(IItemOwner controller, CommandStatus status) { }

	public override void RollBack() { }

}

