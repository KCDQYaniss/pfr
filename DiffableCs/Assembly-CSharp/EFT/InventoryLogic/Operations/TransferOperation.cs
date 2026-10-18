namespace EFT.InventoryLogic.Operations;

public sealed class TransferOperation : AbstractAsyncOperation, ITwoItemOperation, IOneItemOperation, IInventoryOperation, IObservedOperation, IOperationInfo
{
	[CompilerGenerated]
	private struct <ExecuteInternal>d__18 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public TransferOperation <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	internal sealed class TransferCommand : CommandWithOwners
	{
		[JsonProperty("Action")]
		public string Action; //Field offset: 0x20
		[JsonProperty("item")]
		public string Item; //Field offset: 0x28
		[JsonProperty("with")]
		public string With; //Field offset: 0x30
		[JsonProperty("count")]
		public int Count; //Field offset: 0x38

		public TransferCommand() { }

	}

	private readonly Item _item; //Field offset: 0x68
	private readonly ItemAddress _from; //Field offset: 0x70
	private readonly Item _targetItem; //Field offset: 0x78
	private readonly ItemAddress _to; //Field offset: 0x80
	private readonly int _count; //Field offset: 0x88

	private override ItemAddress EFT.InventoryLogic.Operations.IOneItemOperation.From1
	{
		private get { } //Length: 5
	}

	private override Item EFT.InventoryLogic.Operations.IOneItemOperation.Item1
	{
		private get { } //Length: 5
	}

	private override ItemAddress EFT.InventoryLogic.Operations.IOneItemOperation.To1
	{
		private get { } //Length: 5
	}

	private override ItemAddress EFT.InventoryLogic.Operations.ITwoItemOperation.From2
	{
		private get { } //Length: 8
	}

	private override Item EFT.InventoryLogic.Operations.ITwoItemOperation.Item2
	{
		private get { } //Length: 5
	}

	private override ItemAddress EFT.InventoryLogic.Operations.ITwoItemOperation.To2
	{
		private get { } //Length: 8
	}

	internal TransferOperation(ushort id, ItemController controller, TransferResult transferResult) { }

	private override ItemAddress EFT.InventoryLogic.Operations.IOneItemOperation.get_From1() { }

	private override Item EFT.InventoryLogic.Operations.IOneItemOperation.get_Item1() { }

	private override ItemAddress EFT.InventoryLogic.Operations.IOneItemOperation.get_To1() { }

	private override ItemAddress EFT.InventoryLogic.Operations.ITwoItemOperation.get_From2() { }

	private override Item EFT.InventoryLogic.Operations.ITwoItemOperation.get_Item2() { }

	private override ItemAddress EFT.InventoryLogic.Operations.ITwoItemOperation.get_To2() { }

	[AsyncStateMachine(typeof(<ExecuteInternal>d__18))]
	protected virtual Task ExecuteInternal() { }

	public virtual BaseInventoryCommand ToBaseInventoryCommand(string ownerId) { }

	public virtual InventoryOperationDescriptor ToDescriptor() { }

	public virtual string ToString() { }

}

