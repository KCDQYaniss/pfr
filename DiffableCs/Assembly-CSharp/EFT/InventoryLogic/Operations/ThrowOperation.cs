namespace EFT.InventoryLogic.Operations;

public sealed class ThrowOperation : PossibleDestroyOperation, IOneItemOperation, IInventoryOperation
{
	[CompilerGenerated]
	private struct <ExecuteInternal>d__17 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ThrowOperation <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private readonly bool _downDirection; //Field offset: 0x78
	private readonly IPlayer _player; //Field offset: 0x80
	[CompilerGenerated]
	private readonly Item <Item>k__BackingField; //Field offset: 0x88
	[CompilerGenerated]
	private readonly ItemAddress <From>k__BackingField; //Field offset: 0x90

	protected virtual bool DestroysMainItem
	{
		 get { } //Length: 671
	}

	private override ItemAddress EFT.InventoryLogic.Operations.IOneItemOperation.From1
	{
		private get { } //Length: 20
	}

	private override Item EFT.InventoryLogic.Operations.IOneItemOperation.Item1
	{
		private get { } //Length: 20
	}

	private override ItemAddress EFT.InventoryLogic.Operations.IOneItemOperation.To1
	{
		private get { } //Length: 3
	}

	protected virtual ItemAddress From
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	public virtual Item Item
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	internal ThrowOperation(ushort id, ItemController controller, ThrowResult throwResult, IEnumerable destroyedItems, IPlayer player, bool downDirection = false) { }

	public virtual void Dispose() { }

	private override ItemAddress EFT.InventoryLogic.Operations.IOneItemOperation.get_From1() { }

	private override Item EFT.InventoryLogic.Operations.IOneItemOperation.get_Item1() { }

	private override ItemAddress EFT.InventoryLogic.Operations.IOneItemOperation.get_To1() { }

	[AsyncStateMachine(typeof(<ExecuteInternal>d__17))]
	protected virtual Task ExecuteInternal() { }

	protected virtual bool get_DestroysMainItem() { }

	[CompilerGenerated]
	protected virtual ItemAddress get_From() { }

	[CompilerGenerated]
	public virtual Item get_Item() { }

	public virtual BaseInventoryCommand ToBaseInventoryCommand(string ownerId) { }

	public virtual InventoryOperationDescriptor ToDescriptor() { }

	public virtual string ToString() { }

}

