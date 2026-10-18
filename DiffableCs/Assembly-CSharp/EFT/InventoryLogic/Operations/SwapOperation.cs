namespace EFT.InventoryLogic.Operations;

public sealed class SwapOperation : PossibleDestroyOperation, ITwoItemOperation, IOneItemOperation, IInventoryOperation
{
	[CompilerGenerated]
	private struct <ExecuteInternal>d__25 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public SwapOperation <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	internal sealed class SwapCommand : CommandWithOwners
	{
		[JsonProperty("Action")]
		public string Action; //Field offset: 0x20
		[JsonProperty("item")]
		public string Item; //Field offset: 0x28
		[JsonProperty("to")]
		public FullItemLocation To; //Field offset: 0x30
		[JsonProperty("item2")]
		public string Item2; //Field offset: 0x38
		[JsonProperty("to2")]
		public FullItemLocation To2; //Field offset: 0x40
		[JsonProperty("fromOwner2", NullValueHandling = NullValueHandling::Ignore (1))]
		public OwnerInfo FromOwner2; //Field offset: 0x48
		[JsonProperty("toOwner2", NullValueHandling = NullValueHandling::Ignore (1))]
		public OwnerInfo ToOwner2; //Field offset: 0x50

		public SwapCommand() { }

	}

	private readonly ItemAddress _to; //Field offset: 0x78
	private readonly Item _item2; //Field offset: 0x80
	private readonly ItemAddress _from2; //Field offset: 0x88
	private readonly ItemAddress _to2; //Field offset: 0x90
	[CompilerGenerated]
	private readonly Item <Item>k__BackingField; //Field offset: 0x98
	[CompilerGenerated]
	private readonly ItemAddress <From>k__BackingField; //Field offset: 0xA0

	protected virtual bool DestroysMainItem
	{
		 get { } //Length: 3
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
		private get { } //Length: 5
	}

	private override ItemAddress EFT.InventoryLogic.Operations.ITwoItemOperation.From2
	{
		private get { } //Length: 8
	}

	private override Item EFT.InventoryLogic.Operations.ITwoItemOperation.Item2
	{
		private get { } //Length: 8
	}

	private override ItemAddress EFT.InventoryLogic.Operations.ITwoItemOperation.To2
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
		 get { } //Length: 8
	}

	internal SwapOperation(ushort id, ItemController controller, SwapResult swapResult, IEnumerable itemsToDestroy) { }

	private override ItemAddress EFT.InventoryLogic.Operations.IOneItemOperation.get_From1() { }

	private override Item EFT.InventoryLogic.Operations.IOneItemOperation.get_Item1() { }

	private override ItemAddress EFT.InventoryLogic.Operations.IOneItemOperation.get_To1() { }

	private override ItemAddress EFT.InventoryLogic.Operations.ITwoItemOperation.get_From2() { }

	private override Item EFT.InventoryLogic.Operations.ITwoItemOperation.get_Item2() { }

	private override ItemAddress EFT.InventoryLogic.Operations.ITwoItemOperation.get_To2() { }

	[AsyncStateMachine(typeof(<ExecuteInternal>d__25))]
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

