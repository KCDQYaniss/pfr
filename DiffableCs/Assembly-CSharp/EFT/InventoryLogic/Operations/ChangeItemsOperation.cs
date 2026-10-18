namespace EFT.InventoryLogic.Operations;

public sealed class ChangeItemsOperation : AbstractOperation, IMultipleItemsOperation, IInventoryOperation
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__13_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal IEnumerable <LoadBundles>b__13_0(Item x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass11_0
	{
		public Callback callback; //Field offset: 0x10

		public <>c__DisplayClass11_0() { }

		internal void <ExecuteInternal>b__0(Task task) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass12_0
	{
		private struct <<ExecuteInternal>g__InProcess|1>d : IAsyncStateMachine
		{
			public int <>1__state; //Field offset: 0x0
			public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
			public <>c__DisplayClass12_0 <>4__this; //Field offset: 0x20
			public Item item; //Field offset: 0x28
			public ItemAddress to; //Field offset: 0x30
			private TaskAwaiter <>u__1; //Field offset: 0x38

			private override void MoveNext() { }

			[DebuggerHidden]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}

		private struct <<ExecuteInternal>g__OutProcess|0>d : IAsyncStateMachine
		{
			public int <>1__state; //Field offset: 0x0
			public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
			public <>c__DisplayClass12_0 <>4__this; //Field offset: 0x20
			public Item item; //Field offset: 0x28
			private TaskAwaiter <>u__1; //Field offset: 0x30

			private override void MoveNext() { }

			[DebuggerHidden]
			private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

		}

		public ChangeItemsOperation <>4__this; //Field offset: 0x10
		public IResult result; //Field offset: 0x18

		public <>c__DisplayClass12_0() { }

		[AsyncStateMachine(typeof(<<ExecuteInternal>g__InProcess|1>d))]
		internal Task <ExecuteInternal>g__InProcess|1(Item item, ItemAddress to) { }

		[AsyncStateMachine(typeof(<<ExecuteInternal>g__OutProcess|0>d))]
		internal Task <ExecuteInternal>g__OutProcess|0(Item item) { }

		internal IResult <ExecuteInternal>g__TryAddOperationResult|2(OperationResult operationResult) { }

	}

	[CompilerGenerated]
	private sealed class <EFT-InventoryLogic-Operations-IMultipleItemsOperation-get_Items>d__9 : IEnumerable, IEnumerable, IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private Item <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x20
		public ChangeItemsOperation <>4__this; //Field offset: 0x28
		private IEnumerator <>7__wrap1; //Field offset: 0x30
		private IEnumerator <>7__wrap2; //Field offset: 0x38
		private IEnumerator <>7__wrap3; //Field offset: 0x40

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
		public <EFT-InventoryLogic-Operations-IMultipleItemsOperation-get_Items>d__9(int <>1__state) { }

		private void <>m__Finally1() { }

		private void <>m__Finally2() { }

		private void <>m__Finally3() { }

		private void <>m__Finally4() { }

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
	private struct <ExecuteInternal>d__12 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ChangeItemsOperation <>4__this; //Field offset: 0x20
		private <>c__DisplayClass12_0 <>8__1; //Field offset: 0x28
		private List <bundleTasks>5__2; //Field offset: 0x30
		private IEnumerator <>7__wrap2; //Field offset: 0x38
		private Item <removedItem>5__4; //Field offset: 0x40
		private TaskAwaiter <>u__1; //Field offset: 0x48
		private IEnumerator <>7__wrap4; //Field offset: 0x50
		private ItemAddress <address>5__6; //Field offset: 0x58
		private TaskAwaiter <>u__2; //Field offset: 0x60

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CanBeNull]
	private readonly IReadOnlyCollection _removedItems; //Field offset: 0x40
	[CanBeNull]
	private readonly IReadOnlyDictionary _newItems; //Field offset: 0x48
	[CanBeNull]
	private readonly IReadOnlyDictionary _movedItems; //Field offset: 0x50
	[CanBeNull]
	private readonly IReadOnlyDictionary _changedItems; //Field offset: 0x58
	private readonly IPlayer _player; //Field offset: 0x60
	private readonly InventoryOperationDescriptor _internalOperationDescriptor; //Field offset: 0x68
	private AbstractOperation _internalOperation; //Field offset: 0x70
	private List _operationResults; //Field offset: 0x78

	private override IEnumerable EFT.InventoryLogic.Operations.IMultipleItemsOperation.Items
	{
		[IteratorStateMachine(typeof(<EFT-InventoryLogic-Operations-IMultipleItemsOperation-get_Items>d__9))]
		private get { } //Length: 175
	}

	public ChangeItemsOperation(ushort operationId, IReadOnlyCollection removedItems, IReadOnlyDictionary newItems, IReadOnlyDictionary movedItems, IReadOnlyDictionary changedItems, InventoryOperationDescriptor internalOperationDescriptor, IPlayer player) { }

	public virtual void Dispose() { }

	[IteratorStateMachine(typeof(<EFT-InventoryLogic-Operations-IMultipleItemsOperation-get_Items>d__9))]
	private override IEnumerable EFT.InventoryLogic.Operations.IMultipleItemsOperation.get_Items() { }

	protected virtual void ExecuteInternal(Callback callback) { }

	[AsyncStateMachine(typeof(<ExecuteInternal>d__12))]
	private Task ExecuteInternal() { }

	private static Task LoadBundles(Item item) { }

	public virtual BaseInventoryCommand ToBaseInventoryCommand(string ownerId) { }

	public virtual InventoryOperationDescriptor ToDescriptor() { }

}

