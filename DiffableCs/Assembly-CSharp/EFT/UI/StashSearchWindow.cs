namespace EFT.UI;

[UsedImplicitly]
public sealed class StashSearchWindow : PaginationWindow
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func <>9__48_1; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal string <GetAllItems>b__48_1(Item item) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass48_0
	{
		public StashSearchWindow <>4__this; //Field offset: 0x10
		public bool useFilter; //Field offset: 0x18

		public <>c__DisplayClass48_0() { }

		internal bool <GetAllItems>b__0(Item item) { }

		internal bool <GetAllItems>g__CheckItemInternal|2(Item item) { }

		internal bool <GetAllItems>g__GoDeeperCheck|3(IContainer container) { }

		internal bool <GetAllItems>g__GoInsideCheck|4(Item item) { }

	}

	[CompilerGenerated]
	private static class <>O
	{
		public static Func <0>__TemplateIdSelector; //Field offset: 0x0

	}

	[CompilerGenerated]
	private sealed class <GetGroupedItems>d__50 : IEnumerable, IEnumerable, IEnumerator, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x10
		private Item <>2__current; //Field offset: 0x18
		private int <>l__initialThreadId; //Field offset: 0x20
		public StashSearchWindow <>4__this; //Field offset: 0x28
		private IEnumerator <>7__wrap1; //Field offset: 0x30
		private Enumerator <>7__wrap2; //Field offset: 0x38

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
		public <GetGroupedItems>d__50(int <>1__state) { }

		private void <>m__Finally1() { }

		private void <>m__Finally2() { }

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

	private const int MIN_GRID_HEIGHT = 12; //Field offset: 0x0
	private const int MIN_GRID_WIDTH = 12; //Field offset: 0x0
	[SerializeField]
	[UsedImplicitly(ImplicitUseKindFlags::Assign (2))]
	private ToggleEFT _searchEquipmentToggle; //Field offset: 0x148
	[SerializeField]
	[UsedImplicitly(ImplicitUseKindFlags::Assign (2))]
	private ToggleEFT _searchStashToggle; //Field offset: 0x150
	[SerializeField]
	[UsedImplicitly(ImplicitUseKindFlags::Assign (2))]
	private TMP_InputField _searchField; //Field offset: 0x158
	[SerializeField]
	[UsedImplicitly(ImplicitUseKindFlags::Assign (2))]
	private ToggleEFT _nestedSearchToggle; //Field offset: 0x160
	[SerializeField]
	[UsedImplicitly(ImplicitUseKindFlags::Assign (2))]
	private ToggleEFT _searchInLockedToggle; //Field offset: 0x168
	[SerializeField]
	[UsedImplicitly(ImplicitUseKindFlags::Assign (2))]
	private ToggleEFT _searchComponentsToggle; //Field offset: 0x170
	[SerializeField]
	[UsedImplicitly(ImplicitUseKindFlags::Assign (2))]
	private ToggleEFT _searchForSpawnedInSessionToggle; //Field offset: 0x178
	[SerializeField]
	[UsedImplicitly(ImplicitUseKindFlags::Assign (2))]
	private FilterPanel _filterPanel; //Field offset: 0x180
	private CompoundItem _container; //Field offset: 0x188
	private CompoundItem _equipment; //Field offset: 0x190
	private CompoundItem _currentContainer; //Field offset: 0x198
	private bool _group; //Field offset: 0x1A0
	private bool _nestedSearch; //Field offset: 0x1A1
	private bool _skipLocked; //Field offset: 0x1A2
	private bool _searchForComponents; //Field offset: 0x1A3
	private bool _spawnedInSessionOnly; //Field offset: 0x1A4
	private string _textSearch; //Field offset: 0x1A8
	private bool _filterUpdateRequired; //Field offset: 0x1B0
	private readonly List _textSearchTemplates; //Field offset: 0x1B8
	private readonly Dictionary _groupedItems; //Field offset: 0x1C0
	private readonly HashSet _itemCache; //Field offset: 0x1C8

	protected virtual bool DragEnabled
	{
		 get { } //Length: 3
	}

	protected virtual int GridHeight
	{
		 get { } //Length: 6
	}

	protected virtual int GridWidth
	{
		 get { } //Length: 6
	}

	protected virtual bool ItemsUpdateRequired
	{
		 get { } //Length: 8
		 set { } //Length: 26
	}

	protected virtual bool ShowInCenter
	{
		 get { } //Length: 3
	}

	public StashSearchWindow() { }

	[CompilerGenerated]
	private void <Show>b__34_0() { }

	[CompilerGenerated]
	private void <Show>b__34_1() { }

	protected virtual bool CheckForUpdateItemsRequirement(Item item, ItemAddress itemAddress) { }

	private bool CheckItem(Item item, bool useFilter) { }

	private void FilterChangeHandler() { }

	protected virtual bool get_DragEnabled() { }

	protected virtual int get_GridHeight() { }

	protected virtual int get_GridWidth() { }

	protected virtual bool get_ItemsUpdateRequired() { }

	protected virtual bool get_ShowInCenter() { }

	private IEnumerable GetAllItems(bool useFilter) { }

	[IteratorStateMachine(typeof(<GetGroupedItems>d__50))]
	private IEnumerable GetGroupedItems() { }

	protected virtual IEnumerable GetItemsToHandover() { }

	private Item GetRootItem(Item item) { }

	private void GroupToggleHandler(bool active) { }

	private void NestedSearchToggleHandler(bool active) { }

	private void SearchEquipmentHandler(bool active) { }

	private void SearchForComponentsHandler(bool active) { }

	private void SearchInLockedHandler(bool active) { }

	private void SearchSpawnedInSessionHandler(bool active) { }

	private void SearchStashHandler(bool active) { }

	private void SearchTextChangeHandler(string text) { }

	protected virtual void set_ItemsUpdateRequired(bool value) { }

	private void SetCurrentContainer(CompoundItem container) { }

	public DialogWindowContext Show(CompoundItem container, InventoryEquipment equipment, IInventoryProfileInfo profile, ItemController itemController, ItemContext itemContext) { }

	private static MongoID TemplateIdSelector(Item item) { }

	protected virtual ETranslateResult TranslateCommand(ECommand command) { }

	protected virtual void Update() { }

}

