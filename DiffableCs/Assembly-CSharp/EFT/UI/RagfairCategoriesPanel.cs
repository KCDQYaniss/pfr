namespace EFT.UI;

public sealed class RagfairCategoriesPanel : BrowseCategoriesPanel
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass6_0
	{
		public string buffer; //Field offset: 0x10
		public RagfairCategoriesPanel <>4__this; //Field offset: 0x18

		public <>c__DisplayClass6_0() { }

		internal void <Awake>b__1() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass7_0
	{
		public RagfairCategoriesPanel <>4__this; //Field offset: 0x10
		public EViewListType viewListType; //Field offset: 0x18
		public EWindowType windowType; //Field offset: 0x1C
		public string forbiddenItem; //Field offset: 0x20
		public Action onCreation; //Field offset: 0x28
		public HandbookNodes originalNodes; //Field offset: 0x30
		public RagFair ragfair; //Field offset: 0x38

		public <>c__DisplayClass7_0() { }

		internal CombinedView <Show>b__0(HandbookNode arg) { }

		internal Transform <Show>b__1(HandbookNode arg) { }

		internal void <Show>b__2(HandbookNode node, CombinedView view) { }

		internal void <Show>b__3() { }

		internal void <Show>b__4() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass7_1
	{
		public HandbookNode value; //Field offset: 0x10
		public <>c__DisplayClass7_0 CS$<>8__locals1; //Field offset: 0x18

		public <>c__DisplayClass7_1() { }

		internal void <Show>b__5() { }

	}

	[CompilerGenerated]
	private struct <FindById>d__17 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public string arg; //Field offset: 0x28
		public RagfairCategoriesPanel <>4__this; //Field offset: 0x30
		private YieldAwaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <Show>d__7 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public RagfairCategoriesPanel <>4__this; //Field offset: 0x20
		public EViewListType viewListType; //Field offset: 0x28
		public EWindowType windowType; //Field offset: 0x2C
		public string forbiddenItem; //Field offset: 0x30
		public Action onCreation; //Field offset: 0x38
		public HandbookNodes originalNodes; //Field offset: 0x40
		public RagFair ragfair; //Field offset: 0x48
		public Action onFindById; //Field offset: 0x50
		public Handbook handbook; //Field offset: 0x58
		public HandbookNodes nodes; //Field offset: 0x60
		public HandbookNodes filteredNodes; //Field offset: 0x68
		public SimpleContextMenu contextMenu; //Field offset: 0x70
		public Action onSelection; //Field offset: 0x78

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private Action _onFindById; //Field offset: 0x108
	private string _idToFind; //Field offset: 0x110

	protected virtual bool DisplayLoadingStatus
	{
		 get { } //Length: 3
	}

	protected virtual string FilterString
	{
		 get { } //Length: 148
	}

	public RagfairCategoriesPanel() { }

	[CompilerGenerated]
	private void <Awake>b__6_0(PointerEventData eventData) { }

	private void AllItemsRemovedHandler() { }

	protected virtual bool Allowed(HandbookNode node) { }

	protected virtual void Awake() { }

	private void CancellableFilterChangedHandler(CancellableFilter cancellableFilter) { }

	public void ClearIdFilter() { }

	public virtual void Close() { }

	[AsyncStateMachine(typeof(<FindById>d__17))]
	private void FindById(string arg) { }

	protected virtual bool get_DisplayLoadingStatus() { }

	protected virtual string get_FilterString() { }

	private void ItemAddedHandler(HandbookNode node) { }

	private void ItemRemovedHandler(HandbookNode node) { }

	private void NodesCountChangedHandler(HandbookNode node) { }

	private void OnViewListRemoveHandler(HandbookNode node) { }

	public void SetInputFieldText(string text) { }

	public void SetLoadingState(bool loading) { }

	[AsyncStateMachine(typeof(<Show>d__7))]
	public Task Show(string forbiddenItem, RagFair ragfair, Handbook handbook, HandbookNodes originalNodes, HandbookNodes nodes, HandbookNodes filteredNodes, SimpleContextMenu contextMenu, EViewListType viewListType, EWindowType windowType, Action onSelection, Action onCreation = null, Action onFindById = null) { }

}

