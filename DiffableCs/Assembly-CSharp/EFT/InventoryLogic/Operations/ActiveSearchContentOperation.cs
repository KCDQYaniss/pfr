namespace EFT.InventoryLogic.Operations;

public abstract class ActiveSearchContentOperation : SearchContentOperation
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass9_0
	{
		public Callback callback; //Field offset: 0x10

		public <>c__DisplayClass9_0() { }

		internal void <ExecuteInternal>b__0(Task task) { }

	}

	[CompilerGenerated]
	private struct <ExecuteAsync>d__10 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ActiveSearchContentOperation <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <Open>d__11 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ActiveSearchContentOperation <>4__this; //Field offset: 0x20
		private TaskAwaiter <>u__1; //Field offset: 0x28

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <SearchContent>d__12 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ActiveSearchContentOperation <>4__this; //Field offset: 0x20
		private float <speed>5__2; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private const int ACCESS_SECONDS = 2; //Field offset: 0x0
	protected readonly bool Instant; //Field offset: 0x50
	private readonly Profile _profile; //Field offset: 0x58
	private readonly IPlayerSearchController _searchController; //Field offset: 0x60
	private readonly bool _firstSearch; //Field offset: 0x68
	private readonly CancellationTokenSource _cancellationToken; //Field offset: 0x70

	protected bool Terminated
	{
		 get { } //Length: 37
	}

	protected ActiveSearchContentOperation(ushort id, ItemController controller, IPlayerSearchController searchController, Profile profile, SearchableItem item) { }

	protected override void DiscoverItem(Item item) { }

	public virtual void Dispose() { }

	[AsyncStateMachine(typeof(<ExecuteAsync>d__10))]
	private Task ExecuteAsync() { }

	protected virtual void ExecuteInternal(Callback callback) { }

	protected bool get_Terminated() { }

	[AsyncStateMachine(typeof(<Open>d__11))]
	private Task Open() { }

	[AsyncStateMachine(typeof(<SearchContent>d__12))]
	private Task SearchContent() { }

	protected override void SearchItem() { }

	public virtual void Terminate() { }

	private bool TryFindUnknownItem(out Item unknownItem) { }

}

