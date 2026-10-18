namespace EFT.InventoryLogic.Operations;

public sealed class SetDialogProgressOperation : AbstractAsyncOperation
{
	[CompilerGenerated]
	private struct <ExecuteInternal>d__19 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public SetDialogProgressOperation <>4__this; //Field offset: 0x20
		private IResult <result>5__2; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30
		private TaskAwaiter <>u__2; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private sealed class <ToBaseInventoryCommands>d__24 : IEnumerable, IEnumerable, IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private BaseInventoryCommand <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x20
		public SetDialogProgressOperation <>4__this; //Field offset: 0x28
		private string ownerId; //Field offset: 0x30
		public string <>3__ownerId; //Field offset: 0x38

		private override BaseInventoryCommand System.Collections.Generic.IEnumerator<EFT.InventoryLogic.Operations.BaseInventoryCommand>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 5
		}

		[DebuggerHidden]
		public <ToBaseInventoryCommands>d__24(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.Generic.IEnumerable<EFT.InventoryLogic.Operations.BaseInventoryCommand>.GetEnumerator() { }

		[DebuggerHidden]
		private override BaseInventoryCommand System.Collections.Generic.IEnumerator<EFT.InventoryLogic.Operations.BaseInventoryCommand>.get_Current() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	internal sealed class DialogProgressInventoryCommand : BaseInventoryCommand
	{
		[IsReadOnly]
		internal struct DialogProgressBackendData
		{
			[JsonProperty("traderId")]
			public readonly MongoID TraderId; //Field offset: 0x0
			[JsonProperty("dialogueId")]
			public readonly MongoID DialogId; //Field offset: 0x18
			[JsonProperty("nodeId")]
			public readonly MongoID NodeId; //Field offset: 0x30

			public DialogProgressBackendData(MongoID traderId, MongoID dialogId, MongoID nodeId) { }

		}

		[JsonProperty("Action")]
		public string Action; //Field offset: 0x10
		[CompilerGenerated]
		private readonly bool <Queued>k__BackingField; //Field offset: 0x18
		private readonly List _dialogProgress; //Field offset: 0x20

		[JsonProperty("nodePathTraveled")]
		private IReadOnlyList DialogProgress
		{
			private get { } //Length: 5
		}

		public virtual bool Queued
		{
			[CompilerGenerated]
			 get { } //Length: 5
		}

		public DialogProgressInventoryCommand(MongoID traderId, MongoID dialogId, MongoID nodeId, bool queued) { }

		public DialogProgressInventoryCommand() { }

		public void Append(DialogProgressInventoryCommand command) { }

		private IReadOnlyList get_DialogProgress() { }

		[CompilerGenerated]
		public virtual bool get_Queued() { }

	}

	[CompilerGenerated]
	private readonly MongoID <TraderId>k__BackingField; //Field offset: 0x68
	[CompilerGenerated]
	private readonly MongoID <DialogId>k__BackingField; //Field offset: 0x80
	[CompilerGenerated]
	private readonly MongoID <LineId>k__BackingField; //Field offset: 0x98
	[CompilerGenerated]
	private readonly Nullable <EmbeddedDialogId>k__BackingField; //Field offset: 0xB0
	[CompilerGenerated]
	private readonly bool <Queued>k__BackingField; //Field offset: 0xD0
	[CompilerGenerated]
	private readonly IDialogLineActionResult <DialogLineActionResult>k__BackingField; //Field offset: 0xD8

	public MongoID DialogId
	{
		[CompilerGenerated]
		 get { } //Length: 27
	}

	public IDialogLineActionResult DialogLineActionResult
	{
		[CompilerGenerated]
		 get { } //Length: 8
	}

	private Nullable EmbeddedDialogId
	{
		[CompilerGenerated]
		private get { } //Length: 25
	}

	public MongoID LineId
	{
		[CompilerGenerated]
		 get { } //Length: 27
	}

	private bool Queued
	{
		[CompilerGenerated]
		private get { } //Length: 8
	}

	public MongoID TraderId
	{
		[CompilerGenerated]
		 get { } //Length: 21
	}

	internal SetDialogProgressOperation(ushort id, ItemController controller, SetDialogProgressResult setDialogProgressResult) { }

	[AsyncStateMachine(typeof(<ExecuteInternal>d__19))]
	protected virtual Task ExecuteInternal() { }

	[CompilerGenerated]
	public MongoID get_DialogId() { }

	[CompilerGenerated]
	public IDialogLineActionResult get_DialogLineActionResult() { }

	[CompilerGenerated]
	private Nullable get_EmbeddedDialogId() { }

	[CompilerGenerated]
	public MongoID get_LineId() { }

	[CompilerGenerated]
	private bool get_Queued() { }

	[CompilerGenerated]
	public MongoID get_TraderId() { }

	public virtual BaseInventoryCommand ToBaseInventoryCommand(string ownerId) { }

	[IteratorStateMachine(typeof(<ToBaseInventoryCommands>d__24))]
	public virtual IEnumerable ToBaseInventoryCommands(string ownerId) { }

	public virtual InventoryOperationDescriptor ToDescriptor() { }

	public virtual string ToString() { }

}

