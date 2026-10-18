namespace EFT.InventoryLogic.Operations;

public sealed class RecodeOperation : AbstractAsyncOperation
{
	[CompilerGenerated]
	private struct <ExecuteInternal>d__4 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public RecodeOperation <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	internal sealed class RecodeCommand : CommandWithOwner
	{
		[JsonProperty("Action")]
		public string Action; //Field offset: 0x18
		[JsonProperty("item")]
		public string Item; //Field offset: 0x20
		[JsonProperty("value")]
		public bool Value; //Field offset: 0x28

		public RecodeCommand() { }

	}

	private readonly RecodableComponent _recodable; //Field offset: 0x68
	private readonly ItemAddress _from; //Field offset: 0x70
	private readonly bool _newValue; //Field offset: 0x78

	internal RecodeOperation(ushort id, ItemController controller, RecodeResult recodeResult) { }

	[AsyncStateMachine(typeof(<ExecuteInternal>d__4))]
	protected virtual Task ExecuteInternal() { }

	public virtual BaseInventoryCommand ToBaseInventoryCommand(string ownerId) { }

	public virtual InventoryOperationDescriptor ToDescriptor() { }

	public virtual string ToString() { }

}

