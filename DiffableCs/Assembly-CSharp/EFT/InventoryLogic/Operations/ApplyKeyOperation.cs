namespace EFT.InventoryLogic.Operations;

public sealed class ApplyKeyOperation : AbstractAsyncOperation
{
	[CompilerGenerated]
	private struct <ExecuteInternal>d__5 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ApplyKeyOperation <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	internal sealed class ApplyCommand : CommandWithOwners
	{
		[JsonProperty("Action")]
		public string Action; //Field offset: 0x20
		[JsonProperty("item")]
		public string Item; //Field offset: 0x28
		[JsonProperty("target")]
		public string Target; //Field offset: 0x30

		public ApplyCommand() { }

	}

	private readonly KeyComponent _key; //Field offset: 0x68
	private readonly ItemAddress _from; //Field offset: 0x70
	private readonly LockableComponent _lockable; //Field offset: 0x78
	private readonly ItemAddress _to; //Field offset: 0x80

	internal ApplyKeyOperation(ushort id, ItemController controller, ApplyKeyResult applyKeyResult) { }

	[AsyncStateMachine(typeof(<ExecuteInternal>d__5))]
	protected virtual Task ExecuteInternal() { }

	public virtual BaseInventoryCommand ToBaseInventoryCommand(string ownerId) { }

	public virtual InventoryOperationDescriptor ToDescriptor() { }

}

