namespace EFT.UI;

public class ItemSelectionCell : UIElement
{
	[CompilerGenerated]
	private static class <>O
	{
		public static Func <0>__AvailableItemPredicate; //Field offset: 0x0

	}

	[CompilerGenerated]
	private struct <DropdownButtonClickHandler>d__41 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncVoidMethodBuilder <>t__builder; //Field offset: 0x8
		public ItemSelectionCell <>4__this; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x30

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	internal interface IItemSelectionHandler
	{

		public bool CanSelect(Item item) { }

		public IEnumerable GetAvailableItems() { }

		public void ItemSelectionHandler(Item selectedItem) { }

	}

	internal sealed class ItemSelectionHandler : MulticastDelegate
	{

		public ItemSelectionHandler(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(Item selectedItem, bool selected, AsyncCallback callback, object object) { }

		public override bool EndInvoke(IAsyncResult result) { }

		public override bool Invoke(Item selectedItem, bool selected) { }

	}

	private IEnumerable _selectingItems; //Field offset: 0x70
	[SerializeField]
	private EntityIcon _selectedItemIcon; //Field offset: 0x78
	[SerializeField]
	private GameObject _emptyIcon; //Field offset: 0x80
	[SerializeField]
	private Button _dropdownButton; //Field offset: 0x88
	[SerializeField]
	private Sprite _closeButtonIcon; //Field offset: 0x90
	[SerializeField]
	private Sprite _openButtonIcon; //Field offset: 0x98
	[SerializeField]
	private SelectingItemView _itemViewPrefab; //Field offset: 0xA0
	[SerializeField]
	private RectTransform _container; //Field offset: 0xA8
	[SerializeField]
	private RectTransform _mainTransform; //Field offset: 0xB0
	[SerializeField]
	private bool _showEmptyCell; //Field offset: 0xB8
	[SerializeField]
	private Vector2 _contextMenuOffset; //Field offset: 0xBC
	[SerializeField]
	private EContextPriorDirection _contextPriorDirection; //Field offset: 0xC4
	protected Item CurrentItem; //Field offset: 0xC8
	private Func _selectionChecker; //Field offset: 0xD0
	private Action _selectionHandler; //Field offset: 0xD8
	private Func _availableItemsGetter; //Field offset: 0xE0
	private bool _menuOpen; //Field offset: 0xE8
	private bool _menuOpeningInProgress; //Field offset: 0xE9
	private ItemUiContext _context; //Field offset: 0xF0

	protected override IEnumerable AvailableItems
	{
		 get { } //Length: 360
	}

	protected override EContextPriorDirection Direction
	{
		 get { } //Length: 7
	}

	protected Button DropdownButton
	{
		 get { } //Length: 8
	}

	private static HideoutRepresentation Hideout
	{
		private get { } //Length: 46
	}

	protected IEnumerable SelectingItems
	{
		 get { } //Length: 5
		 set { } //Length: 82
	}

	public ItemSelectionCell() { }

	[CompilerGenerated]
	private IEnumerable <Show>b__35_0() { }

	private static bool AvailableItemPredicate(Item item) { }

	protected override void Awake() { }

	public virtual void Close() { }

	[AsyncStateMachine(typeof(<DropdownButtonClickHandler>d__41))]
	private void DropdownButtonClickHandler() { }

	protected override IEnumerable get_AvailableItems() { }

	protected override EContextPriorDirection get_Direction() { }

	protected Button get_DropdownButton() { }

	private static HideoutRepresentation get_Hideout() { }

	protected IEnumerable get_SelectingItems() { }

	protected override string GetDetails(Item item) { }

	public void Hide() { }

	protected override bool IsDropdownItemsInteractable() { }

	private void ItemSelected(Item item) { }

	protected void set_SelectingItems(IEnumerable value) { }

	private void SetDropdownOpenStatus(bool isOpen) { }

	public override void SetItem(Item item) { }

	private void SetItemIcon(Item item) { }

	public override void SetItemsSetAbility(bool canSet) { }

	public void Show(Item currentSelectedItem, IItemSelectionHandler selectionHandler) { }

	protected void Show(Item currentSelectedItem, Func selectionChecker, Action selectionHandler) { }

	public void Show(Item currentSelectedItem, Func selectionChecker, Action selectionHandler, IEnumerable filter) { }

}

