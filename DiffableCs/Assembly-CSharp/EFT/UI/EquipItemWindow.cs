namespace EFT.UI;

public sealed class EquipItemWindow : Window, ISelectionContext
{
	[CompilerGenerated]
	private struct <ApplyDogTagCustomization>d__41 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder <>t__builder; //Field offset: 0x8
		public EquipItemWindow <>4__this; //Field offset: 0x20
		public MongoID itemId; //Field offset: 0x28
		private TaskAwaiter <>u__1; //Field offset: 0x40

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[IsReadOnly]
	private struct EquipItemsGridParameters
	{
		public readonly Vector2 CellSize; //Field offset: 0x0
		public readonly Vector2 Spacing; //Field offset: 0x8
		public readonly int MaxColumnsCount; //Field offset: 0x10
		public readonly int MinColumnsCount; //Field offset: 0x14
		public readonly EItemViewType ViewType; //Field offset: 0x18

		public EquipItemsGridParameters(Vector2 cellSize, Vector2 spacing, int maxColumnsCount, int minColumnsCount, EItemViewType viewType) { }

	}

	private static readonly EquipItemsGridParameters _defaultTextOnlyGridParams; //Field offset: 0x0
	private const string WINDOW_CAPTION = "EquipItemWindow/Caption"; //Field offset: 0x0
	private const string TEXT_ONLY_PREFS_KEY = "EquipWindowTextOnly"; //Field offset: 0x0
	private static readonly EquipItemsGridParameters _defaultGridParams; //Field offset: 0x1C
	private static readonly EquipItemsGridParameters _weaponGridParams; //Field offset: 0x38
	[CompilerGenerated]
	private Action OnItemSelected; //Field offset: 0xB8
	[SerializeField]
	private TMP_InputField _inputField; //Field offset: 0xC0
	[SerializeField]
	private Button _toggleViewButton; //Field offset: 0xC8
	[SerializeField]
	private Image _viewTypeImage; //Field offset: 0xD0
	[SerializeField]
	private RectTransform _viewsContainer; //Field offset: 0xD8
	[SerializeField]
	private GridLayoutGroup _gridLayoutGroup; //Field offset: 0xE0
	[SerializeField]
	private GameObject _placeHolder; //Field offset: 0xE8
	[SerializeField]
	private Vector3 _windowOffset; //Field offset: 0xF0
	private SelectableItemContext _itemContext; //Field offset: 0x100
	private InventoryController _inventoryController; //Field offset: 0x108
	private ViewList _viewList; //Field offset: 0x110
	private ItemUiContext _itemUiContext; //Field offset: 0x118
	private ItemAddress _itemAddress; //Field offset: 0x120
	private EquipmentSlot _equipmentSlot; //Field offset: 0x128
	private SkillManager _sills; //Field offset: 0x130
	private bool _refreshRequired; //Field offset: 0x138
	private string _filter; //Field offset: 0x140
	private Slot _slot; //Field offset: 0x148
	private EquipmentSlot _slotType; //Field offset: 0x150
	private bool _isTextOnly; //Field offset: 0x154
	private IEftSession _session; //Field offset: 0x158

	public override event Action OnItemSelected
	{
		[CompilerGenerated]
		 add { } //Length: 278
		[CompilerGenerated]
		 remove { } //Length: 278
	}

	protected virtual RectTransform RectTransform
	{
		 get { } //Length: 68
	}

	private static EquipItemWindow() { }

	public EquipItemWindow() { }

	[CompilerGenerated]
	private void <Awake>b__31_0(string arg) { }

	[CompilerGenerated]
	private ItemView <CreateItemViews>b__40_0(Item item) { }

	[CompilerGenerated]
	private void <CreateItemViews>b__40_1(Item item, ItemView itemView) { }

	[CompilerGenerated]
	private void <Show>b__33_0() { }

	[CompilerGenerated]
	public override void add_OnItemSelected(Action value) { }

	[AsyncStateMachine(typeof(<ApplyDogTagCustomization>d__41))]
	private Task ApplyDogTagCustomization(MongoID itemId) { }

	protected virtual void Awake() { }

	private void CheckFilter() { }

	private void CreateItemViews(IEnumerable items) { }

	private override bool EFT.InventoryLogic.SelectableItemContext.ISelectionContext.IsActive(ItemContext context, out string tooltip) { }

	private override bool EFT.InventoryLogic.SelectableItemContext.ISelectionContext.IsSelected(Item item) { }

	private override void EFT.InventoryLogic.SelectableItemContext.ISelectionContext.ToggleSelection(SelectableItemContext context) { }

	protected virtual RectTransform get_RectTransform() { }

	private IEnumerable GetAvailableItems() { }

	private void ItemAddedHandler(AddItemEventArgs itemEventArgs) { }

	private void ItemRemovedHandler(RemoveItemEventArgs itemEventArgs) { }

	private void ItemSelectedHandler(Item item) { }

	private void RefreshItemViews() { }

	[CompilerGenerated]
	public override void remove_OnItemSelected(Action value) { }

	public WindowContext Show(Slot slot, InventoryController inventoryController, IEftSession session, SkillManager skills, Vector3 position) { }

	private void ToggleView() { }

	private void Update() { }

	private void UpdateViewTypeIcon() { }

}

