namespace EFT.InventoryLogic.Operations;

public sealed class RemoveOperation : AbstractAsyncOperation, IOneItemOperation, IInventoryOperation, IObservedOperation, IOperationInfo
{
	[CompilerGenerated]
	private struct <ExecuteInternal>d__11 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public RemoveOperation <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	internal sealed class RemoveCommand : CommandWithOwner
	{
		[JsonProperty("Action")]
		public string Action; //Field offset: 0x18
		[JsonProperty("item")]
		public string Item; //Field offset: 0x20

		public RemoveCommand() { }

	}

	private readonly Item _item; //Field offset: 0x68
	private readonly ItemAddress _from; //Field offset: 0x70

	private override ItemAddress EFT.InventoryLogic.Operations.IOneItemOperation.From1
	{
		private get { } //Length: 27
	}

	private override Item EFT.InventoryLogic.Operations.IOneItemOperation.Item1
	{
		private get { } //Length: 5
	}

	private override ItemAddress EFT.InventoryLogic.Operations.IOneItemOperation.To1
	{
		private get { } //Length: 3
	}

	public Item Item
	{
		 get { } //Length: 5
	}

	internal RemoveOperation(ushort id, ItemController controller, DiscardResult discardResult) { }

	private override ItemAddress EFT.InventoryLogic.Operations.IOneItemOperation.get_From1() { }

	private override Item EFT.InventoryLogic.Operations.IOneItemOperation.get_Item1() { }

	private override ItemAddress EFT.InventoryLogic.Operations.IOneItemOperation.get_To1() { }

	[AsyncStateMachine(typeof(<ExecuteInternal>d__11))]
	protected virtual Task ExecuteInternal() { }

	public Item get_Item() { }

	public virtual BaseInventoryCommand ToBaseInventoryCommand(string ownerId) { }

	public virtual InventoryOperationDescriptor ToDescriptor() { }

	public virtual string ToString() { }

}

