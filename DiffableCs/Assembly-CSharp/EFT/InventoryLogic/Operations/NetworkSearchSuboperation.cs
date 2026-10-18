namespace EFT.InventoryLogic.Operations;

public sealed class NetworkSearchSuboperation : AbstractOperation
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
	private sealed class <>c__DisplayClass8_0
	{
		public Callback callback; //Field offset: 0x10

		public <>c__DisplayClass8_0() { }

		internal void <ExecuteInternal>b__0(Task task) { }

	}

	[CompilerGenerated]
	private struct <>c__DisplayClass9_0
	{
		public IResult result; //Field offset: 0x0
		public NetworkSearchSuboperation <>4__this; //Field offset: 0x8

	}

	[CompilerGenerated]
	private struct <ExecuteInternal>d__9 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public NetworkSearchSuboperation <>4__this; //Field offset: 0x20
		private <>c__DisplayClass9_0 <>8__1; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private static readonly ItemsCount[] EmptyDestroyedItems; //Field offset: 0x0
	[CanBeNull]
	private readonly SearchableItem _searchedItem; //Field offset: 0x40
	[CanBeNull]
	private readonly IReadOnlyDictionary _content; //Field offset: 0x48
	[CanBeNull]
	private readonly IReadOnlyCollection _oldItems; //Field offset: 0x50
	private readonly bool _instant; //Field offset: 0x58
	private readonly IPlayerSearchController _searchController; //Field offset: 0x60
	private List _operationResults; //Field offset: 0x68

	private static NetworkSearchSuboperation() { }

	public NetworkSearchSuboperation(ushort id, SearchableItem searchedItem, IReadOnlyDictionary content, IReadOnlyCollection oldItems, bool instant, IPlayerSearchController searchController, ItemController controller) { }

	[CompilerGenerated]
	private IResult <ExecuteInternal>g__TryAddOperationResult|9_0(OperationResult operationResult, ref <>c__DisplayClass9_0 unnamed_param_1) { }

	public virtual void Dispose() { }

	protected virtual void ExecuteInternal(Callback callback) { }

	[AsyncStateMachine(typeof(<ExecuteInternal>d__9))]
	private Task ExecuteInternal() { }

	private static Task LoadBundles(Item item) { }

	public virtual BaseInventoryCommand ToBaseInventoryCommand(string ownerId) { }

	public virtual InventoryOperationDescriptor ToDescriptor() { }

}

