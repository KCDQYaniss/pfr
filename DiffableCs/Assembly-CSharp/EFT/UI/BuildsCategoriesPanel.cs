namespace EFT.UI;

public sealed class BuildsCategoriesPanel : BrowseCategoriesPanel
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass1_0
	{
		public BuildsCategoriesPanel <>4__this; //Field offset: 0x10
		public EViewListType viewListType; //Field offset: 0x18
		public EWindowType windowType; //Field offset: 0x1C
		public Action onConfirmedSelection; //Field offset: 0x20
		public string initialNodeId; //Field offset: 0x28

		public <>c__DisplayClass1_0() { }

		internal CombinedView <Show>b__0(HandbookNode arg) { }

		internal Transform <Show>b__1(HandbookNode arg) { }

		internal void <Show>b__2(HandbookNode node, CombinedView view) { }

	}

	[CompilerGenerated]
	private struct <Show>d__1 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public BuildsCategoriesPanel <>4__this; //Field offset: 0x20
		public EViewListType viewListType; //Field offset: 0x28
		public EWindowType windowType; //Field offset: 0x2C
		public Action onConfirmedSelection; //Field offset: 0x30
		public string initialNodeId; //Field offset: 0x38
		public RagFair ragfair; //Field offset: 0x40
		public Handbook handbook; //Field offset: 0x48
		public HandbookNodes nodes; //Field offset: 0x50
		public HandbookNodes filteredNodes; //Field offset: 0x58
		public SimpleContextMenu contextMenu; //Field offset: 0x60
		public Action onSelection; //Field offset: 0x68
		private TaskAwaiter <>u__1; //Field offset: 0x70

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[SerializeField]
	private ScrollRectNoDrag _scrollRect; //Field offset: 0x108

	public BuildsCategoriesPanel() { }

	[AsyncStateMachine(typeof(<Show>d__1))]
	public Task Show(RagFair ragfair, Handbook handbook, HandbookNodes nodes, HandbookNodes filteredNodes, SimpleContextMenu contextMenu, EViewListType viewListType, EWindowType windowType, string initialNodeId, Action onSelection, Action onConfirmedSelection) { }

}

