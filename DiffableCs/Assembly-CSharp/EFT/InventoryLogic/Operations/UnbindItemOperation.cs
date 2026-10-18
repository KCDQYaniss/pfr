namespace EFT.InventoryLogic.Operations;

public sealed class UnbindItemOperation : AbstractAsyncOperation
{
	[CompilerGenerated]
	private struct <ExecuteInternal>d__6 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public UnbindItemOperation <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	internal sealed class UnbindCommand : CommandWithOwner
	{
		[JsonProperty("Action")]
		public string Action; //Field offset: 0x18
		[JsonProperty("item")]
		public string Item; //Field offset: 0x20
		[JsonProperty("index")]
		public EBoundItem Index; //Field offset: 0x28

		public UnbindCommand() { }

	}

	private readonly InventoryController _inventoryController; //Field offset: 0x68
	private readonly Item _item; //Field offset: 0x70
	private readonly EBoundItem _index; //Field offset: 0x78
	private readonly ItemAddress _from; //Field offset: 0x80
	private readonly bool _removeFromHands; //Field offset: 0x88

	public UnbindItemOperation(ushort id, InventoryController controller, UnbindResult simulatedResult, bool removeFromHands = true) { }

	[AsyncStateMachine(typeof(<ExecuteInternal>d__6))]
	protected virtual Task ExecuteInternal() { }

	public virtual BaseInventoryCommand ToBaseInventoryCommand(string ownerId) { }

	public virtual InventoryOperationDescriptor ToDescriptor() { }

}

