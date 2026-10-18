namespace EFT.InventoryLogic.Operations;

public sealed class SplitOperation : AbstractAsyncOperation, IOneItemOperation, IInventoryOperation, IObservedOperation, IOperationInfo
{
	[CompilerGenerated]
	private struct <ExecuteInternal>d__13 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public SplitOperation <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	internal sealed class SplitCommand : CommandWithOwners
	{
		[JsonProperty("Action")]
		public string Action; //Field offset: 0x20
		[JsonProperty("splitItem")]
		public string Item; //Field offset: 0x28
		[JsonProperty("newItem")]
		public string NewItem; //Field offset: 0x30
		[JsonProperty("container")]
		public FullItemLocation Container; //Field offset: 0x38
		[JsonProperty("count")]
		public int Count; //Field offset: 0x40

		public SplitCommand() { }

	}

	private readonly Item _item; //Field offset: 0x68
	private readonly ItemAddress _from; //Field offset: 0x70
	private readonly ItemAddress _to; //Field offset: 0x78
	private readonly int _count; //Field offset: 0x80
	private readonly string _cloneId; //Field offset: 0x88
	private Item _splitItem; //Field offset: 0x90

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

	internal SplitOperation(ushort id, ItemController controller, SplitResult splitResult) { }

	private override ItemAddress EFT.InventoryLogic.Operations.IOneItemOperation.get_From1() { }

	private override Item EFT.InventoryLogic.Operations.IOneItemOperation.get_Item1() { }

	private override ItemAddress EFT.InventoryLogic.Operations.IOneItemOperation.get_To1() { }

	[AsyncStateMachine(typeof(<ExecuteInternal>d__13))]
	protected virtual Task ExecuteInternal() { }

	public virtual BaseInventoryCommand ToBaseInventoryCommand(string ownerId) { }

	public virtual InventoryOperationDescriptor ToDescriptor() { }

	public virtual string ToString() { }

}

