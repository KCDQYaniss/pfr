namespace EFT.ProfileEditor;

public sealed class ProfileEditorItemsSearcher
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass18_0
	{
		public ProfileEditorItemsSearcher <>4__this; //Field offset: 0x10
		public string searchLower; //Field offset: 0x18
		public CancellationToken token; //Field offset: 0x20
		public Func <>9__1; //Field offset: 0x28

		public <>c__DisplayClass18_0() { }

		internal void <Search>b__0() { }

		internal bool <Search>b__1(Item x) { }

	}

	[CompilerGenerated]
	private struct <Search>d__18 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public ProfileEditorItemsSearcher <>4__this; //Field offset: 0x20
		public string searchText; //Field offset: 0x28
		private bool <success>5__2; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private Action SearchStopped; //Field offset: 0x10
	[CompilerGenerated]
	private Action SearchComplete; //Field offset: 0x18
	private readonly GameObject _loader; //Field offset: 0x20
	private CancellationTokenSource _cancellationSource; //Field offset: 0x28
	private readonly List _allItems; //Field offset: 0x30
	private readonly Stash _stash; //Field offset: 0x38
	private bool _isSearching; //Field offset: 0x40
	[CompilerGenerated]
	private bool <IsSearchActive>k__BackingField; //Field offset: 0x41

	public event Action SearchComplete
	{
		[CompilerGenerated]
		 add { } //Length: 262
		[CompilerGenerated]
		 remove { } //Length: 262
	}

	public event Action SearchStopped
	{
		[CompilerGenerated]
		 add { } //Length: 235
		[CompilerGenerated]
		 remove { } //Length: 235
	}

	public private bool IsSearchActive
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 4
	}

	private bool IsSearching
	{
		private set { } //Length: 114
	}

	public ProfileEditorItemsSearcher(ItemFactory itemFactory, GameObject loader) { }

	[CompilerGenerated]
	public void add_SearchComplete(Action value) { }

	[CompilerGenerated]
	public void add_SearchStopped(Action value) { }

	[CompilerGenerated]
	public bool get_IsSearchActive() { }

	[CompilerGenerated]
	public void remove_SearchComplete(Action value) { }

	[CompilerGenerated]
	public void remove_SearchStopped(Action value) { }

	[AsyncStateMachine(typeof(<Search>d__18))]
	public Task Search(string searchText) { }

	[CompilerGenerated]
	private void set_IsSearchActive(bool value) { }

	private void set_IsSearching(bool value) { }

	public void Stop(bool silent = false) { }

}

