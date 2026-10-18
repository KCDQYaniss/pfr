namespace EFT.Interactive;

public sealed class TransferItemRequirement : ExfiltrationRequirement
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass11_0
	{
		public TransferItemRequirement <>4__this; //Field offset: 0x10
		public Player player; //Field offset: 0x18

		public <>c__DisplayClass11_0() { }

		internal bool <TransferExitItems>b__0(ExfiltrationPoint x) { }

		internal void <TransferExitItems>b__1(IResult error) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass6_0
	{
		public TransferItemRequirement <>4__this; //Field offset: 0x10
		public ExfiltrationPoint point; //Field offset: 0x18

		public <>c__DisplayClass6_0() { }

		internal void <Start>b__0(AddItemEventArgs addItemEventArgs) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass7_0
	{
		public string profileId; //Field offset: 0x10

		public <>c__DisplayClass7_0() { }

		internal bool <GetLocalizedTip>b__0(IPlayer x) { }

	}

	internal sealed class PreparedTransferResult : IOperationResult, IRollable
	{
		[CompilerGenerated]
		private sealed class <>c__DisplayClass4_0
		{
			public ItemController itemController; //Field offset: 0x10

			public <>c__DisplayClass4_0() { }

			internal bool <CanExecute>b__0(IOperationResult operationResult) { }

		}

		public readonly IReadOnlyList OperationResults; //Field offset: 0x10

		public PreparedTransferResult(IReadOnlyList operationResults) { }

		public override bool CanExecute(ItemController itemController) { }

		public override void RaiseEvents(IItemOwner controller, CommandStatus status) { }

		public override void RollBack() { }

	}

	private ItemController _itemController; //Field offset: 0x30

	public ItemController ItemController
	{
		 get { } //Length: 76
	}

	public TransferItemRequirement() { }

	[CompilerGenerated]
	private bool <TryGetOwnerExfilPoint>b__3_0(ExfiltrationPoint x) { }

	public bool CanTransferItems(Player player, out int count) { }

	public ItemController get_ItemController() { }

	public virtual string GetLocalizedTip(string profileId) { }

	public virtual bool Met(Player player, ExfiltrationPoint point) { }

	public virtual void OnDestroy() { }

	public virtual void Start(ExfiltrationPoint point) { }

	public bool TransferExitItem(Player player, Item item) { }

	public bool TransferExitItems(Player player, IReadOnlyCollection items) { }

	public OperationResult TransferExitItems(Player player, ExfiltrationPoint point, IReadOnlyCollection items, bool simulate) { }

	private ExfiltrationPoint TryGetOwnerExfilPoint() { }

	public bool TryGetTransferItems(Player player, out ItemsCount[] items, out int count) { }

}

