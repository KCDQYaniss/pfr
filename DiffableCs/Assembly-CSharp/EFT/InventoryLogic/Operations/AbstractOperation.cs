namespace EFT.InventoryLogic.Operations;

public abstract class AbstractOperation : IInventoryOperation, IOperationInfo
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass18_0
	{
		public AbstractOperation <>4__this; //Field offset: 0x10
		public Callback callback; //Field offset: 0x18

		public <>c__DisplayClass18_0() { }

		internal void <ExecuteWithoutDispose>g__CallbackInMainThread|0(IResult result) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass18_1
	{
		public IResult result; //Field offset: 0x10
		public <>c__DisplayClass18_0 CS$<>8__locals1; //Field offset: 0x18

		public <>c__DisplayClass18_1() { }

		internal void <ExecuteWithoutDispose>b__1() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass19_0
	{
		public AbstractOperation <>4__this; //Field offset: 0x10
		public Callback callback; //Field offset: 0x18

		public <>c__DisplayClass19_0() { }

		internal void <Execute>b__0(IResult result) { }

	}

	[CompilerGenerated]
	private sealed class <get_Items>d__21 : IEnumerable, IEnumerable, IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private Item <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x20
		public AbstractOperation <>4__this; //Field offset: 0x28
		private AbstractOperation <operation>5__2; //Field offset: 0x30
		private IEnumerator <>7__wrap2; //Field offset: 0x38

		private override Item System.Collections.Generic.IEnumerator<EFT.InventoryLogic.Item>.Current
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
		public <get_Items>d__21(int <>1__state) { }

		private void <>m__Finally1() { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.Generic.IEnumerable<EFT.InventoryLogic.Item>.GetEnumerator() { }

		[DebuggerHidden]
		private override Item System.Collections.Generic.IEnumerator<EFT.InventoryLogic.Item>.get_Current() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	private readonly ushort <Id>k__BackingField; //Field offset: 0x10
	protected readonly ItemController Controller; //Field offset: 0x18
	[CompilerGenerated]
	private EOperationStatus <Status>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private readonly MongoID <OwnerId>k__BackingField; //Field offset: 0x28

	public override bool BlockHands
	{
		 get { } //Length: 3
	}

	protected CommandStatus DisposeEventStatus
	{
		 get { } //Length: 206
	}

	private override ushort EFT.IOperationInfo.OperationId
	{
		private get { } //Length: 5
	}

	public ushort Id
	{
		[CompilerGenerated]
		 get { } //Length: 5
	}

	private IEnumerable Items
	{
		[IteratorStateMachine(typeof(<get_Items>d__21))]
		private get { } //Length: 175
	}

	public override MongoID OwnerId
	{
		[CompilerGenerated]
		 get { } //Length: 21
	}

	public private EOperationStatus Status
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		private set { } //Length: 4
	}

	protected AbstractOperation(ushort id, ItemController controller) { }

	public override IResult CanExecute() { }

	[CanBeNull]
	protected static OwnerInfo ConvertOwner(IItemOwner from, string mainProfile) { }

	[CanBeNull]
	private static OwnerInfo CreateOwner(string visitorId, EOwnerType visitorType, string mainProfile) { }

	public abstract void Dispose() { }

	private override ushort EFT.IOperationInfo.get_OperationId() { }

	internal void Execute(Callback callback) { }

	protected abstract void ExecuteInternal(Callback callback) { }

	internal void ExecuteWithoutDispose(Callback callback) { }

	protected static FullItemLocation FromItemAddress(ItemAddress itemAddress) { }

	public override bool get_BlockHands() { }

	protected CommandStatus get_DisposeEventStatus() { }

	[CompilerGenerated]
	public ushort get_Id() { }

	[IteratorStateMachine(typeof(<get_Items>d__21))]
	private IEnumerable get_Items() { }

	[CompilerGenerated]
	public override MongoID get_OwnerId() { }

	[CompilerGenerated]
	public EOperationStatus get_Status() { }

	protected static IItemOwner GetRealOwner(ItemAddress itemAddress, ItemAddress originalAddress) { }

	[CanBeNull]
	protected OwnerInfo OwnerInfoFromOperationOwner(string mainProfile) { }

	[CompilerGenerated]
	private void set_Status(EOperationStatus value) { }

	public abstract BaseInventoryCommand ToBaseInventoryCommand(string ownerId) { }

	public override IEnumerable ToBaseInventoryCommands(string ownerId) { }

	public abstract InventoryOperationDescriptor ToDescriptor() { }

	public virtual string ToString() { }

	public bool WaitingForForeignEvents() { }

}

