namespace EFT.HandBook;

public sealed class HandbookCategoriesPanel : BrowseCategoriesPanel
{
	[CompilerGenerated]
	private struct <<Awake>b__2_0>d : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public HandbookCategoriesPanel <>4__this; //Field offset: 0x28
		public string arg; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass3_0
	{
		public HandbookCategoriesPanel <>4__this; //Field offset: 0x10
		public List questItems; //Field offset: 0x18

		public <>c__DisplayClass3_0() { }

		internal Transform <Show>b__1(HandbookNode arg) { }

		internal void <Show>b__2(HandbookNode item, CombinedView view) { }

		internal CombinedView <Show>g__GetCombinedView|0(HandbookNode node) { }

	}

	[CompilerGenerated]
	private struct <Show>d__3 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public HandbookCategoriesPanel <>4__this; //Field offset: 0x20
		public List questItems; //Field offset: 0x28
		public RagFair ragfair; //Field offset: 0x30
		public Handbook handbook; //Field offset: 0x38
		public HandbookNodes nodes; //Field offset: 0x40
		public HandbookNodes filteredNodes; //Field offset: 0x48
		public ItemUiContext itemUiContext; //Field offset: 0x50
		public Action onSelection; //Field offset: 0x58
		public Profile profile; //Field offset: 0x60

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[SerializeField]
	private EntitiesPanel _entitiesPanel; //Field offset: 0x108
	[SerializeField]
	protected CombinedView WishlistCombinedCategoryView; //Field offset: 0x110

	public HandbookCategoriesPanel() { }

	[AsyncStateMachine(typeof(<<Awake>b__2_0>d))]
	[CompilerGenerated]
	private void <Awake>b__2_0(string arg) { }

	protected virtual void Awake() { }

	public virtual void Close() { }

	protected virtual void FilterHandler() { }

	public void SelectItemNode(string itemId) { }

	[AsyncStateMachine(typeof(<Show>d__3))]
	public Task Show(RagFair ragfair, Handbook handbook, HandbookNodes nodes, HandbookNodes filteredNodes, ItemUiContext itemUiContext, List questItems, Action onSelection, Profile profile) { }

	public void ShowNode(NodeBaseView categoryNode, string id) { }

}

