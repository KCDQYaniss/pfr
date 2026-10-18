namespace EFT.InventoryLogic.Operations;

public sealed class TransferExfiltrationPaymentOperationResult : ISyncOperationResult, ISyncOperation, IRollable, IOperationResult
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__10_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal DestroyedItem <ToDescriptor>b__10_0(ItemsCount item) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass9_0
	{
		public ItemController itemController; //Field offset: 0x10

		public <>c__DisplayClass9_0() { }

		internal bool <CanExecute>b__0(IOperationResult operationResult) { }

	}

	public readonly string PointName; //Field offset: 0x10
	public readonly IReadOnlyCollection Items; //Field offset: 0x18
	private readonly Player _player; //Field offset: 0x20
	private readonly ExfiltrationPoint _point; //Field offset: 0x28
	private readonly IReadOnlyList _operationResults; //Field offset: 0x30

	public TransferExfiltrationPaymentOperationResult(Player player, ExfiltrationPoint point, IReadOnlyCollection items, IReadOnlyList operationResults) { }

	public override bool CanExecute(ItemController itemController) { }

	public override OperationResult Execute() { }

	public override void RaiseEvents(IItemOwner controller, CommandStatus status) { }

	public override void RollBack() { }

	public InventoryOperationDescriptor ToDescriptor(IOperationInfo operation) { }

}

