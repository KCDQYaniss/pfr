namespace EFT.InventoryLogic.Operations;

public sealed class MoveOperation : PossibleDestroyOperation, IOneItemOperation, IInventoryOperation
{
	[CompilerGenerated]
	private struct <ExecuteInternal>d__18 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public MoveOperation <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	internal sealed class MoveCommand : CommandWithOwners
	{
		[JsonProperty("Action")]
		public string Action; //Field offset: 0x20
		[JsonProperty("item")]
		public string Item; //Field offset: 0x28
		[JsonProperty("to")]
		public FullItemLocation To; //Field offset: 0x30

		public MoveCommand() { }

	}

	[CompilerGenerated]
	private readonly Item <Item>k__BackingField; //Field offset: 0x78
	[CompilerGenerated]
	private readonly ItemAddress <From>k__BackingField; //Field offset: 0x80
	[CompilerGenerated]
	private readonly ItemAddress <To>k__BackingField; //Field offset: 0x88

	protected virtual bool DestroysMainItem
	{
		 get { } //Length: 692
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
		private get { } //Length: 8
	}

	protected virtual ItemAddress From
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	public virtual Item Item
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public ItemAddress To
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	internal MoveOperation(ushort id, ItemController controller, MoveResult moveResult, IEnumerable itemsToDestroy) { }

	private override ItemAddress EFT.InventoryLogic.Operations.IOneItemOperation.get_From1() { }

	private override Item EFT.InventoryLogic.Operations.IOneItemOperation.get_Item1() { }

	private override ItemAddress EFT.InventoryLogic.Operations.IOneItemOperation.get_To1() { }

	[AsyncStateMachine(typeof(<ExecuteInternal>d__18))]
	protected virtual Task ExecuteInternal() { }

	protected virtual bool get_DestroysMainItem() { }

	[CompilerGenerated]
	protected virtual ItemAddress get_From() { }

	[CompilerGenerated]
	public virtual Item get_Item() { }

	[CompilerGenerated]
	public ItemAddress get_To() { }

	public virtual BaseInventoryCommand ToBaseInventoryCommand(string ownerId) { }

	public virtual InventoryOperationDescriptor ToDescriptor() { }

	public virtual string ToString() { }

}

