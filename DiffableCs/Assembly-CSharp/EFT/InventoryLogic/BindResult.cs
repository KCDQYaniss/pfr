namespace EFT.InventoryLogic;

public sealed class BindResult : ISyncOperation, IRollable, IOperationResult
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass0_0
	{
		public Item item; //Field offset: 0x10

		public <>c__DisplayClass0_0() { }

		internal bool <Run>b__0(KeyValuePair pair) { }

	}

	public readonly InventoryController Controller; //Field offset: 0x10
	public readonly Item Item; //Field offset: 0x18
	public readonly EBoundItem Index; //Field offset: 0x20
	[CanBeNull]
	private readonly List _unbindResults; //Field offset: 0x28

	private BindResult(InventoryController controller, Item item, EBoundItem index, List unbindResults) { }

	public override bool CanExecute(ItemController itemController) { }

	public override OperationResult Execute() { }

	public override void RaiseEvents(IItemOwner controller, CommandStatus status) { }

	public override void RollBack() { }

	public static OperationResult Run(InventoryController controller, Item item, EBoundItem index, bool simulate) { }

}

