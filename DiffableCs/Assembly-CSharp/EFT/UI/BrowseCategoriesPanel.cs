namespace EFT.UI;

public class BrowseCategoriesPanel : UIElement
{
	[CompilerGenerated]
	private struct <<Awake>b__53_0>d : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public BrowseCategoriesPanel <>4__this; //Field offset: 0x28
		public string arg; //Field offset: 0x30
		private TaskAwaiter <>u__1; //Field offset: 0x38

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__56_0; //Field offset: 0x8
		public static Func <>9__56_2; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal bool <GetNodeRecursively>b__56_0(NodeBaseView nodeView) { }

		internal IEnumerable <GetNodeRecursively>b__56_2(HandbookNode y) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass56_0
	{
		public string id; //Field offset: 0x10
		public Func <>9__3; //Field offset: 0x18

		public <>c__DisplayClass56_0() { }

		internal bool <GetNodeRecursively>b__1(NodeBaseView nodeView) { }

		internal bool <GetNodeRecursively>b__3(HandbookNode childNode) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass58_0
	{
		public BrowseCategoriesPanel <>4__this; //Field offset: 0x10
		public bool searchCanceled; //Field offset: 0x18
		public SearchQuery query; //Field offset: 0x20
		public Func <>9__3; //Field offset: 0x38

		public <>c__DisplayClass58_0() { }

		internal bool <Filter>b__1(HandbookNode x) { }

		internal HandbookNode <Filter>b__2(HandbookNode x) { }

		internal bool <Filter>b__3(HandbookNode node) { }

		internal void <Filter>g__CancelSearch|0() { }

	}

	[CompilerGenerated]
	private struct <Filter>d__58 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public BrowseCategoriesPanel <>4__this; //Field offset: 0x20
		public string value; //Field offset: 0x28
		private <>c__DisplayClass58_0 <>8__1; //Field offset: 0x30
		private int <counter>5__2; //Field offset: 0x38
		private TaskAwaiter <>u__1; //Field offset: 0x40
		private IEnumerator <>7__wrap2; //Field offset: 0x48
		private YieldAwaiter <>u__2; //Field offset: 0x50

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	protected const string QUEST_CATEGORY_ID = "5b619f1a86f77450a702a6f3"; //Field offset: 0x0
	private const int MINIMUM_SEARCH_THRESHOLD = 3; //Field offset: 0x0
	private const float ANTISPAM_FILTER = 1; //Field offset: 0x0
	private const int SEARCH_BATCH_SIZE = 10; //Field offset: 0x0
	[SerializeField]
	protected TMP_InputField SearchInputField; //Field offset: 0x70
	[SerializeField]
	protected CombinedView CombinedCategoryView; //Field offset: 0x78
	[SerializeField]
	protected RectTransform CategoryViewsContainer; //Field offset: 0x80
	[SerializeField]
	private GameObject _loader; //Field offset: 0x88
	[SerializeField]
	private GameObject _searchIcon; //Field offset: 0x90
	[CompilerGenerated]
	private Action _onSearchCancelled; //Field offset: 0x98
	[CompilerGenerated]
	private Action OnFiltered; //Field offset: 0xA0
	[CompilerGenerated]
	private HandbookNodes <FilteredNodes>k__BackingField; //Field offset: 0xA8
	[CompilerGenerated]
	private SimpleContextMenu <ContextMenu>k__BackingField; //Field offset: 0xB0
	[CompilerGenerated]
	private RagFair <Ragfair>k__BackingField; //Field offset: 0xB8
	[CompilerGenerated]
	private Handbook <Handbook>k__BackingField; //Field offset: 0xC0
	[CompilerGenerated]
	private HandbookNodes <Nodes>k__BackingField; //Field offset: 0xC8
	[CompilerGenerated]
	private EViewListType <ViewListType>k__BackingField; //Field offset: 0xD0
	[CompilerGenerated]
	private EWindowType <WindowType>k__BackingField; //Field offset: 0xD4
	protected readonly Dictionary ViewNodes; //Field offset: 0xD8
	protected BindableAsyncViewList ViewList; //Field offset: 0xE0
	protected Action OnSelection; //Field offset: 0xE8
	private bool _clearedAlready; //Field offset: 0xF0
	private string _previousFilter; //Field offset: 0xF8
	private bool _loading; //Field offset: 0x100

	private event Action _onSearchCancelled
	{
		[CompilerGenerated]
		private add { } //Length: 251
		[CompilerGenerated]
		private remove { } //Length: 251
	}

	public event Action OnFiltered
	{
		[CompilerGenerated]
		 add { } //Length: 251
		[CompilerGenerated]
		 remove { } //Length: 251
	}

	protected private SimpleContextMenu ContextMenu
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	protected override bool DisplayLoadingStatus
	{
		 get { } //Length: 3
	}

	protected private HandbookNodes FilteredNodes
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	protected override string FilterString
	{
		 get { } //Length: 59
	}

	protected private Handbook Handbook
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	private HandbookNodes Nodes
	{
		[CompilerGenerated]
		private get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	protected private RagFair Ragfair
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		private set { } //Length: 82
	}

	private EViewListType ViewListType
	{
		[CompilerGenerated]
		private get { } //Length: 7
		[CompilerGenerated]
		private set { } //Length: 7
	}

	public EWindowType WindowType
	{
		[CompilerGenerated]
		 get { } //Length: 7
		[CompilerGenerated]
		 set { } //Length: 7
	}

	public BrowseCategoriesPanel() { }

	[AsyncStateMachine(typeof(<<Awake>b__53_0>d))]
	[CompilerGenerated]
	private void <Awake>b__53_0(string arg) { }

	[CompilerGenerated]
	private void add__onSearchCancelled(Action value) { }

	[CompilerGenerated]
	public void add_OnFiltered(Action value) { }

	protected override bool Allowed(HandbookNode node) { }

	protected override void Awake() { }

	public virtual void Close() { }

	[AsyncStateMachine(typeof(<Filter>d__58))]
	protected Task Filter(string value) { }

	protected override void FilterHandler() { }

	[CompilerGenerated]
	protected SimpleContextMenu get_ContextMenu() { }

	protected override bool get_DisplayLoadingStatus() { }

	[CompilerGenerated]
	protected HandbookNodes get_FilteredNodes() { }

	protected override string get_FilterString() { }

	[CompilerGenerated]
	protected Handbook get_Handbook() { }

	[CompilerGenerated]
	private HandbookNodes get_Nodes() { }

	[CompilerGenerated]
	protected RagFair get_Ragfair() { }

	[CompilerGenerated]
	private EViewListType get_ViewListType() { }

	[CompilerGenerated]
	public EWindowType get_WindowType() { }

	[CanBeNull]
	protected NodeBaseView GetNode(string id) { }

	[CanBeNull]
	private NodeBaseView GetNodeRecursively(string id, IEnumerable selection) { }

	[CompilerGenerated]
	private void remove__onSearchCancelled(Action value) { }

	[CompilerGenerated]
	public void remove_OnFiltered(Action value) { }

	[CanBeNull]
	public NodeBaseView SelectNode(string id) { }

	[CompilerGenerated]
	private void set_ContextMenu(SimpleContextMenu value) { }

	[CompilerGenerated]
	private void set_FilteredNodes(HandbookNodes value) { }

	[CompilerGenerated]
	private void set_Handbook(Handbook value) { }

	[CompilerGenerated]
	private void set_Nodes(HandbookNodes value) { }

	[CompilerGenerated]
	private void set_Ragfair(RagFair value) { }

	[CompilerGenerated]
	private void set_ViewListType(EViewListType value) { }

	[CompilerGenerated]
	public void set_WindowType(EWindowType value) { }

	private void SetLoadingProcess(bool status) { }

	protected void Show(RagFair ragfair, Handbook handbook, HandbookNodes nodes, HandbookNodes filteredNodes, SimpleContextMenu contextMenu, EViewListType viewListType, EWindowType windowType, Action onSelection) { }

}

