namespace EFT.InventoryLogic.Operations;

public sealed class FoldOperation : AbstractAsyncOperation, IOneItemOperation, IInventoryOperation, IObservedOperation, IOperationInfo
{
	[CompilerGenerated]
	private struct <ExecuteInternal>d__15 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public FoldOperation <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	internal sealed class FoldCommand : CommandWithOwner
	{
		[JsonProperty("Action")]
		public string Action; //Field offset: 0x18
		[JsonProperty("item")]
		public string Item; //Field offset: 0x20
		[JsonProperty("value")]
		public bool Value; //Field offset: 0x28

		public FoldCommand() { }

	}

	[CompilerGenerated]
	private readonly FoldableComponent <Foldable>k__BackingField; //Field offset: 0x68
	[CompilerGenerated]
	private readonly bool <NewValue>k__BackingField; //Field offset: 0x70
	private readonly ItemAddress _from; //Field offset: 0x78
	private readonly Item _item; //Field offset: 0x80

	private override ItemAddress EFT.InventoryLogic.Operations.IOneItemOperation.From1
	{
		private get { } //Length: 5
	}

	private override Item EFT.InventoryLogic.Operations.IOneItemOperation.Item1
	{
		private get { } //Length: 8
	}

	private override ItemAddress EFT.InventoryLogic.Operations.IOneItemOperation.To1
	{
		private get { } //Length: 5
	}

	public FoldableComponent Foldable
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	public bool NewValue
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	internal FoldOperation(ushort id, ItemController controller, FoldResult foldResult) { }

	private override ItemAddress EFT.InventoryLogic.Operations.IOneItemOperation.get_From1() { }

	private override Item EFT.InventoryLogic.Operations.IOneItemOperation.get_Item1() { }

	private override ItemAddress EFT.InventoryLogic.Operations.IOneItemOperation.get_To1() { }

	[AsyncStateMachine(typeof(<ExecuteInternal>d__15))]
	protected virtual Task ExecuteInternal() { }

	[CompilerGenerated]
	public FoldableComponent get_Foldable() { }

	[CompilerGenerated]
	public bool get_NewValue() { }

	public virtual BaseInventoryCommand ToBaseInventoryCommand(string ownerId) { }

	public virtual InventoryOperationDescriptor ToDescriptor() { }

	public virtual string ToString() { }

}

